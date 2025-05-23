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
            InventoryDataService = new textMemoryInvData();
            //InventoryDataService = new inMemoryInvData();
            //InventoryDataService = new inventoryJsonData();

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

    }
}
