using LeaveManagmentSystem.web.Models.LeaveTypes;

namespace LeaveManagmentSystem.web.Services
{
    public interface ILeaveTypeServices
    {
        Task Create(LeaveTypeCreateVM model);
        Task Edit(LeaveTypeEditVM model);
        Task<T?> Get<T>(int id) where T : class;
        Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes();
        Task Remove(int id);
    }
}