using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryCommon;

namespace DataLogic
{
    public class inMemoryInvData : IinventoryDataService
    {
         List<Product> products = new List<Product>();

        public inMemoryInvData()
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


        public void addProduct(Product product)
        {
            Product product1 = product;
           

            products.Add(product1);
        }

        public List<Product> getProducts()
        {
           
            return products;
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


        public int FindIndex(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == product.Id)
                {
                    return i;
                }
            }

            return -1;
        }
      


        public void updateProduct(Product product)
        {
          int i = FindIndex(product);
            products[i].Name = product.Name;
                    products[i].Id = product.Id;
                    products[i].Quantity = product.Quantity;
                    products[i].Price = product.Price;
                    products[i].Supplier = product.Supplier;
             
            
        }

        public void removeProduct(Product product)
        {
          int i = FindIndex(product);
            products.RemoveAt(i);
        }
    }
}
