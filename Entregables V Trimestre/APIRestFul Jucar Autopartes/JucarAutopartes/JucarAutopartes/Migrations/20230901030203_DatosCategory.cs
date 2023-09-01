using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3312), "PIN", true },
                    { 2, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3320), "ARANDELA", true },
                    { 3, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3323), "LAINA", true },
                    { 4, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3325), "EMPAQUE CARNAZA", true },
                    { 5, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3327), "TELEFONO CAUCHO", true },
                    { 6, new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 8, 31, 22, 2, 3, 413, DateTimeKind.Local).AddTicks(3329), "MEDIA LUNA", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);
        }
    }
}
