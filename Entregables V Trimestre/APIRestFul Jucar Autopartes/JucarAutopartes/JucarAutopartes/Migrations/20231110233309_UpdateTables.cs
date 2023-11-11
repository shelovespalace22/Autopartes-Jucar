using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProviderAddresses_NeighborhoodId",
                table: "ProviderAddresses");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "OrderDetails");

            migrationBuilder.AddColumn<decimal>(
                name: "IVA",
                table: "Orders",
                type: "decimal(18,2)",
                maxLength: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5994), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4757), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4751), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4747), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5559), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5546), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 11, 10, 18, 33, 8, 707, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_NeighborhoodId",
                table: "ProviderAddresses",
                column: "NeighborhoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProviderAddresses_NeighborhoodId",
                table: "ProviderAddresses");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "IVA",
                table: "OrderDetails",
                type: "decimal(18,2)",
                maxLength: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6508), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6530), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5110), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7024), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5964), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5961), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5968), new DateTime(2023, 11, 7, 17, 20, 0, 60, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_NeighborhoodId",
                table: "ProviderAddresses",
                column: "NeighborhoodId",
                unique: true);
        }
    }
}
