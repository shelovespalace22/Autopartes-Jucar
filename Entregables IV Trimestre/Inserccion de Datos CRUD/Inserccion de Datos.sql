USE JucarAutoBD;

GO

-- ***** REGISTORS CATEGORIA *****

EXEC CRUD_Categoria
    @Operation = 'CREATE',
	@NomCat = 'Pin';



EXEC CRUD_Categoria
    @Operation = 'CREATE',
	@NomCat = 'Arandela';



EXEC CRUD_Categoria
    @Operation = 'CREATE',
	@NomCat = 'Laina';



EXEC CRUD_Categoria
    @Operation = 'CREATE',
	@NomCat = 'Empaque';

GO

-- ***** REGISTROS SUBCATEGORIA *****

EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 1,
	@NomSubc =  'Pin Cruceta';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 1,
	@NomSubc =  'Pin Tuerca';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 1,
	@NomSubc =  'Pin Disco';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 1,
	@NomSubc =  'Pin Leva';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 2,
	@NomSubc =  'Arandela Cacho';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 2,
	@NomSubc =  'Arandela Leva';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 3,
	@NomSubc =  'Laina Splinder';



EXEC CRUD_Subcategoria
    @Operation = 'CREATE',
    @CategoriaID = 4,
	@NomSubc =  'Empaque Carnaza';

GO

-- ***** REGISTROS MATERIA PRIMA

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Acero';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Aluminio';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Hierro';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Hierro Fundido';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Fósil',
	@Nombre = 'Plástico';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Vegetal',
	@Nombre = 'Caucho';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Vidrio';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Mineral',
	@Nombre = 'Cobre';

EXEC CRUD_Materiprima
	@Operation = 'CREATE',
	@Tipo = 'Fósil',
	@Nombre = 'Fibra de Carbono';

GO

-- ***** REGISTROS AUTOPARTE ******

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 1,
	@Nombre = 'PIN CRUCETA 334',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 1,
	@Nombre = 'PIN CRUCETA 333',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 950 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 950 PLANO 2.5 mm',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 950 HI',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 900 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 900 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 900 HI',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 800 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 800 HI',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 600 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 600 HI',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 500 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 300 PLANO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING 300 HI',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING TRAILER DITE',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING AGRALE MODELO NUEVO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING HI 4700',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING INCA MODELO NUEVO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING TRAILER RANDON',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING DAIHATSU DELTA TURBO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING NPR',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING NKR',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING TOYOTA MODELO NUEVO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING NISSAN DELANTERO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING NISSAN TRASERO',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING FORD 250',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING LAND ROVER',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING WILLYS',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING SUZUKI SJ410',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 2,
	@Nombre = 'PIN TUERCA HOUSING MT 3000/MERCEDES 413',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 1,
	@SubcategoriaID = 3,
	@Nombre = 'PIN DISCO QUINTA RUEDA',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO AGRALE',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO KODIAK 1 1/2',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO NPR',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO KENWORTH',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO HINO FC 500',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO 900 OMBLIGONA',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 5,
	@Nombre = 'ARANDELA CACHO WILLYS RUEDA LIBRE',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 3/4"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 7/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 1/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 1/4"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 3/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 1/2"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 5/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 1 3/4"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 2"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 2 1/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 2,
	@SubcategoriaID = 6,
	@Nombre = 'ARANDELA LEVA 2 1/4"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER DODGE 300',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER AGRALE 29mm',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER FORD 350 7/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER NISSAN MT 3000',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER DODGE 600 1 1/4"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER CHEVROLET B60/C70',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER DAIHATSU DELTA',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER FORD 800 1 7/16"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER FORD 900 1 5/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER FORD 950 1 13/16"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER HINO FC 500',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER BRIGADIER 1 11/16',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER KODIAK DIESEL',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER KENWORTH',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 3,
	@SubcategoriaID = 7,
	@Nombre = 'LAINAS SPLINDER SUPER BRIGADIER 2 1/8"',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 4,
	@SubcategoriaID = 8,
	@Nombre = 'EMPAQUE CARNAZA 900',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 4,
	@SubcategoriaID = 8,
	@Nombre = 'EMPAQUE CARNAZA 800',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 4,
	@SubcategoriaID = 8,
	@Nombre = 'EMPAQUE CARNAZA NPR',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 4,
	@SubcategoriaID = 8,
	@Nombre = 'EMPAQUE CARNAZA 300',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

EXEC CRUD_Autoparte
	@Operation = 'CREATE',
	@CategoriaID = 4,
	@SubcategoriaID = 8,
	@Nombre = 'EMPAQUE CARNAZA 600',
	@Funcion = '',
	@ZonaV = '',
	@PesoKgs = '',
	@AltoCm = '',
	@LargoCm = '';

GO

-- ***** REGISTROS HISTORIAL PRECIO *****

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 2,
	@Valor = 640;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 3,
	@Valor = 640;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 4,
	@Valor = 2070;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 5,
	@Valor = 3100;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 6,
	@Valor = 2200;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 7,
	@Valor = 2050;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 8,
	@Valor = 1880;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 9,
	@Valor = 2050;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 10,
	@Valor = 1600;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 11,
	@Valor = 1170;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 12,
	@Valor = 1370;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 13,
	@Valor = 2070;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 14,
	@Valor = 2050;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 15,
	@Valor = 1660;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 16,
	@Valor = 3080;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 17,
	@Valor = 4950;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 18,
	@Valor = 1720;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 19,
	@Valor = 4950;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 20,
	@Valor = 4950;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 21,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 22,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 23,
	@Valor = 1100;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 24,
	@Valor = 1100;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 25,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 26,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 27,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 28,
	@Valor = 1380;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 29,
	@Valor = 3900;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 30,
	@Valor = 1980;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 31,
	@Valor = 1560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 32,
	@Valor = 2300;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 33,
	@Valor = 1720;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 34,
	@Valor = 1780;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 35,
	@Valor = 2300;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 36,
	@Valor = 1250;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 37,
	@Valor = 800;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 38,
	@Valor = 300;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 39,
	@Valor = 330;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 40,
	@Valor = 370;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 41,
	@Valor = 400;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 42,
	@Valor = 440;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 43,
	@Valor = 490;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 44,
	@Valor = 490;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 45,
	@Valor = 530;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 46,
	@Valor = 1020;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 47,
	@Valor = 1180;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 48,
	@Valor = 1200;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 49,
	@Valor = 1180;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 50,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 51,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 52,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 53,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 54,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 55,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 56,
	@Valor = 510;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 57,
	@Valor = 560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 58,
	@Valor = 560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 59,
	@Valor = 560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 60,
	@Valor = 560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 61,
	@Valor = 560;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 62,
	@Valor = 650;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 63,
	@Valor = 650;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 64,
	@Valor = 650;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 65,
	@Valor = 650;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 66,
	@Valor = 1600;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 67,
	@Valor = 1160;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 68,
	@Valor = 1050;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 69,
	@Valor = 940;

EXEC CRUD_HistorialPrecio
	@Operation = 'CREATE',
	@AutoparteID = 70,
	@Valor = 1050;

GO

