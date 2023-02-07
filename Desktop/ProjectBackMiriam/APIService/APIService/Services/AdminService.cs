using APIService.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminLogic _AdminLogic;
        public AdminService(IAdminLogic AdminLogic)
        {
            _AdminLogic = AdminLogic;
        }
        public int InsertAdmin(AdminItem AdminItem)
        {
            _AdminLogic.InsertAdminItem(AdminItem);
            return AdminItem.Id;
        }

        public List<AdminItem> GetAllAdmins()
        {
            var resultList = _AdminLogic.GetAllAdminsItem();
            return resultList;
        }

        public int ModifyAdmin(AdminItem adminItem)
        {
            _AdminLogic.ModifyAdminItem(adminItem);
            return adminItem.Id;
        }

        public int DeleteAdmin(AdminItem adminItem)
        {
            _AdminLogic.DeleteAdminItem(adminItem);
            return adminItem.Id;
        }

    }
}
