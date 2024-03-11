using Entities.Models.Ubications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class NeighborhoodConfiguration : IEntityTypeConfiguration<Neighborhood>
    {
        public void Configure(EntityTypeBuilder<Neighborhood> builder)
        {
            builder.HasData
            (
                /* Medellín */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("0ADB69C7-8C3B-4B7F-B2EE-70153F2BB33F"),
                    Name = "El Poblado",
                    MunicipalityId = new Guid("AFA8F2FB-5494-460E-8A5D-91BA20052BB0")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("847A9D5F-C78D-40C3-8A74-B1EC2720B424"),
                    Name = "Laureles",
                    MunicipalityId = new Guid("AFA8F2FB-5494-460E-8A5D-91BA20052BB0")
                },

                /* Envigado */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("D03940EB-8802-4139-8513-74756BB4BA1F"),
                    Name = "Jardínes",
                    MunicipalityId = new Guid("E8EB2E8C-3421-426B-8035-049A8367980D")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("2EBA303F-B2E5-4A99-A086-9B70A2B0B3CC"),
                    Name = "El Dorado",
                    MunicipalityId = new Guid("E8EB2E8C-3421-426B-8035-049A8367980D")
                },

                /* Bello */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("11DA7410-5D21-4C5D-8310-0BF0AD1F0F79"),
                    Name = "Niquía",
                    MunicipalityId = new Guid("444B2ED7-85B9-4FC4-8421-E32227DE9E5C")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("7BE523F2-D9E3-4F17-A3F6-6BFD1D59B203"),
                    Name = "San Félix",
                    MunicipalityId = new Guid("444B2ED7-85B9-4FC4-8421-E32227DE9E5C")
                },

                /* Itagüí */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("9B664BDD-3685-4C78-B381-BBB5D0343B85"),
                    Name = "Santa María",
                    MunicipalityId = new Guid("12601027-07FE-435D-BF86-C0B8B63E7576")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("8E4B97F6-FEF0-44DD-9B28-CFF12CDBFFAC"),
                    Name = "El Porvenir",
                    MunicipalityId = new Guid("12601027-07FE-435D-BF86-C0B8B63E7576")
                },

                /* Sabaneta */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("DA8BF5A8-8D02-487B-A25E-32D8D08CFA95"),
                    Name = "Ciudadela Robledo",
                    MunicipalityId = new Guid("77292549-BB02-48D3-B9CD-70B7D3A4A22F")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("6EB90F2C-1EB5-4823-9BA8-4B59D4101A86"),
                    Name = "La Doctora",
                    MunicipalityId = new Guid("77292549-BB02-48D3-B9CD-70B7D3A4A22F")
                },

                /* Tunja */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("9D54CEC9-1677-4E9A-87ED-6D71D8E780D3"),
                    Name = "Centro Histórico",
                    MunicipalityId = new Guid("6A1E6BFF-B542-4731-AD4C-8B80097A0A61")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("4B9CAEB5-0572-4E98-AC45-A01EFE3FF258"),
                    Name = "El Topo",
                    MunicipalityId = new Guid("6A1E6BFF-B542-4731-AD4C-8B80097A0A61")
                },

                /* Duitama */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("A32B5C95-0232-49BC-9FFF-B75B52599E24"),
                    Name = "El Libertador",
                    MunicipalityId = new Guid("0AA41C1A-BCE7-4CD0-B372-7BFCA622B3C0")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("AF50CCF0-B2D6-406B-B3AC-E4337B6BB717"),
                    Name = "La Floresta",
                    MunicipalityId = new Guid("0AA41C1A-BCE7-4CD0-B372-7BFCA622B3C0")
                },

                /* Sogamoso */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("D53A814F-2BA4-4E5A-A542-FE5C13E7B44F"),
                    Name = "Centro",
                    MunicipalityId = new Guid("0EFCC66C-64F7-4187-A634-C61B4F54984B")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("F0455FC4-FF3F-4569-9820-4FA9932EFE71"),
                    Name = "La Campiña",
                    MunicipalityId = new Guid("0EFCC66C-64F7-4187-A634-C61B4F54984B")
                },

                /* Chiquinquirá */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("C5897D98-6FC5-462F-98A6-B28D62497047"),
                    Name = "Barrio Simón Bólivar",
                    MunicipalityId = new Guid("9F2EFB19-B9D0-4E2E-A2D9-CA94EECBBAE5")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("60462CC0-E02D-4DAA-94A1-EF67D60C3B7F\r\n"),
                    Name = "Barrio San Antonio",
                    MunicipalityId = new Guid("9F2EFB19-B9D0-4E2E-A2D9-CA94EECBBAE5")
                },

                /* Paipa */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("B820E69D-8A05-4A55-B07D-E0E93ABBECC8"),
                    Name = "La Colina",
                    MunicipalityId = new Guid("07CAE774-1C0B-4B94-A76A-463D475D93FC")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("8A77DA5B-74D8-4C73-A24C-9F9CBA66120F"),
                    Name = "Santa Rita",
                    MunicipalityId = new Guid("07CAE774-1C0B-4B94-A76A-463D475D93FC")
                },

                /* Bucaramanga */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("D4BFCEBC-90CC-4657-9281-F5FE30E18AEA"),
                    Name = "Cabecera del Llano",
                    MunicipalityId = new Guid("BA0E0021-ECA6-4E4D-BB01-31A2FBC36FE5")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("9C8C2877-C973-4493-8032-0BF90FEE4206"),
                    Name = "Provenza",
                    MunicipalityId = new Guid("BA0E0021-ECA6-4E4D-BB01-31A2FBC36FE5")
                },

                /* Floridablanca */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("B723A4D9-22B7-470B-B9C6-637429E6028B"),
                    Name = "Cañaveral",
                    MunicipalityId = new Guid("5376159B-6903-439F-9045-36B176354E55")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("EDEA2A92-D5A3-4350-BCBF-AC80B770D359"),
                    Name = "Lagos del Cacique",
                    MunicipalityId = new Guid("5376159B-6903-439F-9045-36B176354E55")
                },

                /* Girón*/

                new Neighborhood
                {
                    NeighborhoodID = new Guid("0E05D355-C573-4B37-BD09-CC6A4FF1F459"),
                    Name = "Villa Carolina",
                    MunicipalityId = new Guid("FB28C89A-4565-48A2-9516-B8B25DA4EFD8")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("D40747CE-547E-4334-A211-7A3B93FA5FB4"),
                    Name = "Altos de Pan de Azúcar",
                    MunicipalityId = new Guid("FB28C89A-4565-48A2-9516-B8B25DA4EFD8")
                },

                /* Pidecuesta */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("45350C07-2E64-4025-87D3-D063A885C46F"),
                    Name = "Prados del Mutis",
                    MunicipalityId = new Guid("26AF7150-F00E-4B4D-BBA4-A6156F161A18")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("DDA14777-D0F8-416C-97F3-318607704BBF"),
                    Name = "Villa del Prado",
                    MunicipalityId = new Guid("26AF7150-F00E-4B4D-BBA4-A6156F161A18")
                },

                /* Barrancabermeja */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("16C7F9DD-8700-4D96-8453-4E647BDEAEEE"),
                    Name = "San Rafael",
                    MunicipalityId = new Guid("515185C4-491C-483B-B2D1-D8E99EAA0189")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("6F263844-AA55-4280-840C-27BDA923BEAC"),
                    Name = "Los Cedros",
                    MunicipalityId = new Guid("515185C4-491C-483B-B2D1-D8E99EAA0189")
                },

                /* Cartagena */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("7F1629C6-E440-4BD4-9338-D7E284100140"),
                    Name = "Bocagrande",
                    MunicipalityId = new Guid("863104B2-3845-4FBF-B0AA-0471015BA6CC")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("2F2A97DF-9A51-4BBE-A26C-88F71D803D01"),
                    Name = "Getsemaní",
                    MunicipalityId = new Guid("863104B2-3845-4FBF-B0AA-0471015BA6CC")
                },

                /* Turbaco */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("4C589372-1A7E-431F-A9EA-FB8D748C493B"),
                    Name = "El Pueblito",
                    MunicipalityId = new Guid("09EE73C3-DF0D-432E-99B6-F444BC6F25DE")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("16B2E90D-2F62-4DC4-9E4C-F7BAB28D5E8D"),
                    Name = "Las Palmeras",
                    MunicipalityId = new Guid("09EE73C3-DF0D-432E-99B6-F444BC6F25DE")
                },

                /* Magangué */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("A2A07452-DC8E-4CFF-828D-75D9CDCDAFB5"),
                    Name = "El Pueblo Nuevo",
                    MunicipalityId = new Guid("04445038-5881-4660-9A97-9BC53687C8AA")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("B077CA81-A434-46CE-BC15-B242675A011C"),
                    Name = "Barrio Libertad",
                    MunicipalityId = new Guid("04445038-5881-4660-9A97-9BC53687C8AA")
                },

                /* Soledad */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("F22856FD-A0F5-4CB1-8D76-D703AFAA3A66"),
                    Name = "El Hipódromo",
                    MunicipalityId = new Guid("A1AA7F91-20A2-403D-AD2D-6EF971A46832")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("237D8AE9-36C6-4199-88FD-B8EEA93EB2FC"),
                    Name = "Las Moras",
                    MunicipalityId = new Guid("A1AA7F91-20A2-403D-AD2D-6EF971A46832")
                },

                /* Arjona */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("F59FFED8-D257-48B9-B961-3499C41CFA04"),
                    Name = "Centro",
                    MunicipalityId = new Guid("F90C2016-DD81-46E0-AB68-919E7D5BE04B")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("48065608-6CAA-4C95-955E-8F748393FBDD"),
                    Name = "Barrio El Cacao",
                    MunicipalityId = new Guid("F90C2016-DD81-46E0-AB68-919E7D5BE04B")
                },

                /* Soacha */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("BC1664E2-92FA-45B0-9868-FDF4B669E78E"),
                    Name = "Ciudad Verde",
                    MunicipalityId = new Guid("F2C2BFC3-B03F-44D6-8396-CE1D64245F72")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("87004677-4DFF-4BBE-A941-C311F017A769"),
                    Name = "Compartir",
                    MunicipalityId = new Guid("F2C2BFC3-B03F-44D6-8396-CE1D64245F72")
                },

                /* Facatativá */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("EC91BD61-D1E4-469D-8B78-5E544E4C7C73"),
                    Name = "San Rafael",
                    MunicipalityId = new Guid("A3ABFC70-4368-4F24-B4BC-378D2EA1C72E")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("514E8495-FC39-4233-936D-A2B7EE255444"),
                    Name = "La Estación",
                    MunicipalityId = new Guid("A3ABFC70-4368-4F24-B4BC-378D2EA1C72E")
                },

                /* Zipaquirá */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("4FD9E0CC-2D93-4245-9A82-5DD59563C691"),
                    Name = "La Esperanza",
                    MunicipalityId = new Guid("FFAD25DB-CD64-4F75-96DF-D4DB4A698E3A")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("A1A2C738-C1DB-4E39-9FDC-2855536D0F6A"),
                    Name = "El Carmen",
                    MunicipalityId = new Guid("FFAD25DB-CD64-4F75-96DF-D4DB4A698E3A")
                },

                /* Chía */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("5CDE767F-13F9-4462-A96C-2F7CB9AA6E0A"),
                    Name = "Guaymaral",
                    MunicipalityId = new Guid("0070AC2F-33FE-4EE6-95EE-559838F741CC")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("CEFB34AA-E2DA-4A37-BA8C-0071D40AE846"),
                    Name = "La Pradera",
                    MunicipalityId = new Guid("0070AC2F-33FE-4EE6-95EE-559838F741CC")
                },

                /* Fusa */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("3C276CB8-6EE2-4950-8C70-D0B193B729E6"),
                    Name = "La Esperanza",
                    MunicipalityId = new Guid("EFC46672-7656-408A-AED7-33110510D825")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("57888BD6-957F-4754-9CC0-587D15B31F6F"),
                    Name = "Centro",
                    MunicipalityId = new Guid("EFC46672-7656-408A-AED7-33110510D825")
                },

                /* Bogotá */

                new Neighborhood
                {
                    NeighborhoodID = new Guid("A7D35971-AA5B-4479-8F4D-71DE97846C74"),
                    Name = "Chapinero",
                    MunicipalityId = new Guid("C9209C76-D6E3-49C3-B9B1-27CE300CF820")
                },

                new Neighborhood
                {
                    NeighborhoodID = new Guid("610AE713-3A68-41C1-92AC-DD844C60051A"),
                    Name = "Usaquén",
                    MunicipalityId = new Guid("C9209C76-D6E3-49C3-B9B1-27CE300CF820")
                }
            );
        }
    }
}
