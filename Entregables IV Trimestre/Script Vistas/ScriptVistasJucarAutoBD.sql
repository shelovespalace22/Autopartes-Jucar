USE JucarAutoBD;

GO

-- ***** REPORTE AUTOPARTES *****

CREATE VIEW ReporteAutopartes 

AS
SELECT A.AutoparteID, A.Nombre, C.NombreCategoría, SC.NombreSubCat, P.Motivo, P.Lugar, HP.Valor, HD.PorcentajeDescuento, I.CantidadDisponible, MP.NombreMateriaPrima
FROM Autoparte A
LEFT JOIN Subcategoría SC ON A.SubcategoríaID = SC.SubcategoríaID AND A.CategoríaID = SC.CategoríaID
LEFT JOIN Categoría C ON A.CategoríaID = C.CategoríaID
LEFT JOIN HistorialPrecio HP ON A.AutoparteID = HP.AutoparteID
LEFT JOIN HistorialDescuento HD ON HP.HistorialPrecioID = HD.HistorialPrecioID
LEFT JOIN Perdida P ON A.AutoparteID = P.AutoparteID
LEFT JOIN Inventario I ON A.AutoparteID = I.AutoparteID
LEFT JOIN MaterialAutoparte MA ON A.AutoparteID = MA.AutoparteID
LEFT JOIN MateriaPrima MP ON MA.MateriaPrimaID = MP.MateriaPrimaID;

GO

-- ***** REPORTE MATERIAS PRIMAS *****

CREATE VIEW ReporteMateriasPrimas 

AS
SELECT MP.NombreMateriaPrima, E.CantidadDisponible, E.ExistenciasIniciales, E.PuntoReorden, E.InventarioMinimo, E.InventarioMáximo, M.Cantidad, M.TipoMovimiento
FROM MateriaPrima MP
JOIN Existencia E ON MP.MateriaPrimaID = E.MateriaPrimaID
JOIN Movimiento M ON MP.MateriaPrimaID = M.MateriaPrimaID;

GO

-- ***** REPORTE PEDIDOS *****

CREATE VIEW ReportePedidos 

AS
SELECT 
    CASE
        WHEN CJ.RazónSocial IS NOT NULL THEN CJ.RazónSocial
        ELSE CONCAT(CN.PrimerNombre, ' ', CN.SegundoNombre, ' ', CN.PrimerApellido, ' ', CN.SegundoApellido)
    END AS NombreCliente,
    CASE
        WHEN CJ.NIT IS NOT NULL THEN CJ.NIT
        ELSE CN.NumDoc
    END AS Documento,
    P.PedidoID,
    P.FechaCreación,
    DP.Producto,
    DP.Cantidad
FROM Pedido P
INNER JOIN Cliente C ON P.ClienteID = C.ClienteID
LEFT JOIN ClienteJurídico CJ ON C.ClienteID = CJ.ClienteID
LEFT JOIN ClienteNatural CN ON C.ClienteID = CN.ClienteID
INNER JOIN DetallePedido DP ON P.PedidoID = DP.PedidoID AND P.ClienteID = DP.ClienteID;

GO

-- ***** REPORTE VENTAS *****

CREATE VIEW ReporteVentas 

AS
SELECT
    U.PrimerNombre + ' ' + U.PrimerApellido AS NombreUsuario,
    CASE
        WHEN CJ.RazónSocial IS NOT NULL THEN CJ.RazónSocial
        ELSE CN.PrimerNombre + ' ' + CN.PrimerApellido + ' ' + CN.SegundoNombre + ' ' + CN.SegundoApellido
    END AS NombreCliente,
    FP.NombreFormaPago,
    MP.NombreMetodoPago,
    F.N_Factura,
    CASE
        WHEN CN.NumDoc IS NULL THEN 'N/N'
        ELSE F.CC
    END AS CC,
    CASE
        WHEN CJ.NIT IS NULL THEN 'N/N'
        ELSE F.NIT
    END AS NIT,
    F.TeléfonoCliente,
    CASE
        WHEN F.Observación IS NULL THEN 'Nada por observar'
        ELSE F.Observación
    END AS Observación,
    F.FechaCreación,
    F.FechaModificación
