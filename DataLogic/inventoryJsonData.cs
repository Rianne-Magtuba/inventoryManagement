using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;
namespace DataLogic
{
    internal class inventoryJsonData : IinventoryDataService
    {
        string jsonProdDataPath = "json_invData.json";
        string jsonAccFilePath = "json_accData.json";
        string jsonSupFilePath = "json_supData.json";
        string jsonCatFilePath = "json_catData.json";
        List<Product> products = new List<Product>();
        List<Accounts> accounts = new List<Accounts>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Category> categories = new List<Category>();
        public inventoryJsonData()
        {
            ReadJsonDataFromFile();

        }

        public void ReadJsonDataFromFile()
        {
            string jsonProdText = File.ReadAllText(jsonProdDataPath);

            products = JsonSerializer.Deserialize<List<Product>>(jsonProdText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            string jsonAccText = File.ReadAllText(jsonAccFilePath);
            accounts = JsonSerializer.Deserialize<List<Accounts>>(jsonAccText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            string jsonSupText = File.ReadAllText(jsonSupFilePath);
            suppliers = JsonSerializer.Deserialize<List<Supplier>>(jsonSupText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            string jsonCatText = File.ReadAllText(jsonCatFilePath); 
            categories = JsonSerializer.Deserialize<List<Category>>(jsonCatText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

        }
        public int getIndex<T>(List<T> objs, T obj) where T : class
        {
            for (int i = 0; i < objs.Count; i++)
            {

                var objId = obj.GetType().GetProperty("Id")?.GetValue(obj);
                var listItemId = objs[i]?.GetType().GetProperty("Id")?.GetValue(objs[i]);

                if (objId != null && objId.Equals(listItemId))
                {
                    return i;
                }
            }

            return -1;
        }
        public List<Product> getProducts()
        {
            return products;
        }
        private void WriteJsonProdDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(products, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonProdDataPath, jsonString);
        }
     
      
        public void addProduct(Product product)
        {
            products.Add(product);
            WriteJsonProdDataToFile();
        }

        public void updateProduct(Product product, string prodID)
        {
            int index = getIndex(products, product);

            if (index != -1){
                products[index].Name = product.Name;
                products[index].Id = product.Id;
                products[index].Quantity = product.Quantity;
                products[index].Price = product.Price;
                products[index].supplierId = product.supplierId;

                WriteJsonProdDataToFile();
            }
                   


        }

        public void removeProduct(Product product)
        {
            var index = getIndex(products,product);
            if (index != -1)
            {
                products.RemoveAt(index);
                WriteJsonProdDataToFile();
            }
         
        }
        private void WriteJsonAccDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonAccFilePath, jsonString);
        }
        public List<Accounts> getAccounts()
        {
            return accounts; 
        }

        public void addAccount(Accounts account)
        {
            accounts.Add(account);
            WriteJsonAccDataToFile();
        }


        public void removeAccount(Accounts account)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].userName== account.userName)
                {
                    accounts.RemoveAt(i);
                  
                  
                }
              
            }
            WriteJsonAccDataToFile();

        }

        public void updateAccount(Accounts account, string userName)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].userName == account.userName)
                {
                    accounts[i].userName = account.userName;
                    accounts[i].password = account.password;



                }

            }
            WriteJsonAccDataToFile();
        }

        private void WriteJsonSuppDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(suppliers, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonSupFilePath, jsonString);
        }
        public List<Supplier> getSuppliers()
        {
            return suppliers;
        }

        public void addSupplier(Supplier suppliers)
        {
            this.suppliers.Add(suppliers);
            WriteJsonSuppDataToFile();
        }

        public void updateSupplier(Supplier suppliers, string id)
        {
            int index = getIndex(this.suppliers, suppliers);
            if (index != -1)
            {
                this.suppliers[index].Id = suppliers.Id;
                this.suppliers[index].Name = suppliers.Name;
                this.suppliers[index].Address = suppliers.Address;
                this.suppliers[index].ContactNum = suppliers.ContactNum;
                this.suppliers[index].EmailAdd = suppliers.EmailAdd;
                WriteJsonSuppDataToFile();
            }
        
           

        }

        public void removeSupplier(Supplier suppliers)
        {
            int index = getIndex(this.suppliers, suppliers);
            if(index != -1){
                this.suppliers.RemoveAt(index);

                WriteJsonSuppDataToFile();
            }
                    

        }
        private void WriteJsonCatDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(categories, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonCatFilePath, jsonString);
        }
        public List<Category> getCategories()
        {
            return categories;
        }

        public void addCategory(Category category)
        {
            categories.Add(category);
            WriteJsonCatDataToFile();
        }

        public void updateCategory(Category category, int id)
        {
            int index = getIndex(categories, category);
            if (index != -1)
            {
                categories[index].Id = category.Id;
                categories[index].Name = category.Name;
                WriteJsonCatDataToFile();
            }
         
          
        }
    
        public void removeCategory(Category category)
        {
            int index = getIndex(categories, category);
            if (index != -1)
            {
                categories.RemoveAt(index);

                WriteJsonCatDataToFile();
            }

                
                
        }
    }
}
