using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartesAplicacionWeb.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainMaterial",
                table: "AutopartMaterials");

            migrationBuilder.DropColumn(
                name: "OtherMaterial",
                table: "AutopartMaterials");

            migrationBuilder.DropColumn(
                name: "SecondaryMaterial",
                table: "AutopartMaterials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainMaterial",
                table: "AutopartMaterials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OtherMaterial",
                table: "AutopartMaterials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryMaterial",
                table: "AutopartMaterials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
