using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }

        public List<UserItem> GetAllUsers()
        {
            var resultList = _userLogic.GetAllUsersItem();
            return resultList;
        }

        public int ModifyUser(UserItem userItem)
        {
            _userLogic.ModifyUserItem(userItem);
            return userItem.Id;
        }

        public int DeleteUser(UserItem userItem)
        {
            _userLogic.DeleteUserItem(userItem);
            return userItem.Id;
        }
    }
}