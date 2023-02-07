using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService;
        public OrderController(ILogger<ProductController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            return _orderService.InsertOrder(orderItem);
        }

        [HttpGet(Name = "GetAllOrders")]
        public List<OrderItem> GetAll()
        {
            return _orderService.GetAllOrders();
        }

        [HttpPatch(Name = "ModifyOrder")]
        public int Patch([FromBody] OrderItem orderItem)
        {
            return _orderService.ModifyOrder(orderItem);
        }

        [HttpDelete(Name = "DeleteOrder")]
        public int Delete([FromBody] OrderItem orderItem)
        {
            return _orderService.DeleteOrder(orderItem);
        }

        //[HttpGet(Name = "GetOrdersByCriteria")]
        //public List<OrderItem> GetByCriteria([FromQuery] OrderFilter OrderFilter)
        //{
        //    
        //}

    }
}
