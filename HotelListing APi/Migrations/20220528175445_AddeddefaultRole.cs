using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing_APi.Migrations
{
    public partial class AddeddefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a881ef2-b8bd-4393-a4f2-5e81102160d0", "384ce243-9613-4102-aedd-59d6c2996a24", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c981895e-e56b-4007-b989-9d0ad3fbdf72", "9ef6174d-262e-4027-b0f7-4398f2004f47", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a881ef2-b8bd-4393-a4f2-5e81102160d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c981895e-e56b-4007-b989-9d0ad3fbdf72");
        }
    }
}
