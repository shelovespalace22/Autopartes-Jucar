USE JucarAutoBD;

GO
-- ***** CRUD DEPARTAMENTO *****

CREATE PROCEDURE CRUD_Departamento
(
    @Operation NVARCHAR(10),
    @DepartamentoID INT = NULL,
    @Nombre VARCHAR(50) = NULL,
    @Capital VARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Departamento (Nombre, Capital, FechaCreación, FechaModificación)
        VALUES (@Nombre, @Capital, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Departamento WHERE DepartamentoID = @DepartamentoID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Departamento
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Departamento
        SET Nombre = @Nombre,
            Capital = @Capital,
            FechaModificación = GETDATE()
        WHERE DepartamentoID = @DepartamentoID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Departamento WHERE DepartamentoID = @DepartamentoID;
    END
END

GO

-- ***** CRUD MUNICIPIOS *****

CREATE PROCEDURE CRUD_Municipio
(
    @Operation NVARCHAR(10),
    @MunicipioID INT = NULL,
    @DepartamentoID INT = NULL,
    @Nombre VARCHAR(50) = NULL,
    @Capital BIT = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Municipio (DepartamentoID, Nombre, Capital, FechaCreación, FechaModificación)
        VALUES (@DepartamentoID, @Nombre, @Capital, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Municipio WHERE MunicipioID = @MunicipioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Municipio;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Municipio
        SET DepartamentoID = @DepartamentoID,
            Nombre = @Nombre,
            Capital = @Capital,
            FechaModificación = GETDATE()
        WHERE MunicipioID = @MunicipioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Municipio WHERE MunicipioID = @MunicipioID;
    END
END

GO

-- ***** CRUD BARRIO *****

CREATE PROCEDURE CRUD_Barrio
(
    @Operation NVARCHAR(10),
	@BarrioID INT = NULL,
    @MunicipioID INT = NULL,
    @Nombre VARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Barrio(MunicipioID, Nombre, FechaCreación, FechaModificación)
        VALUES (@MunicipioID, @Nombre, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Barrio WHERE BarrioID = @BarrioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Barrio;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Barrio
        SET MunicipioID = @MunicipioID,
            Nombre = @Nombre,
            FechaModificación = GETDATE()
        WHERE BarrioID = @BarrioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Barrio WHERE BarrioID = @BarrioID;
    END
END

GO

-- ***** CRUD VIA *****

CREATE PROCEDURE CRUD_Via
(
    @Operation NVARCHAR(10),
	@ViaID INT = NULL,
    @BarrioID INT = NULL,
    @TipoCalle VARCHAR(50) = NULL,
	@Calle VARCHAR(3) = NULL,
	@Sufijo VARCHAR (10) NULL,
	@Num1 VARCHAR (3) NULL,
	@Num2 VARCHAR (3) NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Vía (BarrioID, TipoCalle, Calle, Sufijo, Número1, Número2, FechaCreación, FechaModificación)
        VALUES (@BarrioID, @TipoCalle, @Calle, @Sufijo, @Num1, @Num2, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Vía WHERE VíaID = @ViaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Vía;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Vía
        SET BarrioID = @BarrioID,
            TipoCalle = @TipoCalle,
			Calle = @Calle,
			Sufijo = @Sufijo,
			Número1 = @Num1,
			Número2 = @Num2,
            FechaModificación = GETDATE()
        WHERE VíaID = @ViaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Vía WHERE VíaID = @ViaID;
    END
END

GO

-- **** CRUD DESTINATARIO *****

CREATE PROCEDURE CRUD_Destinatario
(
    @Operation NVARCHAR(10),
	@DestinatarioID INT = NULL,
    @PrimerNombre VARCHAR(50) = NULL,
    @SegundoNombre VARCHAR(50) = NULL,
	@PrimerApellido VARCHAR(50) = NULL,
	@SegundoApellido VARCHAR (50) NULL,
	@TipoDoc VARCHAR (20) NULL,
	@NumDoc VARCHAR (10) NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Destinatario (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, TipoDoc, NumDoc, FechaCreación, FechaModificación)
        VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @TipoDoc, @NumDoc, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Destinatario WHERE DestinatarioID = @DestinatarioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Destinatario;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Destinatario
        SET PrimerNombre = @PrimerNombre,
            SegundoNombre = @SegundoNombre,
			PrimerApellido = @PrimerApellido,
			SegundoApellido = @SegundoApellido,
			TipoDoc = @TipoDoc,
			NumDoc = @NumDoc,
            FechaModificación = GETDATE()
        WHERE DestinatarioID = @DestinatarioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Destinatario WHERE DestinatarioID = @DestinatarioID;
    END
END

GO

-- ***** CRUD EDIFICIO *****

CREATE PROCEDURE CRUD_Edificio
(
    @Operation NVARCHAR(10),
	@EdificioID INT = NULL,
    @TipoEdificio VARCHAR(50) = NULL,
    @NumEdificio VARCHAR(50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Edificio (TipoEdificio, NumEdificio, FechaCreación, FechaModificación)
        VALUES (@TipoEdificio, @NumEdificio, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Edificio WHERE EdificioID = @EdificioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Edificio;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Edificio
        SET TipoEdificio = @TipoEdificio,
            NumEdificio = @NumEdificio,
            FechaModificación = GETDATE()
        WHERE EdificioID = @EdificioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Edificio WHERE EdificioID = @EdificioID;
    END
END

GO

-- **** CRUD TIPODIRECCION *****

CREATE PROCEDURE CRUD_TipoDirección
(
    @Operation NVARCHAR(10),
	@TipoDireccionID INT = NULL,
    @Tipo VARCHAR(20) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO TipoDirección (Tipo, FechaCreación, FechaModificación)
        VALUES (@Tipo, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM TipoDirección WHERE TipoDirecciónID = @TipoDireccionID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM TipoDirección;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE TipoDirección
        SET Tipo = @Tipo,
            FechaModificación = GETDATE()
        WHERE TipoDirecciónID = @TipoDireccionID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM TipoDirección WHERE TipoDirecciónID = @TipoDireccionID;
    END
END

GO

-- ***** CRUD DIRECCION *****

CREATE PROCEDURE CRUD_Direccion
(
    @Operation NVARCHAR(10),
	@DireccionID INT = NULL,
	@TipoDireccionID INT = NULL,
	@ViaID INT = NULL,
	@EdificioID INT = NULL,
	@DestinatarioID INT = NULL,
	@Pais VARCHAR (30) = NULL,
	@Departamento VARCHAR (30) = NULL,
	@Municipio VARCHAR (30) = NULL,
	@Ciudad VARCHAR (30) = NULL,
	@Localidad VARCHAR (30) = NULL,
	@Barrio VARCHAR (30) = NULL,
	@Direccion VARCHAR (30) = NULL,
	@InfoAd VARCHAR (200) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Dirección (TipoDirecciónID, VíaID, EdificioID, DestinatarioID, País, Departamento, 
			Municipio, Ciudad, Localidad, Barrio, Dirección, InformaciónAdicional, FechaCreación, FechaModificación)
        VALUES (@TipoDireccionID, @ViaID, @EdificioID, @DestinatarioID, @Pais, @Departamento, @Municipio, @Ciudad, 
			@Localidad, @Barrio, @Direccion, @InfoAd, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Dirección WHERE DirecciónID = @DireccionID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Dirección;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Dirección
        SET TipoDirecciónID = @TipoDireccionID,
            VíaID = @ViaID,
			EdificioID = @EdificioID,
			DestinatarioID = @DestinatarioID,
			País = @Pais,
			Departamento = @Departamento,
			Municipio = @Municipio,
			Ciudad = @Ciudad,
			Localidad = @Localidad,
			Barrio = @Barrio,
			Dirección = @Direccion,
			InformaciónAdicional = @InfoAd,
            FechaModificación = GETDATE()
        WHERE DirecciónID = @DireccionID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Dirección WHERE DirecciónID = @DireccionID;
    END
END

GO

-- ***** CRUD CATEGORIA *****

CREATE PROCEDURE CRUD_Categoria
(
    @Operation NVARCHAR(10),
	@CategoriaID INT = NULL,
	@NomCat VARCHAR (40) = NULL,
	@Estado VARCHAR (10) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Categoría(NombreCategoría, Estado, FechaCreación, FechaModificación)
        VALUES (@NomCat, 'Activo/a', GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Categoría WHERE CategoríaID = @CategoriaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Categoría;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Categoría
        SET NombreCategoría = @NomCat,
			Estado = @Estado,
            FechaModificación = GETDATE()
        WHERE CategoríaID = @CategoriaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Categoría WHERE CategoríaID = @CategoriaID;
    END
END

GO

-- ***** CRUD SUBCATEGORIA *****

CREATE PROCEDURE CRUD_Subcategoria
(
    @Operation NVARCHAR(10),
	@SubcategoriaID INT = NULL,
	@CategoriaID INT = NULL,
	@NomSubc VARCHAR (10) = NULL,
	@Estado VARCHAR (10) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Subcategoría (CategoríaID, NombreSubCat, Estado, FechaCreación, FechaModificación)
        VALUES (@CategoriaID, @NomSubc, 'Activo/a', GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Subcategoría WHERE SubcategoríaID = @SubcategoriaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Subcategoría;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Subcategoría
        SET CategoríaID = @CategoriaID,
			NombreSubCat = @NomSubc,
			Estado = @Estado,
            FechaModificación = GETDATE()
        WHERE SubcategoríaID = @SubcategoriaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Subcategoría WHERE SubcategoríaID = @SubcategoriaID;
    END
END

GO

-- ***** CRUD AUTOPARTE *****

CREATE PROCEDURE CRUD_Autoparte
(
    @Operation NVARCHAR(10),
	@AutoparteID INT = NULL,
	@CategoriaID INT = NULL,
	@SubcategoriaID INT = NULL,
	@Nombre VARCHAR (30) = NULL,
	@Funcion VARCHAR (30) = NULL,
	@ZonaV VARCHAR (30) = NULL,
	@Estado VARCHAR (10) = NULL,
	@PesoKgs VARCHAR (3) = NULL,
	@AltoCm VARCHAR (3) = NULL,
	@LargoCm VARCHAR (3) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Autoparte (CategoríaID, SubcategoríaID, Nombre, Función, 
			ZonaVehículo, Estado, PesoKgs, AltoCm, LargoCm, FechaCreación, FechaModificación)
        VALUES (@CategoriaID, @SubcategoriaID, @Nombre, @Funcion, @ZonaV, @Estado, @PesoKgs, 
			@AltoCm, @LargoCm, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Autoparte WHERE AutoparteID = @AutoparteID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Autoparte;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Autoparte
        SET CategoríaID = @CategoriaID,
			SubcategoríaID = @SubcategoriaID,
			Nombre = @Nombre,
			Función = @Funcion,
			ZonaVehículo = @ZonaV,
			Estado = @Estado,
			PesoKgs = @PesoKgs,
			AltoCm = @AltoCm,
			LargoCm = @LargoCm,
            FechaModificación = GETDATE()
        WHERE AutoparteID = @AutoparteID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Autoparte WHERE AutoparteID = @AutoparteID;
    END
END

GO

-- ***** CRUD HISTORIALPRECIO *****

CREATE PROCEDURE CRUD_HistorialPrecio
(
    @Operation NVARCHAR(10),
	@HistorialPrecioID INT = NULL,
	@AutoparteID INT = NULL,
	@Valor BIGINT = NULL,
	@Estado VARCHAR (10) = NULL,
	@FechaInicial DATE = NULL,
	@FechaFinal DATE = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO HistorialPrecio (AutoparteID, Valor, Estado, FechaIniciialPrecio,
			FechaCreación, FechaModificación)
        VALUES (@AutoparteID, @Valor, @Estado, @FechaInicial, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM HistorialPrecio WHERE HistorialPrecioID = @HistorialPrecioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM HistorialPrecio;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE HistorialPrecio
        SET AutoparteID = @AutoparteID,
			Valor = @Valor,
			Estado = @Estado,
			FechaIniciialPrecio = @FechaInicial,
			FechaFinalPrecio = @FechaFinal,
            FechaModificación = GETDATE()
        WHERE HistorialPrecioID = @HistorialPrecioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM HistorialPrecio WHERE HistorialPrecioID = @HistorialPrecioID;
    END
END

GO

-- ***** CRUD HISTORIALDESCUENTO *****

CREATE PROCEDURE CRUD_HistorialDescuento
(
    @Operation NVARCHAR(10),
	@HistorialDescuentoID INT = NULL,
	@HistorialPrecioID INT = NULL,
	@PorDes BIGINT = NULL,
	@ValTemp BIGINT = NULL,
	@Estado VARCHAR (10) = NULL,
	@FechaInicial DATE = NULL,
	@FechaFinal DATE = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO HistorialDescuento (HistorialPrecioID, PorcentajeDescuento, ValorTemporal, Estado, FechaInicialDescuento,
			FechaCreación, FechaModificación)
        VALUES (@HistorialPrecioID, @PorDes, @ValTemp, @Estado, @FechaInicial, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM HistorialDescuento WHERE HistorialDescuentoID = @HistorialDescuentoID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM HistorialDescuento;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE HistorialDescuento
        SET @HistorialPrecioID = @HistorialPrecioID,
			PorcentajeDescuento = @PorDes,
			ValorTemporal = @ValTemp,
			Estado = @Estado,
			FechaInicialDescuento = @FechaInicial,
			FechaFinalDescuento = @FechaFinal,
            FechaModificación = GETDATE()
        WHERE HistorialDescuentoID = @HistorialDescuentoID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM HistorialDescuento WHERE HistorialDescuentoID = @HistorialDescuentoID;
    END
END

GO

-- ***** CRUD PERDIDA *****

CREATE PROCEDURE CRUD_Perdida
(
    @Operation NVARCHAR(10),
	@PerdidaID INT = NULL,
	@AutoparteID INT = NULL,
	@Motivo VARCHAR (20) = NULL,
	@Lugar VARCHAR (50) = NULL,
	@Responsable VARCHAR (30) = NULL,
	@FechaPerdida DATE = NULL,
	@Cantidad VARCHAR (5) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Perdida (AutoparteID, Motivo, Lugar, ResponsablePerdida, FechaPerdida, 
			CantidadPerdida, FechaCreación, FechaModificación)
        VALUES (@AutoparteID, @Motivo, @Lugar, @Responsable, @FechaPerdida, @Cantidad, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Perdida WHERE PerdidaID = @PerdidaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Perdida;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Perdida
        SET AutoparteID = @AutoparteID,
			Motivo = @Motivo,
			Lugar = @Lugar,
			ResponsablePerdida = @Responsable,
			FechaPerdida = @FechaPerdida,
			CantidadPerdida = @Cantidad,
            FechaModificación = GETDATE()
        WHERE PerdidaID = @PerdidaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Perdida WHERE PerdidaID = @PerdidaID;
    END
END

GO

-- ***** CRUD INVENTARIO *****

CREATE PROCEDURE CRUD_Inventario
(
    @Operation NVARCHAR(10),
	@InventarioID INT = NULL,
	@AutoparteID INT = NULL,
	@CantDispo VARCHAR (5) = NULL,
	@ExtIni VARCHAR (5) = NULL,
	@InvMax VARCHAR (5) = NULL,
	@InvMin VARCHAR (5) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Inventario (AutoparteID, CantidadDisponible, ExistenciasIniciales, InventarioMáx,
			InventarioMin, FechaCreación, FechaModificación)
        VALUES (@AutoparteID, @CantDispo, @ExtIni, @InvMax, @InvMin, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Inventario WHERE InventarioID = @InventarioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Inventario;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Inventario
        SET AutoparteID = @AutoparteID,
			CantidadDisponible = @CantDispo,
			ExistenciasIniciales = @ExtIni,
			InventarioMáx = @InvMax,
			InventarioMin = @InvMin,
            FechaModificación = GETDATE()
        WHERE InventarioID = @InventarioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Inventario WHERE InventarioID = @InventarioID;
    END
END

GO

-- ***** CRUD MATERIAPRIMA *****

CREATE PROCEDURE CRUD_Materiprima
(
    @Operation NVARCHAR(10),
	@MateriaPrimaID INT = NULL,
	@Tipo VARCHAR (20) = NULL,
	@Nombre VARCHAR (30) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO MateriaPrima (TipoMateriaPrima, NombreMateriaPrima, FechaCreación, FechaModificación)
        VALUES (@Tipo, @Nombre, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM MateriaPrima WHERE MateriaPrimaID = @MateriaPrimaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM MateriaPrima;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE MateriaPrima
        SET TipoMateriaPrima = @Tipo,
			NombreMateriaPrima = @Nombre,
            FechaModificación = GETDATE()
        WHERE MateriaPrimaID = @MateriaPrimaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM MateriaPrima WHERE MateriaPrimaID = @MateriaPrimaID;
    END
END

GO

-- ***** CRUD EXISTENCIA *****

CREATE PROCEDURE CRUD_Existencia
(
    @Operation NVARCHAR(10),
	@ExistenciaID INT = NULL,
	@MateriaPrimaID INT = NULL,
	@CantDispo VARCHAR (3) = NULL,
	@Existencias VARCHAR (3) = NULL,
	@PuntoReorden VARCHAR (3) = NULL,
	@InvMin VARCHAR (3) = NULL,
	@InvMax VARCHAR (3) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Existencia (MateriaPrimaID, CantidadDisponible, ExistenciasIniciales, PuntoReorden,
			InventarioMinimo, InventarioMáximo, FechaCreación, FechaModificación)
        VALUES (@MateriaPrimaID, @CantDispo, @Existencias, @PuntoReorden, @InvMin, @InvMax, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Existencia WHERE ExistenciaID = @ExistenciaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Existencia;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Existencia
        SET MateriaPrimaID = @MateriaPrimaID,
			CantidadDisponible = @CantDispo,
			ExistenciasIniciales = @Existencias,
			PuntoReorden = @PuntoReorden,
			InventarioMinimo = @InvMin,
			InventarioMáximo = @InvMax,
            FechaModificación = GETDATE()
        WHERE ExistenciaID = @ExistenciaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Existencia WHERE ExistenciaID = @ExistenciaID;
    END
END

GO

-- ***** CRUD MOVIMIENTO *****

CREATE PROCEDURE CRUD_Movimiento
(
    @Operation NVARCHAR(10),
	@MovimientoID INT = NULL,
	@MateriaPrimaID INT = NULL,
	@Cantidad INT = NULL,
	@TipoMovimiento VARCHAR (15) = NULL,
	@FechaMovimiento DATE = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Movimiento (MateriaPrimaID, Cantidad, TipoMovimiento, FechaMovimiento, FechaCreación, FechaModificación)
        VALUES (@MateriaPrimaID, @Cantidad, @TipoMovimiento, @FechaMovimiento, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Movimiento WHERE MovimientoID = @MovimientoID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Movimiento;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Movimiento
        SET MateriaPrimaID = @MateriaPrimaID,
			Cantidad = @Cantidad,
			TipoMovimiento = @TipoMovimiento,
			FechaMovimiento = @FechaMovimiento,
            FechaModificación = GETDATE()
        WHERE MovimientoID = @MovimientoID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Movimiento WHERE MovimientoID = @MovimientoID;
    END
END

GO

-- ***** CRUD MATERIALAUTOPARTE *****

CREATE PROCEDURE CRUD_MaterialAutoparte
(
    @Operation NVARCHAR(10),
	@MaterialAutoparteID INT = NULL,
	@MateriaPrimaID INT = NULL,
	@AutoparteID INT = NULL, 
	@Composicion VARCHAR (50) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO MaterialAutoparte (MateriaPrimaID, AutoparteID, ComposiciónAutoparte, FechaCreación, FechaModificación)
        VALUES (@MateriaPrimaID, @AutoparteID, @Composicion, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM MaterialAutoparte WHERE MaterialAutoparteID = @MaterialAutoparteID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM MaterialAutoparte;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE MaterialAutoparte
        SET MateriaPrimaID = @MateriaPrimaID,
			AutoparteID = @AutoparteID,
			ComposiciónAutoparte = @Composicion,
            FechaModificación = GETDATE()
        WHERE MaterialAutoparteID = @MaterialAutoparteID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM MaterialAutoparte WHERE MaterialAutoparteID = @MaterialAutoparteID;
    END
END

GO

-- ***** CRUD FABRICA *****

CREATE PROCEDURE CRUD_Fabrica
(
    @Operation NVARCHAR(10),
	@FabricaID INT = NULL,
	@NIT VARCHAR (9) = NULL,
	@RazonSocial VARCHAR (30) = NULL,
	@Email VARCHAR (30) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Fabrica (NIT, RazónSocial, DirecciónEmail, FechaCreación, FechaModificación)
        VALUES (@NIT, @RazonSocial, @Email, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Fabrica WHERE FabricaID = @FabricaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Fabrica;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Fabrica
        SET NIT = @NIT,
			RazónSocial = @RazonSocial,
			DirecciónEmail = @Email,
            FechaModificación = GETDATE()
        WHERE FabricaID = @FabricaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Fabrica WHERE FabricaID = @FabricaID;
    END
END

GO

-- ***** CRUD TELEFONOFABRICA *****

CREATE PROCEDURE CRUD_TelefonoFabrica
(
    @Operation NVARCHAR(10),
	@TelefonoFabricaID INT = NULL,
	@FabricaID INT = NULL,
	@Tipo VARCHAR (20) = NULL,
	@Num VARCHAR (10) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO TelefonoFabrica (FabricaID, TipoTélefono, NumTeléfono, FechaCreación, FechaModificación)
        VALUES (@FabricaID, @Tipo, @Num, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM TelefonoFabrica WHERE TelefonoFabricaID = @TelefonoFabricaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM TelefonoFabrica;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE TelefonoFabrica
        SET FabricaID = @FabricaID,
			TipoTélefono = @Tipo,
			NumTeléfono = @Num,
            FechaModificación = GETDATE()
        WHERE TelefonoFabricaID = @TelefonoFabricaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM TelefonoFabrica WHERE TelefonoFabricaID = @TelefonoFabricaID;
    END
END

GO

-- ***** CRUD BODEGA *****

CREATE PROCEDURE CRUD_Bodega
(
    @Operation NVARCHAR(10),
	@BodegaID INT = NULL,
	@FabricaID INT = NULL,
	@Nombre VARCHAR (30) = NULL,
	@Estado VARCHAR (10) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Bodega (FabricaID, Nombre, Estado, FechaCreación, FechaModificación)
        VALUES (@FabricaID, @Nombre, @Estado, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Bodega WHERE BodegaID = @BodegaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Bodega;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Bodega
        SET FabricaID = @FabricaID,
			Nombre = @Nombre,
			Estado = @Estado,
            FechaModificación = GETDATE()
        WHERE BodegaID = @BodegaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Bodega WHERE BodegaID = @BodegaID;
    END
END

GO

-- ***** CRUD ESTANTEORGANIZADOR *****

CREATE PROCEDURE CRUD_EstanteOrganizador
(
    @Operation NVARCHAR(10),
	@EstanteOrganizadorID INT = NULL,
	@FabricaID INT = NULL,
	@BodegaID INT = NULL,
	@Material VARCHAR (30) = NULL,
	@Color VARCHAR (30) = NULL,
	@Capacidad VARCHAR (5) = NULL,
	@AltoCm VARCHAR (3) = NULL,
	@LargoCm VARCHAR (3) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO EstanteOrganizador (FabricaID, BodegaID, Material, Color, CapacidadMáxKgs, 
			AltoCm, LargoCm, FechaCreación, FechaModificación)
        VALUES (@FabricaID, @BodegaID, @Material, @Color, @Capacidad, @AltoCm, @LargoCm, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM EstanteOrganizador WHERE EstanteOrganizador = @EstanteOrganizadorID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM EstanteOrganizador;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE EstanteOrganizador
        SET FabricaID = @FabricaID,
			BodegaID = @BodegaID,
			Material = @Material,
			Color = @Color,
			CapacidadMáxKgs = @Capacidad,
			AltoCm = @AltoCm,
			LargoCm = @LargoCm,
            FechaModificación = GETDATE()
        WHERE EstanteOrganizador = @EstanteOrganizadorID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM EstanteOrganizador WHERE EstanteOrganizador = @EstanteOrganizadorID;
    END
END

GO

-- ***** CRUD ESTANTERIA *****

CREATE PROCEDURE CRUD_Estanteria
(
    @Operation NVARCHAR(10),
	@EstanteriaID INT = NULL,
	@EstanteOrganizadorID INT = NULL,
	@InventarioID INT = NULL,
	@AutoparteID INT = NULL,
	@Num VARCHAR (3) = NULL,
	@Tipo VARCHAR (20) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Estantería (EstanteOrganizadorID, InventarioID, AutoparteID, NumEstantería,
			TipoProducto, FechaCreación, FechaModificación)
        VALUES (@EstanteOrganizadorID, @InventarioID, @AutoparteID, @Num, @Tipo, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Estantería WHERE EstanteríaID = @EstanteriaID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Estantería;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Estantería
        SET EstanteOrganizadorID = EstanteOrganizadorID,
			InventarioID = @InventarioID,
			AutoparteID = @AutoparteID,
			NumEstantería = @Num,
			TipoProducto = @Tipo,
            FechaModificación = GETDATE()
        WHERE EstanteríaID = @EstanteriaID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Estantería WHERE EstanteríaID = @EstanteriaID;
    END
END

GO

-- ***** CRUD PROVEEDORJURIDICO *****

CREATE PROCEDURE CRUD_ProveedorJuridico
(
    @Operation NVARCHAR(10),
	@ProveedorID INT = NULL,
	@TipoProducto VARCHAR (30) = NULL,
	@Estado VARCHAR (10) = NULL,
	@Correo VARCHAR (30) = NULL,
	@RazonSocial VARCHAR (40) = NULL,
	@NIT VARCHAR (9) = NULL,
	@Representante VARCHAR (50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
		-- Variable para insertar en las dos tablas

        DECLARE @NewProveedorID INT

        -- Insertar en la tabla Proveedor para obtener el nuevo ProveedorID
        INSERT INTO Proveedor (TipoProducto, Estado, Correo, FechaCreación, FechaModificación)
        VALUES (@TipoProducto, @Estado, @Correo, GETDATE(), GETDATE());

        SET @NewProveedorID = SCOPE_IDENTITY();

        -- Insertar en la tabla ProveedorJuridico utilizando el nuevo ProveedorID
        INSERT INTO ProveedorJurídico (ProveedorID, RazónSocial, NIT, RepresentanteLegal)
        VALUES (@NewProveedorID, @RazonSocial, @NIT, @Representante);
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT P.*, PJ.RazónSocial, PJ.NIT, PJ.RepresentanteLegal
        FROM Proveedor AS P
        INNER JOIN ProveedorJurídico AS PJ ON P.ProveedorID = PJ.ProveedorID
        WHERE P.ProveedorID = @ProveedorID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT P.*, PJ.RazónSocial, PJ.NIT, PJ.RepresentanteLegal
		FROM Proveedor AS P
		INNER JOIN ProveedorJurídico AS PJ ON P.ProveedorID = PJ.ProveedorID;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE ProveedorJurídico
        SET 
            RazónSocial = @RazonSocial,
            NIT = @NIT,
            RepresentanteLegal = @Representante
        WHERE ProveedorID = @ProveedorID;

        -- Actualizar los campos correspondientes en la tabla Proveedor
        UPDATE Proveedor
        SET
            TipoProducto = @TipoProducto,
            Estado = @Estado,
            Correo = @Correo,
            FechaModificación = GETDATE()
        WHERE ProveedorID = @ProveedorID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM ProveedorJurídico WHERE ProveedorID = @ProveedorID;
        DELETE FROM Proveedor WHERE ProveedorID = @ProveedorID;
    END
END

GO

-- ***** CRUD PROVEEDORNATURAL *****

CREATE PROCEDURE CRUD_ProveedorNatural
(
    @Operation NVARCHAR(10),
	@ProveedorID INT = NULL,
	@TipoProducto VARCHAR (30) = NULL,
	@Estado VARCHAR (10) = NULL,
	@Correo VARCHAR (30) = NULL,
	@TipoDoc VARCHAR (20) = NULL,
	@NumDoc VARCHAR (10) = NULL,
	@PrimerN VARCHAR (30) = NULL,
	@SegundoN VARCHAR (30) = NULL,
	@PrimerA VARCHAR (30) = NULL,
	@SegundoA VARCHAR (50) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
		-- Variable para insertar en las dos tablas

        DECLARE @NewProveedorID INT

        -- Insertar en la tabla Proveedor para obtener el nuevo ProveedorID
        INSERT INTO Proveedor (TipoProducto, Estado, Correo, FechaCreación, FechaModificación)
        VALUES (@TipoProducto, @Estado, @Correo, GETDATE(), GETDATE());

        SET @NewProveedorID = SCOPE_IDENTITY();

        -- Insertar en la tabla ProveedorJuridico utilizando el nuevo ProveedorID
        INSERT INTO ProveedorNatural (ProveedorID, TipoDoc, NumDoc, PrimerNombre, SegundoNombre,
			PrimeApellido, SegundoApellido)
        VALUES (@NewProveedorID, @TipoDoc, @NumDoc, @PrimerN, @SegundoN, @PrimerA, @SegundoA);
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT P.*, PN.TipoDoc, PN.NumDoc, PN. PrimerNombre, PN.SegundoNombre, PN.PrimeApellido, PN.SegundoApellido
        FROM Proveedor AS P
        INNER JOIN ProveedorNatural AS PN ON P.ProveedorID = PN.ProveedorID
        WHERE P.ProveedorID = @ProveedorID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT P.*, PN.TipoDoc, PN.NumDoc, PN. PrimerNombre, PN.SegundoNombre, PN.PrimeApellido, PN.SegundoApellido
		FROM Proveedor AS P
		INNER JOIN ProveedorNatural AS PN ON P.ProveedorID = PN.ProveedorID;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE ProveedorNatural
        SET 
            TipoDoc = @TipoDoc,
            NumDoc = @NumDoc,
            PrimerNombre = @PrimerN,
			SegundoNombre = @SegundoN,
			PrimeApellido = @PrimerA,
			SegundoApellido = @SegundoA
        WHERE ProveedorID = @ProveedorID;

        -- Actualizar los campos correspondientes en la tabla Proveedor
        UPDATE Proveedor
        SET
            TipoProducto = @TipoProducto,
            Estado = @Estado,
            Correo = @Correo,
            FechaModificación = GETDATE()
        WHERE ProveedorID = @ProveedorID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM ProveedorNatural WHERE ProveedorID = @ProveedorID;
        DELETE FROM Proveedor WHERE ProveedorID = @ProveedorID;
    END
END

GO

-- ***** CRUD TELEFONOPROVEEDOR *****

CREATE PROCEDURE CRUD_TelefonoProveedor
(
    @Operation NVARCHAR(10),
	@TelefonoProveedorID INT = NULL,
	@ProveedorID INT = NULL,
	@TipoTelefono VARCHAR (30) = NULL,
	@NumTelefono VARCHAR (10) = NULL
)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO TélefonoProveedor (ProveedorID, TipoTélefono, NumTélefono, FechaCreación, FechaModificación)
        VALUES (@ProveedorID, @TipoTelefono, @NumTelefono, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM TélefonoProveedor WHERE TelefonoProveedorID = @TelefonoProveedorID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM TélefonoProveedor;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE TélefonoProveedor
        SET ProveedorID = @ProveedorID,
			TipoTélefono = @TipoTelefono,
			NumTélefono = @NumTelefono,
            FechaModificación = GETDATE()
        WHERE TelefonoProveedorID = @TelefonoProveedorID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM TélefonoProveedor WHERE TelefonoProveedorID = @TelefonoProveedorID;
    END
END

GO

-- ***** CRUD USUARIO *****

CREATE PROCEDURE CRUD_Usuario
(
    @Operation NVARCHAR(10),
	@UsuarioID INT = NULL,
	@PrimerN VARCHAR (30) = NULL,
	@SegundoN VARCHAR (30) = NULL,
	@PrimerA VARCHAR (30) = NULL,
	@SegundoA VARCHAR (30) = NULL,
	@Correo VARCHAR (30) = NULL,
	@Direccion VARCHAR (30) = NULL,
	@Sexo VARCHAR (15) = NULL,
	@Nacimiento DATE = NULL,
	@Estado VARCHAR (10) = NULL,
	@UserName VARCHAR (30) = NULL,
	@Password VARCHAR (100) = NULL

)
AS
BEGIN

    SET NOCOUNT ON;

    -- Crear un nuevo registro
    IF @Operation = 'CREATE'
    BEGIN
        INSERT INTO Usuario (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, DirecciónCorreo,
			DirecciónDomicilio, Sexo, FechaNacimiento, Estado, NombreUsuario, PasswordHash, FechaCreación,
				FechaModificación)
        VALUES (@PrimerN, @SegundoN, @PrimerA, @SegundoA, @Correo, @Direccion, @Sexo, @Nacimiento, 
			'Activo/a', @UserName, @Password, GETDATE(), GETDATE());
    END
    -- Leer un registro
    ELSE IF @Operation = 'READ'
    BEGIN
        SELECT * FROM Usuario WHERE UsuarioID = @UsuarioID;
    END
	-- Leer todos los registros
	ELSE IF @Operation = 'READ ALL'
	BEGIN
		SELECT * FROM Usuario;
	END
    -- Actualizar un registro
    ELSE IF @Operation = 'UPDATE'
    BEGIN
        UPDATE Usuario
        SET PrimerNombre = @PrimerN,
			SegundoNombre = @SegundoN,
			PrimerApellido = @PrimerA,
			SegundoApellido = @SegundoA,
			DirecciónCorreo = @Correo,
			DirecciónDomicilio = @Direccion,
			Sexo = @Sexo,
			FechaNacimiento = @Nacimiento,
			Estado = @Estado,
			NombreUsuario = @UserName,
			PasswordHash = @Password,
            FechaModificación = GETDATE()
        WHERE UsuarioID = @UsuarioID;
    END
    -- Eliminar un registro
    ELSE IF @Operation = 'DELETE'
    BEGIN
        DELETE FROM Usuario WHERE UsuarioID = @UsuarioID;
    END
END

GO