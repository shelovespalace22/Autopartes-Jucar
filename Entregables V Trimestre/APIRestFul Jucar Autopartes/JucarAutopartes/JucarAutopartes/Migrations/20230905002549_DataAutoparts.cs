using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataAutoparts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "HeightCm", "LengthCm", "ModificationDate", "Name", "State", "SubcategoryId", "VehicleZone", "WeightKgs" },
                values: new object[,]
                {
                    { new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3873), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3874), "PIN DISCO QUINTA RUEDA", true, new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), "N/N", "0" },
                    { new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3857), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3858), "PIN CRUCETA 334", true, new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), "N/N", "0" },
                    { new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3894), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3895), "LAINA SPLINDER NPR", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3890), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3891), "ARANDELA LEVA 3/4", true, new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), "N/N", "0" },
                    { new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3878), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3878), "PIN LEVA 1 1/4", true, new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), "N/N", "0" },
                    { new Guid("8db21635-4db7-453d-8010-831137e72d63"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3903), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3904), "LAINA SPLINDER HINO FC 500", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3886), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3886), "ARANDELA CACHO AGRALE MODELO NUEVO", true, new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), "N/N", "0" },
                    { new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3899), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3899), "LAINA SPLINDER KENWORTH", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3867), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3868), "PIN TUERCA HOUSING 950 PLANO", true, new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), "N/N", "0" },
                    { new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3909), "N/N", "0", "0", new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3910), "LAINA SPLINDER NISSAN MT 3000", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3410), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3400), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3385), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3406), new DateTime(2023, 9, 4, 19, 25, 48, 870, DateTimeKind.Local).AddTicks(3407) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"));

            migrationBuilder.DeleteData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5798), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6672), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6677), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6668), new DateTime(2023, 9, 4, 19, 23, 52, 258, DateTimeKind.Local).AddTicks(6668) });
        }
    }
}
