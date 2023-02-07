using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IAdminLogic
    {
        List<AdminItem> GetAllAdminsItem();
        public int InsertAdminItem(AdminItem adminItem);
        public void ModifyAdminItem(AdminItem adminItem);
        public void DeleteAdminItem(AdminItem adminItem);
    }
}
