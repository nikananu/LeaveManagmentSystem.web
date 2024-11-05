using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d7b45-b074-4692-86ff-d555d80656b4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4ff94441-b169-4062-8d89-7f6ed9ce64df", new DateOnly(2002, 3, 17), "admin@localhost.com", "Default", "Admin", "ADMIN_LOCALHOST.COM", "ADMIN_LOCALHOST.COM", "AQAAAAIAAYagAAAAEBbNb9F3LV/6ed6tiKlBABzjg7tInYfj9uZ6rLbERe5xFREsfB0vyLiV76im4cZEkg==", "ce18f1f5-7bea-45ec-b9b5-565b2af767b9", "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3d7b45-b074-4692-86ff-d555d80656b4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5ee63acf-596d-4f2a-b03f-7bc08e00c5bb", "n_nanuashvili@cu.edu.ge", "N_NANUASHVILI@CU.EDU.GE", "NIKANANU", "AQAAAAIAAYagAAAAEDRSrkOmGU6XbwMEV6BNLW7HfNgiYZhnmhi6TGwy4aicCgIakRdqGfheWmLZRadYiQ==", "92cefc44-3bb9-4f63-9c93-d5067c834cf4", "nikananu" });
        }
    }
}
