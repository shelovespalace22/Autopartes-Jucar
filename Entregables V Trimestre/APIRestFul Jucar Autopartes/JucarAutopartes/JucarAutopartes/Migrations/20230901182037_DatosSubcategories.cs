using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosSubcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1685), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1686), "PIN CRUCETA", true },
                    { 2, 1, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1690), "PIN TUERCA", true },
                    { 3, 1, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1691), "PIN DISCO", true },
                    { 4, 1, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1692), "PIN LEVA", true },
                    { 5, 2, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1693), "ARANDELA CACHO", true },
                    { 6, 2, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1694), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1694), "ARANDELA LEVA", true },
                    { 7, 3, new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 9, 1, 13, 20, 37, 143, DateTimeKind.Local).AddTicks(1695), "LAINA SPLINDER", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(401) });
        }
    }
}
