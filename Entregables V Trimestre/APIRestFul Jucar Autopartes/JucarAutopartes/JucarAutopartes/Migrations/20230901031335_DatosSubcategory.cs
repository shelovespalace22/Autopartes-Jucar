using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosSubcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5379), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5381), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6059), "PIN CRUCETA", true },
                    { 2, 1, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6064), "PIN TUERCA", true },
                    { 3, 1, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6067), "PIN DISCO", true },
                    { 4, 1, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6069), "PIN LEVA", true },
                    { 5, 2, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6071), "ARANDELA CACHO", true },
                    { 6, 2, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6073), "ARANDELA LEVA", true },
                    { 7, 3, new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6075), "LAINA SPLINDER", true }
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
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3329) });
        }
    }
}
