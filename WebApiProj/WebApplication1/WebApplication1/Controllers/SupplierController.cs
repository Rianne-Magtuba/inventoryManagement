using Microsoft.AspNetCore.Mvc;
using InventoryCommon;
using BusinessLogic;
using System.Collections.Generic;

namespace inventoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        inventoryProcess inventoryProcess = new inventoryProcess();

        [HttpGet]
        public List<Supplier> GetSuppliers()
        {
            return inventoryProcess.getSuppliers();
        }

        [HttpGet("exist")]
        public bool SupplierExist(string supplierId)
        {
            return inventoryProcess.supplierExist(supplierId);
        }

        [HttpGet("names")]
        public List<string> GetSupplierNames()
        {
            return inventoryProcess.getSupplierNames();
        }

        [HttpGet("getById")]
        public List<Supplier> GetSupplier(string supplierId)
        {
            return inventoryProcess.getSupplier(supplierId);
        }

        [HttpGet("getByName")]
        public List<Supplier> GetSupplierByName(string supplierName)
        {
            return inventoryProcess.getSupplierByName(supplierName);
        }

        [HttpGet("products")]
        public List<string> GetSupplierProducts(string supplierId)
        {
            return inventoryProcess.getSupplierProducts(supplierId);
        }

        [HttpGet("nameFromId")]
        public string GetSupplierName(string supplierId)
        {
            return inventoryProcess.getSupplierName(supplierId);
        }

        [HttpGet("idFromName")]
        public string GetSupplierId(string supplierName)
        {
            return inventoryProcess.getSupplierId(supplierName);
        }

        [HttpPost("add")]
        public void AddSupplier(string supplierId, string supplierName, string supplierAddress, string supplierContactNum, string supplierEmailAdd)
        {
            inventoryProcess.addSupplier(supplierId, supplierName, supplierAddress, supplierContactNum, supplierEmailAdd);
        }

        [HttpDelete("remove")]
        public bool RemoveSupplier(string supplierId)
        {
            return inventoryProcess.removeSupplier(supplierId);
        }

        [HttpPost("update")]
        public void UpdateSupplier(string NewSupplierId, string NewSupplierName, string NewSupplierAddress, string NewSupplierContactNum, string NewSupplierEmailAdd)
        {
            inventoryProcess.updateSupplier(NewSupplierId, NewSupplierName, NewSupplierAddress, NewSupplierContactNum, NewSupplierEmailAdd);
        }
    }
}
