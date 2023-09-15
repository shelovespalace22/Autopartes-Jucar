using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addressees",
                columns: table => new
                {
                    AddresseeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumntType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addressees", x => x.AddresseeID);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AddressTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AddressTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NIT = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    FactoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.FactoryID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NIT = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    LegalRepresentative = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityResidence = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    SubcategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryID);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPhones",
                columns: table => new
                {
                    CustomerPhoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhones", x => x.CustomerPhoneID);
                    table.ForeignKey(
                        name: "FK_CustomerPhones_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    MunicipalityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capital = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.MunicipalityID);
                    table.ForeignKey(
                        name: "FK_Municipalities_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoryPhones",
                columns: table => new
                {
                    FactoryPhoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryPhones", x => x.FactoryPhoneID);
                    table.ForeignKey(
                        name: "FK_FactoryPhones_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "FactoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                    table.ForeignKey(
                        name: "FK_Warehouses_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "FactoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderPhones",
                columns: table => new
                {
                    ProviderPhoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPhones", x => x.ProviderPhoneID);
                    table.ForeignKey(
                        name: "FK_ProviderPhones_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    MovementID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MovementType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MovementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RawMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.MovementID);
                    table.ForeignKey(
                        name: "FK_Movements_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityAvailable = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    InitialStock = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ReorderPoint = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MinimumInventory = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MaximumInventory = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RawMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stocks_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPhones",
                columns: table => new
                {
                    UserPhoneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhones", x => x.UserPhoneID);
                    table.ForeignKey(
                        name: "FK_UserPhones_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPositions",
                columns: table => new
                {
                    UserPositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPositions", x => x.UserPositionID);
                    table.ForeignKey(
                        name: "FK_UserPositions_Positions_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Positions",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPositions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autoparts",
                columns: table => new
                {
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    WeightKgs = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    HeightCm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    LengthCm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    VehicleZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubcategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autoparts", x => x.AutopartID);
                    table.ForeignKey(
                        name: "FK_Autoparts_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesInvoiceNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NIT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Contributions",
                columns: table => new
                {
                    ContributionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountPaid = table.Column<double>(type: "float", maxLength: 5, nullable: false),
                    ContributionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributions", x => x.ContributionID);
                    table.ForeignKey(
                        name: "FK_Contributions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contributions_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MunicipalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodID);
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "MunicipalityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    ShelfID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HeightCm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LengthCm = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    MaxCapacityKgs = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.ShelfID);
                    table.ForeignKey(
                        name: "FK_Shelves_Warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutopartMaterials",
                columns: table => new
                {
                    AutopartMaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutopartMaterials", x => x.AutopartMaterialID);
                    table.ForeignKey(
                        name: "FK_AutopartMaterials_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutopartMaterials_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityAvailable = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimateModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Losses",
                columns: table => new
                {
                    LossID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountLoss = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LossDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losses", x => x.LossID);
                    table.ForeignKey(
                        name: "FK_Losses_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Product = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceHistories",
                columns: table => new
                {
                    PriceHistoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceHistories", x => x.PriceHistoryID);
                    table.ForeignKey(
                        name: "FK_PriceHistories_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    BillDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemNumber = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UnitValue = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    IVA = table.Column<double>(type: "float", maxLength: 2, nullable: false),
                    SubtotalValue = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    TotalValue = table.Column<double>(type: "float", maxLength: 10, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AutopartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.BillDetailID);
                    table.ForeignKey(
                        name: "FK_BillDetails_Autoparts_AutopartId",
                        column: x => x.AutopartId,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WayToPays",
                columns: table => new
                {
                    WayToPayID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WayToPayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WayToPays", x => x.WayToPayID);
                    table.ForeignKey(
                        name: "FK_WayToPays_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Streets",
                columns: table => new
                {
                    StreetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Sufix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FirstNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    SecondNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NeighborhoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.StreetID);
                    table.ForeignKey(
                        name: "FK_Streets_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shelvings",
                columns: table => new
                {
                    ShelvingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelvingNumber = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelvings", x => x.ShelvingID);
                    table.ForeignKey(
                        name: "FK_Shelvings_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shelvings_Shelves_ShelfId",
                        column: x => x.ShelfId,
                        principalTable: "Shelves",
                        principalColumn: "ShelfID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountHistories",
                columns: table => new
                {
                    DiscountHistoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    TemporalValue = table.Column<double>(type: "float", nullable: false),
                    InitialDiscountDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalDiscountDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PriceHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountHistories", x => x.DiscountHistoryID);
                    table.ForeignKey(
                        name: "FK_DiscountHistories_PriceHistories_PriceHistoryId",
                        column: x => x.PriceHistoryId,
                        principalTable: "PriceHistories",
                        principalColumn: "PriceHistoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AditionalInformation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StreetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddresseeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressTypes_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Addressees_AddresseeId",
                        column: x => x.AddresseeId,
                        principalTable: "Addressees",
                        principalColumn: "AddresseeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Streets_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Streets",
                        principalColumn: "StreetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    CustomerAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.CustomerAddressID);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoryAddresses",
                columns: table => new
                {
                    FactoryAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryAddresses", x => x.FactoryAddressID);
                    table.ForeignKey(
                        name: "FK_FactoryAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryAddresses_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "FactoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAddresses",
                columns: table => new
                {
                    ProviderAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAddresses", x => x.ProviderAddressID);
                    table.ForeignKey(
                        name: "FK_ProviderAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderAddresses_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    UserAddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.UserAddressID);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("29961716-b4fe-43a9-874d-0acdc993a5b8"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7793), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7794), "EMPAQUE CARNAZA", true },
                    { new Guid("2e6b11a6-3f6c-47f6-beb6-f7edd8645175"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7797), "TELEFONO CAUCHO", true },
                    { new Guid("6b158255-0b3e-47f0-bc22-5ba2ec06ffef"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7800), "MEDIA LUNA", true },
                    { new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7760), "PIN", true },
                    { new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7791), "LAINA", true },
                    { new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(7788), "ARANDELA", true }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryID", "CategoryId", "CreationDate", "ModificationDate", "Name", "State" },
                values: new object[,]
                {
                    { new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8529), "ARANDELA LEVA", true },
                    { new Guid("3120692a-9626-418d-baae-315eea262ab5"), new Guid("ae377c3d-bbfd-4ed2-a84a-47fd42c823b6"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8533), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8533), "LAINA SPLINDER", true },
                    { new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8520), "PIN LEVA", true },
                    { new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8516), "PIN DISCO", true },
                    { new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8512), "PIN TUERCA", true },
                    { new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), new Guid("70dcee4c-8fea-43ad-9d30-a35f5b458c1a"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8502), "PIN CRUCETA", true },
                    { new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), new Guid("d0529dd0-a201-48d0-bbf5-447cb0d2997e"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(8524), "ARANDELA CACHO", true }
                });

            migrationBuilder.InsertData(
                table: "Autoparts",
                columns: new[] { "AutopartID", "CreationDate", "Description", "HeightCm", "LengthCm", "ModificationDate", "Name", "State", "SubcategoryId", "VehicleZone", "WeightKgs" },
                values: new object[,]
                {
                    { new Guid("2653e777-21cb-43a5-b585-3bcbf7e513fe"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9077), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9078), "PIN DISCO QUINTA RUEDA", true, new Guid("52992cc2-fd87-4298-81cc-9c290e0e53ba"), "N/N", "0" },
                    { new Guid("2a2bb8a4-ef22-4875-9cdf-1d83b06defe8"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9033), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9035), "PIN CRUCETA 334", true, new Guid("b449767b-601c-4811-ad3e-8b388bedf632"), "N/N", "0" },
                    { new Guid("2d57d220-0899-4f97-ae4c-c75d132a8921"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9112), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9113), "LAINA SPLINDER NPR", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("322f81e3-7781-4bcd-947f-d32acc672ce6"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9107), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9108), "ARANDELA LEVA 3/4", true, new Guid("19e5fff4-c619-4ce4-b250-044ca30dca43"), "N/N", "0" },
                    { new Guid("65f4a9e7-30a8-48f2-abff-843ebe0f3333"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9082), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9083), "PIN LEVA 1 1/4", true, new Guid("37c86e98-38d1-4ddf-bba2-df4b3098ea67"), "N/N", "0" },
                    { new Guid("8db21635-4db7-453d-8010-831137e72d63"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9121), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9122), "LAINA SPLINDER HINO FC 500", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("d0ec66b5-378b-44c1-aa29-08614564de98"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9088), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9089), "ARANDELA CACHO AGRALE MODELO NUEVO", true, new Guid("e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3"), "N/N", "0" },
                    { new Guid("d5afd5fc-4094-4003-a242-fd35342f6bc0"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9117), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9117), "LAINA SPLINDER KENWORTH", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" },
                    { new Guid("def7808b-1f75-4ed9-875a-54a09659b77e"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9051), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9062), "PIN TUERCA HOUSING 950 PLANO", true, new Guid("6378b394-f899-4ad4-96c6-9183c6787ad4"), "N/N", "0" },
                    { new Guid("f9e4d631-4015-45e1-9c11-8b88262ad802"), new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9125), "N/N", "0", "0", new DateTime(2023, 9, 15, 18, 8, 25, 852, DateTimeKind.Local).AddTicks(9126), "LAINA SPLINDER NISSAN MT 3000", true, new Guid("3120692a-9626-418d-baae-315eea262ab5"), "N/N", "0" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddresseeId",
                table: "Addresses",
                column: "AddresseeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressTypeId",
                table: "Addresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BuildingId",
                table: "Addresses",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StreetId",
                table: "Addresses",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_AutopartMaterials_AutopartId",
                table: "AutopartMaterials",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_AutopartMaterials_RawMaterialId",
                table: "AutopartMaterials",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Autoparts_SubcategoryId",
                table: "Autoparts",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_AutopartId",
                table: "BillDetails",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderId",
                table: "Bills",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserID",
                table: "Bills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_OrderId",
                table: "Contributions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_PaymentMethodId",
                table: "Contributions",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_AddressId",
                table: "CustomerAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerId",
                table: "CustomerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhones_CustomerId",
                table: "CustomerPhones",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountHistories_PriceHistoryId",
                table: "DiscountHistories",
                column: "PriceHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryAddresses_AddressId",
                table: "FactoryAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryAddresses_FactoryId",
                table: "FactoryAddresses",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryPhones_FactoryId",
                table: "FactoryPhones",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AutopartId",
                table: "Inventories",
                column: "AutopartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Losses_AutopartId",
                table: "Losses",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_RawMaterialId",
                table: "Movements",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_DepartmentId",
                table: "Municipalities",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_MunicipalityId",
                table: "Neighborhoods",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_AutopartId",
                table: "OrderDetails",
                column: "AutopartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceHistories_AutopartId",
                table: "PriceHistories",
                column: "AutopartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_AddressId",
                table: "ProviderAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_ProviderId",
                table: "ProviderAddresses",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderPhones_ProviderId",
                table: "ProviderPhones",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_WarehouseId",
                table: "Shelves",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelvings_InventoryId",
                table: "Shelvings",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelvings_ShelfId",
                table: "Shelvings",
                column: "ShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_RawMaterialId",
                table: "Stocks",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_NeighborhoodId",
                table: "Streets",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryId",
                table: "Subcategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressId",
                table: "UserAddresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_UserID",
                table: "UserAddresses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhones_UserId",
                table: "UserPhones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_PositionID",
                table: "UserPositions",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_UserID",
                table: "UserPositions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_FactoryId",
                table: "Warehouses",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WayToPays_BillId",
                table: "WayToPays",
                column: "BillId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutopartMaterials");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Contributions");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DropTable(
                name: "CustomerPhones");

            migrationBuilder.DropTable(
                name: "DiscountHistories");

            migrationBuilder.DropTable(
                name: "FactoryAddresses");

            migrationBuilder.DropTable(
                name: "FactoryPhones");

            migrationBuilder.DropTable(
                name: "Losses");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProviderAddresses");

            migrationBuilder.DropTable(
                name: "ProviderPhones");

            migrationBuilder.DropTable(
                name: "Shelvings");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.DropTable(
                name: "UserPhones");

            migrationBuilder.DropTable(
                name: "UserPositions");

            migrationBuilder.DropTable(
                name: "WayToPays");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PriceHistories");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Autoparts");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Addressees");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Streets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
