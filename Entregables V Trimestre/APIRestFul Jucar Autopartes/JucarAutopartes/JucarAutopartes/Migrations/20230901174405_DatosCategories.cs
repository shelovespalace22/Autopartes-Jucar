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
                    { new Guid("43481b37-96ed-46cd-9b6a-219a608d5ec4"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7527), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7527), "MEDIA LUNA", true },
                    { new Guid("7188d63b-d793-4172-9b6e-80ed770a2f30"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7526), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7526), "TELEFONO CAUCHO", true },
                    { new Guid("84bbabc8-ac5a-4947-803e-cb6de7fefa46"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7524), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7524), "EMPAQUE CARNAZA", true },
                    { new Guid("b9aeaff4-3070-4222-8c80-996f4077d6ee"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7499), "PIN", true },
                    { new Guid("bced38bb-809e-405b-ac09-9a472c3d694d"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7523), "LAINA", true },
                    { new Guid("eabf6ea8-6d8f-4852-b267-54850987a246"), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7521), new DateTime(2023, 9, 1, 12, 44, 5, 627, DateTimeKind.Local).AddTicks(7521), "ARANDELA", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("43481b37-96ed-46cd-9b6a-219a608d5ec4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("7188d63b-d793-4172-9b6e-80ed770a2f30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("84bbabc8-ac5a-4947-803e-cb6de7fefa46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("b9aeaff4-3070-4222-8c80-996f4077d6ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("bced38bb-809e-405b-ac09-9a472c3d694d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("eabf6ea8-6d8f-4852-b267-54850987a246"));
        }
    }
}
