using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JucarAutopartes.Migrations
{
    /// <inheritdoc />
    public partial class RegistrosBarrios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Name" },
                values: new object[,]
                {
                    { new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Bolívar" },
                    { new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Cundinamarca" },
                    { new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Santander" },
                    { new Guid("c5424105-77c9-4cb2-bf05-ff1db7fa1b12"), "Bogotá D.C." },
                    { new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Boyacá" },
                    { new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Antioquia" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "MunicipalityID", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("0070ac2f-33fe-4ee6-95ee-559838f741cc"), new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Chía" },
                    { new Guid("04445038-5881-4660-9a97-9bc53687c8aa"), new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Magangué" },
                    { new Guid("07cae774-1c0b-4b94-a76a-463d475d93fc"), new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Paipa" },
                    { new Guid("09ee73c3-df0d-432e-99b6-f444bc6f25de"), new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Turbaco" },
                    { new Guid("0aa41c1a-bce7-4cd0-b372-7bfca622b3c0"), new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Duitama" },
                    { new Guid("0efcc66c-64f7-4187-a634-c61b4f54984b"), new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Sogamoso" },
                    { new Guid("12601027-07fe-435d-bf86-c0b8b63e7576"), new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Itagüí" },
                    { new Guid("26af7150-f00e-4b4d-bba4-a6156f161a18"), new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Pídecuesta" },
                    { new Guid("444b2ed7-85b9-4fc4-8421-e32227de9e5c"), new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Bello" },
                    { new Guid("515185c4-491c-483b-b2d1-d8e99eaa0189"), new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Barrancabermeja" },
                    { new Guid("5376159b-6903-439f-9045-36b176354e55"), new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Floridablanca" },
                    { new Guid("6a1e6bff-b542-4731-ad4c-8b80097a0a61"), new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Tunja" },
                    { new Guid("77292549-bb02-48d3-b9cd-70b7d3a4a22f"), new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Sabaneta" },
                    { new Guid("863104b2-3845-4fbf-b0aa-0471015ba6cc"), new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Cartagena" },
                    { new Guid("9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5"), new Guid("e6a04ebb-433f-492f-9d0d-6636e8e9c392"), "Chiquinquirá" },
                    { new Guid("a1aa7f91-20a2-403d-ad2d-6ef971a46832"), new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Soledad" },
                    { new Guid("a3abfc70-4368-4f24-b4bc-378d2ea1c72e"), new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Facatativá" },
                    { new Guid("afa8f2fb-5494-460e-8a5d-91ba20052bb0"), new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Medellín" },
                    { new Guid("ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5"), new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Bucaramanga" },
                    { new Guid("c9209c76-d6e3-49c3-b9b1-27ce300cf820"), new Guid("c5424105-77c9-4cb2-bf05-ff1db7fa1b12"), "Bogotá" },
                    { new Guid("e8eb2e8c-3421-426b-8035-049a8367980d"), new Guid("eeb58df4-a5c4-47b9-9cea-5f98b338260f"), "Envigado" },
                    { new Guid("efc46672-7656-408a-aed7-33110510d825"), new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Fusagasugá" },
                    { new Guid("f2c2bfc3-b03f-44d6-8396-ce1d64245f72"), new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Soacha" },
                    { new Guid("f90c2016-dd81-46e0-ab68-919e7d5be04b"), new Guid("25b2b57e-f928-4c8e-8eb5-23209e9a2ae1"), "Arjona" },
                    { new Guid("fb28c89a-4565-48a2-9516-b8b25da4efd8"), new Guid("c26f1779-ac31-4b71-935b-cc91864f35d8"), "Girón" },
                    { new Guid("ffad25db-cd64-4f75-96df-d4db4a698e3a"), new Guid("958920ce-4d55-4038-a87f-af783ff1d533"), "Zipaquirá" }
                });

            migrationBuilder.InsertData(
                table: "Neighborhoods",
                columns: new[] { "NeighborhoodID", "MunicipalityId", "Name" },
                values: new object[,]
                {
                    { new Guid("0adb69c7-8c3b-4b7f-b2ee-70153f2bb33f"), new Guid("afa8f2fb-5494-460e-8a5d-91ba20052bb0"), "El Poblado" },
                    { new Guid("0e05d355-c573-4b37-bd09-cc6a4ff1f459"), new Guid("fb28c89a-4565-48a2-9516-b8b25da4efd8"), "Villa Carolina" },
                    { new Guid("11da7410-5d21-4c5d-8310-0bf0ad1f0f79"), new Guid("444b2ed7-85b9-4fc4-8421-e32227de9e5c"), "Niquía" },
                    { new Guid("16b2e90d-2f62-4dc4-9e4c-f7bab28d5e8d"), new Guid("09ee73c3-df0d-432e-99b6-f444bc6f25de"), "Las Palmeras" },
                    { new Guid("16c7f9dd-8700-4d96-8453-4e647bdeaeee"), new Guid("515185c4-491c-483b-b2d1-d8e99eaa0189"), "San Rafael" },
                    { new Guid("237d8ae9-36c6-4199-88fd-b8eea93eb2fc"), new Guid("a1aa7f91-20a2-403d-ad2d-6ef971a46832"), "Las Moras" },
                    { new Guid("2eba303f-b2e5-4a99-a086-9b70a2b0b3cc"), new Guid("e8eb2e8c-3421-426b-8035-049a8367980d"), "El Dorado" },
                    { new Guid("2f2a97df-9a51-4bbe-a26c-88f71d803d01"), new Guid("863104b2-3845-4fbf-b0aa-0471015ba6cc"), "Getsemaní" },
                    { new Guid("3c276cb8-6ee2-4950-8c70-d0b193b729e6"), new Guid("efc46672-7656-408a-aed7-33110510d825"), "La Esperanza" },
                    { new Guid("45350c07-2e64-4025-87d3-d063a885c46f"), new Guid("26af7150-f00e-4b4d-bba4-a6156f161a18"), "Prados del Mutis" },
                    { new Guid("48065608-6caa-4c95-955e-8f748393fbdd"), new Guid("f90c2016-dd81-46e0-ab68-919e7d5be04b"), "Barrio El Cacao" },
                    { new Guid("4b9caeb5-0572-4e98-ac45-a01efe3ff258"), new Guid("6a1e6bff-b542-4731-ad4c-8b80097a0a61"), "El Topo" },
                    { new Guid("4c589372-1a7e-431f-a9ea-fb8d748c493b"), new Guid("09ee73c3-df0d-432e-99b6-f444bc6f25de"), "El Pueblito" },
                    { new Guid("4fd9e0cc-2d93-4245-9a82-5dd59563c691"), new Guid("ffad25db-cd64-4f75-96df-d4db4a698e3a"), "La Esperanza" },
                    { new Guid("514e8495-fc39-4233-936d-a2b7ee255444"), new Guid("a3abfc70-4368-4f24-b4bc-378d2ea1c72e"), "La Estación" },
                    { new Guid("57888bd6-957f-4754-9cc0-587d15b31f6f"), new Guid("efc46672-7656-408a-aed7-33110510d825"), "Centro" },
                    { new Guid("5cde767f-13f9-4462-a96c-2f7cb9aa6e0a"), new Guid("0070ac2f-33fe-4ee6-95ee-559838f741cc"), "Guaymaral" },
                    { new Guid("60462cc0-e02d-4daa-94a1-ef67d60c3b7f"), new Guid("9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5"), "Barrio San Antonio" },
                    { new Guid("610ae713-3a68-41c1-92ac-dd844c60051a"), new Guid("c9209c76-d6e3-49c3-b9b1-27ce300cf820"), "Usaquén" },
                    { new Guid("6eb90f2c-1eb5-4823-9ba8-4b59d4101a86"), new Guid("77292549-bb02-48d3-b9cd-70b7d3a4a22f"), "La Doctora" },
                    { new Guid("6f263844-aa55-4280-840c-27bda923beac"), new Guid("515185c4-491c-483b-b2d1-d8e99eaa0189"), "Los Cedros" },
                    { new Guid("7be523f2-d9e3-4f17-a3f6-6bfd1d59b203"), new Guid("444b2ed7-85b9-4fc4-8421-e32227de9e5c"), "San Félix" },
                    { new Guid("7f1629c6-e440-4bd4-9338-d7e284100140"), new Guid("863104b2-3845-4fbf-b0aa-0471015ba6cc"), "Bocagrande" },
                    { new Guid("847a9d5f-c78d-40c3-8a74-b1ec2720b424"), new Guid("afa8f2fb-5494-460e-8a5d-91ba20052bb0"), "Laureles" },
                    { new Guid("87004677-4dff-4bbe-a941-c311f017a769"), new Guid("f2c2bfc3-b03f-44d6-8396-ce1d64245f72"), "Compartir" },
                    { new Guid("8a77da5b-74d8-4c73-a24c-9f9cba66120f"), new Guid("07cae774-1c0b-4b94-a76a-463d475d93fc"), "Santa Rita" },
                    { new Guid("8e4b97f6-fef0-44dd-9b28-cff12cdbffac"), new Guid("12601027-07fe-435d-bf86-c0b8b63e7576"), "El Porvenir" },
                    { new Guid("9b664bdd-3685-4c78-b381-bbb5d0343b85"), new Guid("12601027-07fe-435d-bf86-c0b8b63e7576"), "Santa María" },
                    { new Guid("9c8c2877-c973-4493-8032-0bf90fee4206"), new Guid("ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5"), "Provenza" },
                    { new Guid("9d54cec9-1677-4e9a-87ed-6d71d8e780d3"), new Guid("6a1e6bff-b542-4731-ad4c-8b80097a0a61"), "Centro Histórico" },
                    { new Guid("a1a2c738-c1db-4e39-9fdc-2855536d0f6a"), new Guid("ffad25db-cd64-4f75-96df-d4db4a698e3a"), "El Carmen" },
                    { new Guid("a2a07452-dc8e-4cff-828d-75d9cdcdafb5"), new Guid("04445038-5881-4660-9a97-9bc53687c8aa"), "El Pueblo Nuevo" },
                    { new Guid("a32b5c95-0232-49bc-9fff-b75b52599e24"), new Guid("0aa41c1a-bce7-4cd0-b372-7bfca622b3c0"), "El Libertador" },
                    { new Guid("a7d35971-aa5b-4479-8f4d-71de97846c74"), new Guid("c9209c76-d6e3-49c3-b9b1-27ce300cf820"), "Chapinero" },
                    { new Guid("af50ccf0-b2d6-406b-b3ac-e4337b6bb717"), new Guid("0aa41c1a-bce7-4cd0-b372-7bfca622b3c0"), "La Floresta" },
                    { new Guid("b077ca81-a434-46ce-bc15-b242675a011c"), new Guid("04445038-5881-4660-9a97-9bc53687c8aa"), "Barrio Libertad" },
                    { new Guid("b723a4d9-22b7-470b-b9c6-637429e6028b"), new Guid("5376159b-6903-439f-9045-36b176354e55"), "Cañaveral" },
                    { new Guid("b820e69d-8a05-4a55-b07d-e0e93abbecc8"), new Guid("07cae774-1c0b-4b94-a76a-463d475d93fc"), "La Colina" },
                    { new Guid("bc1664e2-92fa-45b0-9868-fdf4b669e78e"), new Guid("f2c2bfc3-b03f-44d6-8396-ce1d64245f72"), "Ciudad Verde" },
                    { new Guid("c5897d98-6fc5-462f-98a6-b28d62497047"), new Guid("9f2efb19-b9d0-4e2e-a2d9-ca94eecbbae5"), "Barrio Simón Bólivar" },
                    { new Guid("cefb34aa-e2da-4a37-ba8c-0071d40ae846"), new Guid("0070ac2f-33fe-4ee6-95ee-559838f741cc"), "La Pradera" },
                    { new Guid("d03940eb-8802-4139-8513-74756bb4ba1f"), new Guid("e8eb2e8c-3421-426b-8035-049a8367980d"), "Jardínes" },
                    { new Guid("d40747ce-547e-4334-a211-7a3b93fa5fb4"), new Guid("fb28c89a-4565-48a2-9516-b8b25da4efd8"), "Altos de Pan de Azúcar" },
                    { new Guid("d4bfcebc-90cc-4657-9281-f5fe30e18aea"), new Guid("ba0e0021-eca6-4e4d-bb01-31a2fbc36fe5"), "Cabecera del Llano" },
                    { new Guid("d53a814f-2ba4-4e5a-a542-fe5c13e7b44f"), new Guid("0efcc66c-64f7-4187-a634-c61b4f54984b"), "Centro" },
                    { new Guid("da8bf5a8-8d02-487b-a25e-32d8d08cfa95"), new Guid("77292549-bb02-48d3-b9cd-70b7d3a4a22f"), "Ciudadela Robledo" },
                    { new Guid("dda14777-d0f8-416c-97f3-318607704bbf"), new Guid("26af7150-f00e-4b4d-bba4-a6156f161a18"), "Villa del Prado" },
                    { new Guid("ec91bd61-d1e4-469d-8b78-5e544e4c7c73"), new Guid("a3abfc70-4368-4f24-b4bc-378d2ea1c72e"), "San Rafael" },
                    { new Guid("edea2a92-d5a3-4350-bcbf-ac80b770d359"), new Guid("5376159b-6903-439f-9045-36b176354e55"), "Lagos del Cacique" },
                    { new Guid("f0455fc4-ff3f-4569-9820-4fa9932efe71"), new Guid("0efcc66c-64f7-4187-a634-c61b4f54984b"), "La Campiña" },
                    { new Guid("f22856fd-a0f5-4cb1-8d76-d703afaa3a66"), new Guid("a1aa7f91-20a2-403d-ad2d-6ef971a46832"), "El Hipódromo" },
                    { new Guid("f59ffed8-d257-48b9-b961-3499c41cfa04"), new Guid("f90c2016-dd81-46e0-ab68-919e7d5be04b"), "Centro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
