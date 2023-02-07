using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }

        public List<ProductItem> GetAllProducts()
        {
            var resultList = _productLogic.GetAllProductsItem();
            return resultList;
        }

        public int ModifyProduct(ProductItem productItem)
        {
            _productLogic.ModifyProductItem(productItem);
            return productItem.Id;
        }

        public int DeleteProduct(ProductItem productItem)
        {
            _productLogic.DeleteProductItem(productItem);
            return productItem.Id;
        }
    }
}