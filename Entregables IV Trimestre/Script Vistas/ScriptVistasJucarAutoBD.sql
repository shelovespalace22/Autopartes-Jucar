USE JucarAutoBD;

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

