using Entities.Entities;

namespace APIService.IServices
{
    public interface IBuyerService
    {
        int InsertBuyer(BuyerItem BuyerItem);
        List<BuyerItem> GetAllBuyers();
        int ModifyBuyer(BuyerItem buyerItem);
        int DeleteBuyer(BuyerItem buyerItem);
    }

}