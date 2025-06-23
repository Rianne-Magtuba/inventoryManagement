using DataLogic;
using InventoryCommon;
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

        //public List<Product> searchProduct(string productId)
        //{
        //    return InventoryData.searchProduct(productId);
        //}


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

