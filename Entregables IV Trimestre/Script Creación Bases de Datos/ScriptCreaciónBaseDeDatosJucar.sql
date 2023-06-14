CREATE DATABASE JucarAutoBD;

USE JucarAutoBD;

-- ***** CREACION TABLAS *****

CREATE TABLE Aporte 
    (
     AporteID INTEGER IDENTITY(1,1) NOT NULL , 
     MedioPagoID INTEGER NOT NULL , 
     PedidoID INTEGER NOT NULL , 
     ClienteID INTEGER NOT NULL , 
     MontoAbonado BIGINT NOT NULL , 
     FechaAporte DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificacion DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Aporte ADD CONSTRAINT Aporte_PK PRIMARY KEY CLUSTERED (AporteID, PedidoID, ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Autoparte 
    (
     AutoparteID INTEGER IDENTITY(1,1) NOT NULL , 
     CategoríaID INTEGER , 
     SubcategoríaID INTEGER , 
     Nombre VARCHAR (30) NOT NULL , 
     Función VARCHAR (30) NOT NULL , 
     ZonaVehículo VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     PesoKgs VARCHAR (3) NOT NULL , 
     AltoCm VARCHAR (3) NOT NULL , 
     LargoCm VARCHAR (3) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Autoparte ADD CONSTRAINT Autoparte_PK PRIMARY KEY CLUSTERED (AutoparteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Barrio 
    (
     BarrioID INTEGER IDENTITY(1,1) NOT NULL , 
     MunicipioID INTEGER NOT NULL , 
     Nombre VARCHAR (50) NOT NULL, 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Barrio ADD CONSTRAINT Barrio_PK PRIMARY KEY CLUSTERED (BarrioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Bodega 
    (
     BodegaID INTEGER IDENTITY(1,1) NOT NULL , 
     FabricaID INTEGER NOT NULL , 
     Nombre VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL, 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Bodega ADD CONSTRAINT Bodega_PK PRIMARY KEY CLUSTERED (FabricaID, BodegaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Cargo 
    (
     CargoID INTEGER IDENTITY(1,1) NOT NULL , 
     NombreCargo VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL, 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Cargo ADD CONSTRAINT Cargo_PK PRIMARY KEY CLUSTERED (CargoID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Categoría 
    (
     CategoríaID INTEGER IDENTITY(1,1) NOT NULL , 
     NombreCategoría VARCHAR (40) NOT NULL , 
     Estado VARCHAR (10) NOT NULL, 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Categoría ADD CONSTRAINT Categoría_PK PRIMARY KEY CLUSTERED (CategoríaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Cliente 
    (
     ClienteID INTEGER IDENTITY(1,1) NOT NULL , 
     Correo VARCHAR (30) NOT NULL , 
     País VARCHAR (30) NOT NULL , 
     Ciudad VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Cliente ADD CONSTRAINT Cliente_PK PRIMARY KEY CLUSTERED (ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE ClienteJurídico 
    (
     ClienteID INTEGER IDENTITY(1,1) NOT NULL , 
     RazónSocial VARCHAR (30) NOT NULL , 
     NIT VARCHAR (30) NOT NULL 
    )
GO

ALTER TABLE ClienteJurídico ADD CONSTRAINT ClienteJurídico_PK PRIMARY KEY CLUSTERED (ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE ClienteNatural 
    (
     ClienteID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoDoc VARCHAR (30) NOT NULL , 
     NumDoc VARCHAR (15) NOT NULL , 
     PrimerNombre VARCHAR (30) NOT NULL , 
     SegundoNombre VARCHAR (30) NOT NULL , 
     PrimerApellido VARCHAR (30) NOT NULL , 
     SegundoApellido VARCHAR (30) NOT NULL 
    )
GO

ALTER TABLE ClienteNatural ADD CONSTRAINT ClienteNatural_PK PRIMARY KEY CLUSTERED (ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Departamento 
    (
     DepartamentoID INTEGER IDENTITY(1,1) NOT NULL , 
     Nombre VARCHAR (50) NOT NULL , 
     Capital VARCHAR (50) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE Departamento ADD CONSTRAINT Departamento_PK PRIMARY KEY CLUSTERED (DepartamentoID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Destinatario 
    (
     DestinatarioID INTEGER IDENTITY(1,1) NOT NULL , 
     PrimerNombre VARCHAR (50) NOT NULL , 
     SegundoNombre VARCHAR (50) NOT NULL , 
     PrimerApellido VARCHAR (50) NOT NULL , 
     SegundoApellido VARCHAR (50) NOT NULL , 
     TipoDoc VARCHAR (5) NOT NULL , 
     NumDoc VARCHAR (10) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Destinatario ADD CONSTRAINT Destinatario_PK PRIMARY KEY CLUSTERED (DestinatarioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DetalleFactura 
    (
     DetalleFacturaID INTEGER IDENTITY(1,1) NOT NULL , 
     FacturaID INTEGER NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     NumItem VARCHAR (3) NOT NULL , 
     Cantidad VARCHAR (3) NOT NULL , 
     ValorUnitario BIGINT NOT NULL , 
     IVA BIGINT NOT NULL , 
     ValorSubtotal BIGINT NOT NULL , 
     ValorTotal BIGINT NOT NULL 
    )
GO

ALTER TABLE DetalleFactura ADD CONSTRAINT DetalleFactura_PK PRIMARY KEY CLUSTERED (FacturaID, DetalleFacturaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DetallePedido 
    (
     DetallePedidoID INTEGER IDENTITY(1,1) NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     ClienteID INTEGER NOT NULL , 
     PedidoID INTEGER NOT NULL , 
     Producto VARCHAR (50) NOT NULL , 
     Cantidad VARCHAR (3) NOT NULL 
    )
GO

ALTER TABLE DetallePedido ADD CONSTRAINT DetallePedidov1_PK PRIMARY KEY CLUSTERED (DetallePedidoID, PedidoID, ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Dirección 
    (
     DirecciónID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoDirecciónID INTEGER NOT NULL , 
     VíaID INTEGER NOT NULL , 
     EdificioID INTEGER NOT NULL , 
     DestinatarioID INTEGER NOT NULL , 
     País VARCHAR (30) , 
     Departamento VARCHAR (30) , 
     Municipio VARCHAR (30) , 
     Ciudad VARCHAR (30) NOT NULL , 
     Localidad VARCHAR (30) NOT NULL , 
     Barrio VARCHAR (30) NOT NULL , 
     Dirección VARCHAR (30) NOT NULL , 
     InformaciónAdicional VARCHAR (200) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO 

    


CREATE UNIQUE NONCLUSTERED INDEX 
    Ubicación__IDX ON Dirección 
    ( 
     DirecciónID 
    ) 
GO

ALTER TABLE Dirección ADD CONSTRAINT Dirección_PK PRIMARY KEY CLUSTERED (DirecciónID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DireccionCliente 
    (
     DireccionClienteID INTEGER IDENTITY(1,1) NOT NULL , 
     DirecciónID INTEGER NOT NULL , 
     ClienteID INTEGER NOT NULL , 
     TipoDirecciónID INTEGER NOT NULL , 
     DestinatarioID INTEGER NOT NULL , 
     EdificioID INTEGER NOT NULL , 
     VíaID INTEGER NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE DireccionCliente ADD CONSTRAINT DireccionCliente_PK PRIMARY KEY CLUSTERED (DireccionClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DireccionFabrica 
    (
     DireccionFabricaID INTEGER IDENTITY(1,1) NOT NULL , 
     DirecciónID INTEGER NOT NULL , 
     FabricaID INTEGER NOT NULL , 
     EdificioID INTEGER NOT NULL , 
     VíaID INTEGER NOT NULL , 
     TipoDirecciónID INTEGER NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE DireccionFabrica ADD CONSTRAINT DireccionFabrica_PK PRIMARY KEY CLUSTERED (DireccionFabricaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DireccionProveedor 
    (
     DireccionProveedorID INTEGER IDENTITY(1,1) NOT NULL , 
     DirecciónID INTEGER NOT NULL , 
     ProveedorID INTEGER NOT NULL , 
     VíaID INTEGER NOT NULL , 
     TipoDirecciónID INTEGER NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE DireccionProveedor ADD CONSTRAINT DireccionProveedor_PK PRIMARY KEY CLUSTERED (DireccionProveedorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DireccionUsuario 
    (
     DireccionUsuarioID INTEGER IDENTITY(1,1) NOT NULL , 
     DirecciónID INTEGER NOT NULL , 
     UsuarioID INTEGER NOT NULL , 
     EdificioID INTEGER NOT NULL , 
     VíaID INTEGER NOT NULL , 
     TipoDirecciónID INTEGER NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE DireccionUsuario ADD CONSTRAINT DireccionUsuario_PK PRIMARY KEY CLUSTERED (DireccionUsuarioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Edificio 
    (
     EdificioID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoEdificio VARCHAR (20) NOT NULL , 
     NumEdificio VARCHAR (10) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Edificio ADD CONSTRAINT Edificio_PK PRIMARY KEY CLUSTERED (EdificioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE EstanteOrganizador 
    (
     EstanteOrganizador INTEGER IDENTITY(1,1) NOT NULL , 
     FabricaID INTEGER NOT NULL , 
     BodegaID INTEGER NOT NULL , 
     Material VARCHAR (30) NOT NULL , 
     Color VARCHAR (30) NOT NULL , 
     CapacidadMáxKgs VARCHAR (5) NOT NULL , 
     AltoCm VARCHAR (3) NOT NULL , 
     LargoCm VARCHAR (3) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE EstanteOrganizador ADD CONSTRAINT EstanteOrganizador_PK PRIMARY KEY CLUSTERED (EstanteOrganizador)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Estantería 
    (
     EstanteríaID INTEGER IDENTITY(1,1) NOT NULL , 
     EstanteOrganizadorID INTEGER NOT NULL , 
     InventarioID INTEGER NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     NumEstantería VARCHAR (3) NOT NULL , 
     TipoProducto VARCHAR (20) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Estantería ADD CONSTRAINT Estantería_PK PRIMARY KEY CLUSTERED (EstanteríaID, EstanteOrganizadorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Existencia 
    (
     ExistenciaID INTEGER IDENTITY(1,1) NOT NULL , 
     MateriaPrimaID INTEGER NOT NULL , 
     CantidadDisponible VARCHAR (3) NOT NULL , 
     ExistenciasIniciales VARCHAR (3) NOT NULL , 
     PuntoReorden VARCHAR (3) NOT NULL , 
     InventarioMinimo VARCHAR (3) NOT NULL , 
     InventarioMáximo VARCHAR (3) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Existencia ADD CONSTRAINT Existencia_PK PRIMARY KEY CLUSTERED (ExistenciaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Fabrica 
    (
     FabricaID INTEGER IDENTITY(1,1) NOT NULL , 
     NIT VARCHAR (20) NOT NULL , 
     RazónSocial VARCHAR (30) NOT NULL , 
     DirecciónEmail VARCHAR (30) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Fabrica ADD CONSTRAINT Fabrica_PK PRIMARY KEY CLUSTERED (FabricaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Factura 
    (
     FacturaID INTEGER IDENTITY(1,1) NOT NULL , 
     PedidoID INTEGER NOT NULL , 
     ClienteID INTEGER NOT NULL , 
     UsuarioID INTEGER NOT NULL , 
     FormaPagoID INTEGER NOT NULL , 
     N_Factura VARCHAR (5) NOT NULL , 
     Dirección VARCHAR (30) NOT NULL , 
     Télefono VARCHAR (15) NOT NULL , 
     NumFacturaVenta VARCHAR (10) NOT NULL , 
     Cliente VARCHAR (50) NOT NULL , 
     CC VARCHAR (10) NOT NULL ,
	 NIT VARCHAR (9) NOT NULL,
     TeléfonoCliente VARCHAR (10) NOT NULL , 
     Observación VARCHAR (150) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO 

    


CREATE UNIQUE NONCLUSTERED INDEX 
    Factura__IDX ON Factura 
    ( 
     FormaPagoID 
    ) 
GO 


CREATE UNIQUE NONCLUSTERED INDEX 
    Factura__IDXv1 ON Factura 
    ( 
     PedidoID , 
     ClienteID 
    ) 
GO

ALTER TABLE Factura ADD CONSTRAINT Factura_PK PRIMARY KEY CLUSTERED (FacturaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE FormaPago 
    (
     FormaPagoID INTEGER IDENTITY(1,1) NOT NULL , 
     NombreFormaPago VARCHAR (50) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL 
    )
GO

ALTER TABLE FormaPago ADD CONSTRAINT FormaPago_PK PRIMARY KEY CLUSTERED (FormaPagoID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE HistorialDescuento 
    (
     HistorialDescuentoID INTEGER IDENTITY(1,1) NOT NULL , 
     HistorialPrecioID INTEGER NOT NULL , 
     PorcentajeDescuento BIGINT NOT NULL , 
     ValorTemporal BIGINT NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     FechaInicialDescuento DATETIME NOT NULL , 
     FechaFinalDescuento DATETIME NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE HistorialDescuento ADD CONSTRAINT HistorialDescuento_PK PRIMARY KEY CLUSTERED (HistorialDescuentoID, HistorialPrecioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE HistorialPrecio 
    (
     HistorialPrecioID INTEGER IDENTITY(1,1) NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     Valor BIGINT NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     FechaIniciialPrecio DATE NOT NULL , 
     FechaFinalPrecio DATE NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE HistorialPrecio ADD CONSTRAINT HistorialPrecio_PK PRIMARY KEY CLUSTERED (HistorialPrecioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Inventario 
    (
     InventarioID INTEGER IDENTITY(1,1) NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     CantidadDisponible VARCHAR (5) NOT NULL , 
     ExistenciasIniciales VARCHAR (5) NOT NULL , 
     InventarioMáx VARCHAR (5) NOT NULL , 
     InventarioMin VARCHAR (5) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO 

    


CREATE UNIQUE NONCLUSTERED INDEX 
    Inventario__IDX ON Inventario 
    ( 
     AutoparteID 
    ) 
GO

ALTER TABLE Inventario ADD CONSTRAINT Inventario_PK PRIMARY KEY CLUSTERED (InventarioID, AutoparteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE MaterialAutoparte 
    (
     MaterialAutoparteID INTEGER IDENTITY(1,1) NOT NULL , 
     MateriaPrimaID INTEGER NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     ComposiciónAutoparte VARCHAR (50) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE MaterialAutoparte ADD CONSTRAINT MaterialAutoparte_PK PRIMARY KEY CLUSTERED (MateriaPrimaID, AutoparteID, MaterialAutoparteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE MateriaPrima 
    (
     MateriaPrimaID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoMateriaPrima VARCHAR (20) NOT NULL , 
     NombreMateriaPrima VARCHAR (30) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE MateriaPrima ADD CONSTRAINT MateriaPrima_PK PRIMARY KEY CLUSTERED (MateriaPrimaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE MedioPago 
    (
     MedioPagoID INTEGER IDENTITY(1,1) NOT NULL , 
     Remitente VARCHAR (30) NOT NULL , 
     NombreMetodoPago VARCHAR (50) NOT NULL , 
     Estado BIT NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE MedioPago ADD CONSTRAINT MedioPago_PK PRIMARY KEY CLUSTERED (MedioPagoID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Movimiento 
    (
     MovimientoID INTEGER IDENTITY(1,1) NOT NULL , 
     MateriaPrimaID INTEGER NOT NULL , 
     Cantidad INTEGER NOT NULL , 
     TipoMovimiento VARCHAR (15) NOT NULL , 
     FechaMovimiento DATETIME NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Movimiento ADD CONSTRAINT Movimiento_PK PRIMARY KEY CLUSTERED (MovimientoID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Municipio 
    (
     MunicipioID INTEGER IDENTITY(1,1) NOT NULL , 
     DepartamentoID INTEGER NOT NULL , 
     Nombre VARCHAR (50) NOT NULL , 
     Capital BIT NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Municipio ADD CONSTRAINT Municipio_PK PRIMARY KEY CLUSTERED (MunicipioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Pedido 
    (
     PedidoID INTEGER IDENTITY(1,1) NOT NULL , 
     ClienteID INTEGER NOT NULL , 
     Lugar VARCHAR (50) NOT NULL , 
     Estado BIT NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Pedido ADD CONSTRAINT Pedidov1_PK PRIMARY KEY CLUSTERED (PedidoID, ClienteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Perdida 
    (
     PerdidaID INTEGER IDENTITY(1,1) NOT NULL , 
     AutoparteID INTEGER NOT NULL , 
     Motivo VARCHAR (20) NOT NULL , 
     Lugar VARCHAR (50) NOT NULL , 
     ResponsablePerdida VARCHAR (30) NOT NULL , 
     FechaPerdida DATETIME NOT NULL , 
     CantidadPerdida VARCHAR (5) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Perdida ADD CONSTRAINT Perdida_PK PRIMARY KEY CLUSTERED (PerdidaID, AutoparteID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Proveedor 
    (
     ProveedorID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoProducto VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     Correo VARCHAR (30) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Proveedor ADD CONSTRAINT Proveedor_PK PRIMARY KEY CLUSTERED (ProveedorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE ProveedorJurídico 
    (
     ProveedorID INTEGER IDENTITY(1,1) NOT NULL , 
     RazónSocial VARCHAR (40) NOT NULL , 
     NIT VARCHAR (15) NOT NULL , 
     RepresentanteLegal VARCHAR (50) NOT NULL 
    )
GO

ALTER TABLE ProveedorJurídico ADD CONSTRAINT ProveedorJurídico_PK PRIMARY KEY CLUSTERED (ProveedorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE ProveedorNatural 
    (
     ProveedorID INTEGER IDENTITY(1,1) NOT NULL , 
     TipoDoc VARCHAR (20) NOT NULL , 
     NumDoc VARCHAR (10) NOT NULL , 
     PrimerNombre VARCHAR (30) NOT NULL , 
     SegundoNombre VARCHAR (30) NOT NULL , 
     PrimeApellido VARCHAR (30) NOT NULL , 
     SegundoApellido VARCHAR (50) NOT NULL 
    )
GO

ALTER TABLE ProveedorNatural ADD CONSTRAINT ProveedorNatural_PK PRIMARY KEY CLUSTERED (ProveedorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Subcategoría 
    (
     SubcategoríaID INTEGER IDENTITY(1,1) NOT NULL , 
     CategoríaID INTEGER NOT NULL , 
     NombreSubCat VARCHAR (30) NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Subcategoría ADD CONSTRAINT Subcategoría_PK PRIMARY KEY CLUSTERED (SubcategoríaID, CategoríaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TelefonoFabrica 
    (
     TelefonoFabricaID INTEGER IDENTITY(1,1) NOT NULL , 
     FabricaID INTEGER NOT NULL , 
     TipoTélefono VARCHAR (20) NOT NULL , 
     NumTeléfono VARCHAR (20) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE TelefonoFabrica ADD CONSTRAINT TelefonoFabrica_PK PRIMARY KEY CLUSTERED (TelefonoFabricaID, FabricaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TélefonoProveedor 
    (
     TelefonoProveedorID INTEGER IDENTITY(1,1) NOT NULL , 
     ProveedorID INTEGER NOT NULL , 
     TipoTélefono VARCHAR (30) NOT NULL , 
     NumTélefono VARCHAR (10) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE TélefonoProveedor ADD CONSTRAINT TélefonoProveedor_PK PRIMARY KEY CLUSTERED (TelefonoProveedorID, ProveedorID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TelefonoUsuario 
    (
     TelefonoUsuarioID INTEGER IDENTITY(1,1) NOT NULL , 
     UsuarioID INTEGER NOT NULL , 
     TipoTélefono VARCHAR (20) NOT NULL , 
     NumTélefono VARCHAR (15) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE TelefonoUsuario ADD CONSTRAINT TelefonoUsuario_PK PRIMARY KEY CLUSTERED (TelefonoUsuarioID, UsuarioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TipoDirección 
    (
     TipoDirecciónID INTEGER IDENTITY(1,1) NOT NULL , 
     Tipo VARCHAR (20) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE TipoDirección ADD CONSTRAINT TipoDirección_PK PRIMARY KEY CLUSTERED (TipoDirecciónID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Usuario 
    (
     UsuarioID INTEGER IDENTITY(1,1) NOT NULL , 
     PrimerNombre VARCHAR (30) NOT NULL , 
     SegundoNombre VARCHAR (30) NOT NULL , 
     PrimerApellido VARCHAR (30) NOT NULL , 
     SegundoApellido VARCHAR (30) NOT NULL , 
     DirecciónCorreo VARCHAR (30) NOT NULL , 
     DirecciónDomicilio VARCHAR (30) NOT NULL , 
     Sexo VARCHAR (15) NOT NULL , 
     FechaNacimiento DATE NOT NULL , 
     Estado VARCHAR (10) NOT NULL , 
     NombreUsuario VARCHAR (30) NOT NULL , 
     PasswordHash VARCHAR (100) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Usuario ADD CONSTRAINT Usuario_PK PRIMARY KEY CLUSTERED (UsuarioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE UsuarioCargo 
    (
     UsuarioCargoID INTEGER IDENTITY(1,1) NOT NULL , 
     CargoID INTEGER NOT NULL , 
     UsuarioID INTEGER NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE UsuarioCargo ADD CONSTRAINT UsuarioCargo_PK PRIMARY KEY CLUSTERED (CargoID, UsuarioCargoID, UsuarioID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Vía 
    (
     VíaID INTEGER IDENTITY(1,1) NOT NULL , 
     BarrioID INTEGER NOT NULL , 
     TipoCalle VARCHAR (15) NOT NULL , 
     Calle VARCHAR (3) NOT NULL , 
     Sufijo VARCHAR (10) NOT NULL , 
     Número1 VARCHAR (3) NOT NULL , 
     Número2 VARCHAR (3) NOT NULL , 
     FechaCreación DATE DEFAULT GETDATE() NOT NULL , 
     FechaModificación DATETIME DEFAULT GETDATE() NOT NULL
    )
GO

ALTER TABLE Vía ADD CONSTRAINT Vía_PK PRIMARY KEY CLUSTERED (VíaID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

-- ***** LLAVES FORANEAS *****

ALTER TABLE Aporte 
    ADD CONSTRAINT Aporte_MedioPago_FK FOREIGN KEY 
    ( 
     MedioPagoID
    ) 
    REFERENCES MedioPago 
    ( 
     MedioPagoID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Aporte 
    ADD CONSTRAINT Aporte_Pedido_FK FOREIGN KEY 
    ( 
     PedidoID, 
     ClienteID
    ) 
    REFERENCES Pedido 
    ( 
     PedidoID , 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Autoparte 
    ADD CONSTRAINT Autoparte_Subcategoría_FK FOREIGN KEY 
    ( 
     SubcategoríaID, 
     CategoríaID
    ) 
    REFERENCES Subcategoría 
    ( 
     SubcategoríaID , 
     CategoríaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Barrio 
    ADD CONSTRAINT Barrio_Municipio_FK FOREIGN KEY 
    ( 
     MunicipioID
    ) 
    REFERENCES Municipio 
    ( 
     MunicipioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Bodega 
    ADD CONSTRAINT Bodega_Fabrica_FK FOREIGN KEY 
    ( 
     FabricaID
    ) 
    REFERENCES Fabrica 
    ( 
     FabricaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE ClienteJurídico 
    ADD CONSTRAINT ClienteJurídico_Cliente_FK FOREIGN KEY 
    ( 
     ClienteID
    ) 
    REFERENCES Cliente 
    ( 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE ClienteNatural 
    ADD CONSTRAINT ClienteNatural_Cliente_FK FOREIGN KEY 
    ( 
     ClienteID
    ) 
    REFERENCES Cliente 
    ( 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetalleFactura 
    ADD CONSTRAINT DetalleFactura_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetalleFactura 
    ADD CONSTRAINT DetalleFactura_Factura_FK FOREIGN KEY 
    ( 
     FacturaID
    ) 
    REFERENCES Factura 
    ( 
     FacturaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetallePedido 
    ADD CONSTRAINT DetallePedido_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetallePedido 
    ADD CONSTRAINT DetallePedido_Pedido_FK FOREIGN KEY 
    ( 
     PedidoID, 
     ClienteID
    ) 
    REFERENCES Pedido 
    ( 
     PedidoID , 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Dirección 
    ADD CONSTRAINT Dirección_Destinatario_FK FOREIGN KEY 
    ( 
     DestinatarioID
    ) 
    REFERENCES Destinatario 
    ( 
     DestinatarioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Dirección 
    ADD CONSTRAINT Dirección_Edificio_FK FOREIGN KEY 
    ( 
     EdificioID
    ) 
    REFERENCES Edificio 
    ( 
     EdificioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Dirección 
    ADD CONSTRAINT Dirección_TipoDirección_FK FOREIGN KEY 
    ( 
     TipoDirecciónID
    ) 
    REFERENCES TipoDirección 
    ( 
     TipoDirecciónID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Dirección 
    ADD CONSTRAINT Dirección_Vía_FK FOREIGN KEY 
    ( 
     VíaID
    ) 
    REFERENCES Vía 
    ( 
     VíaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionCliente 
    ADD CONSTRAINT DireccionCliente_Cliente_FK FOREIGN KEY 
    ( 
     ClienteID
    ) 
    REFERENCES Cliente 
    ( 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionCliente 
    ADD CONSTRAINT DireccionCliente_Dirección_FK FOREIGN KEY 
    ( 
     DirecciónID
    ) 
    REFERENCES Dirección 
    ( 
     DirecciónID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionFabrica 
    ADD CONSTRAINT DireccionFabrica_Dirección_FK FOREIGN KEY 
    ( 
     DirecciónID
    ) 
    REFERENCES Dirección 
    ( 
     DirecciónID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionFabrica 
    ADD CONSTRAINT DireccionFabrica_Fabrica_FK FOREIGN KEY 
    ( 
     FabricaID
    ) 
    REFERENCES Fabrica 
    ( 
     FabricaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionProveedor 
    ADD CONSTRAINT DireccionProveedor_Dirección_FK FOREIGN KEY 
    ( 
     DirecciónID
    ) 
    REFERENCES Dirección 
    ( 
     DirecciónID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionProveedor 
    ADD CONSTRAINT DireccionProveedor_Proveedor_FK FOREIGN KEY 
    ( 
     ProveedorID
    ) 
    REFERENCES Proveedor 
    ( 
     ProveedorID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionUsuario 
    ADD CONSTRAINT DireccionUsuario_Dirección_FK FOREIGN KEY 
    ( 
     DirecciónID
    ) 
    REFERENCES Dirección 
    ( 
     DirecciónID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DireccionUsuario 
    ADD CONSTRAINT DireccionUsuario_Usuario_FK FOREIGN KEY 
    ( 
     UsuarioID
    ) 
    REFERENCES Usuario 
    ( 
     UsuarioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE EstanteOrganizador 
    ADD CONSTRAINT EstanteOrganizador_Bodega_FK FOREIGN KEY 
    ( 
     FabricaID, 
     BodegaID
    ) 
    REFERENCES Bodega 
    ( 
     FabricaID , 
     BodegaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Estantería 
    ADD CONSTRAINT Estantería_EstanteOrganizador_FK FOREIGN KEY 
    ( 
     EstanteOrganizadorID
    ) 
    REFERENCES EstanteOrganizador 
    ( 
     EstanteOrganizador 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Estantería 
    ADD CONSTRAINT Estantería_Inventario_FK FOREIGN KEY 
    ( 
     InventarioID, 
     AutoparteID
    ) 
    REFERENCES Inventario 
    ( 
     InventarioID , 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Existencia 
    ADD CONSTRAINT Existencia_MateriaPrima_FK FOREIGN KEY 
    ( 
     MateriaPrimaID
    ) 
    REFERENCES MateriaPrima 
    ( 
     MateriaPrimaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Factura 
    ADD CONSTRAINT Factura_FormaPago_FK FOREIGN KEY 
    ( 
     FormaPagoID
    ) 
    REFERENCES FormaPago 
    ( 
     FormaPagoID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Factura 
    ADD CONSTRAINT Factura_Pedido_FK FOREIGN KEY 
    ( 
     PedidoID, 
     ClienteID
    ) 
    REFERENCES Pedido 
    ( 
     PedidoID , 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Factura 
    ADD CONSTRAINT Factura_Usuario_FK FOREIGN KEY 
    ( 
     UsuarioID
    ) 
    REFERENCES Usuario 
    ( 
     UsuarioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE HistorialDescuento 
    ADD CONSTRAINT HistorialDescuento_HistorialPrecio_FK FOREIGN KEY 
    ( 
     HistorialPrecioID
    ) 
    REFERENCES HistorialPrecio 
    ( 
     HistorialPrecioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE HistorialPrecio 
    ADD CONSTRAINT HistorialPrecio_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Inventario 
    ADD CONSTRAINT Inventario_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE MaterialAutoparte 
    ADD CONSTRAINT MaterialAutoparte_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE MaterialAutoparte 
    ADD CONSTRAINT MaterialAutoparte_MateriaPrima_FK FOREIGN KEY 
    ( 
     MateriaPrimaID
    ) 
    REFERENCES MateriaPrima 
    ( 
     MateriaPrimaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Movimiento 
    ADD CONSTRAINT Movimiento_MateriaPrima_FK FOREIGN KEY 
    ( 
     MateriaPrimaID
    ) 
    REFERENCES MateriaPrima 
    ( 
     MateriaPrimaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Municipio 
    ADD CONSTRAINT Municipio_Departamento_FK FOREIGN KEY 
    ( 
     DepartamentoID
    ) 
    REFERENCES Departamento 
    ( 
     DepartamentoID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Pedido 
    ADD CONSTRAINT Pedido_Cliente_FK FOREIGN KEY 
    ( 
     ClienteID
    ) 
    REFERENCES Cliente 
    ( 
     ClienteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Perdida 
    ADD CONSTRAINT Perdida_Autoparte_FK FOREIGN KEY 
    ( 
     AutoparteID
    ) 
    REFERENCES Autoparte 
    ( 
     AutoparteID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE ProveedorJurídico 
    ADD CONSTRAINT ProveedorJurídico_Proveedor_FK FOREIGN KEY 
    ( 
     ProveedorID
    ) 
    REFERENCES Proveedor 
    ( 
     ProveedorID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE ProveedorNatural 
    ADD CONSTRAINT ProveedorNatural_Proveedor_FK FOREIGN KEY 
    ( 
     ProveedorID
    ) 
    REFERENCES Proveedor 
    ( 
     ProveedorID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Subcategoría 
    ADD CONSTRAINT Subcategoría_Categoría_FK FOREIGN KEY 
    ( 
     CategoríaID
    ) 
    REFERENCES Categoría 
    ( 
     CategoríaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE TelefonoFabrica 
    ADD CONSTRAINT TelefonoFabrica_Fabrica_FK FOREIGN KEY 
    ( 
     FabricaID
    ) 
    REFERENCES Fabrica 
    ( 
     FabricaID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE TélefonoProveedor 
    ADD CONSTRAINT TélefonoProveedor_Proveedor_FK FOREIGN KEY 
    ( 
     ProveedorID
    ) 
    REFERENCES Proveedor 
    ( 
     ProveedorID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE TelefonoUsuario 
    ADD CONSTRAINT TelefonoUsuario_Usuario_FK FOREIGN KEY 
    ( 
     UsuarioID
    ) 
    REFERENCES Usuario 
    ( 
     UsuarioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE UsuarioCargo 
    ADD CONSTRAINT UsuarioCargo_Cargo_FK FOREIGN KEY 
    ( 
     CargoID
    ) 
    REFERENCES Cargo 
    ( 
     CargoID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE UsuarioCargo 
    ADD CONSTRAINT UsuarioCargo_Usuario_FK FOREIGN KEY 
    ( 
     UsuarioID
    ) 
    REFERENCES Usuario 
    ( 
     UsuarioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Vía 
    ADD CONSTRAINT Vía_Barrio_FK FOREIGN KEY 
    ( 
     BarrioID
    ) 
    REFERENCES Barrio 
    ( 
     BarrioID 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO


