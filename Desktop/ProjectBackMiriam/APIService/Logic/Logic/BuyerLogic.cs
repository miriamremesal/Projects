using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BuyerLogic : BaseContextLogic, IBuyerLogic
    {
        public BuyerLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertBuyerItem(BuyerItem buyerItem)
        {
            _serviceContext.Buyers.Add(buyerItem);
            _serviceContext.SaveChanges();

            return buyerItem.Id;
        }

        public List<BuyerItem> GetAllBuyersItem()
        {
            return _serviceContext.Set<BuyerItem>().ToList();
        }

        public void ModifyBuyerItem(BuyerItem buyerItem)
        {
            _serviceContext.Buyers.Update(buyerItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteBuyerItem(BuyerItem buyerItem)
        {
            _serviceContext.Buyers.Remove(buyerItem);
            _serviceContext.SaveChanges();
        }

    }
}