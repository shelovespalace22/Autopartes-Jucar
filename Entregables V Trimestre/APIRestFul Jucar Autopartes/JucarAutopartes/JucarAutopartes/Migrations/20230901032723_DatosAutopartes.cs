using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DatosAutopartes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "HeightCm", "LengthCm", "ModificationDate", "Name", "State", "SubcategoryID", "VehicleZone", "WeightKgs" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4822), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4823), "PIN CRUCETA 334", true, 1, "N/N", "0" },
                    { 2, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4828), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4828), "PIN TUERCA HOUSING 950 PLANO", true, 2, "N/N", "0" },
                    { 3, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4831), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4832), "PIN DISCO QUINTA RUEDA", true, 3, "N/N", "0" },
                    { 4, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4834), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4834), "PIN LEVA 1 1/4", true, 4, "N/N", "0" },
                    { 5, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4837), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4837), "ARANDELA CACHO AGRALE MODELO NUEVO", true, 5, "N/N", "0" },
                    { 6, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4839), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4840), "ARANDELA LEVA 3/4", true, 6, "N/N", "0" },
                    { 7, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4843), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4843), "LAINA SPLINDER NPR", true, 7, "N/N", "0" },
                    { 8, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4846), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4846), "LAINA SPLINDER KENWORTH", true, 7, "N/N", "0" },
                    { 9, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4849), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4849), "LAINA SPLINDER HINO FC 500", true, 7, "N/N", "0" },
                    { 10, new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4853), "N/N", "0", "0", new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4853), "LAINA SPLINDER NISSAN MT 3000", true, 7, "N/N", "0" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3488), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3506), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3513), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4302), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 8, 31, 22, 27, 23, 427, DateTimeKind.Local).AddTicks(4307) });
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

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 1,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 2,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 3,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 4,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 5,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 6,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: 7,
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 8, 31, 22, 13, 35, 531, DateTimeKind.Local).AddTicks(6075) });
        }
    }
}
