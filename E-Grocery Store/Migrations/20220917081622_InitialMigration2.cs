using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Grocery_Store.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "Email", "Name", "Password" },
                values: new object[] { new DateTime(1997, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "shy@gmail.com", "Shyyub", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DOB", "Email", "Name", "Password" },
                values: new object[] { new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavans@mail.com", "Pavan", "123" });
        }
    }
}
