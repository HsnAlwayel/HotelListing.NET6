using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing_APi.Migrations
{
    public partial class jwt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a881ef2-b8bd-4393-a4f2-5e81102160d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c981895e-e56b-4007-b989-9d0ad3fbdf72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e7cf7b4-3b6e-45ec-9648-f72fe4faf1a4", "0df5a911-450e-4ef9-82a4-b9123fed1b4c", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "858f35ea-cdfd-4b73-b221-3ffdff0ca2c0", "a4102cdd-ee12-4064-895b-f4862d224f3f", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7cf7b4-3b6e-45ec-9648-f72fe4faf1a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "858f35ea-cdfd-4b73-b221-3ffdff0ca2c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a881ef2-b8bd-4393-a4f2-5e81102160d0", "384ce243-9613-4102-aedd-59d6c2996a24", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c981895e-e56b-4007-b989-9d0ad3fbdf72", "9ef6174d-262e-4027-b0f7-4398f2004f47", "User", "USER" });
        }
    }
}
