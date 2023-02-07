using Entities.Entities;

namespace APIService.IServices
{
    public interface IUserService
    {
        List<UserItem> GetAllUsers();
        int InsertUser(UserItem userItem);
        int ModifyUser(UserItem userItem);
        int DeleteUser(UserItem userItem);
    }
}
