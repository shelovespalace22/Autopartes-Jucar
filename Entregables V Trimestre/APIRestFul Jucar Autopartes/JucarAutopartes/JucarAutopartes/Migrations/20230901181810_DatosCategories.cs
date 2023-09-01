using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(326), "PIN", true },
                    { 2, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(397), "ARANDELA", true },
                    { 3, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(398), "LAINA", true },
                    { 4, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(399), "EMPAQUE CARNAZA", true },
                    { 5, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(400), "TELEFONO CAUCHO", true },
                    { 6, new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 9, 1, 13, 18, 10, 733, DateTimeKind.Local).AddTicks(401), "MEDIA LUNA", true }
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
