using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DataLogic
{
    //connection String
  
    internal class dbIInventoryData : IinventoryDataService
    {

        string connectionString = "Data Source = DESKTOP-OJ35B1P\\SQLEXPRESS; initial Catalog = InventoryManagement;  Integrated Security = True; TrustServerCertificate = True;";
        static SqlConnection sqlConnection;
        List<Product> products = new List<Product>();
        List<Accounts> accounts = new List<Accounts>();
        List<Supplier> suppliers = new List<Supplier>();
        List<Category> categories = new List<Category>();
        public dbIInventoryData()
        {
            sqlConnection = new SqlConnection(connectionString);

           
        }


        public void addProduct(Product product)
        {
            sqlConnection.Open();
            var insertStatement = "INSERT INTO inv_product_table  VALUES (@Id, @name, @supplier,  @price, @qty,  @category, @dateModified )";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Id", product.Id);
            insertCommand.Parameters.AddWithValue("@name", product.Name);
            insertCommand.Parameters.AddWithValue("@qty", product.Quantity);
            insertCommand.Parameters.AddWithValue("@price", product.Price);
            insertCommand.Parameters.AddWithValue("@supplier", product.supplierId);
            insertCommand.Parameters.AddWithValue("@category", product.category);
            insertCommand.Parameters.AddWithValue("@dateModified", product.dateModified);
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

    
        public List<Product> getProducts()
        {
            products.Clear(); 
            var selectStatement = "Select pID, pName, pQty, price,  supplierId, pCategory,dateModified  FROM inv_product_table";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
               
            SqlDataReader sqlRead = selectCommand.ExecuteReader();
          
            while (sqlRead.Read())
            {
                products.Add(new Product
                {
                    Id = sqlRead["pId"].ToString(),
                    Name = sqlRead["pName"].ToString(),
                    Quantity = Convert.ToInt32(sqlRead["pQty"].ToString() ),
                    Price = Convert.ToDouble(sqlRead["price"].ToString()),
                    supplierId = sqlRead["supplierId"].ToString(),
                    category = sqlRead["pCategory"].ToString(),
                    dateModified = DateOnly.FromDateTime((DateTime)sqlRead["dateModified"])


                });

            }


            sqlConnection.Close();


            return products;
        }

        public void removeProduct(Product product)
        {
            string deleteStatement = "DELETE FROM inv_product_table WHERE pID = @id";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@id", product.Id);
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void updateProduct(Product product)
        {   string updateStatement = $"UPDATE inv_product_table SET pName = @Name, pQty = @qty, price = @price, supplierId = @supplier, pCategory = @category, dateModified = @dateNow WHERE pId = @selectedId ";
            sqlConnection.Open();
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@Name", product.Name);
            updateCommand.Parameters.AddWithValue("@qty", product.Quantity);
            updateCommand.Parameters.AddWithValue("@price", product.Price);
            updateCommand.Parameters.AddWithValue("@supplier", product.supplierId);
            updateCommand.Parameters.AddWithValue("@category", product.category);
            updateCommand.Parameters.AddWithValue("@dateNow", product.dateModified);
            updateCommand.Parameters.AddWithValue("@selectedId", product.Id);
          
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public List<Accounts> getAccounts()
        { 
            var selectStatement = "Select username, password FROM inventory_accounts";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();
    
            while (sqlRead.Read())
            {
                accounts.Add(new Accounts
                {
                    userName = sqlRead["username"].ToString(),
                    password = sqlRead["password"].ToString(),
                  


                });

            }


            sqlConnection.Close();

            return accounts;
        }

        public void addAccount(Accounts account)
        {
            sqlConnection.Open();
            var insertStatement = "INSERT INTO inventory_accounts  VALUES (@username, @password )";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@username", account.userName);
            insertCommand.Parameters.AddWithValue("@password", account.password);
      

            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void updateAccount(Accounts account, string username)
        {
            string updateStatement = $"UPDATE inventory_accounts SET username = @username, password = @password WHERE pId = @selectedUserName ";
            sqlConnection.Open();
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@username", account.userName);
            updateCommand.Parameters.AddWithValue("@password", account.password);
            updateCommand.Parameters.AddWithValue("@selectedUserName", username);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void removeAccount(Accounts account)
        {
            string deleteStatement = "DELETE FROM inventory_accounts WHERE username = @username";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@username", account.userName);
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Supplier> getSuppliers()
        {
            suppliers.Clear();
            var selectStatement = "Select supplierId, supplierName, supplierAddress, supplierContactNum, supplierEmailAdd FROM supplier_table";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                suppliers.Add(new Supplier
                {
                  Id = sqlRead["supplierId"].ToString(),
                    Name = sqlRead["supplierName"].ToString(),
                    Address = sqlRead["supplierAddress"].ToString(),
                    ContactNum = sqlRead["supplierContactNum"].ToString(),
                    EmailAdd = sqlRead["supplierEmailAdd"].ToString()


                });

            }


            sqlConnection.Close();


            return suppliers;
        }

        public void addSupplier(Supplier suppliers)
        {
            sqlConnection.Open();
            var insertStatement = "INSERT INTO supplier_table  VALUES (@Id, @name, @add, @contactNum, @emailAdd)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Id", suppliers.Id);
            insertCommand.Parameters.AddWithValue("@name", suppliers.Name);
            insertCommand.Parameters.AddWithValue("@add", suppliers.Address);
            insertCommand.Parameters.AddWithValue("@contactNum", suppliers.ContactNum);
            insertCommand.Parameters.AddWithValue("@emailAdd", suppliers.EmailAdd);
        
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void updateSupplier(Supplier suppliers)
        {
              string updateStatement = $"UPDATE supplier_table SET  supplierName = @supName,  " +
                $"supplierAddress = @supAdd, supplierContactNum = @contactNum, supplierEmailAdd = @supEmailAd WHERE supplierId = @selectedId ";
                sqlConnection.Open();
                SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
          
                updateCommand.Parameters.AddWithValue("@supName", suppliers.Name);
                updateCommand.Parameters.AddWithValue("@supAdd", suppliers.Address);
                updateCommand.Parameters.AddWithValue("@contactNum", suppliers.ContactNum);
                updateCommand.Parameters.AddWithValue("@supEmailAd", suppliers.EmailAdd);
            
                updateCommand.Parameters.AddWithValue("@selectedId", suppliers.Id);
                updateCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }

        public void removeSupplier(Supplier suppliers)
        {
            string deleteStatement = "DELETE FROM supplier_tbl WHERE supplierId = @id";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@id", suppliers.Id);
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Category> getCategories()
        {
            categories.Clear();
            var selectStatement = "Select categoryId, categoryName FROM categoryTbl";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            SqlDataReader sqlRead = selectCommand.ExecuteReader();

            while (sqlRead.Read())
            {
                categories.Add(new Category
                {
                    Id = (int)sqlRead["categoryId"],
                    Name = sqlRead["categoryName"].ToString(),
                    


                });

            }


            sqlConnection.Close();


            return categories;
        }

        public void addCategory(Category category)
        {
            sqlConnection.Open();
            var insertStatement = "INSERT INTO categoryTbl  (categoryName) VALUES (@name)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", category.Name);


            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

      

        public void removeCategory(Category category)
        {
            string deleteStatement = "DELETE FROM categoryTbl WHERE categoryId = @id";
            sqlConnection.Open();
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@id", category.Id);
            deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void updateCategory(Category category)
        {

            string updateStatement = $"UPDATE categoryTbl SET  categoryName = @catName WHERE categoryId = @selectedId ";
            sqlConnection.Open();
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
           
            updateCommand.Parameters.AddWithValue("@catName", category.Name);


            updateCommand.Parameters.AddWithValue("@selectedId", category.Id);
            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
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
}
