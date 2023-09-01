using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosAutoparts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "HeightCm", "LengthCm", "ModificationDate", "Name", "State", "SubcategoryID", "VehicleZone", "WeightKgs" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9100), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9101), "PIN CRUCETA 334", true, 1, "N/N", "0" },
                    { 2, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9104), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9104), "PIN TUERCA HOUSING 950 PLANO", true, 2, "N/N", "0" },
                    { 3, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9105), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9106), "PIN DISCO QUINTA RUEDA", true, 3, "N/N", "0" },
                    { 4, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9107), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9107), "PIN LEVA 1 1/4", true, 4, "N/N", "0" },
                    { 5, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9108), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9108), "ARANDELA CACHO AGRALE MODELO NUEVO", true, 5, "N/N", "0" },
                    { 6, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9109), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9109), "ARANDELA LEVA 3/4", true, 6, "N/N", "0" },
                    { 7, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9110), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9111), "LAINA SPLINDER NPR", true, 7, "N/N", "0" },
                    { 8, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9112), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9112), "LAINA SPLINDER KENWORTH", true, 7, "N/N", "0" },
                    { 9, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9113), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9113), "LAINA SPLINDER HINO FC 500", true, 7, "N/N", "0" },
                    { 10, new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9114), "N/N", "0", "0", new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(9115), "LAINA SPLINDER NISSAN MT 3000", true, 7, "N/N", "0" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 9, 1, 13, 22, 13, 946, DateTimeKind.Local).AddTicks(8900) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1342), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1343), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1344), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1685), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1694), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1695) });
        }
    }
}
