using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagmentSystem.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
            Builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "5b8f37ba-9817-43c3-9f07-02cef6faeb7b",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "ef42fa65-f69a-47a0-99ad-3e3f39c909cf",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"

                },
                new IdentityRole
                {
                    Id = "b8302985-9d52-4db4-8f36-deffb80824ce",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });

            var hasher = new PasswordHasher<ApplicationUser>();
            Builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "8f3d7b45-b074-4692-86ff-d555d80656b4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "admin"),
                    EmailConfirmed = true,
                    FirstName = "admin",
                    LastName = "Admin",
                    DateOfBirth = new DateOnly(2002, 03, 17)
                });

            Builder.Entity<IdentityUserRole<string>>().HasData
                (new IdentityUserRole<string>
                {
                    RoleId = "b8302985-9d52-4db4-8f36-deffb80824ce",
                    UserId = "8f3d7b45-b074-4692-86ff-d555d80656b4",
                });
        }
        public DbSet <LeaveType> LeaveTypes { get; set; }
    }  


}
