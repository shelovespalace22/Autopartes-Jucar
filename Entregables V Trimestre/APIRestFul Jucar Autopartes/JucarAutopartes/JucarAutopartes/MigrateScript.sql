IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Categories] (
    [CategoryID] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryID])
);
GO

CREATE TABLE [Customers] (
    [CustomerID] uniqueidentifier NOT NULL,
    [IdentifierType] nvarchar(50) NOT NULL,
    [IdentifierNumber] nvarchar(10) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerID])
);
GO

CREATE TABLE [Departments] (
    [DepartmentID] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([DepartmentID])
);
GO

CREATE TABLE [PaymentMethods] (
    [PaymentMethodID] uniqueidentifier NOT NULL,
    [PaymentMethodName] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_PaymentMethods] PRIMARY KEY ([PaymentMethodID])
);
GO

CREATE TABLE [Providers] (
    [ProviderID] uniqueidentifier NOT NULL,
    [IdentifierType] nvarchar(50) NOT NULL,
    [IdentifierNumber] nvarchar(10) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [EmailAddress] nvarchar(max) NOT NULL,
    [ProductType] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY ([ProviderID])
);
GO

CREATE TABLE [RawMaterials] (
    [RawMaterialID] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_RawMaterials] PRIMARY KEY ([RawMaterialID])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Subcategories] (
    [SubcategoryID] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [CategoryId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Subcategories] PRIMARY KEY ([SubcategoryID]),
    CONSTRAINT [FK_Subcategories_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryID]) ON DELETE CASCADE
);
GO