FROM Factura F
INNER JOIN Usuario U ON F.UsuarioID = U.UsuarioID
INNER JOIN Cliente C ON F.ClienteID = C.ClienteID
LEFT JOIN ClienteJurídico CJ ON C.ClienteID = CJ.ClienteID
LEFT JOIN ClienteNatural CN ON C.ClienteID = CN.ClienteID
INNER JOIN FormaPago FP ON F.FormaPagoID = FP.FormaPagoID
INNER JOIN MedioPago MP ON MP.MedioPagoID = F.FormaPagoID;

GO

-- ***** REPORTE PROVEEDORES *****

CREATE VIEW ReporteProveedores 

AS
SELECT
    CASE
        WHEN PJ.RazónSocial IS NOT NULL THEN PJ.RazónSocial
        ELSE PN.PrimerNombre + ' ' + PN.SegundoNombre + ' ' + PN.PrimeApellido + ' ' + PN.SegundoApellido
    END AS NombreProveedor,
    CASE
        WHEN PJ.NIT IS NOT NULL THEN PJ.NIT
        ELSE PN.NumDoc
    END AS Identificación,
    P.Correo,
    P.TipoProducto,
    TP.NumTélefono,
    D.Dirección,
    P.Estado,
    P.FechaCreación
FROM Proveedor P
LEFT JOIN ProveedorJurídico PJ ON P.ProveedorID = PJ.ProveedorID
LEFT JOIN ProveedorNatural PN ON P.ProveedorID = PN.ProveedorID
LEFT JOIN DireccionProveedor DP ON P.ProveedorID = DP.ProveedorID
LEFT JOIN Dirección D ON DP.DirecciónID = D.DirecciónID
LEFT JOIN TélefonoProveedor TP ON P.ProveedorID = TP.ProveedorID;

GO

-- ***** REPORTE USUARIOS *****

CREATE VIEW ReporteUsuarios 

AS
SELECT
    U.PrimerNombre + ' ' + U.SegundoNombre + ' ' + U.PrimerApellido + ' ' + U.SegundoApellido AS Nombre,
    U.DirecciónCorreo AS Correo,
    CASE
        WHEN U.Sexo = 'Masculino' THEN 'M'
        WHEN U.Sexo = 'Femenino' THEN 'F'
        ELSE ''
    END AS Sexo,
    U.NombreUsuario,
    C.NombreCargo,
    TU.NumTélefono AS Telefono,
    D.Dirección
FROM Usuario U
LEFT JOIN UsuarioCargo UC ON U.UsuarioID = UC.UsuarioID
LEFT JOIN Cargo C ON UC.CargoID = C.CargoID
LEFT JOIN DireccionUsuario DU ON U.UsuarioID = DU.UsuarioID
LEFT JOIN Dirección D ON DU.DirecciónID = D.DirecciónID
LEFT JOIN TelefonoUsuario TU ON U.UsuarioID = TU.UsuarioID;

GO

-- ***** AUTOPARTES CON SU PRECIO Y CANTIDAD DISPONIBLE ACTUAL *****

CREATE VIEW VISTA1

AS
SELECT 
A.Nombre AS Autoparte,
HP.Valor,
I.CantidadDisponible
FROM Autoparte AS A
INNER JOIN HistorialPrecio AS HP ON A.AutoparteID = HP.AutoparteID
INNER JOIN Inventario AS I ON A.AutoparteID = I.AutoparteID
WHERE HP.FechaModificación = GETDATE() AND I.FechaModificación = GETDATE()

GO

-- ***** AUTOPARTES CON DESCUENTO 

CREATE VIEW VISTA2

