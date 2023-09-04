using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataCategoriesSubcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7460), "EMPAQUE CARNAZA", true },
                    { new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7461), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7461), "TELEFONO CAUCHO", true },
                    { new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7463), "MEDIA LUNA", true },
                    { new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7428), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7438), "PIN", true },
                    { new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7458), "LAINA", true },
                    { new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7456), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7456), "ARANDELA", true }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryId", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7845), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7846), "ARANDELA LEVA", true },
                    { new Guid("3120692a-9626-418d-baae-315eea262ab5"), new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7847), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7847), "LAINA SPLINDER", true },
                    { new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7842), "PIN LEVA", true },
                    { new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7840), "PIN DISCO", true },
                    { new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7838), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7838), "PIN TUERCA", true },
                    { new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7832), "PIN CRUCETA", true },
                    { new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7843), new DateTime(2023, 9, 4, 17, 32, 2, 788, DateTimeKind.Local).AddTicks(7844), "ARANDELA CACHO", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
