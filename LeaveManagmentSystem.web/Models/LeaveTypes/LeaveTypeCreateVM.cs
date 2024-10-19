﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagmentSystem.web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4,50, ErrorMessage ="You have violated the length requirments")]
        public string name { get; set; }
        [Required]
        [Range(1,90)]
        public int NumberOfDays { get; set; }
    }
}