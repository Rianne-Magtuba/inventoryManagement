using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryCommon;

namespace DataLogic
{
    public class InventoryData
    {
         List<Product> products = new List<Product>();

        public InventoryData()
        {

            addDummyData();
        }
        public string getProductName(string productId)
        {
            string productName ="";

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == productId)
                {
                    productName = products[i].Name;
                }
            }
            return productName;
        }
        public  bool checkStocksAmount()
        {

            return products.Count == 0;
        }

        public void addDummyData()
        {
            Product product1 = new Product();
            product1.Id = "1234";
            product1.Name = "Test";
            product1.Quantity = 5;
            product1.Supplier = "coke ph";
            product1.Price = 32;

            products.Add(product1);


            Product product2 = new Product();
            product2.Id = "123456";
            product2.Name = "Testing";
            product2.Quantity = 55;
            product2.Supplier = "coke phh";
            product2.Price = 322;

            products.Add(product2);

        }


        public void addProduct(string productId, string productName, int productQuantity,  string productSupplier, double productPrice)
        {
            Product product1 = new Product();
            product1.Id = productId;
            product1.Name = productName;
            product1.Quantity = productQuantity;
            product1.Supplier = productSupplier;
            product1.Price = productPrice;

            products.Add(product1);
        }

        public List<Product> getProducts()
        {
            List<Product> localProducts = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {

                
                    localProducts.Add(products[i]);
           
            }

            return localProducts;
        }

        public bool productExist(string productId)
        {
            bool exist = false;
            for (int i = 0; i < products.Count; i++)
            {
                if(productId == products[i].Id)
                {
                    exist = true;
                }
            }

            return exist;
        }
        public bool removeProduct(string ProductId)
        {
            
         
            bool exist = productExist(ProductId);
            for (int i = 0; i < products.Count; i++)
            {

                if (ProductId.Equals(products[i].Id))
                {  
                   products.RemoveAt(i);
                }
              
            }


            return exist;
        }
        public List<Product> searchProduct(String productId)
        {
            List<Product> localProducts = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    localProducts.Add(products[i]);
                }
            }

            return localProducts;
        }

        public void updateAllValues(string SelectedId, string NewProductName, string NewProductId,  int NewProductQuantity,  double NewProductPrice, string NewProductSupplier)
        {
            for (int i = 0; i < products.Count; i++)
            {

                if (SelectedId.Equals(products[i].Id))
                {
                    products[i].Name = NewProductName;
                    products[i].Id = NewProductId;
                    products[i].Quantity = NewProductQuantity;
                    products[i].Price = NewProductPrice;
                    products[i].Supplier = NewProductSupplier;
                }
            }

        }

        public void updateProducSupplier(String productSupplier, String productId)
        {

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    products[i].Supplier = productSupplier;
                }
            }

        }
        public void updateProductName(String productName, String productId)
        {

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    products[i].Name = productName;
                }
            }

        }

        public void updateProductQuantity(int productQuantity, String productId)
        {

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    products[i].Quantity = productQuantity;
                }
            }

        }

        public void updateProductPrice(double productPrice, String productId)
        {

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    products[i].Price = productPrice;
                }
            }

        }

        public void updateProductId(string NewProductID, String productId)
        {

            for (int i = 0; i < products.Count; i++)
            {

                if (productId.Equals(products[i].Id))
                {
                    products[i].Id = NewProductID;
                }
            }

        }

    }
}
