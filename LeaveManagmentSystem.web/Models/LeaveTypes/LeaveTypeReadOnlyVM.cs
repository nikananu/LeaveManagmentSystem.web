using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM: BaseLeaveTypeVM
    {
        
        public string name { get; set; }
        [Display(Name = "Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}