
using BusinessLogic;
using InventoryCommon;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class productController : ControllerBase
    {
        private readonly inventoryProcess inventoryProcess;

        public productController(inventoryProcess _inventoryProcess)
        {
            inventoryProcess = _inventoryProcess;
        }

        [HttpGet("getAll")]
        public List<Product> GetAllProducts()
        {
            return inventoryProcess.getProducts();
        }

        [HttpGet("searchByName/{productName}")]
        public List<Product> SearchByName(string productName)
        {
            return inventoryProcess.getProductByName(productName);
        }

        [HttpGet("getNameById/{productId}")]
        public string GetProductNameById(string productId)
        {
            return inventoryProcess.getProductNameById(productId);
        }

        [HttpGet("getIdByName/{productName}")]
        public string GetProductIdByName(string productName)
        {
            return inventoryProcess.getProductIdByName(productName);
        }

        [HttpGet("nameExists/{productName}")]
        public bool ProductNameExists(string productName)
        {
            return inventoryProcess.productNameExist(productName);
        }

        [HttpGet("getById/{productId}")]
        public List<Product> GetProductById(string productId)
        {
            return inventoryProcess.getProductById(productId);
        }

        [HttpGet("getByCategory/{categoryName}")]
        public List<Product> GetProductByCategory(string categoryName)
        {
            return inventoryProcess.getProductByCategory(categoryName);
        }

        [HttpGet("getByCategoryAndName/{categoryName}/{selectedName}")]
        public List<Product> GetByCategoryAndName(string categoryName, string selectedName)
        {
            return inventoryProcess.getProductByCategoryAndName(categoryName, selectedName, inventoryProcess.getProducts());
        }

        [HttpPost("add")]
        public void AddProduct(Product product)
        {
            inventoryProcess.addProduct(product.Id, product.Name, product.Quantity, product.supplierId, product.Price, product.category);
        }

        [HttpPatch("update")]
        public void UpdateProduct(Product product)
        {
            inventoryProcess.updateProduct(product.Name, product.Id, product.Quantity, product.Price, product.supplierId, product.category);
        }

        [HttpDelete("delete/{productId}")]
        public bool DeleteProduct(string productId)
        {
            return inventoryProcess.removeProduct(productId);
        }

        [HttpGet("search/{productName}")]
        public List<Product> SearchProducts(string productName)
        {
            return inventoryProcess.searchProduct(productName);
        }

        [HttpGet("exists/{productId}")]
        public bool ProductExists(string productId)
        {
            return inventoryProcess.productExist(productId);
        }

        [HttpGet("totalStock")]
        public int GetTotalStock()
        {
            return inventoryProcess.getTotalStockProduct(inventoryProcess.getProducts());
        }

        [HttpGet("lowStock")]
        public int GetLowStock()
        {
            return inventoryProcess.getLowStockProduct(inventoryProcess.getProducts());
        }

        [HttpGet("outOfStock")]
        public int GetOutOfStock()
        {
            return inventoryProcess.getOutOfStockProduct(inventoryProcess.getProducts());
        }

    
    }
}
