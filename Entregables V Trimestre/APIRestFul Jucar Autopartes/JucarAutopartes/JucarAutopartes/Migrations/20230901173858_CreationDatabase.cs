using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class CreationDatabase : Migration
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
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryID);
                    table.ForeignKey(
                        name: "FK_Subcategories_Categories_CategoryID",
                        column: x => x.CategoryID,
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPhones", x => x.CustomerPhoneID);
                    table.ForeignKey(
                        name: "FK_CustomerPhones_Customers_CustomerID",
                        column: x => x.CustomerID,
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
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
                    DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.MunicipalityID);
                    table.ForeignKey(
                        name: "FK_Municipalities_Departments_DepartmentID",
                        column: x => x.DepartmentID,
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
                    FactoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryPhones", x => x.FactoryPhoneID);
                    table.ForeignKey(
                        name: "FK_FactoryPhones_Factories_FactoryID",
                        column: x => x.FactoryID,
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
                    FactoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseID);
                    table.ForeignKey(
                        name: "FK_Warehouses_Factories_FactoryID",
                        column: x => x.FactoryID,
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
                    ProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderPhones", x => x.ProviderPhoneID);
                    table.ForeignKey(
                        name: "FK_ProviderPhones_Providers_ProviderID",
                        column: x => x.ProviderID,
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
                    RawMaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.MovementID);
                    table.ForeignKey(
                        name: "FK_Movements_RawMaterials_RawMaterialID",
                        column: x => x.RawMaterialID,
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
                    RawMaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stocks_RawMaterials_RawMaterialID",
                        column: x => x.RawMaterialID,
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
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhones", x => x.UserPhoneID);
                    table.ForeignKey(
                        name: "FK_UserPhones_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "UserPositions",
                columns: table => new
                {
                    UserPositionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "UserID");
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
                    SubcategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autoparts", x => x.AutopartID);
                    table.ForeignKey(
                        name: "FK_Autoparts_Subcategories_SubcategoryID",
                        column: x => x.SubcategoryID,
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
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_OrderID",
                        column: x => x.OrderID,
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
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributions", x => x.ContributionID);
                    table.ForeignKey(
                        name: "FK_Contributions_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contributions_PaymentMethods_PaymentMethodID",
                        column: x => x.PaymentMethodID,
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
                    MunicipalityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodID);
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Municipalities_MunicipalityID",
                        column: x => x.MunicipalityID,
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
                    WarehouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.ShelfID);
                    table.ForeignKey(
                        name: "FK_Shelves_Warehouses_WarehouseID",
                        column: x => x.WarehouseID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutopartMaterials", x => x.AutopartMaterialID);
                    table.ForeignKey(
                        name: "FK_AutopartMaterials_Autoparts_AutopartID",
                        column: x => x.AutopartID,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutopartMaterials_RawMaterials_RawMaterialID",
                        column: x => x.RawMaterialID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_Autoparts_AutopartID",
                        column: x => x.AutopartID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Losses", x => x.LossID);
                    table.ForeignKey(
                        name: "FK_Losses_Autoparts_AutopartID",
                        column: x => x.AutopartID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Autoparts_AutopartID",
                        column: x => x.AutopartID,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceHistories", x => x.PriceHistoryID);
                    table.ForeignKey(
                        name: "FK_PriceHistories_Autoparts_AutopartID",
                        column: x => x.AutopartID,
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
                    AutopartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.BillDetailID);
                    table.ForeignKey(
                        name: "FK_BillDetails_Autoparts_AutopartID",
                        column: x => x.AutopartID,
                        principalTable: "Autoparts",
                        principalColumn: "AutopartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillID",
                        column: x => x.BillID,
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
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WayToPays", x => x.WayToPayID);
                    table.ForeignKey(
                        name: "FK_WayToPays_Bills_BillID",
                        column: x => x.BillID,
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
                    NeighborhoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Streets", x => x.StreetID);
                    table.ForeignKey(
                        name: "FK_Streets_Neighborhoods_NeighborhoodID",
                        column: x => x.NeighborhoodID,
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
                    InventoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShelfID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelvings", x => x.ShelvingID);
                    table.ForeignKey(
                        name: "FK_Shelvings_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shelvings_Shelves_ShelfID",
                        column: x => x.ShelfID,
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
                    PriceHistoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountHistories", x => x.DiscountHistoryID);
                    table.ForeignKey(
                        name: "FK_DiscountHistories_PriceHistories_PriceHistoryID",
                        column: x => x.PriceHistoryID,
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
                    StreetID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddresseeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressTypes_AddressTypeID",
                        column: x => x.AddressTypeID,
                        principalTable: "AddressTypes",
                        principalColumn: "AddressTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Addressees_AddresseeID",
                        column: x => x.AddresseeID,
                        principalTable: "Addressees",
                        principalColumn: "AddresseeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Streets_StreetID",
                        column: x => x.StreetID,
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
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.CustomerAddressID);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Customers_CustomerID",
                        column: x => x.CustomerID,
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
                    FactoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryAddresses", x => x.FactoryAddressID);
                    table.ForeignKey(
                        name: "FK_FactoryAddresses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactoryAddresses_Factories_FactoryID",
                        column: x => x.FactoryID,
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
                    ProviderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAddresses", x => x.ProviderAddressID);
                    table.ForeignKey(
                        name: "FK_ProviderAddresses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderAddresses_Providers_ProviderID",
                        column: x => x.ProviderID,
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
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.UserAddressID);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddresses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddresseeID",
                table: "Addresses",
                column: "AddresseeID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressTypeID",
                table: "Addresses",
                column: "AddressTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_BuildingID",
                table: "Addresses",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StreetID",
                table: "Addresses",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_AutopartMaterials_AutopartID",
                table: "AutopartMaterials",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_AutopartMaterials_RawMaterialID",
                table: "AutopartMaterials",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Autoparts_SubcategoryID",
                table: "Autoparts",
                column: "SubcategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_AutopartID",
                table: "BillDetails",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillID",
                table: "BillDetails",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_OrderID",
                table: "Bills",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserID",
                table: "Bills",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_OrderID",
                table: "Contributions",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Contributions_PaymentMethodID",
                table: "Contributions",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_AddressID",
                table: "CustomerAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddresses_CustomerID",
                table: "CustomerAddresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPhones_CustomerID",
                table: "CustomerPhones",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountHistories_PriceHistoryID",
                table: "DiscountHistories",
                column: "PriceHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryAddresses_AddressID",
                table: "FactoryAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryAddresses_FactoryID",
                table: "FactoryAddresses",
                column: "FactoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryPhones_FactoryID",
                table: "FactoryPhones",
                column: "FactoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AutopartID",
                table: "Inventories",
                column: "AutopartID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Losses_AutopartID",
                table: "Losses",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_RawMaterialID",
                table: "Movements",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_DepartmentID",
                table: "Municipalities",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_MunicipalityID",
                table: "Neighborhoods",
                column: "MunicipalityID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_AutopartID",
                table: "OrderDetails",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PriceHistories_AutopartID",
                table: "PriceHistories",
                column: "AutopartID");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_AddressID",
                table: "ProviderAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAddresses_ProviderID",
                table: "ProviderAddresses",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderPhones_ProviderID",
                table: "ProviderPhones",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_WarehouseID",
                table: "Shelves",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Shelvings_InventoryID",
                table: "Shelvings",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Shelvings_ShelfID",
                table: "Shelvings",
                column: "ShelfID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_RawMaterialID",
                table: "Stocks",
                column: "RawMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Streets_NeighborhoodID",
                table: "Streets",
                column: "NeighborhoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategories_CategoryID",
                table: "Subcategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_AddressID",
                table: "UserAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_UserID",
                table: "UserAddresses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhones_UserID",
                table: "UserPhones",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_PositionID",
                table: "UserPositions",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositions_UserID",
                table: "UserPositions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_FactoryID",
                table: "Warehouses",
                column: "FactoryID");

            migrationBuilder.CreateIndex(
                name: "IX_WayToPays_BillID",
                table: "WayToPays",
                column: "BillID",
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
