using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertUserItem(UserItem userItem)
        {
            _serviceContext.Users.Add(userItem);
            _serviceContext.SaveChanges();

            return userItem.Id;
        }

        public List<UserItem> GetAllUsersItem()
        {
            return _serviceContext.Set<UserItem>().ToList();
        }

        public void ModifyUserItem(UserItem userItem)
        {
            _serviceContext.Users.Update(userItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteUserItem(UserItem userItem)
        {
            _serviceContext.Users.Remove(userItem);
            _serviceContext.SaveChanges();
        }

    }
}
