using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }

        public List<OrderItem> GetAllOrders()
        {
            var resultList = _orderLogic.GetAllOrdersItem();
            return resultList;
        }

        public int ModifyOrder(OrderItem orderItem)
        {
            _orderLogic.ModifyOrderItem(orderItem);
            return orderItem.Id;
        }

        public int DeleteOrder(OrderItem orderItem)
        {
            _orderLogic.DeleteOrderItem(orderItem);
            return orderItem.Id;
        }

    }
}
