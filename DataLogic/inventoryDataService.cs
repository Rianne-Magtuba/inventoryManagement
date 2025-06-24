using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
    public class inventoryDataService
    {
        IinventoryDataService InventoryDataService; 

        public inventoryDataService()
        {
            //InventoryDataService = new textMemoryInvData();
            //InventoryDataService = new inMemoryInvData();
            //InventoryDataService = new inventoryJsonData();
            InventoryDataService = new dbIInventoryData();

        }

        public List<Product>getProducts(){
         return InventoryDataService.getProducts();
        }
        public void addProduct(Product product) {
            InventoryDataService.addProduct(product);
        }
        public void updateProduct(Product product) {
            InventoryDataService.updateProduct(product);
        }
        public void removeProduct(Product product) {
            InventoryDataService.removeProduct(product);
        }
        public List<Accounts> getAccounts()
        {
           return  InventoryDataService.getAccounts();
        }
        public void addAccount(Accounts account)
        {
            InventoryDataService.addAccount(account);
        }
        public void updateAccount(Accounts account, string userName)
        {
            InventoryDataService.updateAccount(account, userName);

        }
        public void removeAccount(Accounts account)
        {
            InventoryDataService.removeAccount(account);
        }

        //suppliers
        public List<Supplier> getSuppliers()
        {
            return InventoryDataService.getSuppliers();
        }
        public void addSupplier(Supplier supplier)
        {
            InventoryDataService.addSupplier(supplier);
        }
        public void updateSupplier(Supplier supplier)
        {
            InventoryDataService.updateSupplier(supplier);

        }
        public void removeSupplier(Supplier supplier)
        {
            InventoryDataService.removeSupplier(supplier);
        }


        //category
        public List<Category> getCategories()
        {
            return InventoryDataService.getCategories();
        }
        public void addCategory(Category category)
        {
            InventoryDataService.addCategory(category);
        }
        public void updateCategory(Category category)
        {
            InventoryDataService.updateCategory(category);

        }
        public void removeCategory(Category category)
        {
            InventoryDataService.removeCategory(category);
        }


        //order
        public List<Orders> getOrders()
        {
            return InventoryDataService.getOrders();
        }
        public void addOrders(Orders orders)
        {
            InventoryDataService.addOrders(orders);
        }
        public void updateOrders(Orders orders)
        {
            InventoryDataService.updateOrders(orders);

        }
        public void removeOrders(Orders orders)
        {
            InventoryDataService.removeOrders(orders);
        }

    }

}
