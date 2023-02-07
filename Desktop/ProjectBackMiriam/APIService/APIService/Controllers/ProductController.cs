using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAll()
        {
            return _productService.GetAllProducts();
        }

        [HttpPatch(Name = "ModifyProduct")]
        public int Patch([FromBody] ProductItem productItem)
        {
            return _productService.ModifyProduct(productItem);
        }

        [HttpDelete(Name = "DeleteProduct")]
        public int Delete([FromBody] ProductItem productItem)
        {
            return _productService.DeleteProduct(productItem);
        }

        //[HttpGet(Name = "GetProductsByCriteria")]
        //public List<ProductItem> GetByCriteria([FromQuery] ProductFilter ProductFilter)
        //{
        //    
        //}
    }
}