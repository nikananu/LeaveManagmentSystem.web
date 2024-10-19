using AutoMapper;
using LeaveManagmentSystem.web.Data;
using LeaveManagmentSystem.web.Models.LeaveTypes;

namespace LeaveManagmentSystem.web.MappingProfiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
            
        }
    }
}
