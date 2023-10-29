using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class InserccionDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(93), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(94), "EMPAQUE CARNAZA", true },
                    { new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(96), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(96), "TELEFONO CAUCHO", true },
                    { new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(99), "MEDIA LUNA", true },
                    { new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(51), "PIN", true },
                    { new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(91), "LAINA", true },
                    { new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(87), "ARANDELA", true }
                });

            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "RawMaterialID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3743), "Hierro", true },
                    { new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3735), "Acero", true },
                    { new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(3747), "Cobre", true }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryId", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1643), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1644), "ARANDELA LEVA", true },
                    { new Guid("3120692a-9626-418d-baae-315eea262ab5"), new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1647), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1648), "LAINA SPLINDER", true },
                    { new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1637), "PIN LEVA", true },
                    { new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1633), "PIN DISCO", true },
                    { new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1629), "PIN TUERCA", true },
                    { new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1615), "PIN CRUCETA", true },
                    { new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(1640), "ARANDELA CACHO", true }
                });

            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "ModificationDate", "Name", "RawMaterialId", "State", "SubcategoryId" },
                values: new object[,]
                {
                    { new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2402), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2402), "PIN DISCO QUINTA RUEDA", new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"), true, new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba") },
                    { new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2378), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2381), "PIN CRUCETA 334", new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"), true, new Guid("b449767b-601c-4811-ad3e-8b388bedf632") },
                    { new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2423), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2424), "LAINA SPLINDER NPR", new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"), true, new Guid("3120692a-9626-418d-baae-315eea262ab5") },
                    { new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2417), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2418), "ARANDELA LEVA 3/4", new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"), true, new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43") },
                    { new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2407), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2408), "PIN LEVA 1 1/4", new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"), true, new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67") },
                    { new Guid("8db21635-4db7-453d-8010-831137e72d63"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2530), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2531), "LAINA SPLINDER HINO FC 500", new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"), true, new Guid("3120692a-9626-418d-baae-315eea262ab5") },
                    { new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2412), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2413), "ARANDELA CACHO AGRALE MODELO NUEVO", new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"), true, new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3") },
                    { new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2428), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2429), "LAINA SPLINDER KENWORTH", new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"), true, new Guid("3120692a-9626-418d-baae-315eea262ab5") },
                    { new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2396), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2397), "PIN TUERCA HOUSING 950 PLANO", new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"), true, new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4") },
                    { new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"), new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2538), "N/N", new DateTime(2023, 10, 28, 20, 56, 19, 454, DateTimeKind.Local).AddTicks(2539), "LAINA SPLINDER NISSAN MT 3000", new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"), true, new Guid("3120692a-9626-418d-baae-315eea262ab5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("8a7505db-8bb3-4872-a927-8113834f0c10"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("c3818a2d-d242-4493-b437-2d74d434fa21"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "RawMaterialID",
                keyValue: new Guid("da932f1f-4bf1-4233-9fd6-283a0ff4ce6e"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"));
        }
    }
}
