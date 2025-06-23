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
        List<Accounts> accounts = new List<Accounts>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Category> categories = new List<Category>();
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
            product1.supplierId = "1019";
            product1.Price = 32;
            product1.dateModified = DateOnly.Parse("2024-12-10");

            products.Add(product1);


            Product product2 = new Product();
            product2.Id = "123456";
            product2.Name = "Testing";
            product2.Quantity = 55;
            product2.supplierId = "1019";
            product2.Price = 322;
            product2.dateModified = DateOnly.Parse("2025-02-10");

            products.Add(product2);


            Accounts account1 = new Accounts();
            account1.userName = "admin";
            account1.password = "1234";

            accounts.Add(account1);

            Supplier supplier1 = new Supplier();
            supplier1.Id = "1019";
            supplier1.Name = "coke ph";
            supplier1.ContactNum = "09123456789";
            supplier1.Address = "1234 MAnila st";
            supplier1.EmailAdd = "coke@corp.ph.com";
            suppliers.Add(supplier1);

            Supplier supplier2 = new Supplier();
            supplier2.Id = "1027";
            supplier2.Name = "pepsi ph";
            supplier2.ContactNum = "123141414";
            supplier2.Address = "6969 MAnila st";
            supplier2.EmailAdd = "spolilarium@corp.ph.com";
            suppliers.Add(supplier2);

            Category cat1 = new Category();
            cat1.Id = 1;
            cat1.Name = "Drink";
            categories.Add(cat1);


            Category cat2 = new Category();
            cat2.Id = 2;
            cat2.Name = "beverage";
            categories.Add(cat2);




        }


        public void addProduct(Product product)
        {
        
            products.Add(product);
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


        public void updateProduct(Product product, string prodID)  
        {
            int index = getIndex(products, product);
            if (index != -1) { 
                    products[index].Name = product.Name;
                    products[index].Id = product.Id;
                    products[index].Quantity = product.Quantity;
                    products[index].Price = product.Price;
                    products[index].supplierId = product.supplierId;
                    products[index].dateModified = product.dateModified;

                }

                

            
        }
     
        public void removeProduct(Product product)
        {
          int index = getIndex(products,product);
            if (index != -1)
            {
                products.RemoveAt(index);
            }
   
        }

        public List<Accounts> getAccounts()
        {
            return accounts;
        }

        public void addAccount(Accounts account)
        {
            Accounts account1 = account;


            accounts.Add(account1);
        }

        public void updateAccount(Accounts account,  string userName)
        {
            for (int i = 0; i <= accounts.Count; i++)
            {
                if (accounts[i].userName == userName)
                {
                    accounts[i].userName = account.userName;
                    accounts[i].password = account.password;
                 

                }

            }
        }

        public void removeAccount(Accounts account)
        {
            for(int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].userName == account.userName)
                {
                    accounts.RemoveAt(i);
                }
            }
            
        }

        public List<Supplier> getSuppliers()
        {
            return suppliers;
        }

        public void addSupplier(Supplier suppliers)
        {
            this.suppliers.Add(suppliers);
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
            }
                   
                

                
        }

        public void removeSupplier(Supplier suppliers)
        {
            int index = getIndex(this.suppliers, suppliers);
           if (index != -1){
                this.suppliers.RemoveAt(index);
            }
                   
               
        }

        public List<Category> getCategories()
        {
            return categories;
        }

        public void addCategory(Category category)
        {
           categories.Add(category);
        }

        public void updateCategory(Category category, int id)
        {
            int index = getIndex(categories, category);

            if (index != -1)
            {
                categories[index].Id = category.Id;
                categories[index].Name = category.Name;
            }
         
                 


               
        }

        public void removeCategory(Category category)
        {
            int index = getIndex(categories, category);
            if (index != -1)
            {
                categories.RemoveAt(index);

            }
                  

               
        }
    }
}
