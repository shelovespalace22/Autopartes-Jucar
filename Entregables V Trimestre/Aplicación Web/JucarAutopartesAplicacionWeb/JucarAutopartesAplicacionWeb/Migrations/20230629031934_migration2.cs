using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartesAplicacionWeb.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPhones_Users_UserId",
                table: "UserPhones");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserPhones",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserPhones_UserId",
                table: "UserPhones",
                newName: "IX_UserPhones_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhones_Users_UserID",
                table: "UserPhones",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPhones_Users_UserID",
                table: "UserPhones");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserPhones",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserPhones_UserID",
                table: "UserPhones",
                newName: "IX_UserPhones_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPhones_Users_UserId",
                table: "UserPhones",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
