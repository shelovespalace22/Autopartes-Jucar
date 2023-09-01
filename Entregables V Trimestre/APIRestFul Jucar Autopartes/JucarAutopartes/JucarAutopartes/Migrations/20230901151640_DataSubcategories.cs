using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataSubcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("0ae5b20f-564c-4186-8ce8-11f80369a94a"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9863), "ARANDELA", true },
                    { new Guid("0ed5cd10-b1a9-4fed-beab-738d6cd50e44"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9889), "MEDIA LUNA", true },
                    { new Guid("1ddb1b04-b87e-4a48-b997-79357cd39669"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9830), "PIN", true },
                    { new Guid("2bbbd7a7-eb2e-4354-9efe-aeea69dae563"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9866), "LAINA", true },
                    { new Guid("57ae325e-cd5d-4cfc-be8c-5ffb026001c9"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9885), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9886), "TELEFONO CAUCHO", true },
                    { new Guid("584aa268-9449-4730-9279-f88f6e45d739"), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 9, 1, 10, 16, 39, 557, DateTimeKind.Local).AddTicks(9869), "EMPAQUE CARNAZA", true }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("07bb7e86-05e3-4815-9e89-81976d902938"), new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(641), "PIN TUERCA", true },
                    { new Guid("0965157a-9da8-4f9e-8ca2-f692b30dbe05"), new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(605), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(608), "PIN CRUCETA", true },
                    { new Guid("1df165e9-cd41-448e-b143-77c32e895087"), new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(711), "PIN LEVA", true },
                    { new Guid("7aa3fe83-92ff-4c8a-ad67-5452117d824b"), new Guid("7aa51602-6cfa-4b17-b1b8-853f0e0388c6"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(705), "PIN DISCO", true },
                    { new Guid("7f1ad2af-9341-4b54-bb13-bce52110de80"), new Guid("b78ff6fb-eeea-4685-940e-5aa3b2de64f1"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(719), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(719), "ARANDELA LEVA", true },
                    { new Guid("85f0b298-b551-450b-9961-1e019e13a679"), new Guid("b78ff6fb-eeea-4685-940e-5aa3b2de64f1"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(715), "ARANDELA CACHO", true },
                    { new Guid("c4564044-3f5d-47b0-8c15-a5d36d6c946a"), new Guid("655a812b-f7b0-42cc-b438-8d06ece10291"), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(729), new DateTime(2023, 9, 1, 10, 16, 39, 558, DateTimeKind.Local).AddTicks(730), "LAINA SPLINDER", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("0ae5b20f-564c-4186-8ce8-11f80369a94a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("0ed5cd10-b1a9-4fed-beab-738d6cd50e44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("1ddb1b04-b87e-4a48-b997-79357cd39669"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2bbbd7a7-eb2e-4354-9efe-aeea69dae563"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("57ae325e-cd5d-4cfc-be8c-5ffb026001c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("584aa268-9449-4730-9279-f88f6e45d739"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("07bb7e86-05e3-4815-9e89-81976d902938"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("0965157a-9da8-4f9e-8ca2-f692b30dbe05"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("1df165e9-cd41-448e-b143-77c32e895087"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("7aa3fe83-92ff-4c8a-ad67-5452117d824b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("7f1ad2af-9341-4b54-bb13-bce52110de80"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("85f0b298-b551-450b-9961-1e019e13a679"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("c4564044-3f5d-47b0-8c15-a5d36d6c946a"));

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
    }
}
