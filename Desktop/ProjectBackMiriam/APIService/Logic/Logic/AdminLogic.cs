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
    public class AdminLogic : BaseContextLogic, IAdminLogic
    {
        public AdminLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertAdminItem(AdminItem adminItem)
        {
            _serviceContext.Admins.Add(adminItem);
            _serviceContext.SaveChanges();

            return adminItem.Id;
        }

        public List<AdminItem> GetAllAdminsItem()
        {
            return _serviceContext.Set<AdminItem>().ToList();
        }

        public void ModifyAdminItem(AdminItem adminItem)
        {
            _serviceContext.Admins.Update(adminItem);
            _serviceContext.SaveChanges();
        }

        public void DeleteAdminItem(AdminItem adminItem)
        {
            _serviceContext.Admins.Remove(adminItem);
            _serviceContext.SaveChanges();
        }

    }
}