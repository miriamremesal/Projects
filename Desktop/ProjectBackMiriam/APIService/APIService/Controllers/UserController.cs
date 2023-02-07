using APIService.IServices;
using APIService.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost(Name = "InsertUser")]
        public int Post([FromBody] UserItem userItem)
        {
            return _userService.InsertUser(userItem);
        }

        [HttpGet(Name = "GetAllUsers")]
        public List<UserItem> GetAll()
        {
            return _userService.GetAllUsers();
        }

        [HttpPatch(Name = "ModifyUser")]
        public int Patch([FromBody] UserItem userItem)
        {
            return _userService.ModifyUser(userItem);
        }

        [HttpDelete(Name = "DeleteUser")]
        public int Delete([FromBody] UserItem userItem)
        {
            return _userService.DeleteUser(userItem);
        }

        //[HttpGet(Name = "GetUsersByCriteria")]
        //public List<UserItem> GetByCriteria([FromQuery] UserFilter UserFilter)
        //{
        //    
        //}
    }
}