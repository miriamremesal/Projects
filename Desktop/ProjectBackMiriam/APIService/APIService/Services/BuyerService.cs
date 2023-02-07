using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace APIService.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerLogic _BuyerLogic;
        public BuyerService(IBuyerLogic BuyerLogic)
        {
            _BuyerLogic = BuyerLogic;
        }
        public int InsertBuyer(BuyerItem BuyerItem)
        {
            _BuyerLogic.InsertBuyerItem(BuyerItem);
            return BuyerItem.Id;
        }

        public List<BuyerItem> GetAllBuyers()
        {
            var resultList = _BuyerLogic.GetAllBuyersItem();
            return resultList;
        }

        public int ModifyBuyer(BuyerItem buyerItem)
        {
            _BuyerLogic.ModifyBuyerItem(buyerItem);
            return buyerItem.Id;
        }

        public int DeleteBuyer(BuyerItem buyerItem)
        {
            _BuyerLogic.DeleteBuyerItem(buyerItem);
            return buyerItem.Id;
        }

    }
}
