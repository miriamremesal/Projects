using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyerController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IBuyerService _BuyerService;
        public BuyerController(ILogger<ProductController> logger, IBuyerService BuyerService)
        {
            _logger = logger;
            _BuyerService = BuyerService;
        }

        [HttpPost(Name = "InsertBuyer")]
        public int Post([FromBody] BuyerItem BuyerItem)
        {
            return _BuyerService.InsertBuyer(BuyerItem);
        }

        [HttpGet(Name = "GetAllBuyers")]
        public List<BuyerItem> GetAll()
        {
            return _BuyerService.GetAllBuyers();
        }

        [HttpPatch(Name = "ModifyBuyer")]
        public int Patch([FromBody] BuyerItem buyerItem)
        {
            return _BuyerService.ModifyBuyer(buyerItem);
        }

        [HttpDelete(Name = "DeleteBuyer")]
        public int Delete([FromBody] BuyerItem buyerItem)
        {
            return _BuyerService.DeleteBuyer(buyerItem);
        }

        //[HttpGet(Name = "GetBuyersByCriteria")]
        //public List<BuyerItem> GetByCriteria([FromQuery] BuyerFilter BuyerFilter)
        //{
        //    
        //}

    }
}
