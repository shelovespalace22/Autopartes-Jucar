using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartesCRUD.Migrations
{
    /// <inheritdoc />
    public partial class migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutoPartID",
                table: "PricesHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RawMaterialID",
                table: "Movements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutoPartID",
                table: "Losses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutoPartID",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PriceHistoryID",
                table: "DiscountsHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AutoPartID",
                table: "BillsDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityAvailable = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    InitialStocks = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ReorderPoint = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MinimumInventory = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MaximumInventory = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RawMaterialID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stock_RawMaterials_RawMaterialID",
                        column: x => x.RawMaterialID,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricesHistory_AutoPartID",
                table: "PricesHistory",
                column: "AutoPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_RawMaterialID",
                table: "Movements",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Losses_AutoPartID",
                table: "Losses",
                column: "AutoPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AutoPartID",
                table: "Inventories",
                column: "AutoPartID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscountsHistory_PriceHistoryID",
                table: "DiscountsHistory",
                column: "PriceHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BillsDetail_AutoPartID",
                table: "BillsDetail",
                column: "AutoPartID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_RawMaterialID",
                table: "Stock",
                column: "RawMaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillsDetail_AutoParts_AutoPartID",
                table: "BillsDetail",
                column: "AutoPartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountsHistory_PricesHistory_PriceHistoryID",
                table: "DiscountsHistory",
                column: "PriceHistoryID",
                principalTable: "PricesHistory",
                principalColumn: "PriceHistoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_AutoParts_AutoPartID",
                table: "Inventories",
                column: "AutoPartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Losses_AutoParts_AutoPartID",
                table: "Losses",
                column: "AutoPartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movements_RawMaterials_RawMaterialID",
                table: "Movements",
                column: "RawMaterialID",
                principalTable: "RawMaterials",
                principalColumn: "RawMaterialID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PricesHistory_AutoParts_AutoPartID",
                table: "PricesHistory",
                column: "AutoPartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillsDetail_AutoParts_AutoPartID",
                table: "BillsDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountsHistory_PricesHistory_PriceHistoryID",
                table: "DiscountsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_AutoParts_AutoPartID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Losses_AutoParts_AutoPartID",
                table: "Losses");

            migrationBuilder.DropForeignKey(
                name: "FK_Movements_RawMaterials_RawMaterialID",
                table: "Movements");

            migrationBuilder.DropForeignKey(
                name: "FK_PricesHistory_AutoParts_AutoPartID",
                table: "PricesHistory");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_PricesHistory_AutoPartID",
                table: "PricesHistory");

            migrationBuilder.DropIndex(
                name: "IX_Movements_RawMaterialID",
                table: "Movements");

            migrationBuilder.DropIndex(
                name: "IX_Losses_AutoPartID",
                table: "Losses");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_AutoPartID",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_DiscountsHistory_PriceHistoryID",
                table: "DiscountsHistory");

            migrationBuilder.DropIndex(
                name: "IX_BillsDetail_AutoPartID",
                table: "BillsDetail");

            migrationBuilder.DropColumn(
                name: "AutoPartID",
                table: "PricesHistory");

            migrationBuilder.DropColumn(
                name: "RawMaterialID",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "AutoPartID",
                table: "Losses");

            migrationBuilder.DropColumn(
                name: "AutoPartID",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "PriceHistoryID",
                table: "DiscountsHistory");

            migrationBuilder.DropColumn(
                name: "AutoPartID",
                table: "BillsDetail");
        }
    }
}
