﻿using Microsoft.AspNetCore.Identity;

namespace LeaveManagmentSystem.web.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
