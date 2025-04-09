using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using DataLogic;
using InventoryCommon;
namespace BusinessLogic

{
    public class inventoryProcess
    {

        InventoryData InventoryData = new InventoryData();

        //public static List<String> productName = new List<String>();
        //public static List<int> productQty = new List<int>();
        //public static List<Double> productPrice = new List<Double>();

       
        public bool checkProductAmount()
        {
            return InventoryData.checkStocksAmount();
        }

        public string getProductName(string productId)
        {
            return InventoryData.getProductName(productId);
        }
        public  void AddProduct(string productId, string productName, int productQuantity, string productSupplier, double productPrice)
        {
            InventoryData.addProduct(productId, productName, productQuantity, productSupplier, productPrice);

        }

        public bool  removeProduct(string productId)
        {

            return InventoryData.removeProduct(productId);
           
        }

        public bool checkStocksAmount()
        {
            return InventoryData.checkStocksAmount();
        }

        public bool productExist(string productId)
        {
            return InventoryData.productExist(productId);
        }
        public List<Product> getProducts() { 
        
       
            return InventoryData.getProducts();

        }

        public List<Product> searchProduct(string productId)
        {
            return InventoryData.searchProduct(productId);
        }

        public bool  updateProductName(string productId, string NewproductName) 
            {
           
            if (productExist(productId)==true)
            {
                InventoryData.updateProductName(NewproductName, productId);
                return true;
            }
            else
            {
                return false;
            }

           
            }

        public bool updateProductId(string productId, string newProductId)
        {

            if (productExist(productId) == true)
            {
                InventoryData.updateProductId(newProductId, productId);
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool updateProductQuantity(string productId, int newProductQuantity)
        {

            if (productExist(productId) == true)
            {
                InventoryData.updateProductQuantity(newProductQuantity, productId);
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool updateProductPrice(string productId, double newProductPrice)
        {

            if (productExist(productId) == true)
            {
                InventoryData.updateProductPrice(newProductPrice, productId);
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool updateProductSupplier(string productId, string newProductSupplier)
        {

            if (productExist(productId) == true)
            {
                InventoryData.updateProducSupplier(newProductSupplier, productId);
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool updateAllProducts(string SelectedId, string NewProductName, string NewProductId, int NewProductQuantity, double NewProductPrice, string NewProductSupplier)
        {

            if (productExist(SelectedId) == true)
            {
                InventoryData.updateAllValues(SelectedId,NewProductName, NewProductId, NewProductQuantity,NewProductPrice, NewProductSupplier);
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
