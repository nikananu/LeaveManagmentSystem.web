using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagmentSystem.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5b8f37ba-9817-43c3-9f07-02cef6faeb7b", null, "Employee", "EMPLOYEE" },
                    { "b8302985-9d52-4db4-8f36-deffb80824ce", null, "Administrator", "ADMINISTRATOR" },
                    { "ef42fa65-f69a-47a0-99ad-3e3f39c909cf", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8f3d7b45-b074-4692-86ff-d555d80656b4", 0, "5ee63acf-596d-4f2a-b03f-7bc08e00c5bb", "n_nanuashvili@cu.edu.ge", true, false, null, "N_NANUASHVILI@CU.EDU.GE", "NIKANANU", "AQAAAAIAAYagAAAAEDRSrkOmGU6XbwMEV6BNLW7HfNgiYZhnmhi6TGwy4aicCgIakRdqGfheWmLZRadYiQ==", null, false, "92cefc44-3bb9-4f63-9c93-d5067c834cf4", false, "nikananu" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b8302985-9d52-4db4-8f36-deffb80824ce", "8f3d7b45-b074-4692-86ff-d555d80656b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b8f37ba-9817-43c3-9f07-02cef6faeb7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef42fa65-f69a-47a0-99ad-3e3f39c909cf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8302985-9d52-4db4-8f36-deffb80824ce", "8f3d7b45-b074-4692-86ff-d555d80656b4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8302985-9d52-4db4-8f36-deffb80824ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d7b45-b074-4692-86ff-d555d80656b4");
        }
    }
}
