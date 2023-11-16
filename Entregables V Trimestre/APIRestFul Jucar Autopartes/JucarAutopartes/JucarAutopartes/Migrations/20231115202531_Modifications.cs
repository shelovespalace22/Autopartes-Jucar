using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class Modifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1366), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1354), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1359), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(149), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(882), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(878), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(874), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 11, 15, 15, 25, 30, 616, DateTimeKind.Local).AddTicks(888) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8586), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8598), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7302), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7350), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7346), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9037), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8097), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8087), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 11, 10, 18, 36, 55, 652, DateTimeKind.Local).AddTicks(8101) });
        }
    }
}
