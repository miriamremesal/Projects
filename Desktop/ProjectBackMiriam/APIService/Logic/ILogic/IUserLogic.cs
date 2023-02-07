using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        List<UserItem> GetAllUsersItem();
        public int InsertUserItem(UserItem userItem);
        public void ModifyUserItem(UserItem userItem);
        public void DeleteUserItem(UserItem userItem);
    }
}