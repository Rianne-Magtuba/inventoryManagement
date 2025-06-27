using DataLogic;
using InventoryCommon;
using Microsoft.Identity.Client;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
namespace BusinessLogic

{
    public class inventoryProcess
    {

        inventoryDataService InventoryData;
        public inventoryProcess()
        {
           InventoryData = new inventoryDataService();
        }

    

        //PRODUT METHODS


        public List<Product> getProductByName(string productName)
        {
            List<Product> products = InventoryData.getProducts();
            List<Product> searchedProduct = new List<Product>();
            if(productName == "" || productName=="Search Product Name")
            {
                return products;
            }
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.ToLowerInvariant().StartsWith(productName.ToLowerInvariant()))
                {
                    searchedProduct.Add(products[i]);
                }
            }
            return searchedProduct;
        }
        public string getProductNameById(string productId)
        {
            List<Product> products = getProducts();

         

            for(int i =0; i < products.Count; i++)
            {
                if (products[i].Id == productId)
                {
                   return products[i].Name;
                }
            }
            return "";
         
        }

        public string getProductIdByName(string productName)
        {
            List<Product> products = getProducts();



            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.Trim().ToLowerInvariant().StartsWith(productName.Trim().ToLowerInvariant()))
                {
                    return products[i].Id;
                }
            }
            return "";
        }
      
        public bool productNameExist(string productName)
        {
            List<Product> products = InventoryData.getProducts();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == productName)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Product> getProductById(string productId)
        {
            List<Product> products = InventoryData.getProducts();
            List<Product> searchedProduct = new List<Product>();
           
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id==productId)
                {
                    searchedProduct.Add(products[i]);
                }
            }
            return searchedProduct;
        }

        public List<Product> getProductByCategory(string categoryName)
        {
            List<Product> searchedProduct = new List<Product>();
            List<Product> products = InventoryData.getProducts();
            if (categoryName == "All")
            {
                return products;
            }
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].category == categoryName)
                {
                    searchedProduct.Add(products[i]);
                }
            }
            return searchedProduct;
        }
        public List<Product> getProductByCategoryAndName(string categoryName , string selectedName, List<Product> products)
        { 
            List<Product> searchedProduct = new List<Product>();
          
            if(categoryName == "All")
            {
                return getProductByName(selectedName);
            }
            if(selectedName == "Search Product Name" || selectedName == "" )
            {
                return getProductByCategory(categoryName);
            }
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].category == categoryName && products[i].Name.StartsWith(selectedName))
                {
                    searchedProduct.Add(products[i]);
                }
            }
            return searchedProduct;
        }


        public void addProduct(string productId, string productName, int productQuantity, string productSupplier, double productPrice, string prodCategory)
        {
            Product product1 = new Product();

            product1.Id = productId;
            product1.Name = productName;
            product1.Quantity = productQuantity;
            product1.supplierId = productSupplier;
            product1.Price = productPrice;
            product1.category = prodCategory;
            product1.dateModified = DateOnly.FromDateTime(DateTime.Now);


            InventoryData.addProduct(product1);



        }

        public bool removeProduct(string productId)
        {
            List<Product> products = InventoryData.getProducts();
            for (int i = 0; i < InventoryData.getProducts().Count; i++)
            {
                if (productId == products[i].Id)
                {
                    InventoryData.removeProduct(products[i]);
                    return true;
                }
            }
            return false;


        }

        public  List<Product> searchProduct(string productName)
        {
            List<Product> products = InventoryData.getProducts();
            List<Product> searchedProducts = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.StartsWith(productName))
                {
                    searchedProducts.Add(products[i]);
                }
            }
            return searchedProducts;
        }
        public bool productExist(string productId)
        {     List<Product> products = InventoryData.getProducts();
            for(int i = 0; i < products.Count; i++)
            {
                if (productId == products[i].Id)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Product> getProducts()
        {

            return InventoryData.getProducts();

        }


        public void updateProduct(string NewProductName, string NewProductId, int NewProductQuantity, double NewProductPrice, string NewProductSupplier, string newCategory)
        {

            Product product1 = new Product();
            
            product1.Id = NewProductId;
            product1.Name = NewProductName;
            product1.Quantity = NewProductQuantity;
            product1.supplierId = NewProductSupplier;
            product1.Price = NewProductPrice;
            product1.category = newCategory;
            product1.dateModified = DateOnly.FromDateTime(DateTime.Now);


            InventoryData.updateProduct(product1);


        }
      
        
        public int getTotalStockProduct(List<Product> products )
        {
         
            int totalQty = 0;
            for (int i = 0; i < products.Count; i++)
            {
                totalQty += products[i].Quantity;
            }
            return totalQty;
        }

    
        public int getLowStockProduct(List<Product> products)
        {
            int lowStockProduct = 0;
            for(int i =0; i < products.Count; i++)
            {
                if (products[i].Quantity < 5)
                {
                    lowStockProduct++;
                }
            }
            return lowStockProduct;
        }

        public int getOutOfStockProduct(List<Product> products)
        {
            int OutOfStockProduct = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Quantity ==0)
                {
                    OutOfStockProduct++;
                }
            }
            return OutOfStockProduct;
        }


        //SUPPLIER METHODS

        public List<Supplier> getSuppliers()
        {
            return InventoryData.getSuppliers();
        }

        public bool supplierExist(string supplierId)
        {
            List<Supplier> suppliers = InventoryData.getSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Id == supplierId)
                {
                    return true;
                }
            }
            return false;
        }
        public List<string> getSupplierNames()
        {
            return InventoryData.getSuppliers()
                       .Select(s => s.Name)
                       .ToList();
        }
        public List<Supplier> getSupplier(string supplierId)
        {
           List<Supplier> suppliers = InventoryData.getSuppliers();
            List<Supplier> searchedSupplier = new List<Supplier>();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Id == supplierId)
                {
                    searchedSupplier.Add(suppliers[i]);
                }
            }
            return searchedSupplier;
        }
       
        public List<Supplier> getSupplierByName(string supplierName)
        {
            List<Supplier> suppliers = InventoryData.getSuppliers();
            List<Supplier> searchedSupplier = new List<Supplier>();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Name.StartsWith(supplierName))
                {
                    searchedSupplier.Add(suppliers[i]);
                }
            }
            return searchedSupplier;
        }

      
        public List<string> getSupplierProducts(string supplierId)
        {
            List<Product> products = InventoryData.getProducts();
            List<string> supplierProducts = new List<string>();
            int productCount = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].supplierId == supplierId)
                {
                    supplierProducts.Add(products[i].Name);
                    productCount++;
                }
            }

         
            return supplierProducts;
        }
        public string getSupplierName(string supplierId)
        {
            List<Supplier> suppliers = InventoryData.getSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Id == supplierId)
                {
                    return suppliers[i].Name;
                }
            }
            return "";
        }
        public string getSupplierId(string supplierName)
        {
            List<Supplier> suppliers = InventoryData.getSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Name == supplierName)
                {
                    return suppliers[i].Id;
                }
            }
            return null;
        }

        public void addSupplier(string supplierId, string supplierName, string supplierAddress, string supplierContactNum, string supplierEmailAdd)
        {
            Supplier supplier1 = new Supplier();
            supplier1.Id = supplierId;
            supplier1.Name = supplierName;
            supplier1.Address = supplierAddress;
            supplier1.ContactNum = supplierContactNum;
            supplier1.EmailAdd = supplierEmailAdd;
            InventoryData.addSupplier(supplier1);
        }

        public bool removeSupplier(string supplierId)
        {
            List<Supplier> suppliers = InventoryData.getSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].Id == supplierId)
                {
                    InventoryData.removeSupplier(suppliers[i]);
                    return true;
                }
            }
            return false;
        }

        public void updateSupplier(string NewSupplierId, string NewSupplierName, string NewSupplierAddress, string NewSupplierContactNum, string NewSupplierEmailAdd)
        {
            Supplier supplier1 = new Supplier();
            supplier1.Id = NewSupplierId;
            supplier1.Name = NewSupplierName;
            supplier1.Address = NewSupplierAddress;
            supplier1.ContactNum = NewSupplierContactNum;
            supplier1.EmailAdd = NewSupplierEmailAdd;
            InventoryData.updateSupplier(supplier1);

           
        }

        //ACCOUNT METHODS
        public List<Accounts> getAccounts()
        {
            return InventoryData.getAccounts();
        }

        public bool accountExist(string userName, string password)
        {

            List<Accounts> accounts = InventoryData.getAccounts();
          
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].userName == userName && accounts[i].password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public void addAccount(string userName, string password)
        {
            Accounts account1 = new Accounts();
            account1.userName = userName;
            account1.password = password;
            InventoryData.addAccount(account1);
        }


        //Category METHODS

        public List<Category> GetCategories()
        {
            return InventoryData.getCategories();
        }

        public List<string> GetCategoryNames()
        {
            return InventoryData.getCategories()
                       .Select(c => c.Name)
                       .ToList();
        }
        public void addCategory( string categoryName)
        {
            Category category1 = new Category();
            category1.Name = categoryName;
            InventoryData.addCategory(category1);
        }
        public int getCategoryId(string categoryName)
        {
          
            List<Category> categories = InventoryData.getCategories();

            int categoryId = 0;
              for (int i =0; i<categories.Count; i++)
            {
                if (categories[i].Name == categoryName)
                {
                    categoryId = categories[i].Id;
                    break;
                }
            }

         

                return categoryId;
        }
        public void removeCategory(string categoryName)
        {
           Category category1 = new Category();
            category1.Name = categoryName;
            category1.Id = getCategoryId(categoryName);
            InventoryData.removeCategory(category1);
        }

        public void updateCategory(string newCategoryName, string oldCategoryName)
        {
            Category category1 = new Category();
            category1.Name = newCategoryName;
            category1.Id = getCategoryId(oldCategoryName);
            InventoryData.updateCategory(category1);
        }


        //ORDERS METHOD

        public List<Orders> getOrders()
        {
            return InventoryData.getOrders();
        }
        public Orders getOrder(int id)
        {   List<Orders> orders = InventoryData.getOrders();
            Orders order = new Orders();

            for(int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == id)
                {
                    order = orders[i];
                    break;
                }
            }

            return order;
        }

        public List<Orders> getOrderByProductId(string productId,  List<Orders> orders)
        {
        
            List<Orders> filteredOrders = new List<Orders>();
            

            for(int i=0;i <orders.Count; i++)
            {
                if (orders[i].productId==productId)
                {
                    filteredOrders.Add(orders[i]);
                }
            }
            return filteredOrders;

        }

        public List<Orders> getOrdersByStatus(string status, List<Orders> orders)
        {
            List<Orders> filteredOrders = new List<Orders>();
            for(int i = 0; i < orders.Count; i++)
            {
                if (orders[i].status == status)
                {
                    filteredOrders.Add(orders[i]);
                }
            }

            return filteredOrders;
        }
        public List<Orders> getOrderByProductIdAndStatus(string productName, string status, List<Orders> orders)
        {

            string productId = getProductIdByName(productName);

            List<Orders> filteredOrders = new List<Orders>();
           
            if (status == "All")
            {
                return orders; 
            }
            if (string.IsNullOrWhiteSpace(productName) || productName == "Search Product Name")
            {
                return getOrdersByStatus(status, orders);
            }

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].productId == productId && orders[i].status == status)
                {
                    filteredOrders.Add(orders[i]);
                }
            }

            return filteredOrders;
        }
            


        public string  getProductNameByOrderId(int orderId)
        {
         
            List<Orders> orders = InventoryData.getOrders();
            for(int i = 0; i < orders.Count; i++)
            {
                if(orderId == orders[i].Id)
                {
                    return getProductNameById(orders[i].productId);
                }
            }
            return "";

        }

        public List<Orders> getArrivingOrders()
        {
            List<Orders> orders = InventoryData.getOrders();
            List<Orders> arrivingOrders = new List<Orders>();
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            DateOnly targetDate = today.AddDays(2);
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].status == "Ordered" && orders[i].estimatedDate >= today && orders[i].estimatedDate <= targetDate)
                {
                    arrivingOrders.Add(orders[i]);
                }
            }
            return arrivingOrders;

        }
        public void addOrder(DateOnly orderDate, string supplierId, string productId, int qty, string status, DateOnly estimatedDate)
        {
         
            Orders orders = new Orders();
            orders.orderDate = orderDate;
            orders.supplierId = supplierId;
            orders.productId = productId;
            orders.qty = qty;
            orders.status = status;
            orders.estimatedDate = estimatedDate;
          

            InventoryData.addOrders(orders);
        }
        public void updateOrder(int orderId, string newStatus)
        {
            Orders order = getOrder(orderId);
            order.status = newStatus;
            InventoryData.updateOrders(order);
        }
        public void removeOrder(int  orderId)
        {
            List<Orders> orders = InventoryData.getOrders();
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == orderId)
                {
                    InventoryData.removeOrders(orders[i]);
                    
                }
            }
           
        }



    }


    }

