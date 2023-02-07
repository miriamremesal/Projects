using APIService.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IAdminService _AdminService;
        public AdminController(ILogger<ProductController> logger, IAdminService AdminService)
        {
            _logger = logger;
            _AdminService = AdminService;
        }

        [HttpPost(Name = "InsertAdmin")]
        public int Post([FromBody] AdminItem AdminItem)
        {
            return _AdminService.InsertAdmin(AdminItem);
        }

        [HttpGet(Name = "GetAllAdmins")]
        public List<AdminItem> GetAll()
        {
            return _AdminService.GetAllAdmins();
        }

        [HttpPatch(Name = "ModifyAdmin")]
        public int Patch([FromBody] AdminItem adminItem)
        {
            return _AdminService.ModifyAdmin(adminItem);
        }

        [HttpDelete(Name = "DeleteAdmin")]
        public int Delete([FromBody] AdminItem adminItem)
        {
            return _AdminService.DeleteAdmin(adminItem);
        }

        //[HttpGet(Name = "GetAdminsByCriteria")]
        //public List<AdminItem> GetByCriteria([FromQuery] AdminFilter AdminFilter)
        //{
        //    
        //}

    }
}