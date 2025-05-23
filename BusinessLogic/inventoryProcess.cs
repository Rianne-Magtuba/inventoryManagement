using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using DataLogic;
using InventoryCommon;
namespace BusinessLogic

{
    public class inventoryProcess
    {

        inventoryDataService InventoryData = new inventoryDataService();


        //public string getProductName(string productId)
        //{
        //    return InventoryData.getProductName(productId);
        //}
        public void addProduct(string productId, string productName, int productQuantity, string productSupplier, double productPrice)
        {
            Product product1 = new Product();

            product1.Id = productId;
            product1.Name = productName;
            product1.Quantity = productQuantity;
            product1.Supplier = productSupplier;
            product1.Price = productPrice;


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


        public bool updateAllProducts(string SelectedId, string NewProductName, string NewProductId, int NewProductQuantity, double NewProductPrice, string NewProductSupplier)
        {
            List<Product> products = InventoryData.getProducts();

            for (int i = 0; i < InventoryData.getProducts().Count; i++)
            {
                if (SelectedId == products[i].Id)
                {
                    products[i].Id = NewProductId;
                    products[i].Name = NewProductName;
                    products[i].Quantity = NewProductQuantity;
                    products[i].Supplier = NewProductSupplier;
                    products[i].Price = NewProductPrice;

                    InventoryData.updateProduct(products[i]);


                }
             
            }
            return false;

        }
    }
    


}

