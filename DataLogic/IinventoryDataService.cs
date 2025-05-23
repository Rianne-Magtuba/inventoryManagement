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
        public void updateProduct(Product bankAccount);
        public void removeProduct(Product bankAccount);
    }
}
