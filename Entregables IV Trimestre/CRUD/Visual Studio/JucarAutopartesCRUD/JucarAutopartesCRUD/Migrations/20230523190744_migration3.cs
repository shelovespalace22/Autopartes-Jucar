using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartesCRUD.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Losss",
                table: "Losss");

            migrationBuilder.DropColumn(
                name: "AmountStock",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "InitialStocks",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "MaxInventory",
                table: "Stocks");

            migrationBuilder.RenameTable(
                name: "Losss",
                newName: "Losses");

            migrationBuilder.RenameColumn(
                name: "MinInventory",
                table: "Stocks",
                newName: "QuantityAvailable");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Losses",
                table: "Losses",
                column: "LossID");

            migrationBuilder.CreateTable(
                name: "RawMaterial",
                columns: table => new
                {
                    RawMaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterial", x => x.RawMaterialID);
                });

            migrationBuilder.CreateTable(
                name: "AutoPartMaterial",
                columns: table => new
                {
                    AutoPartMaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoPartComposition = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AutopartID = table.Column<int>(type: "int", nullable: false),
                    RawMaterialID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoPartMaterial", x => x.AutoPartMaterialID);
                    table.ForeignKey(
                        name: "FK_AutoPartMaterial_AutoParts_AutopartID",
                        column: x => x.AutopartID,
                        principalTable: "AutoParts",
                        principalColumn: "AutoPartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoPartMaterial_RawMaterial_RawMaterialID",
                        column: x => x.RawMaterialID,
                        principalTable: "RawMaterial",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoPartMaterial_AutopartID",
                table: "AutoPartMaterial",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_AutoPartMaterial_RawMaterialID",
                table: "AutoPartMaterial",
                column: "RawMaterialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoPartMaterial");

            migrationBuilder.DropTable(
                name: "RawMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Losses",
                table: "Losses");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Stocks");

            migrationBuilder.RenameTable(
                name: "Losses",
                newName: "Losss");

            migrationBuilder.RenameColumn(
                name: "QuantityAvailable",
                table: "Stocks",
                newName: "MinInventory");

            migrationBuilder.AddColumn<int>(
                name: "AmountStock",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InitialStocks",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxInventory",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Losss",
                table: "Losss",
                column: "LossID");
        }
    }
}
