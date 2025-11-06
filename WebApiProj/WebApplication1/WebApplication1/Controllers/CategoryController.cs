using BusinessLogic;
using InventoryCommon;
using Microsoft.AspNetCore.Mvc;

namespace inventoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly inventoryProcess inventoryProcess;

        public CategoryController(inventoryProcess _inventoryProcess)
        {
            inventoryProcess = _inventoryProcess;
        }

        [HttpGet]
        public List<Category> GetCategories()
        {
            return inventoryProcess.GetCategories();
        }

        [HttpGet("getNames")]
        public List<string> GetCategoryNames()
        {
            return inventoryProcess.GetCategoryNames();
        }

        [HttpGet("getCategoryId")]
        public int GetCategoryId(string categoryName)
        {
            return inventoryProcess.getCategoryId(categoryName);
        }

        [HttpPost("add")]
        public void AddCategory(string categoryName)
        {
            inventoryProcess.addCategory(categoryName);
        }

        [HttpPost("update")]
        public void UpdateCategory(string newCategoryName, string oldCategoryName)
        {
            inventoryProcess.updateCategory(newCategoryName, oldCategoryName);
        }

        [HttpDelete("remove")]
        public void RemoveCategory(string categoryName)
        {
            inventoryProcess.removeCategory(categoryName);
        }
    }
}
