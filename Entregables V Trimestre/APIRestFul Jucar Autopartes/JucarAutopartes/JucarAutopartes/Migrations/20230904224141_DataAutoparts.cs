using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataAutoparts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "HeightCm", "LengthCm", "ModificationDate", "Name", "State", "SubcategoryId", "VehicleZone", "WeightKgs" },
                values: new object[,]
                {
                    { new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1674), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1675), "PIN DISCO QUINTA RUEDA", true, new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), "N/N", "0" },
                    { new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1664), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1665), "PIN CRUCETA 334", true, new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), "N/N", "0" },
                    { new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1685), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1685), "LAINA SPLINDER NPR", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1683), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1683), "ARANDELA LEVA 3/4", true, new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), "N/N", "0" },
                    { new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1677), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1678), "PIN LEVA 1 1/4", true, new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), "N/N", "0" },
                    { new Guid("8db21635-4db7-453d-8010-831137e72d63"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1689), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1689), "LAINA SPLINDER HINO FC 500", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1680), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1680), "ARANDELA CACHO AGRALE MODELO NUEVO", true, new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), "N/N", "0" },
                    { new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1687), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1687), "LAINA SPLINDER KENWORTH", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1671), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1672), "PIN TUERCA HOUSING 950 PLANO", true, new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), "N/N", "0" },
                    { new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1691), "N/N", "0", "0", new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1692), "LAINA SPLINDER NISSAN MT 3000", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1085), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1086), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1083), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1449), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1447), new DateTime(2023, 9, 4, 17, 41, 41, 201, DateTimeKind.Local).AddTicks(1448) });
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7461), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7428), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7845), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7838), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7844) });
        }
    }
}
