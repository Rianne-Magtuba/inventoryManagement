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

        //public string getProductName(string productId)
        //{
        //    return InventoryData.getProductName(productId);
        //}

        //PRODUT METHODS
        public List<Product> getProduct(string productId)
        {
            List<Product> products = InventoryData.getProducts();
            List<Product> searchedProduct = new List<Product>();
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == productId)
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


        public void updateProduct(string SelectedId, string NewProductName, string NewProductId, int NewProductQuantity, double NewProductPrice, string NewProductSupplier, string newCategory)
        {

            Product product1 = new Product();
            
            product1.Id = NewProductId;
            product1.Name = NewProductName;
            product1.Quantity = NewProductQuantity;
            product1.supplierId = NewProductSupplier;
            product1.Price = NewProductPrice;
            product1.category = newCategory;
            product1.dateModified = DateOnly.FromDateTime(DateTime.Now);


            InventoryData.updateProduct(product1, SelectedId);


        }
        //SUPPLIER METHODS

        public List<Supplier> getSuppliers()
        {
            return InventoryData.getSuppliers();
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

            if(productCount == 0)
            {
                supplierProducts.Add("No products found");
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

        public void updateSupplier(string SelectedId, string NewSupplierId, string NewSupplierName, string NewSupplierAddress, string NewSupplierContactNum, string NewSupplierEmailAdd)
        {
            Supplier supplier1 = new Supplier();
            supplier1.Id = NewSupplierId;
            supplier1.Name = NewSupplierName;
            supplier1.Address = NewSupplierAddress;
            supplier1.ContactNum = NewSupplierContactNum;
            supplier1.EmailAdd = NewSupplierEmailAdd;
            InventoryData.updateSupplier(supplier1, SelectedId);
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
    }
    


}

