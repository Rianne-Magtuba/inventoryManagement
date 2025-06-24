using DataLogic;
using InventoryCommon;
using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;

public class textMemoryInvData : IinventoryDataService
{
	string prodFilePath = "prod_data.txt";
    string accFilePath = "accounts_data.txt";
    string suppliersFilePath = "suppliers_data.txt";
    string categoryFilePath = "categories_data.txt";
    List<Product> product = new List<Product>();
    List<Accounts> accounts = new List<Accounts>();
    List<Supplier> suppliers = new List<Supplier>();
    List<Category> categories = new List<Category>();
    public textMemoryInvData()
    {
        GetDataFromFile();

        }



    private void GetDataFromFile()
    {
        if (!File.Exists(prodFilePath) | !File.Exists(accFilePath) | !File.Exists(suppliersFilePath) | !File.Exists(categoryFilePath))
        {
           
            File.WriteAllText(prodFilePath, string.Empty);
            File.WriteAllText(accFilePath, string.Empty);
            File.WriteAllText(suppliersFilePath, string.Empty);
            File.WriteAllText(categoryFilePath, string.Empty);
            return;
        }

        var prodLines = File.ReadAllLines(prodFilePath);

        foreach (var line in prodLines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue; 

            var parts = line.Split('|');
          

            product.Add(new Product
            {
                Id = parts[0],
                Name = parts[1],
                Quantity = Convert.ToInt32(parts[2]),
                supplierId = parts[3],
                Price = Convert.ToDouble(parts[4]),
                dateModified = DateOnly.Parse(parts[5])
            });
   
        }

        var accLines = File.ReadAllLines(accFilePath);

        foreach (var line in accLines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split('|');


            accounts.Add(new Accounts
            {
               userName = parts[0],
                password = parts[1],
               
            });

        }

        var supplierLines = File.ReadAllLines(suppliersFilePath);

        foreach (var line in accLines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split('|');


            suppliers.Add(new Supplier
            {
                Id = parts[0],
                Name = parts[1],
                Address = parts[2],
                ContactNum = parts[3],
                EmailAdd = parts[4]

            });

        }

        var categoryLines = File.ReadAllLines(categoryFilePath);

        foreach (var line in accLines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split('|');


            categories.Add(new Category
            {
                Id = Convert.ToInt16(parts[0]),
                Name = parts[1],
              

            });

        }

    }

  
    private void writeProdDataToFile()
    {
        var lines = new string[product.Count];

        for (int i = 0; i < product.Count; i++)
        {
            lines[i] = $"{product[i].Id}|{product[i].Name}|{product[i].Quantity}|{product[i].supplierId}|{product[i].Price} | {product[i].dateModified}";
        }

        File.WriteAllLines(prodFilePath, lines);





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



    public List<Product> searchProduct(Product products)
    {
        List<Product> localProducts = new List<Product>();

        for (int i = 0; i < product.Count; i++)
        {

            if (products.Id ==product[i].Id)
            {
                localProducts.Add(product[i]);
            }
        }

        return localProducts;
    }

    public void addProduct(Product products)
    {

        product.Add(products);
        writeProdDataToFile();

    }

    public List<Product> getProducts()
    {

        return product;
    }

    public void removeProduct(Product products)
    {
 
        int index = getIndex(product,products);

        if (index != -1)
        {
            product.RemoveAt(index);

            writeProdDataToFile();

        }
        
    }
  

    public void updateProduct(Product products)
    {
     
        

        int index = getIndex(product, products);
        if (index != -1)
        {
            product[index].Name = products.Name;
            product[index].Id = products.Id;
            product[index].Quantity = products.Quantity;
            product[index].Price = products.Price;
            product[index].supplierId = products.supplierId;
            product[index].dateModified = products.dateModified;
            writeProdDataToFile();
        }
    }

    private void writeAccDataToFile()
    {
        var lines = new string[accounts.Count];

        for (int i = 0; i < accounts.Count; i++)
        {
            lines[i] = $"{accounts[i].userName}|{accounts[i].password}";
        }

        File.WriteAllLines(accFilePath, lines);





    }
    public List<Accounts> getAccounts()
    {
        return accounts;
    }

    public void addAccount(Accounts account)
    {
        accounts.Add(account);
        writeAccDataToFile();
    }

    public void updateAccount(Accounts account, string userName)
    {
        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].userName == userName)
            {
                accounts[i].userName = account.userName;
                accounts[i].password = account.password;
              

            }


        }
        writeAccDataToFile();
    }

    public void removeAccount(Accounts account)
    {
        int index = -1;
        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].userName == account.userName)
            {
                index = i;
            }
        }

        accounts.RemoveAt(index);

        writeAccDataToFile();
    }

    private void writeSupplierDataToFile()
    {
        var lines = new string[suppliers.Count];

        for (int i = 0; i < suppliers.Count; i++)
        {
            lines[i] = $"{suppliers[i].Id}|{suppliers[i].Name} | {suppliers[i].Address } | {suppliers[i].ContactNum} | {suppliers[i].EmailAdd}";
        }

        File.WriteAllLines(suppliersFilePath, lines);





    }
    public List<Supplier> getSuppliers()
    {
        return suppliers;
    }

    public void addSupplier(Supplier suppliers)
    {
      this.suppliers.Add(suppliers);
        writeSupplierDataToFile();
    }

    public void updateSupplier(Supplier suppliers)
    {
        int index = getIndex(this.suppliers, suppliers);
        if (index != -1)
        {
            this.suppliers[index].Id = suppliers.Id;
            this.suppliers[index].Name = suppliers.Name;
            this.suppliers[index].Address = suppliers.Address;
            this.suppliers[index].ContactNum = suppliers.ContactNum;
            this.suppliers[index].EmailAdd = suppliers.EmailAdd;
            writeSupplierDataToFile();
        }
       
      
    }

    public void removeSupplier(Supplier suppliers)
    {
        int index = getIndex(this.suppliers, suppliers);
        if (index != -1)
        {
            this.suppliers.RemoveAt(index);
            writeSupplierDataToFile();
        }
    }

    private void writeCategoryDataToFile()
    {
        var lines = new string[categories.Count];

        for (int i = 0; i < categories.Count; i++)
        {
            lines[i] = $"{categories[i].Id}|{categories[i].Name}  ";
        }

        File.WriteAllLines(categoryFilePath, lines);





    }
    public List<Category> getCategories()
    {
        return categories;
    }

    public void addCategory(Category category)
    {
        categories.Add(category);
        writeCategoryDataToFile();
    }

    public void updateCategory(Category category)
    {
        int index = getIndex(categories, category);
        if (index != -1)
        {
            categories[index].Id = category.Id;
            categories[index].Name = category.Name;
            writeCategoryDataToFile();
        }
     
    }

    public void removeCategory(Category category)
    {
        int index = getIndex(categories, category);
            if (index != -1)
        {
            categories.RemoveAt(index);


            writeCategoryDataToFile();
        }
               
    }

    public List<Orders> getOrders()
    {
        throw new NotImplementedException();
    }

    public void addOrders(Orders orders)
    {
        throw new NotImplementedException();
    }

    public void updateOrders(Orders orders)
    {
        throw new NotImplementedException();
    }

    public void removeOrders(Orders orders)
    {
        throw new NotImplementedException();
    }
}
