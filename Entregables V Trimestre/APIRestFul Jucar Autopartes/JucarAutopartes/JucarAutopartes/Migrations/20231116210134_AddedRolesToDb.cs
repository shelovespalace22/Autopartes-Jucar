using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1456c3-01d4-4382-960d-3af5f05b3762", null, "Manager", "MANAGER" },
                    { "55d10bea-e927-4929-80dd-1fa57605ddf5", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(888), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(899), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9472), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9478), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9414), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9469), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 11, 16, 16, 1, 34, 258, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(278), new DateTime(2023, 11, 16, 16, 1, 34, 259, DateTimeKind.Local).AddTicks(278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1456c3-01d4-4382-960d-3af5f05b3762");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55d10bea-e927-4929-80dd-1fa57605ddf5");

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5813), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5833), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5374), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5362), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 11, 15, 16, 39, 22, 40, DateTimeKind.Local).AddTicks(5367) });
        }
    }
}