AS
SELECT 
A.Nombre AS Autoparte,
HP.Valor AS PrecioNormal,
HD.PorcentajeDescuento AS Descuento,
HD.ValorTemporal AS PrecioDescuento
FROM Autoparte AS A
INNER JOIN HistorialPrecio AS HP ON A.AutoparteID = HP.AutoparteID
INNER JOIN HistorialDescuento AS HD ON HP.HistorialPrecioID = HD.HistorialPrecioID
WHERE HD.Estado = 'Activo/a'

GO

-- ***** AUTOPARTES CON SU CATEGORIA/SUBCATEGORIA

CREATE VIEW VISTA3

AS
SELECT 
A.Nombre AS Autoparte,
S.NombreSubCat AS Categoría
FROM Categoría AS C
INNER JOIN Subcategoría AS S ON C.CategoríaID = S.CategoríaID
INNER JOIN Autoparte AS A ON C.CategoríaID = A.CategoríaID

GO

-- ***** USUARIOS Y SU CARGO

CREATE VIEW VISTA4

AS
SELECT 
U.PrimerNombre AS Nombre,
U.PrimerApellido AS Apellido,
U.DirecciónCorreo AS Email,
C.NombreCargo AS Cargo
FROM UsuarioCargo AS UC
INNER JOIN Usuario AS U ON UC.UsuarioID = U.UsuarioID
INNER JOIN Cargo AS C ON UC.CargoID = C.CargoID

GO

-- ***** PROVEEDORES CON SU TELEFONO Y DIRECCION

CREATE VIEW VISTA5

AS
SELECT 
P.ProveedorID AS ID,
CASE
	WHEN PJ.RazónSocial = NULL THEN 'NoJuridico'
	ELSE PJ.RazónSocial
END AS NombreJuridico,
CASE
	WHEN PN.PrimerNombre = NULL THEN 'NoNatural'
	ELSE CONCAT(PN.PrimerNombre, ' ', PN.PrimeApellido)
END AS ProveedorNatural,
TP.NumTélefono AS NumeroTel,
D.Ciudad AS Ciudad,
D.Barrio AS Barrio,
D.Dirección AS Direccion
FROM Proveedor AS P 
INNER JOIN ProveedorJurídico AS PJ ON P.ProveedorID = PJ.ProveedorID
INNER JOIN ProveedorNatural AS PN ON P.ProveedorID = PN.ProveedorID
INNER JOIN TélefonoProveedor AS TP ON P.ProveedorID = TP.ProveedorID
INNER JOIN DireccionProveedor AS DP ON P.ProveedorID = DP.ProveedorID
INNER JOIN Dirección AS D ON D.DirecciónID = DP.DirecciónID

GO

-- ***** EXISTENCIA DE MATERIASPRIMAS

CREATE VIEW VISTA6

AS
SELECT 
MP.NombreMateriaPrima AS Materia,
E.CantidadDisponible AS Existencia,
E.FechaModificación AS UltimaActualización
FROM MateriaPrima AS MP
INNER JOIN Existencia AS E ON MP.MateriaPrimaID = E.MateriaPrimaID
WHERE E.FechaModificación = GETDATE()

GO

-- ***** MOVIMIENTOS DE MATERIASPRIMAS

CREATE VIEW VISTA7

AS
SELECT 
MP.NombreMateriaPrima,
M.TipoMovimiento,
M.Cantidad,
M.FechaMovimiento
FROM MateriaPrima AS MP
INNER JOIN Movimiento AS M ON MP.MateriaPrimaID = M.MateriaPrimaID

GO

-- ***** PERDIDA DE AUTOPARTES

CREATE VIEW VISTA8

AS
SELECT 
A.Nombre AS Autoparte,
P.CantidadPerdida AS Cuanto,
P.Motivo AS Como,
P.FechaPerdida AS Cuando,
P.Lugar AS Donde
FROM Autoparte AS A
INNER JOIN Perdida AS P ON A.AutoparteID = P.AutoparteID

GO