CREATE TABLE [CustomerPhones] (
    [CustomerPhoneID] uniqueidentifier NOT NULL,
    [PhoneType] nvarchar(30) NOT NULL,
    [PhoneNumber] nvarchar(10) NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_CustomerPhones] PRIMARY KEY ([CustomerPhoneID]),
    CONSTRAINT [FK_CustomerPhones_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Orders] (
    [OrderID] uniqueidentifier NOT NULL,
    [OrderDate] datetime2 NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    [Total] decimal(18,2) NULL,
    [PaymentStatus] nvarchar(50) NULL,
    [ShippingAddress] nvarchar(100) NULL,
    [ShippingStatus] nvarchar(50) NULL,
    [Observation] nvarchar(200) NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderID]),
    CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Municipalities] (
    [MunicipalityID] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [DepartmentId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Municipalities] PRIMARY KEY ([MunicipalityID]),
    CONSTRAINT [FK_Municipalities_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([DepartmentID]) ON DELETE CASCADE
);
GO

CREATE TABLE [ProviderPhones] (
    [ProviderPhoneID] uniqueidentifier NOT NULL,
    [PhoneType] nvarchar(20) NOT NULL,
    [PhoneNumber] nvarchar(10) NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [ProviderId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_ProviderPhones] PRIMARY KEY ([ProviderPhoneID]),
    CONSTRAINT [FK_ProviderPhones_Providers_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [Providers] ([ProviderID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Movements] (
    [MovementID] uniqueidentifier NOT NULL,
    [Quantity] int NOT NULL,
    [MovementType] nvarchar(20) NOT NULL,
    [MovementDate] datetime2 NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [RawMaterialId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Movements] PRIMARY KEY ([MovementID]),
    CONSTRAINT [FK_Movements_RawMaterials_RawMaterialId] FOREIGN KEY ([RawMaterialId]) REFERENCES [RawMaterials] ([RawMaterialID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Stocks] (
    [StockID] uniqueidentifier NOT NULL,
    [QuantityAvailable] int NOT NULL,
    [InitialStock] int NOT NULL,
    [ReorderPoint] int NOT NULL,
    [MinimumInventory] int NOT NULL,
    [MaximumInventory] int NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [RawMaterialId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Stocks] PRIMARY KEY ([StockID]),
    CONSTRAINT [FK_Stocks_RawMaterials_RawMaterialId] FOREIGN KEY ([RawMaterialId]) REFERENCES [RawMaterials] ([RawMaterialID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Autoparts] (
    [AutopartID] uniqueidentifier NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(200) NULL,
    [Inventory] int NOT NULL,
    [Value] decimal(18,2) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [SubcategoryId] uniqueidentifier NOT NULL,
    [RawMaterialId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Autoparts] PRIMARY KEY ([AutopartID]),
    CONSTRAINT [FK_Autoparts_RawMaterials_RawMaterialId] FOREIGN KEY ([RawMaterialId]) REFERENCES [RawMaterials] ([RawMaterialID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Autoparts_Subcategories_SubcategoryId] FOREIGN KEY ([SubcategoryId]) REFERENCES [Subcategories] ([SubcategoryID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Contributions] (
    [ContributionID] uniqueidentifier NOT NULL,
    [AmountPaid] decimal(18,2) NOT NULL,
    [ContributionDate] datetime2 NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [PaymentMethodId] uniqueidentifier NOT NULL,
    [OrderId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Contributions] PRIMARY KEY ([ContributionID]),
    CONSTRAINT [FK_Contributions_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Contributions_PaymentMethods_PaymentMethodId] FOREIGN KEY ([PaymentMethodId]) REFERENCES [PaymentMethods] ([PaymentMethodID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Neighborhoods] (
    [NeighborhoodID] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [MunicipalityId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Neighborhoods] PRIMARY KEY ([NeighborhoodID]),
    CONSTRAINT [FK_Neighborhoods_Municipalities_MunicipalityId] FOREIGN KEY ([MunicipalityId]) REFERENCES [Municipalities] ([MunicipalityID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Losses] (
    [LossID] uniqueidentifier NOT NULL,
    [AmountLoss] int NOT NULL,
    [Responsible] nvarchar(50) NOT NULL,
    [Reason] nvarchar(150) NOT NULL,
    [LossDate] datetime2 NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [AutopartId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Losses] PRIMARY KEY ([LossID]),
    CONSTRAINT [FK_Losses_Autoparts_AutopartId] FOREIGN KEY ([AutopartId]) REFERENCES [Autoparts] ([AutopartID]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderDetails] (
    [OrderDetailID] uniqueidentifier NOT NULL,
    [Quantity] nvarchar(5) NOT NULL,
    [UnitValue] decimal(18,2) NOT NULL,
    [IVA] decimal(18,2) NOT NULL,
    [SubtotalValue] decimal(18,2) NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [AutopartId] uniqueidentifier NOT NULL,
    [OrderId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderDetailID]),
    CONSTRAINT [FK_OrderDetails_Autoparts_AutopartId] FOREIGN KEY ([AutopartId]) REFERENCES [Autoparts] ([AutopartID]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderID]) ON DELETE CASCADE
);
GO

CREATE TABLE [CustomerAddresses] (
    [CustomerAddressID] uniqueidentifier NOT NULL,
    [Address] nvarchar(50) NOT NULL,
    [AddressType] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [NeighborhoodId] uniqueidentifier NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_CustomerAddresses] PRIMARY KEY ([CustomerAddressID]),
    CONSTRAINT [FK_CustomerAddresses_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CustomerAddresses_Neighborhoods_NeighborhoodId] FOREIGN KEY ([NeighborhoodId]) REFERENCES [Neighborhoods] ([NeighborhoodID]) ON DELETE CASCADE
);
GO

CREATE TABLE [ProviderAddresses] (
    [ProviderAddressID] uniqueidentifier NOT NULL,
    [Address] nvarchar(50) NOT NULL,
    [AddressType] nvarchar(50) NOT NULL,
    [State] bit NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    [ModificationDate] datetime2 NOT NULL,
    [NeighborhoodId] uniqueidentifier NOT NULL,
    [ProviderId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_ProviderAddresses] PRIMARY KEY ([ProviderAddressID]),
    CONSTRAINT [FK_ProviderAddresses_Neighborhoods_NeighborhoodId] FOREIGN KEY ([NeighborhoodId]) REFERENCES [Neighborhoods] ([NeighborhoodID]) ON DELETE CASCADE,
    CONSTRAINT [FK_ProviderAddresses_Providers_ProviderId] FOREIGN KEY ([ProviderId]) REFERENCES [Providers] ([ProviderID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

CREATE INDEX [IX_Autoparts_RawMaterialId] ON [Autoparts] ([RawMaterialId]);
GO

CREATE INDEX [IX_Autoparts_SubcategoryId] ON [Autoparts] ([SubcategoryId]);
GO

CREATE INDEX [IX_Contributions_OrderId] ON [Contributions] ([OrderId]);
GO

CREATE INDEX [IX_Contributions_PaymentMethodId] ON [Contributions] ([PaymentMethodId]);
GO

CREATE INDEX [IX_CustomerAddresses_CustomerId] ON [CustomerAddresses] ([CustomerId]);
GO

CREATE UNIQUE INDEX [IX_CustomerAddresses_NeighborhoodId] ON [CustomerAddresses] ([NeighborhoodId]);
GO

CREATE INDEX [IX_CustomerPhones_CustomerId] ON [CustomerPhones] ([CustomerId]);
GO

CREATE INDEX [IX_Losses_AutopartId] ON [Losses] ([AutopartId]);
GO

CREATE INDEX [IX_Movements_RawMaterialId] ON [Movements] ([RawMaterialId]);
GO

CREATE INDEX [IX_Municipalities_DepartmentId] ON [Municipalities] ([DepartmentId]);
GO

CREATE INDEX [IX_Neighborhoods_MunicipalityId] ON [Neighborhoods] ([MunicipalityId]);
GO

CREATE INDEX [IX_OrderDetails_AutopartId] ON [OrderDetails] ([AutopartId]);
GO

CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
GO

CREATE INDEX [IX_Orders_CustomerId] ON [Orders] ([CustomerId]);
GO

CREATE UNIQUE INDEX [IX_ProviderAddresses_NeighborhoodId] ON [ProviderAddresses] ([NeighborhoodId]);
GO

CREATE INDEX [IX_ProviderAddresses_ProviderId] ON [ProviderAddresses] ([ProviderId]);
GO

CREATE INDEX [IX_ProviderPhones_ProviderId] ON [ProviderPhones] ([ProviderId]);
GO

CREATE UNIQUE INDEX [IX_Stocks_RawMaterialId] ON [Stocks] ([RawMaterialId]);
GO

CREATE INDEX [IX_Subcategories_CategoryId] ON [Subcategories] ([CategoryId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231107220423_CreatingDatabase', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryID', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([CategoryID], [CreationDate], [ModificationDate], [Name], [State])
VALUES ('29961716-b4fe-43a9-874d-0acdc993a5b8', '2023-11-07T17:20:00.0605110-05:00', '2023-11-07T17:20:00.0605111-05:00', N'EMPAQUE CARNAZA', CAST(1 AS bit)),
('2e6b11a6-3f6c-47f6-beb6-f7edd8645175', '2023-11-07T17:20:00.0605113-05:00', '2023-11-07T17:20:00.0605114-05:00', N'TELEFONO CAUCHO', CAST(1 AS bit)),
('6b158255-0b3e-47f0-bc22-5ba2ec06ffef', '2023-11-07T17:20:00.0605116-05:00', '2023-11-07T17:20:00.0605117-05:00', N'MEDIA LUNA', CAST(1 AS bit)),
('70dcee4c-8fea-43ad-9d30-a35f5b458c1a', '2023-11-07T17:20:00.0605067-05:00', '2023-11-07T17:20:00.0605080-05:00', N'PIN', CAST(1 AS bit)),
('ae377c3d-bbfd-4ed2-a84a-47fd42c823b6', '2023-11-07T17:20:00.0605108-05:00', '2023-11-07T17:20:00.0605108-05:00', N'LAINA', CAST(1 AS bit)),
('d0529dd0-a201-48d0-bbf5-447cb0d2997e', '2023-11-07T17:20:00.0605104-05:00', '2023-11-07T17:20:00.0605105-05:00', N'ARANDELA', CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryID', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RawMaterialID', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[RawMaterials]'))
    SET IDENTITY_INSERT [RawMaterials] ON;
INSERT INTO [RawMaterials] ([RawMaterialID], [CreationDate], [ModificationDate], [Name], [State])
VALUES ('8a7505db-8bb3-4872-a927-8113834f0c10', '2023-11-07T17:20:00.0607031-05:00', '2023-11-07T17:20:00.0607031-05:00', N'Hierro', CAST(1 AS bit)),
('c3818a2d-d242-4493-b437-2d74d434fa21', '2023-11-07T17:20:00.0607024-05:00', '2023-11-07T17:20:00.0607026-05:00', N'Acero', CAST(1 AS bit)),
('da932f1f-4bf1-4233-9fd6-283a0ff4ce6e', '2023-11-07T17:20:00.0607034-05:00', '2023-11-07T17:20:00.0607035-05:00', N'Cobre', CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RawMaterialID', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[RawMaterials]'))
    SET IDENTITY_INSERT [RawMaterials] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SubcategoryID', N'CategoryId', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[Subcategories]'))
    SET IDENTITY_INSERT [Subcategories] ON;
INSERT INTO [Subcategories] ([SubcategoryID], [CategoryId], [CreationDate], [ModificationDate], [Name], [State])
VALUES ('19e5fff4-c619-4ce4-b250-044ca30dca43', 'd0529dd0-a201-48d0-bbf5-447cb0d2997e', '2023-11-07T17:20:00.0605972-05:00', '2023-11-07T17:20:00.0605973-05:00', N'ARANDELA LEVA', CAST(1 AS bit)),
('3120692a-9626-418d-baae-315eea262ab5', 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6', '2023-11-07T17:20:00.0605975-05:00', '2023-11-07T17:20:00.0605976-05:00', N'LAINA SPLINDER', CAST(1 AS bit)),
('37c86e98-38d1-4ddf-bba2-df4b3098ea67', '70dcee4c-8fea-43ad-9d30-a35f5b458c1a', '2023-11-07T17:20:00.0605964-05:00', '2023-11-07T17:20:00.0605965-05:00', N'PIN LEVA', CAST(1 AS bit)),
('52992cc2-fd87-4298-81cc-9c290e0e53ba', '70dcee4c-8fea-43ad-9d30-a35f5b458c1a', '2023-11-07T17:20:00.0605961-05:00', '2023-11-07T17:20:00.0605961-05:00', N'PIN DISCO', CAST(1 AS bit)),
('6378b394-f899-4ad4-96c6-9183c6787ad4', '70dcee4c-8fea-43ad-9d30-a35f5b458c1a', '2023-11-07T17:20:00.0605957-05:00', '2023-11-07T17:20:00.0605957-05:00', N'PIN TUERCA', CAST(1 AS bit)),
('b449767b-601c-4811-ad3e-8b388bedf632', '70dcee4c-8fea-43ad-9d30-a35f5b458c1a', '2023-11-07T17:20:00.0605947-05:00', '2023-11-07T17:20:00.0605948-05:00', N'PIN CRUCETA', CAST(1 AS bit)),
('e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3', 'd0529dd0-a201-48d0-bbf5-447cb0d2997e', '2023-11-07T17:20:00.0605968-05:00', '2023-11-07T17:20:00.0605968-05:00', N'ARANDELA CACHO', CAST(1 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'SubcategoryID', N'CategoryId', N'CreationDate', N'ModificationDate', N'Name', N'State') AND [object_id] = OBJECT_ID(N'[Subcategories]'))
    SET IDENTITY_INSERT [Subcategories] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AutopartID', N'CreationDate', N'Description', N'Inventory', N'ModificationDate', N'Name', N'RawMaterialId', N'State', N'SubcategoryId', N'Value') AND [object_id] = OBJECT_ID(N'[Autoparts]'))
    SET IDENTITY_INSERT [Autoparts] ON;
INSERT INTO [Autoparts] ([AutopartID], [CreationDate], [Description], [Inventory], [ModificationDate], [Name], [RawMaterialId], [State], [SubcategoryId], [Value])
VALUES ('2653e777-21cb-43a5-b585-3bcbf7e513fe', '2023-11-07T17:20:00.0606508-05:00', N'N/N', 60, '2023-11-07T17:20:00.0606508-05:00', N'PIN DISCO QUINTA RUEDA', 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e', CAST(1 AS bit), '52992cc2-fd87-4298-81cc-9c290e0e53ba', 800.0),
('2a2bb8a4-ef22-4875-9cdf-1d83b06defe8', '2023-11-07T17:20:00.0606487-05:00', N'N/N', 80, '2023-11-07T17:20:00.0606488-05:00', N'PIN CRUCETA 334', 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e', CAST(1 AS bit), 'b449767b-601c-4811-ad3e-8b388bedf632', 100.0),
('2d57d220-0899-4f97-ae4c-c75d132a8921', '2023-11-07T17:20:00.0606530-05:00', N'N/N', 80, '2023-11-07T17:20:00.0606530-05:00', N'LAINA SPLINDER NPR', 'c3818a2d-d242-4493-b437-2d74d434fa21', CAST(1 AS bit), '3120692a-9626-418d-baae-315eea262ab5', 100.0),
('322f81e3-7781-4bcd-947f-d32acc672ce6', '2023-11-07T17:20:00.0606524-05:00', N'N/N', 190, '2023-11-07T17:20:00.0606525-05:00', N'ARANDELA LEVA 3/4', 'c3818a2d-d242-4493-b437-2d74d434fa21', CAST(1 AS bit), '19e5fff4-c619-4ce4-b250-044ca30dca43', 50.0),
('65f4a9e7-30a8-48f2-abff-843ebe0f3333', '2023-11-07T17:20:00.0606513-05:00', N'N/N', 80, '2023-11-07T17:20:00.0606514-05:00', N'PIN LEVA 1 1/4', 'c3818a2d-d242-4493-b437-2d74d434fa21', CAST(1 AS bit), '37c86e98-38d1-4ddf-bba2-df4b3098ea67', 100.0),
('8db21635-4db7-453d-8010-831137e72d63', '2023-11-07T17:20:00.0606540-05:00', N'N/N', 45, '2023-11-07T17:20:00.0606541-05:00', N'LAINA SPLINDER HINO FC 500', '8a7505db-8bb3-4872-a927-8113834f0c10', CAST(1 AS bit), '3120692a-9626-418d-baae-315eea262ab5', 200.0),
('d0ec66b5-378b-44c1-aa29-08614564de98', '2023-11-07T17:20:00.0606518-05:00', N'N/N', 200, '2023-11-07T17:20:00.0606519-05:00', N'ARANDELA CACHO AGRALE MODELO NUEVO', 'c3818a2d-d242-4493-b437-2d74d434fa21', CAST(1 AS bit), 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3', 90.0),
('d5afd5fc-4094-4003-a242-fd35342f6bc0', '2023-11-07T17:20:00.0606535-05:00', N'N/N', 65, '2023-11-07T17:20:00.0606536-05:00', N'LAINA SPLINDER KENWORTH', '8a7505db-8bb3-4872-a927-8113834f0c10', CAST(1 AS bit), '3120692a-9626-418d-baae-315eea262ab5', 70.0),
('def7808b-1f75-4ed9-875a-54a09659b77e', '2023-11-07T17:20:00.0606502-05:00', N'N/N', 10, '2023-11-07T17:20:00.0606503-05:00', N'PIN TUERCA HOUSING 950 PLANO', 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e', CAST(1 AS bit), '6378b394-f899-4ad4-96c6-9183c6787ad4', 150.0),
('f9e4d631-4015-45e1-9c11-8b88262ad802', '2023-11-07T17:20:00.0606546-05:00', N'N/N', 23, '2023-11-07T17:20:00.0606547-05:00', N'LAINA SPLINDER NISSAN MT 3000', '8a7505db-8bb3-4872-a927-8113834f0c10', CAST(1 AS bit), '3120692a-9626-418d-baae-315eea262ab5', 150.0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AutopartID', N'CreationDate', N'Description', N'Inventory', N'ModificationDate', N'Name', N'RawMaterialId', N'State', N'SubcategoryId', N'Value') AND [object_id] = OBJECT_ID(N'[Autoparts]'))
    SET IDENTITY_INSERT [Autoparts] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231107222000_InsertingDataConfiguration', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP INDEX [IX_ProviderAddresses_NeighborhoodId] ON [ProviderAddresses];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderDetails]') AND [c].[name] = N'IVA');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [OrderDetails] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [OrderDetails] DROP COLUMN [IVA];
GO

ALTER TABLE [Orders] ADD [IVA] decimal(18,2) NOT NULL DEFAULT 0.0;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076020-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076020-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7075994-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075996-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076043-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076044-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076036-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076037-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076025-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076025-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076055-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076055-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076030-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076031-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076049-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076050-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076012-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076013-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:33:08.7076061-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076061-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074754-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074755-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074757-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074758-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074760-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074761-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074699-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074716-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074751-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074752-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:33:08.7074747-05:00', [ModificationDate] = '2023-11-10T18:33:08.7074747-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:33:08.7076624-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076624-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:33:08.7076617-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076618-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:33:08.7076627-05:00', [ModificationDate] = '2023-11-10T18:33:08.7076627-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075570-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075571-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075575-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075575-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075563-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075563-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075559-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075559-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075554-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075555-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075546-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075547-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:33:08.7075566-05:00', [ModificationDate] = '2023-11-10T18:33:08.7075567-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_ProviderAddresses_NeighborhoodId] ON [ProviderAddresses] ([NeighborhoodId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231110233309_UpdateTables', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP INDEX [IX_CustomerAddresses_NeighborhoodId] ON [CustomerAddresses];
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528565-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528565-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528544-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528545-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528586-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528587-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528581-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528582-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528570-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528570-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528598-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528598-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528575-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528576-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528592-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528593-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528559-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528559-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-10T18:36:55.6528603-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528604-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527353-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527354-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527356-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527356-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527358-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527359-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527302-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527319-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527350-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527351-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-10T18:36:55.6527346-05:00', [ModificationDate] = '2023-11-10T18:36:55.6527347-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:36:55.6529037-05:00', [ModificationDate] = '2023-11-10T18:36:55.6529037-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:36:55.6529030-05:00', [ModificationDate] = '2023-11-10T18:36:55.6529032-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-10T18:36:55.6529040-05:00', [ModificationDate] = '2023-11-10T18:36:55.6529040-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528104-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528104-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528107-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528108-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528097-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528097-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528092-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528092-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528087-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528087-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528077-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528078-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-10T18:36:55.6528100-05:00', [ModificationDate] = '2023-11-10T18:36:55.6528101-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

CREATE INDEX [IX_CustomerAddresses_NeighborhoodId] ON [CustomerAddresses] ([NeighborhoodId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231110233656_UpdateTableNeighborhood', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161348-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161348-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161327-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161329-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161371-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161372-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161366-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161366-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161354-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161355-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161383-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161383-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161359-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161360-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161377-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161377-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161341-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161342-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T15:25:30.6161388-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161389-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160144-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160144-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160146-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160147-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160149-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160150-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160099-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160112-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160141-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160142-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T15:25:30.6160137-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160138-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T15:25:30.6161831-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161832-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T15:25:30.6161824-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161825-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T15:25:30.6161834-05:00', [ModificationDate] = '2023-11-15T15:25:30.6161835-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160891-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160892-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160895-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160896-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160882-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160883-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160878-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160879-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160874-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160874-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160865-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160866-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T15:25:30.6160887-05:00', [ModificationDate] = '2023-11-15T15:25:30.6160888-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231115202531_Modifications', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405839-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405839-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405813-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405814-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405899-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405899-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405893-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405893-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405845-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405846-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405909-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405910-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405887-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405887-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405904-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405905-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405833-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405833-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-15T16:39:22.0405915-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405915-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404585-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404586-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404587-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404588-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404590-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404591-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404537-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404552-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404582-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404583-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-15T16:39:22.0404578-05:00', [ModificationDate] = '2023-11-15T16:39:22.0404578-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T16:39:22.0406357-05:00', [ModificationDate] = '2023-11-15T16:39:22.0406358-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T16:39:22.0406350-05:00', [ModificationDate] = '2023-11-15T16:39:22.0406352-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-15T16:39:22.0406361-05:00', [ModificationDate] = '2023-11-15T16:39:22.0406361-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405370-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405371-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405374-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405374-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405362-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405363-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405359-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405359-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405355-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405355-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405346-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405347-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-15T16:39:22.0405366-05:00', [ModificationDate] = '2023-11-15T16:39:22.0405367-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231115213922_ModificationsII', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'1b1456c3-01d4-4382-960d-3af5f05b3762', NULL, N'Manager', N'MANAGER'),
(N'55d10bea-e927-4929-80dd-1fa57605ddf5', NULL, N'Administrator', N'ADMINISTRATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590743-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590744-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590720-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590722-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590888-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590889-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590881-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590882-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590868-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590869-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590899-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590900-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590876-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590876-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590894-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590895-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590737-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590738-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T16:01:34.2590905-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590906-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589472-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589473-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589475-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589476-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589478-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589479-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589414-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589431-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589469-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589470-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T16:01:34.2589465-05:00', [ModificationDate] = '2023-11-16T16:01:34.2589465-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T16:01:34.2591580-05:00', [ModificationDate] = '2023-11-16T16:01:34.2591581-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T16:01:34.2591571-05:00', [ModificationDate] = '2023-11-16T16:01:34.2591573-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T16:01:34.2591583-05:00', [ModificationDate] = '2023-11-16T16:01:34.2591584-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590282-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590282-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590285-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590286-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590274-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590275-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590269-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590270-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590265-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590265-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590255-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590257-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T16:01:34.2590278-05:00', [ModificationDate] = '2023-11-16T16:01:34.2590278-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231116210134_AddedRolesToDb', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'1b1456c3-01d4-4382-960d-3af5f05b3762';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'55d10bea-e927-4929-80dd-1fa57605ddf5';
SELECT @@ROWCOUNT;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'IVA');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Orders] DROP COLUMN [IVA];
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'62252a9e-a611-4224-a3a5-084c3f0ab516', NULL, N'Administrator', N'ADMINISTRATOR'),
(N'dfb91f97-9dbe-4ccb-8f8b-46734f2caf30', NULL, N'Manager', N'MANAGER');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550506-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550507-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550483-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550485-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550530-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550531-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550524-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550524-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550512-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550513-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550544-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550544-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550517-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550518-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550536-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550537-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550500-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550500-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:15:11.2550550-05:00', [ModificationDate] = '2023-11-16T19:15:11.2550551-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2549018-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549019-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2549023-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549024-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2549026-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549026-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2548972-05:00', [ModificationDate] = '2023-11-16T19:15:11.2548986-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2549016-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549016-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:15:11.2549013-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549013-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:15:11.2551241-05:00', [ModificationDate] = '2023-11-16T19:15:11.2551242-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:15:11.2551230-05:00', [ModificationDate] = '2023-11-16T19:15:11.2551233-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:15:11.2551244-05:00', [ModificationDate] = '2023-11-16T19:15:11.2551245-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549985-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549986-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549989-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549989-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549977-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549978-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549973-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549973-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549968-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549969-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549958-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549959-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:15:11.2549981-05:00', [ModificationDate] = '2023-11-16T19:15:11.2549982-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231117001511_QuiteIVA', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'62252a9e-a611-4224-a3a5-084c3f0ab516';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'dfb91f97-9dbe-4ccb-8f8b-46734f2caf30';
SELECT @@ROWCOUNT;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderDetails]') AND [c].[name] = N'Quantity');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [OrderDetails] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [OrderDetails] ALTER COLUMN [Quantity] int NOT NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'36cbf895-bc7c-4be3-886f-dd881884af2e', NULL, N'Manager', N'MANAGER'),
(N'c61fa2a7-af13-4cba-98da-e1acb7f79318', NULL, N'Administrator', N'ADMINISTRATOR');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147908-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147908-05:00'
WHERE [AutopartID] = '2653e777-21cb-43a5-b585-3bcbf7e513fe';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147887-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147888-05:00'
WHERE [AutopartID] = '2a2bb8a4-ef22-4875-9cdf-1d83b06defe8';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147930-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147930-05:00'
WHERE [AutopartID] = '2d57d220-0899-4f97-ae4c-c75d132a8921';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147924-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147924-05:00'
WHERE [AutopartID] = '322f81e3-7781-4bcd-947f-d32acc672ce6';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147913-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147914-05:00'
WHERE [AutopartID] = '65f4a9e7-30a8-48f2-abff-843ebe0f3333';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147941-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147941-05:00'
WHERE [AutopartID] = '8db21635-4db7-453d-8010-831137e72d63';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147919-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147919-05:00'
WHERE [AutopartID] = 'd0ec66b5-378b-44c1-aa29-08614564de98';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147935-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147936-05:00'
WHERE [AutopartID] = 'd5afd5fc-4094-4003-a242-fd35342f6bc0';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147902-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147903-05:00'
WHERE [AutopartID] = 'def7808b-1f75-4ed9-875a-54a09659b77e';
SELECT @@ROWCOUNT;

GO

UPDATE [Autoparts] SET [CreationDate] = '2023-11-16T19:24:24.8147946-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147947-05:00'
WHERE [AutopartID] = 'f9e4d631-4015-45e1-9c11-8b88262ad802';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146352-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146353-05:00'
WHERE [CategoryID] = '29961716-b4fe-43a9-874d-0acdc993a5b8';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146355-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146355-05:00'
WHERE [CategoryID] = '2e6b11a6-3f6c-47f6-beb6-f7edd8645175';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146358-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146358-05:00'
WHERE [CategoryID] = '6b158255-0b3e-47f0-bc22-5ba2ec06ffef';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146302-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146316-05:00'
WHERE [CategoryID] = '70dcee4c-8fea-43ad-9d30-a35f5b458c1a';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146349-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146350-05:00'
WHERE [CategoryID] = 'ae377c3d-bbfd-4ed2-a84a-47fd42c823b6';
SELECT @@ROWCOUNT;

GO

UPDATE [Categories] SET [CreationDate] = '2023-11-16T19:24:24.8146346-05:00', [ModificationDate] = '2023-11-16T19:24:24.8146346-05:00'
WHERE [CategoryID] = 'd0529dd0-a201-48d0-bbf5-447cb0d2997e';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:24:24.8148617-05:00', [ModificationDate] = '2023-11-16T19:24:24.8148618-05:00'
WHERE [RawMaterialID] = '8a7505db-8bb3-4872-a927-8113834f0c10';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:24:24.8148609-05:00', [ModificationDate] = '2023-11-16T19:24:24.8148611-05:00'
WHERE [RawMaterialID] = 'c3818a2d-d242-4493-b437-2d74d434fa21';
SELECT @@ROWCOUNT;

GO

UPDATE [RawMaterials] SET [CreationDate] = '2023-11-16T19:24:24.8148620-05:00', [ModificationDate] = '2023-11-16T19:24:24.8148621-05:00'
WHERE [RawMaterialID] = 'da932f1f-4bf1-4233-9fd6-283a0ff4ce6e';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147419-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147420-05:00'
WHERE [SubcategoryID] = '19e5fff4-c619-4ce4-b250-044ca30dca43';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147423-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147423-05:00'
WHERE [SubcategoryID] = '3120692a-9626-418d-baae-315eea262ab5';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147411-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147412-05:00'
WHERE [SubcategoryID] = '37c86e98-38d1-4ddf-bba2-df4b3098ea67';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147407-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147408-05:00'
WHERE [SubcategoryID] = '52992cc2-fd87-4298-81cc-9c290e0e53ba';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147403-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147404-05:00'
WHERE [SubcategoryID] = '6378b394-f899-4ad4-96c6-9183c6787ad4';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147391-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147394-05:00'
WHERE [SubcategoryID] = 'b449767b-601c-4811-ad3e-8b388bedf632';
SELECT @@ROWCOUNT;

GO

UPDATE [Subcategories] SET [CreationDate] = '2023-11-16T19:24:24.8147415-05:00', [ModificationDate] = '2023-11-16T19:24:24.8147416-05:00'
WHERE [SubcategoryID] = 'e08f3a12-fb06-4e53-9e37-c7d9ad42f9d3';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231117002425_CambioTipoQuantity', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AspNetUsers] ADD [RefreshToken] nvarchar(max) NULL;
GO

ALTER TABLE [AspNetUsers] ADD [RefreshTokenExpiryTime] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231126145931_AdditionalUserFiledsForRefreshToken', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231205164402_StocksModification', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'Total');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Orders] ALTER COLUMN [Total] decimal(10,2) NULL;
GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderDetails]') AND [c].[name] = N'UnitValue');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [OrderDetails] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [OrderDetails] ALTER COLUMN [UnitValue] decimal(10,2) NOT NULL;
GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderDetails]') AND [c].[name] = N'SubtotalValue');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [OrderDetails] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [OrderDetails] ALTER COLUMN [SubtotalValue] decimal(10,2) NOT NULL;
GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Contributions]') AND [c].[name] = N'AmountPaid');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Contributions] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Contributions] ALTER COLUMN [AmountPaid] decimal(10,2) NOT NULL;
GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Autoparts]') AND [c].[name] = N'Value');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Autoparts] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Autoparts] ALTER COLUMN [Value] decimal(10,2) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240302210615_ConfiguracionPrecisionCamposDecimal', N'8.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentID', N'Name') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] ON;
INSERT INTO [Departments] ([DepartmentID], [Name])
VALUES ('25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Bolívar'),
('958920ce-4d55-4038-a87f-af783ff1d533', N'Cundinamarca'),
('c26f1779-ac31-4b71-935b-cc91864f35d8', N'Santander'),
('c5424105-77c9-4cb2-bf05-ff1db7fa1b12', N'Bogotá D.C.'),
('e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Boyacá'),
('eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Antioquia');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'DepartmentID', N'Name') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MunicipalityID', N'DepartmentId', N'Name') AND [object_id] = OBJECT_ID(N'[Municipalities]'))
    SET IDENTITY_INSERT [Municipalities] ON;
INSERT INTO [Municipalities] ([MunicipalityID], [DepartmentId], [Name])
VALUES ('0070ac2f-33fe-4ee6-95ee-559838f741cc', '958920ce-4d55-4038-a87f-af783ff1d533', N'Chía'),
('04445038-5881-4660-9a97-9bc53687c8aa', '25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Magangué'),
('07cae774-1c0b-4b94-a76a-463d475d93fc', 'e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Paipa'),
('09ee73c3-df0d-432e-99b6-f444bc6f25de', '25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Turbaco'),
('0aa41c1a-bce7-4cd0-b372-7bfca622b3c0', 'e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Duitama'),
('0efcc66c-64f7-4187-a634-c61b4f54984b', 'e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Sogamoso'),
('12601027-07fe-435d-bf86-c0b8b63e7576', 'eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Itagüí'),
('26af7150-f00e-4b4d-bba4-a6156f161a18', 'c26f1779-ac31-4b71-935b-cc91864f35d8', N'Pídecuesta'),
('444b2ed7-85b9-4fc4-8421-e32227de9e5c', 'eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Bello'),
('515185c4-491c-483b-b2d1-d8e99eaa0189', 'c26f1779-ac31-4b71-935b-cc91864f35d8', N'Barrancabermeja'),
('5376159b-6903-439f-9045-36b176354e55', 'c26f1779-ac31-4b71-935b-cc91864f35d8', N'Floridablanca'),
('6a1e6bff-b542-4731-ad4c-8b80097a0a61', 'e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Tunja'),
('77292549-bb02-48d3-b9cd-70b7d3a4a22f', 'eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Sabaneta'),
('863104b2-3845-4fbf-b0aa-0471015ba6cc', '25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Cartagena'),
('9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5', 'e6a04ebb-433f-492f-9d0d-6636e8e9c392', N'Chiquinquirá'),
('a1aa7f91-20a2-403d-ad2d-6ef971a46832', '25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Soledad'),
('a3abfc70-4368-4f24-b4bc-378d2ea1c72e', '958920ce-4d55-4038-a87f-af783ff1d533', N'Facatativá'),
('afa8f2fb-5494-460e-8a5d-91ba20052bb0', 'eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Medellín'),
('ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5', 'c26f1779-ac31-4b71-935b-cc91864f35d8', N'Bucaramanga'),
('c9209c76-d6e3-49c3-b9b1-27ce300cf820', 'c5424105-77c9-4cb2-bf05-ff1db7fa1b12', N'Bogotá'),
('e8eb2e8c-3421-426b-8035-049a8367980d', 'eeb58df4-a5c4-47b9-9cea-5f98b338260f', N'Envigado'),
('efc46672-7656-408a-aed7-33110510d825', '958920ce-4d55-4038-a87f-af783ff1d533', N'Fusagasugá'),
('f2c2bfc3-b03f-44d6-8396-ce1d64245f72', '958920ce-4d55-4038-a87f-af783ff1d533', N'Soacha'),
('f90c2016-dd81-46e0-ab68-919e7d5be04b', '25b2b57e-f928-4c8e-8eb5-23209e9a2ae1', N'Arjona'),
('fb28c89a-4565-48a2-9516-b8b25da4efd8', 'c26f1779-ac31-4b71-935b-cc91864f35d8', N'Girón'),
('ffad25db-cd64-4f75-96df-d4db4a698e3a', '958920ce-4d55-4038-a87f-af783ff1d533', N'Zipaquirá');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'MunicipalityID', N'DepartmentId', N'Name') AND [object_id] = OBJECT_ID(N'[Municipalities]'))
    SET IDENTITY_INSERT [Municipalities] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'NeighborhoodID', N'MunicipalityId', N'Name') AND [object_id] = OBJECT_ID(N'[Neighborhoods]'))
    SET IDENTITY_INSERT [Neighborhoods] ON;
INSERT INTO [Neighborhoods] ([NeighborhoodID], [MunicipalityId], [Name])
VALUES ('0adb69c7-8c3b-4b7f-b2ee-70153f2bb33f', 'afa8f2fb-5494-460e-8a5d-91ba20052bb0', N'El Poblado'),
('0e05d355-c573-4b37-bd09-cc6a4ff1f459', 'fb28c89a-4565-48a2-9516-b8b25da4efd8', N'Villa Carolina'),
('11da7410-5d21-4c5d-8310-0bf0ad1f0f79', '444b2ed7-85b9-4fc4-8421-e32227de9e5c', N'Niquía'),
('16b2e90d-2f62-4dc4-9e4c-f7bab28d5e8d', '09ee73c3-df0d-432e-99b6-f444bc6f25de', N'Las Palmeras'),
('16c7f9dd-8700-4d96-8453-4e647bdeaeee', '515185c4-491c-483b-b2d1-d8e99eaa0189', N'San Rafael'),
('237d8ae9-36c6-4199-88fd-b8eea93eb2fc', 'a1aa7f91-20a2-403d-ad2d-6ef971a46832', N'Las Moras'),
('2eba303f-b2e5-4a99-a086-9b70a2b0b3cc', 'e8eb2e8c-3421-426b-8035-049a8367980d', N'El Dorado'),
('2f2a97df-9a51-4bbe-a26c-88f71d803d01', '863104b2-3845-4fbf-b0aa-0471015ba6cc', N'Getsemaní'),
('3c276cb8-6ee2-4950-8c70-d0b193b729e6', 'efc46672-7656-408a-aed7-33110510d825', N'La Esperanza'),
('45350c07-2e64-4025-87d3-d063a885c46f', '26af7150-f00e-4b4d-bba4-a6156f161a18', N'Prados del Mutis'),
('48065608-6caa-4c95-955e-8f748393fbdd', 'f90c2016-dd81-46e0-ab68-919e7d5be04b', N'Barrio El Cacao'),
('4b9caeb5-0572-4e98-ac45-a01efe3ff258', '6a1e6bff-b542-4731-ad4c-8b80097a0a61', N'El Topo'),
('4c589372-1a7e-431f-a9ea-fb8d748c493b', '09ee73c3-df0d-432e-99b6-f444bc6f25de', N'El Pueblito'),
('4fd9e0cc-2d93-4245-9a82-5dd59563c691', 'ffad25db-cd64-4f75-96df-d4db4a698e3a', N'La Esperanza'),
('514e8495-fc39-4233-936d-a2b7ee255444', 'a3abfc70-4368-4f24-b4bc-378d2ea1c72e', N'La Estación'),
('57888bd6-957f-4754-9cc0-587d15b31f6f', 'efc46672-7656-408a-aed7-33110510d825', N'Centro'),
('5cde767f-13f9-4462-a96c-2f7cb9aa6e0a', '0070ac2f-33fe-4ee6-95ee-559838f741cc', N'Guaymaral'),
('60462cc0-e02d-4daa-94a1-ef67d60c3b7f', '9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5', N'Barrio San Antonio'),
('610ae713-3a68-41c1-92ac-dd844c60051a', 'c9209c76-d6e3-49c3-b9b1-27ce300cf820', N'Usaquén'),
('6eb90f2c-1eb5-4823-9ba8-4b59d4101a86', '77292549-bb02-48d3-b9cd-70b7d3a4a22f', N'La Doctora'),
('6f263844-aa55-4280-840c-27bda923beac', '515185c4-491c-483b-b2d1-d8e99eaa0189', N'Los Cedros'),
('7be523f2-d9e3-4f17-a3f6-6bfd1d59b203', '444b2ed7-85b9-4fc4-8421-e32227de9e5c', N'San Félix'),
('7f1629c6-e440-4bd4-9338-d7e284100140', '863104b2-3845-4fbf-b0aa-0471015ba6cc', N'Bocagrande'),
('847a9d5f-c78d-40c3-8a74-b1ec2720b424', 'afa8f2fb-5494-460e-8a5d-91ba20052bb0', N'Laureles'),
('87004677-4dff-4bbe-a941-c311f017a769', 'f2c2bfc3-b03f-44d6-8396-ce1d64245f72', N'Compartir'),
('8a77da5b-74d8-4c73-a24c-9f9cba66120f', '07cae774-1c0b-4b94-a76a-463d475d93fc', N'Santa Rita'),
('8e4b97f6-fef0-44dd-9b28-cff12cdbffac', '12601027-07fe-435d-bf86-c0b8b63e7576', N'El Porvenir'),
('9b664bdd-3685-4c78-b381-bbb5d0343b85', '12601027-07fe-435d-bf86-c0b8b63e7576', N'Santa María'),
('9c8c2877-c973-4493-8032-0bf90fee4206', 'ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5', N'Provenza'),
('9d54cec9-1677-4e9a-87ed-6d71d8e780d3', '6a1e6bff-b542-4731-ad4c-8b80097a0a61', N'Centro Histórico'),
('a1a2c738-c1db-4e39-9fdc-2855536d0f6a', 'ffad25db-cd64-4f75-96df-d4db4a698e3a', N'El Carmen'),
('a2a07452-dc8e-4cff-828d-75d9cdcdafb5', '04445038-5881-4660-9a97-9bc53687c8aa', N'El Pueblo Nuevo'),
('a32b5c95-0232-49bc-9fff-b75b52599e24', '0aa41c1a-bce7-4cd0-b372-7bfca622b3c0', N'El Libertador'),
('a7d35971-aa5b-4479-8f4d-71de97846c74', 'c9209c76-d6e3-49c3-b9b1-27ce300cf820', N'Chapinero'),
('af50ccf0-b2d6-406b-b3ac-e4337b6bb717', '0aa41c1a-bce7-4cd0-b372-7bfca622b3c0', N'La Floresta'),
('b077ca81-a434-46ce-bc15-b242675a011c', '04445038-5881-4660-9a97-9bc53687c8aa', N'Barrio Libertad'),
('b723a4d9-22b7-470b-b9c6-637429e6028b', '5376159b-6903-439f-9045-36b176354e55', N'Cañaveral'),
('b820e69d-8a05-4a55-b07d-e0e93abbecc8', '07cae774-1c0b-4b94-a76a-463d475d93fc', N'La Colina'),
('bc1664e2-92fa-45b0-9868-fdf4b669e78e', 'f2c2bfc3-b03f-44d6-8396-ce1d64245f72', N'Ciudad Verde'),
('c5897d98-6fc5-462f-98a6-b28d62497047', '9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5', N'Barrio Simón Bólivar'),
('cefb34aa-e2da-4a37-ba8c-0071d40ae846', '0070ac2f-33fe-4ee6-95ee-559838f741cc', N'La Pradera'),
('d03940eb-8802-4139-8513-74756bb4ba1f', 'e8eb2e8c-3421-426b-8035-049a8367980d', N'Jardínes');
INSERT INTO [Neighborhoods] ([NeighborhoodID], [MunicipalityId], [Name])
VALUES ('d40747ce-547e-4334-a211-7a3b93fa5fb4', 'fb28c89a-4565-48a2-9516-b8b25da4efd8', N'Altos de Pan de Azúcar'),
('d4bfcebc-90cc-4657-9281-f5fe30e18aea', 'ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5', N'Cabecera del Llano'),
('d53a814f-2ba4-4e5a-a542-fe5c13e7b44f', '0efcc66c-64f7-4187-a634-c61b4f54984b', N'Centro'),
('da8bf5a8-8d02-487b-a25e-32d8d08cfa95', '77292549-bb02-48d3-b9cd-70b7d3a4a22f', N'Ciudadela Robledo'),
('dda14777-d0f8-416c-97f3-318607704bbf', '26af7150-f00e-4b4d-bba4-a6156f161a18', N'Villa del Prado'),
('ec91bd61-d1e4-469d-8b78-5e544e4c7c73', 'a3abfc70-4368-4f24-b4bc-378d2ea1c72e', N'San Rafael'),
('edea2a92-d5a3-4350-bcbf-ac80b770d359', '5376159b-6903-439f-9045-36b176354e55', N'Lagos del Cacique'),
('f0455fc4-ff3f-4569-9820-4fa9932efe71', '0efcc66c-64f7-4187-a634-c61b4f54984b', N'La Campiña'),
('f22856fd-a0f5-4cb1-8d76-d703afaa3a66', 'a1aa7f91-20a2-403d-ad2d-6ef971a46832', N'El Hipódromo'),
('f59ffed8-d257-48b9-b961-3499c41cfa04', 'f90c2016-dd81-46e0-ab68-919e7d5be04b', N'Centro');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'NeighborhoodID', N'MunicipalityId', N'Name') AND [object_id] = OBJECT_ID(N'[Neighborhoods]'))
    SET IDENTITY_INSERT [Neighborhoods] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240311194953_RegistrosBarrios', N'8.0.2');
GO

COMMIT;
GO

