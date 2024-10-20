using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.web.Models.LeaveTypes
{
    public class LeaveTypeEditVM: BaseLeaveTypeVM
    {
       
        [Required]
        [Length(4, 50, ErrorMessage = "You have violated the length requirments")]
        public string name { get; set; }
        [Required]
        [Range(1, 90)]
        [Display(Name ="Maximum Allocation of Days")]
        public int NumberOfDays { get; set; }
    }
}
