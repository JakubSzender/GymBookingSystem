using Microsoft.EntityFrameworkCore.Migrations;

namespace GymBookingSystem.Data.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Machine1" },
                    { 2, "Machine2" },
                    { 3, "Machine3" },
                    { 4, "Machine4" },
                    { 5, "Machine5" },
                    { 6, "Machine6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
