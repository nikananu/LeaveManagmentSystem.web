using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedadminstats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d7b45-b074-4692-86ff-d555d80656b4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8428fd51-50fb-4f80-b843-9bd1f13eb1b8", "admin", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJwQ2lfyyCtn5kEfC6424gtZq3kmM8DoR6tuEn/ZfGxfsaFv+XvSYzgj+ZlSanVz9Q==", "2dc158fd-b226-4fdd-a4d0-ba6ff77462d4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d7b45-b074-4692-86ff-d555d80656b4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ff94441-b169-4062-8d89-7f6ed9ce64df", "Default", "ADMIN_LOCALHOST.COM", "ADMIN_LOCALHOST.COM", "AQAAAAIAAYagAAAAEBbNb9F3LV/6ed6tiKlBABzjg7tInYfj9uZ6rLbERe5xFREsfB0vyLiV76im4cZEkg==", "ce18f1f5-7bea-45ec-b9b5-565b2af767b9" });
        }
    }
}
