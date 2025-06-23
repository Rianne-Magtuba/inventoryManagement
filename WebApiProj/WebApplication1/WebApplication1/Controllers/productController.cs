
using Microsoft.AspNetCore.Mvc;
using BusinessLogic;
using InventoryCommon;
using DataLogic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class productController : ControllerBase
    {
        inventoryProcess inventoryProcess = new inventoryProcess();
        [HttpGet]
        public IEnumerable<Product> get()
        {
            var products =  inventoryProcess.getProducts();
            return products;
        }

        [HttpPut]
        public void  addProduct(Product product)
        {
            inventoryProcess.addProduct(product.Id,product.Name,product.Quantity,product.supplierId,  product.Price, product.category);
          
        }
        [HttpPatch]
        public void updateProduct(productModule request)

        {
            string id = request.id;
            string name = request.name;
            int quantity = request.quantity;
            double price = request.price;
            string supplier = request.supplier;
            string selectedId = request.selectedId;
            string category = request.category;
            inventoryProcess.updateProduct(selectedId, name, id, quantity, price, supplier,category);
            //  inventoryProcess.updateAllProducts(request.selectedId, request.name, request.id, request.quantity, request.price, request.supplier);


        }
        [HttpDelete]
        public void deleteProduct(string id)
        {
            inventoryProcess.removeProduct(id);
        }
    }
}
