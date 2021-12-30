using Microsoft.EntityFrameworkCore.Migrations;

namespace GymBookingSystem.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_Email",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Reservations",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_Email",
                table: "Reservations",
                newName: "IX_Reservations_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservations",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                newName: "IX_Reservations_Email");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_Email",
                table: "Reservations",
                column: "Email",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
