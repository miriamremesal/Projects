using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        public int InsertOrderItem(OrderItem orderItem);
        List<OrderItem> GetAllOrdersItem();
        public void ModifyOrderItem(OrderItem orderItem);
        public void DeleteOrderItem(OrderItem orderItem);
    }
}
