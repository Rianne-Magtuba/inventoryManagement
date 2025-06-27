using BusinessLogic;
using InventoryCommon;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace inventoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        inventoryProcess inventoryProcess = new inventoryProcess();

        [HttpGet]
        public List<Orders> GetOrders()
        {
            return inventoryProcess.getOrders();
        }

        [HttpGet("getOrder")]
        public Orders GetOrder(int id)
        {
            return inventoryProcess.getOrder(id);
        }

        [HttpGet("getArriving")]
        public List<Orders> GetArrivingOrders()
        {
            return inventoryProcess.getArrivingOrders();
        }

        [HttpGet("getProductNameByOrderId")]
        public string GetProductNameByOrderId(int orderId)
        {
            return inventoryProcess.getProductNameByOrderId(orderId);
        }

        [HttpGet("getOrderByProductId")]
        public List<Orders> GetOrderByProductId(string productId)
        {
            List<Orders> orders = inventoryProcess.getOrders();
            return inventoryProcess.getOrderByProductId(productId, orders);
        }

        [HttpGet("getOrdersByStatus")]
        public List<Orders> GetOrdersByStatus(string status)
        {
            List<Orders> orders = inventoryProcess.getOrders();
            return inventoryProcess.getOrdersByStatus(status, orders);
        }

        [HttpGet("getOrderByProductIdAndStatus")]
        public List<Orders> GetOrderByProductIdAndStatus(string productName, string status)
        {
            List<Orders> orders = inventoryProcess.getOrders();
            return inventoryProcess.getOrderByProductIdAndStatus(productName, status, orders);
        }

        [HttpPost("add")]
        public void AddOrder(string orderDate, string supplierId, string productId, int qty, string status, string estimatedDate)
        {
            DateOnly parsedOrderDate = DateOnly.Parse(orderDate);
            DateOnly parsedEstimatedDate = DateOnly.Parse(estimatedDate);

            inventoryProcess.addOrder(parsedOrderDate, supplierId, productId, qty, status, parsedEstimatedDate);
        }

        [HttpPost("update")]
        public void UpdateOrder(int orderId, string newStatus)
        {
            inventoryProcess.updateOrder(orderId, newStatus);
        }

        [HttpDelete("remove")]
        public void RemoveOrder(int orderId)
        {
            inventoryProcess.removeOrder(orderId);
        }
    }
}
