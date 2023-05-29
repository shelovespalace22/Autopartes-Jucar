using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartesCRUD.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoPartMaterial_AutoParts_AutopartID",
                table: "AutoPartMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoPartMaterial_RawMaterial_RawMaterialID",
                table: "AutoPartMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RawMaterial",
                table: "RawMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoPartMaterial",
                table: "AutoPartMaterial");

            migrationBuilder.RenameTable(
                name: "RawMaterial",
                newName: "RawMaterials");

            migrationBuilder.RenameTable(
                name: "AutoPartMaterial",
                newName: "AutoPartMaterials");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPartMaterial_RawMaterialID",
                table: "AutoPartMaterials",
                newName: "IX_AutoPartMaterials_RawMaterialID");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPartMaterial_AutopartID",
                table: "AutoPartMaterials",
                newName: "IX_AutoPartMaterials_AutopartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials",
                column: "RawMaterialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoPartMaterials",
                table: "AutoPartMaterials",
                column: "AutoPartMaterialID");

            migrationBuilder.CreateTable(
                name: "Compartments",
                columns: table => new
                {
                    CompartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compartments", x => x.CompartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    FactoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIT = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.FactoryID);
                });

            migrationBuilder.CreateTable(
                name: "FactoryPhones",
                columns: table => new
                {
                    FactroyPhoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryPhones", x => x.FactroyPhoneID);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    MovementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovementType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.MovementID);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAddresses",
                columns: table => new
                {
                    ProviderAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAddresses", x => x.ProviderAddressID);
                });

            migrationBuilder.CreateTable(
                name: "ProviderPhones",
                columns: table => new
                {
                    ProviderPhoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPhones", x => x.ProviderPhoneID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BussinesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NIT = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "ShelveMeasurements",
                columns: table => new
                {
                    ShelveMeasurementsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    UnitMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelveMeasurements", x => x.ShelveMeasurementsID);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    ShelfID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaxCapacityKgs = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.ShelfID);
                });

            migrationBuilder.CreateTable(
                name: "Ubications",
                columns: table => new
                {
                    UbicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubications", x => x.UbicationID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPartMaterials_AutoParts_AutopartID",
                table: "AutoPartMaterials",
                column: "AutopartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPartMaterials_RawMaterials_RawMaterialID",
                table: "AutoPartMaterials",
                column: "RawMaterialID",
                principalTable: "RawMaterials",
                principalColumn: "RawMaterialID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoPartMaterials_AutoParts_AutopartID",
                table: "AutoPartMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoPartMaterials_RawMaterials_RawMaterialID",
                table: "AutoPartMaterials");

            migrationBuilder.DropTable(
                name: "Compartments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "FactoryPhones");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "ProviderAddresses");

            migrationBuilder.DropTable(
                name: "ProviderPhones");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "ShelveMeasurements");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "Ubications");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RawMaterials",
                table: "RawMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoPartMaterials",
                table: "AutoPartMaterials");

            migrationBuilder.RenameTable(
                name: "RawMaterials",
                newName: "RawMaterial");

            migrationBuilder.RenameTable(
                name: "AutoPartMaterials",
                newName: "AutoPartMaterial");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPartMaterials_RawMaterialID",
                table: "AutoPartMaterial",
                newName: "IX_AutoPartMaterial_RawMaterialID");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPartMaterials_AutopartID",
                table: "AutoPartMaterial",
                newName: "IX_AutoPartMaterial_AutopartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RawMaterial",
                table: "RawMaterial",
                column: "RawMaterialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoPartMaterial",
                table: "AutoPartMaterial",
                column: "AutoPartMaterialID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPartMaterial_AutoParts_AutopartID",
                table: "AutoPartMaterial",
                column: "AutopartID",
                principalTable: "AutoParts",
                principalColumn: "AutoPartID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPartMaterial_RawMaterial_RawMaterialID",
                table: "AutoPartMaterial",
                column: "RawMaterialID",
                principalTable: "RawMaterial",
                principalColumn: "RawMaterialID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
