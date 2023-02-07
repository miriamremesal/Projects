using Entities.Entities;

namespace APIService.IServices
{
    public interface IOrderService
    {
        int InsertOrder(OrderItem orderItem);
        List<OrderItem> GetAllOrders();
        int ModifyOrder(OrderItem orderItem);
        int DeleteOrder(OrderItem orderItem);
    }
}
