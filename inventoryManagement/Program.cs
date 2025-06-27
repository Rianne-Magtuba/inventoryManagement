using BusinessLogic;
using DataLogic;
using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization.Json;

namespace inventoryManagement
{
    internal class Program
    {
        static inventoryProcess inventoryProcess = new inventoryProcess();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Computer Inventory Management");

            bool retry = false;
            Console.WriteLine("=============================================");
            Console.WriteLine("Please Login");
            bool loginSuccess = false;

            do
            {
                Console.WriteLine("Enter your username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();
                if (inventoryProcess.accountExist(username, password))
                {
                    Console.WriteLine("Login successful!");
                    loginSuccess = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Login failed! Please try again.");
                    retry = tryAgain();
                }

            } while (retry == false);

            if (loginSuccess == true)
            {
                do
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Please Select An Action");
                    Console.WriteLine("[1] Product Management");
                    Console.WriteLine("[2] Supplier Management");
                    Console.WriteLine("[3] Order Management");
                    Console.WriteLine("[4] Category Management");
                    Console.WriteLine("[5] Account Management");
                    Console.WriteLine("[6] Reports & Analytics");
                    Console.WriteLine("[7] Exit");

                    int choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ProductManagementMenu();
                            retry = tryAgain();
                            break;
                        case 2:
                            SupplierManagementMenu();
                            retry = tryAgain();
                            break;
                        case 3:
                            OrderManagementMenu();
                            retry = tryAgain();
                            break;
                        case 4:
                            CategoryManagementMenu();
                            retry = tryAgain();
                            break;
                        case 5:
                            AccountManagementMenu();
                            retry = tryAgain();
                            break;
                        case 6:
                            ReportsMenu();
                            retry = tryAgain();
                            break;
                        case 7:
                            retry = false;
                            Console.WriteLine("Program Terminated, Thank you");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            retry = true;
                            break;
                    }
                } while (retry == true);
            }
        }

  
        static void ProductManagementMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("PRODUCT MANAGEMENT");
            Console.WriteLine("[1] View All Products");
            Console.WriteLine("[2] Add Product");
            Console.WriteLine("[3] Update Product");
            Console.WriteLine("[4] Remove Product");
            Console.WriteLine("[5] Search Product by Name");
            Console.WriteLine("[6] Search Product by ID");
            Console.WriteLine("[7] Search Product by Category");
            Console.WriteLine("[8] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewStocks();
                    break;
                case 2:
                    addItem();
                    break;
                case 3:
                    updateStocks();
                    break;
                case 4:
                    removeItem();
                    break;
                case 5:
                    searchProductByName();
                    break;
                case 6:
                    searchProductById();
                    break;
                case 7:
                    searchProductByCategory();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static public void addItem()
        {
            string pId, pName, pSupplier;
            int pQty = 0;
            double pPrice = 0;

            Console.WriteLine("Please enter the product ID:");
            pId = Console.ReadLine();

            // Check if product ID already exists
            if (inventoryProcess.productExist(pId))
            {
                Console.WriteLine("ERROR! Product ID already exists.");
                return;
            }

            Console.WriteLine("Please enter the product name:");
            pName = Console.ReadLine();

            bool properInput = false;
            while (properInput != true)
            {
                try
                {
                    Console.WriteLine("Please enter its quantity:");
                    pQty = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter its Price:");
                    pPrice = Convert.ToDouble(Console.ReadLine());

                    properInput = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("ERROR! Please enter a valid number.");
                    properInput = false;
                }
            }

            Console.WriteLine("Available suppliers:");
            List<string> supplierNames = inventoryProcess.getSupplierNames();
            for (int i = 0; i < supplierNames.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {supplierNames[i]}");
            }
            Console.WriteLine("Please select supplier number or enter new supplier name:");
            string supplierInput = Console.ReadLine();

            if (int.TryParse(supplierInput, out int supplierIndex) && supplierIndex > 0 && supplierIndex <= supplierNames.Count)
            {
                pSupplier = inventoryProcess.getSupplierId(supplierNames[supplierIndex - 1]);
            }
            else
            {
                pSupplier = supplierInput;
            }

            Console.WriteLine("Available categories:");
            List<string> categoryNames = inventoryProcess.GetCategoryNames();
            for (int i = 0; i < categoryNames.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {categoryNames[i]}");
            }
            Console.WriteLine("Please select category number or enter new category name:");
            string categoryInput = Console.ReadLine();
            string pCategory;

            if (int.TryParse(categoryInput, out int categoryIndex) && categoryIndex > 0 && categoryIndex <= categoryNames.Count)
            {
                pCategory = categoryNames[categoryIndex - 1];
            }
            else
            {
                pCategory = categoryInput;
                // Add new category if it doesn't exist
                inventoryProcess.addCategory(pCategory);
            }

            inventoryProcess.addProduct(pId, pName, pQty, pSupplier, pPrice, pCategory);
            Console.WriteLine("Product added successfully!");
        }

        static void removeItem()
        {
            List<Product> products = inventoryProcess.getProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("ERROR: No products found to remove");
                return;
            }

            viewStocks();
            Console.WriteLine("Please enter the product ID that you want to remove:");
            var input = Console.ReadLine();

            if (inventoryProcess.removeProduct(input))
            {
                Console.WriteLine("Product removed successfully");
            }
            else
            {
                Console.WriteLine("Error: Cannot remove product. Product ID not found.");
            }
        }

        static public void viewStocks()
        {
            List<Product> products = inventoryProcess.getProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("Your stock is empty. Please add products.");
                return;
            }

            Console.WriteLine("================================================================================");
            Console.WriteLine(  "Product Name", "Product ID", "Quantity", "Price", "Supplier", "Category");
            Console.WriteLine("================================================================================");

            foreach (var product in products)
            {
                string supplierName = inventoryProcess.getSupplierName(product.supplierId);
                string displaySupplier;

                if (supplierName != "")
                {
                    displaySupplier = supplierName;
                }
                else
                {
                    displaySupplier = product.supplierId;
                }

                Console.WriteLine(product.Name, product.Id, product.Quantity, product.Price, displaySupplier, product.category);
            }
            Console.WriteLine("================================================================================");
        }


        public static void updateStocks()
        {
            viewStocks();
            Console.WriteLine("Please enter product ID of the product you want to update:");
            var id = Console.ReadLine();

            if (!inventoryProcess.productExist(id))
            {
                Console.WriteLine("ERROR: Product ID not found.");
                return;
            }

            try
            {
                Console.WriteLine("Please enter the new product name:");
                var newProductName = Console.ReadLine();
                Console.WriteLine("Please enter new product Id:");
                var newProdId = Console.ReadLine();
                Console.WriteLine("Please enter new product quantity:");
                int newProdQty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter new product price:");
                double newProdPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter new product supplier:");
                var newProdSupplier = Console.ReadLine();
                Console.WriteLine("Please enter new product category:");
                var newCategory = Console.ReadLine();

                inventoryProcess.updateProduct(newProductName, newProdId, newProdQty, newProdPrice, newProdSupplier, newCategory);
                Console.WriteLine("Product updated successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid input format. Please enter valid numbers for quantity and price.");
            }
        }

        static void searchProductByName()
        {
            Console.WriteLine("Enter product name to search:");
            string productName = Console.ReadLine();
            List<Product> products = inventoryProcess.getProductByName(productName);

            if (products.Count == 0)
            {
                Console.WriteLine("No products found with that name.");
                return;
            }

            Console.WriteLine($"Found {products.Count} product(s):");
            displayProducts(products);
        }

        static void searchProductById()
        {
            Console.WriteLine("Enter product ID to search:");
            string productId = Console.ReadLine();
            List<Product> products = inventoryProcess.getProductById(productId);

            if (products.Count == 0)
            {
                Console.WriteLine("No product found with that ID.");
                return;
            }

            displayProducts(products);
        }

        static void searchProductByCategory()
        {
            Console.WriteLine("Available categories:");
            List<string> categories = inventoryProcess.GetCategoryNames();
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {categories[i]}");
            }
            Console.WriteLine("Enter category name:");
            string category = Console.ReadLine();

            List<Product> products = inventoryProcess.getProductByCategory(category);
            if (products.Count == 0)
            {
                Console.WriteLine("No products found in that category.");
                return;
            }

            Console.WriteLine($"Products in category '{category}':");
            displayProducts(products);
        }

        static void displayProducts(List<Product> products)
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine(  "Product Name", "Product ID", "Quantity", "Price", "Supplier", "Category");
            Console.WriteLine("================================================================================");

            foreach (var product in products)
            {
                string supplierName = inventoryProcess.getSupplierName(product.supplierId);
                string displaySupplier;

                if (supplierName != "")
                {
                    displaySupplier = supplierName;
                }
                else
                {
                    displaySupplier = product.supplierId;
                }

                Console.WriteLine( product.Name, product.Id, product.Quantity, product.Price, displaySupplier, product.category);
            }
            Console.WriteLine("================================================================================");
        }
        static void SupplierManagementMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("SUPPLIER MANAGEMENT");
            Console.WriteLine("[1] View All Suppliers");
            Console.WriteLine("[2] Add Supplier");
            Console.WriteLine("[3] Update Supplier");
            Console.WriteLine("[4] Remove Supplier");
            Console.WriteLine("[5] Search Supplier");
            Console.WriteLine("[6] View Supplier Products");
            Console.WriteLine("[7] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewSuppliers();
                    break;
                case 2:
                    addSupplier();
                    break;
                case 3:
                    updateSupplier();
                    break;
                case 4:
                    removeSupplier();
                    break;
                case 5:
                    searchSupplier();
                    break;
                case 6:
                    viewSupplierProducts();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void viewSuppliers()
        {
            List<Supplier> suppliers = inventoryProcess.getSuppliers();
            if (suppliers.Count == 0)
            {
                Console.WriteLine("No suppliers found.");
                return;
            }

            Console.WriteLine("====================================================================================");
            Console.WriteLine(  "ID", "Name", "Address", "Contact", "Email");
            Console.WriteLine("====================================================================================");

            foreach (var supplier in suppliers)
            {
                Console.WriteLine( supplier.Id, supplier.Name, supplier.Address, supplier.ContactNum, supplier.EmailAdd);
            }
            Console.WriteLine("====================================================================================");
        }

        static void addSupplier()
        {
            Console.WriteLine("Enter supplier ID:");
            string id = Console.ReadLine();

            if (inventoryProcess.supplierExist(id))
            {
                Console.WriteLine("ERROR! Supplier ID already exists.");
                return;
            }

            Console.WriteLine("Enter supplier name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter supplier address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter supplier contact number:");
            string contact = Console.ReadLine();
            Console.WriteLine("Enter supplier email:");
            string email = Console.ReadLine();

            inventoryProcess.addSupplier(id, name, address, contact, email);
            Console.WriteLine("Supplier added successfully!");
        }

        static void updateSupplier()
        {
            viewSuppliers();
            Console.WriteLine("Enter supplier ID to update:");
            string id = Console.ReadLine();

            if (!inventoryProcess.supplierExist(id))
            {
                Console.WriteLine("ERROR: Supplier ID not found.");
                return;
            }

            Console.WriteLine("Enter new supplier name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter new supplier address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter new supplier contact number:");
            string contact = Console.ReadLine();
            Console.WriteLine("Enter new supplier email:");
            string email = Console.ReadLine();

            inventoryProcess.updateSupplier(id, name, address, contact, email);
            Console.WriteLine("Supplier updated successfully!");
        }

        static void removeSupplier()
        {
            viewSuppliers();
            Console.WriteLine("Enter supplier ID to remove:");
            string id = Console.ReadLine();

            if (inventoryProcess.removeSupplier(id))
            {
                Console.WriteLine("Supplier removed successfully!");
            }
            else
            {
                Console.WriteLine("ERROR: Supplier ID not found.");
            }
        }

        static void searchSupplier()
        {
            Console.WriteLine("Enter supplier name to search:");
            string name = Console.ReadLine();
            List<Supplier> suppliers = inventoryProcess.getSupplierByName(name);

            if (suppliers.Count == 0)
            {
                Console.WriteLine("No suppliers found with that name.");
                return;
            }

            Console.WriteLine($"Found {suppliers.Count} supplier(s):");
            displaySuppliers(suppliers);
        }

        static void viewSupplierProducts()
        {
            viewSuppliers();
            Console.WriteLine("Enter supplier ID to view products:");
            string supplierId = Console.ReadLine();

            if (!inventoryProcess.supplierExist(supplierId))
            {
                Console.WriteLine("ERROR: Supplier ID not found.");
                return;
            }

            List<string> products = inventoryProcess.getSupplierProducts(supplierId);
            string supplierName = inventoryProcess.getSupplierName(supplierId);

            Console.WriteLine($"Products supplied by {supplierName}:");
            if (products.Count == 0)
            {
                Console.WriteLine("No products found for this supplier.");
            }
            else
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i]}");
                }
            }
        }

        static void displaySuppliers(List<Supplier> suppliers)
        {
            Console.WriteLine("====================================================================================");
            Console.WriteLine( "ID", "Name", "Address", "Contact", "Email");
            Console.WriteLine("====================================================================================");

            foreach (var supplier in suppliers)
            {
                Console.WriteLine(supplier.Id, supplier.Name, supplier.Address, supplier.ContactNum, supplier.EmailAdd);
            }
            Console.WriteLine("====================================================================================");
        }
    

      
        static void OrderManagementMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("ORDER MANAGEMENT");
            Console.WriteLine("[1] View All Orders");
            Console.WriteLine("[2] Add Order");
            Console.WriteLine("[3] Update Order Status");
            Console.WriteLine("[4] Remove Order");
            Console.WriteLine("[5] View Orders by Status");
            Console.WriteLine("[6] View Arriving Orders (Next 2 Days)");
            Console.WriteLine("[7] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewOrders();
                    break;
                case 2:
                    addOrder();
                    break;
                case 3:
                    updateOrderStatus();
                    break;
                case 4:
                    removeOrder();
                    break;
                case 5:
                    viewOrdersByStatus();
                    break;
                case 6:
                    viewArrivingOrders();
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void viewOrders()
        {
            List<Orders> orders = inventoryProcess.getOrders();
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("ID", "Order Date", "Product", "Supplier", "Qty", "Status", "Est. Date");
            Console.WriteLine("========================================================================================");

            foreach (var order in orders)
            {
                string productName = inventoryProcess.getProductNameById(order.productId);
                string supplierName = inventoryProcess.getSupplierName(order.supplierId);
                Console.WriteLine( order.Id.ToString(), order.orderDate.ToString("yyyy-MM-dd"), productName, supplierName,
             order.qty, order.status, order.estimatedDate.ToString("yyyy-MM-dd"));
            }
            Console.WriteLine("========================================================================================");
        }

        static void addOrder()
        {
            try
            {
                Console.WriteLine("Enter order date (yyyy-mm-dd) or press Enter for today:");
                string dateInput = Console.ReadLine();
                DateOnly orderDate;

                if (string.IsNullOrEmpty(dateInput))
                {
                    orderDate = DateOnly.FromDateTime(DateTime.Now);
                }
                else
                {
                    orderDate = DateOnly.Parse(dateInput);
                }

                viewSuppliers();
                Console.WriteLine("Enter supplier ID:");
                string supplierId = Console.ReadLine();

                if (!inventoryProcess.supplierExist(supplierId))
                {
                    Console.WriteLine("ERROR: Supplier ID not found.");
                    return;
                }

                viewStocks();
                Console.WriteLine("Enter product ID:");
                string productId = Console.ReadLine();

                if (!inventoryProcess.productExist(productId))
                {
                    Console.WriteLine("ERROR: Product ID not found.");
                    return;
                }

                Console.WriteLine("Enter quantity:");
                int qty = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter order status (Pending/Ordered/Delivered/Cancelled):");
                string status = Console.ReadLine();

                Console.WriteLine("Enter estimated delivery date (yyyy-mm-dd):");
                DateOnly estimatedDate = DateOnly.Parse(Console.ReadLine());

                inventoryProcess.addOrder(orderDate, supplierId, productId, qty, status, estimatedDate);
                Console.WriteLine("Order added successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid input format.");
            }
        }

        static void updateOrderStatus()
        {
            viewOrders();
            try
            {
                Console.WriteLine("Enter order ID to update:");
                int orderId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new status (Pending/Ordered/Delivered/Cancelled):");
                string newStatus = Console.ReadLine();

                inventoryProcess.updateOrder(orderId, newStatus);
                Console.WriteLine("Order status updated successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid order ID format.");
            }
        }

        static void removeOrder()
        {
            viewOrders();
            try
            {
                Console.WriteLine("Enter order ID to remove:");
                int orderId = Convert.ToInt32(Console.ReadLine());

                inventoryProcess.removeOrder(orderId);
                Console.WriteLine("Order removed successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid order ID format.");
            }
        }

        static void viewOrdersByStatus()
        {
            Console.WriteLine("Enter status to filter by (Pending/Ordered/Delivered/Cancelled/All):");
            string status = Console.ReadLine();

            List<Orders> allOrders = inventoryProcess.getOrders();
            List<Orders> filteredOrders = inventoryProcess.getOrdersByStatus(status, allOrders);

            if (filteredOrders.Count == 0)
            {
                Console.WriteLine($"No orders found with status: {status}");
                return;
            }

            Console.WriteLine($"Orders with status '{status}':");
            displayOrders(filteredOrders);
        }

        static void viewArrivingOrders()
        {
            List<Orders> arrivingOrders = inventoryProcess.getArrivingOrders();

            if (arrivingOrders.Count == 0)
            {
                Console.WriteLine("No orders arriving in the next 2 days.");
                return;
            }

            Console.WriteLine("Orders arriving in the next 2 days:");
            displayOrders(arrivingOrders);
        }

        static void displayOrders(List<Orders> orders)
        {
            Console.WriteLine("========================================================================================");
            Console.WriteLine( "ID", "Order Date", "Product", "Supplier", "Qty", "Status", "Est. Date");
            Console.WriteLine("========================================================================================");

            foreach (var order in orders)
            {
                string productName = inventoryProcess.getProductNameById(order.productId);
                string supplierName = inventoryProcess.getSupplierName(order.supplierId);
                Console.WriteLine(
                    order.Id.ToString(), order.orderDate.ToString("yyyy-MM-dd"), productName, supplierName,
                    order.qty, order.status, order.estimatedDate.ToString("yyyy-MM-dd"));
            }
            Console.WriteLine("========================================================================================");
        }


    
        static void CategoryManagementMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("CATEGORY MANAGEMENT");
            Console.WriteLine("[1] View All Categories");
            Console.WriteLine("[2] Add Category");
            Console.WriteLine("[3] Update Category");
            Console.WriteLine("[4] Remove Category");
            Console.WriteLine("[5] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewCategories();
                    break;
                case 2:
                    addCategory();
                    break;
                case 3:
                    updateCategory();
                    break;
                case 4:
                    removeCategory();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void viewCategories()
        {
            List<Category> categories = inventoryProcess.GetCategories();
            if (categories.Count == 0)
            {
                Console.WriteLine("No categories found.");
                return;
            }

            Console.WriteLine("Available Categories:");
            Console.WriteLine("===================");
            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.Id} | Name: {category.Name}");
            }
            Console.WriteLine("===================");
        }

        static void addCategory()
        {
            Console.WriteLine("Enter category name:");
            string categoryName = Console.ReadLine();

            inventoryProcess.addCategory(categoryName);
            Console.WriteLine("Category added successfully!");
        }

        static void updateCategory()
        {
            viewCategories();
            Console.WriteLine("Enter current category name to update:");
            string oldCategoryName = Console.ReadLine();
            Console.WriteLine("Enter new category name:");
            string newCategoryName = Console.ReadLine();

            inventoryProcess.updateCategory(newCategoryName, oldCategoryName);
            Console.WriteLine("Category updated successfully!");
        }

        static void removeCategory()
        {
            viewCategories();
            Console.WriteLine("Enter category name to remove:");
            string categoryName = Console.ReadLine();

            inventoryProcess.removeCategory(categoryName);
            Console.WriteLine("Category removed successfully!");
        }
        


        static void AccountManagementMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("ACCOUNT MANAGEMENT");
            Console.WriteLine("[1] View All Accounts");
            Console.WriteLine("[2] Add Account");
            Console.WriteLine("[3] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    viewAccounts();
                    break;
                case 2:
                    addAccount();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void viewAccounts()
        {
            List<Accounts> accounts = inventoryProcess.getAccounts();
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Console.WriteLine("User Accounts:");
            Console.WriteLine("===============");
            foreach (var account in accounts)
            {
                Console.WriteLine($"Username: {account.userName}");
            }
            Console.WriteLine("===============");
        }

        static void addAccount()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            inventoryProcess.addAccount(username, password);
            Console.WriteLine("Account added successfully!");
        }
     

      
        static void ReportsMenu()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("REPORTS & ANALYTICS");
            Console.WriteLine("[1] Stock Summary Report");
            Console.WriteLine("[2] Low Stock Alert");
            Console.WriteLine("[3] Out of Stock Report");
            Console.WriteLine("[4] Supplier Report");
            Console.WriteLine("[5] Back to Main Menu");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    stockSummaryReport();
                    break;
                case 2:
                    lowStockAlert();
                    break;
                case 3:
                    outOfStockReport();
                    break;
                case 4:
                    supplierReport();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void stockSummaryReport()
        {
            List<Product> products = inventoryProcess.getProducts();

            Console.WriteLine("=========================================");
            Console.WriteLine("STOCK SUMMARY REPORT");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Total Products: {products.Count}");
            Console.WriteLine($"Total Stock Quantity: {inventoryProcess.getTotalStockProduct(products)}");
            Console.WriteLine($"Low Stock Products (< 5): {inventoryProcess.getLowStockProduct(products)}");
            Console.WriteLine($"Out of Stock Products: {inventoryProcess.getOutOfStockProduct(products)}");

            // Calculate total value
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.Price * product.Quantity;
            }
            Console.WriteLine($"Total Inventory Value: {totalValue:C}");
            Console.WriteLine("=========================================");
        }

        static void lowStockAlert()
        {
            List<Product> products = inventoryProcess.getProducts();
            List<Product> lowStockProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Quantity < 5 && product.Quantity > 0)
                {
                    lowStockProducts.Add(product);
                }
            }

            if (lowStockProducts.Count == 0)
            {
                Console.WriteLine("No products with low stock found.");
                return;
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("LOW STOCK ALERT (Quantity < 5)");
            Console.WriteLine("=========================================");
            displayProducts(lowStockProducts);
        }

        static void outOfStockReport()
        {
            List<Product> products = inventoryProcess.getProducts();
            List<Product> outOfStockProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Quantity == 0)
                {
                    outOfStockProducts.Add(product);
                }
            }

            if (outOfStockProducts.Count == 0)
            {
                Console.WriteLine("No out of stock products found.");
                return;
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("OUT OF STOCK REPORT");
            Console.WriteLine("=========================================");
            displayProducts(outOfStockProducts);
        }

        static void supplierReport()
        {
            List<Supplier> suppliers = inventoryProcess.getSuppliers();

            if (suppliers.Count == 0)
            {
                Console.WriteLine("No suppliers found.");
                return;
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("SUPPLIER REPORT");
            Console.WriteLine("=========================================");

            foreach (var supplier in suppliers)
            {
                List<string> supplierProducts = inventoryProcess.getSupplierProducts(supplier.Id);
                Console.WriteLine($"Supplier: {supplier.Name} (ID: {supplier.Id})");
                Console.WriteLine($"Contact: {supplier.ContactNum} | Email: {supplier.EmailAdd}");
                Console.WriteLine($"Address: {supplier.Address}");
                Console.WriteLine($"Products Supplied: {supplierProducts.Count}");

                if (supplierProducts.Count > 0)
                {
                    Console.WriteLine("Products:");
                    for (int i = 0; i < supplierProducts.Count; i++)
                    {
                        Console.WriteLine($"  - {supplierProducts[i]}");
                    }
                }
                Console.WriteLine("-----------------------------------------");
            }
        }
      

     
        static public bool tryAgain()
        {
            Boolean tryAgain = false;
            Console.WriteLine("Do you want to continue using the system? Y/N");
            String input = Console.ReadLine();

            if (input.ToUpper().Equals("Y"))
            {
                tryAgain = true;
            }
            else if (input.ToUpper().Equals("N"))
            {
                tryAgain = false;
                Console.WriteLine("Program Terminated, Thank you");
            }
           

            return tryAgain;
        }
        
    }
}