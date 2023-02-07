using Entities.Entities;

namespace APIService.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
        int ModifyProduct(ProductItem productItem);
        int DeleteProduct(ProductItem productItem);
    }
}
