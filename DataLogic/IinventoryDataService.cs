using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public interface IinventoryDataService
    {

        public List<Product> getProducts();
        
        public void addProduct(Product product);
        public void updateProduct(Product product);
        public void removeProduct(Product product);


        //accounts
        public List<Accounts> getAccounts();
        public void addAccount(Accounts account);
        public void updateAccount(Accounts account, string userName);
        public void removeAccount(Accounts account);

        //suppliers
        public List<Supplier> getSuppliers();
        public void addSupplier(Supplier suppliers);
        public void updateSupplier(Supplier suppliers);
        public void removeSupplier(Supplier suppliers);

        //category

        public List<Category> getCategories();
        public void addCategory(Category category);
        public void updateCategory(Category category);
        public void removeCategory(Category category);

            //Orders

       public List<Orders> getOrders();
        public void addOrders(Orders orders);
        public void updateOrders(Orders orders);
        public void removeOrders(Orders orders);
    }
}
