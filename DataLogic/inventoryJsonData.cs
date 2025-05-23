using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace DataLogic
{
    internal class inventoryJsonData : IinventoryDataService
    {
        string jsonFilePath = "json_invData.json";
        List<Product> products = new List<Product>();
        public inventoryJsonData()
        {
            ReadJsonDataFromFile();

        }

        public void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);

            products = JsonSerializer.Deserialize<List<Product>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }
        public List<Product> getProducts()
        {
            return products;
        }
        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(products, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }
        private int FindIndex(string Id)
        {
            var products = getProducts();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == Id)
                {
                    return i;
                }
            }

            return -1;
        }
        public void addProduct(Product product)
        {
            products.Add(product);
            WriteJsonDataToFile();
        }

        public void updateProduct(Product product)
        {
            var i = FindIndex(product.Id);


            products[i].Id = product.Id;
            products[i].Name = product.Name;
            products[i].Quantity = product.Quantity;
            products[i].Price = product.Price;
            products[i].Supplier = product.Supplier;

            WriteJsonDataToFile();
        }

        public void removeProduct(Product product)
        {
            var index = FindIndex(product.Id);

            products.RemoveAt(index);
            WriteJsonDataToFile();
        }
    }
}
