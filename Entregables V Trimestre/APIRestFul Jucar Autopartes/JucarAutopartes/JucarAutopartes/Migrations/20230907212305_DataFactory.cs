using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class DataFactory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5888), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5881), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5890), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "FactoryID", "BusinessName", "CreationDate", "EmailAddress", "ModificationDate", "NIT", "State" },
                values: new object[,]
                {
                    { new Guid("22ee0460-57b4-4ab6-a060-710073d1cab3"), "JucarAutopartes", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6124), "Migueladmin@jucar.com", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6124), "1345432", true },
                    { new Guid("4667f93e-75a9-4935-87ed-3a73e638046f"), "Adiautos", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6121), "Cristianadmin@jucar.com", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6122), "1345432", true },
                    { new Guid("dd84045c-100b-43d9-bd79-f9e174511aff"), "JucarAutopartes", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6116), "Danieladmin@jucar.com", new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(6117), "1345432", true }
                });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5648), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5652), new DateTime(2023, 9, 7, 16, 23, 5, 530, DateTimeKind.Local).AddTicks(5652) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "FactoryID",
                keyValue: new Guid("22ee0460-57b4-4ab6-a060-710073d1cab3"));

            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "FactoryID",
                keyValue: new Guid("4667f93e-75a9-4935-87ed-3a73e638046f"));

            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "FactoryID",
                keyValue: new Guid("dd84045c-100b-43d9-bd79-f9e174511aff"));

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8438), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8458), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8455), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("8db21635-4db7-453d-8010-831137e72d63"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8444), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Autoparts",
                keyColumn: "AutopartID",
                keyValue: new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8467), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7837), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7839), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7803), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("3120692a-9626-418d-baae-315eea262ab5"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8182), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8178), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("b449767b-601c-4811-ad3e-8b388bedf632"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Subcategories",
                keyColumn: "SubcategoryID",
                keyValue: new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"),
                columns: new[] { "CreationDate", "ModificationDate" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 9, 7, 16, 20, 6, 0, DateTimeKind.Local).AddTicks(8184) });
        }
    }
}
