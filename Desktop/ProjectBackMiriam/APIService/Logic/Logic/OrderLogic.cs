using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();

            return orderItem.Id;
        }

        public List<OrderItem> GetAllOrdersItem()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }

        public void ModifyOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Update(orderItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Remove(orderItem);
            _serviceContext.SaveChanges();
        }

    }
}
