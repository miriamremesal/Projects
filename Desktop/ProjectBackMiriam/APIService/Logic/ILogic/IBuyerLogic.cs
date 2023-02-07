using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBuyerLogic
    {
        List<BuyerItem> GetAllBuyersItem();
        public int InsertBuyerItem(BuyerItem buyerItem);
        public void ModifyBuyerItem(BuyerItem buyerItem);
        public void DeleteBuyerItem(BuyerItem buyerItem);
    }
}
