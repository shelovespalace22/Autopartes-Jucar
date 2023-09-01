using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("14f34865-27aa-478f-bbf5-e4c33aa6c4a7"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9887), "TELEFONO CAUCHO", true },
                    { new Guid("655a812b-f7b0-42cc-b438-8d06ece10291"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9881), "LAINA", true },
                    { new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9845), "PIN", true },
                    { new Guid("b78ff6fb-eeea-4685-940e-5aa3b2de64f1"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9877), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9877), "ARANDELA", true },
                    { new Guid("e0ce962a-a844-4b9e-ae36-d00ccd6c8dfa"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9890), "MEDIA LUNA", true },
                    { new Guid("f063d736-8543-4fc5-b571-f1295e0e9ea0"), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9883), new DateTime(2023, 9, 1, 9, 51, 1, 662, DateTimeKind.Local).AddTicks(9884), "EMPAQUE CARNAZA", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("14f34865-27aa-478f-bbf5-e4c33aa6c4a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("655a812b-f7b0-42cc-b438-8d06ece10291"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("b78ff6fb-eeea-4685-940e-5aa3b2de64f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("e0ce962a-a844-4b9e-ae36-d00ccd6c8dfa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("f063d736-8543-4fc5-b571-f1295e0e9ea0"));
        }
    }
}
