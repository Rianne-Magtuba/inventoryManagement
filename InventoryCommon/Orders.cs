using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCommon
{
    public class Orders
    {
       public  string Id { get; set; }
        public DateOnly orderDate    { get; set; }
        public string supplierId { get; set; }
        public string productId { get; set; }
        public int qty { get; set; }

    }
}
