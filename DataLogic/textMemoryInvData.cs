using DataLogic;
using System.IO;
using InventoryCommon;
using System;
using System.Security.Principal;

public class textMemoryInvData : IinventoryDataService
{
	string filePath = "inv_data.txt";
    List<Product> product = new List<Product>();
	public textMemoryInvData()
    {
        GetDataFromFile();

        }



    private void GetDataFromFile()
    {
        if (!File.Exists(filePath))
        {
            // Optionally create the file or just return if no data yet
            File.WriteAllText(filePath, string.Empty);
            return;
        }

        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue; // skip empty lines

            var parts = line.Split('|');
          

            product.Add(new Product
            {
                Id = parts[0],
                Name = parts[1],
                Quantity = Convert.ToInt32(parts[2]),
                Supplier = parts[3],
                Price = Convert.ToDouble(parts[4]),
            });
   
        }
      
    }

    public int FindIndex(Product products)
    {
        for (int i = 0; i < product.Count; i++)
        {
            if (product[i].Id == products.Id)
            {
                return i;
            }
        }

        return -1;
    }
    private void writeDataToFile()
    {
        var lines = new string[product.Count];

        for (int i = 0; i < product.Count; i++)
        {
            lines[i] = $"{product[i].Id}|{product[i].Name}|{product[i].Quantity}|{product[i].Supplier}|{product[i].Price}";
        }

        File.WriteAllLines(filePath, lines);

    }
    public void addProduct(Product products)
    {

        //var newLine = $"\n{products.Id}|{products.Name}|{products.Quantity}|{products.Supplier}|{products.Price}";

        product.Add(products);
        writeDataToFile();



    }

    public List<Product> getProducts()
    {
     
        return product;
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

    public void removeProduct(Product products)
    {
 
        int index = -1;
        for (int i = 0; i < product.Count; i++)
        {
            if (product[i].Id == products.Id)
            {
                index = i;
            }
        }

        product.RemoveAt(index);

        writeDataToFile();
    }

    public void updateProduct(Product products)
    {
        int index = FindIndex(products);

        product[index].Id = products.Id;
        product[index].Name = products.Name;
        product[index].Quantity = products.Quantity;
        product[index].Supplier = products.Supplier;
        product[index].Price = products.Price;

        writeDataToFile();
    }


}
