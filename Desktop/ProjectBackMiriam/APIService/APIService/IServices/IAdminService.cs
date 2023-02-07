using Entities.Entities;

namespace APIService.IServices
{
    public interface IAdminService
    {
        List<AdminItem> GetAllAdmins();
        int InsertAdmin(AdminItem adminItem);
        int ModifyAdmin(AdminItem adminItem);
        int DeleteAdmin(AdminItem adminItem);
    }
}