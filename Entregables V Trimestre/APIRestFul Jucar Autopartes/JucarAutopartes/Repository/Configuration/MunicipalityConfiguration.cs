using Entities.Models.Ubications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class MunicipalityConfiguration : IEntityTypeConfiguration<Municipality>
    {
        public void Configure(EntityTypeBuilder<Municipality> builder)
        {
            builder.HasData
            (
                /* Bogotá D.C. */

                new Municipality
                {
                    MunicipalityID = new Guid("C9209C76-D6E3-49C3-B9B1-27CE300CF820"),
                    Name = "Bogotá",
                    DepartmentId = new Guid("C5424105-77C9-4CB2-BF05-FF1DB7FA1B12")
                },

                /* Cundinamarca */

                new Municipality
                {
                    MunicipalityID = new Guid("F2C2BFC3-B03F-44D6-8396-CE1D64245F72"),
                    Name = "Soacha",
                    DepartmentId = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("A3ABFC70-4368-4F24-B4BC-378D2EA1C72E"),
                    Name = "Facatativá",
                    DepartmentId = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("FFAD25DB-CD64-4F75-96DF-D4DB4A698E3A"),
                    Name = "Zipaquirá",
                    DepartmentId = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("0070AC2F-33FE-4EE6-95EE-559838F741CC"),
                    Name = "Chía",
                    DepartmentId = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("EFC46672-7656-408A-AED7-33110510D825"),
                    Name = "Fusagasugá",
                    DepartmentId = new Guid("958920CE-4D55-4038-A87F-AF783FF1D533")
                },

                /* Antioquia */

                new Municipality
                {
                    MunicipalityID = new Guid("AFA8F2FB-5494-460E-8A5D-91BA20052BB0"),
                    Name = "Medellín",
                    DepartmentId = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("E8EB2E8C-3421-426B-8035-049A8367980D"),
                    Name = "Envigado",
                    DepartmentId = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("444B2ED7-85B9-4FC4-8421-E32227DE9E5C"),
                    Name = "Bello",
                    DepartmentId = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("12601027-07FE-435D-BF86-C0B8B63E7576"),
                    Name = "Itagüí",
                    DepartmentId = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("77292549-BB02-48D3-B9CD-70B7D3A4A22F"),
                    Name = "Sabaneta",
                    DepartmentId = new Guid("EEB58DF4-A5C4-47B9-9CEA-5F98B338260F")
                },

                /* Boyacá */

                new Municipality
                {
                    MunicipalityID = new Guid("6A1E6BFF-B542-4731-AD4C-8B80097A0A61"),
                    Name = "Tunja",
                    DepartmentId = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("0AA41C1A-BCE7-4CD0-B372-7BFCA622B3C0"),
                    Name = "Duitama",
                    DepartmentId = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("0EFCC66C-64F7-4187-A634-C61B4F54984B"),
                    Name = "Sogamoso",
                    DepartmentId = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("9F2EFB19-B9D0-4E2E-A2D9-CA94EECBBAE5"),
                    Name = "Chiquinquirá",
                    DepartmentId = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("07CAE774-1C0B-4B94-A76A-463D475D93FC"),
                    Name = "Paipa",
                    DepartmentId = new Guid("E6A04EBB-433F-492F-9D0D-6636E8E9C392")
                },

                /* Bólivar */

                new Municipality
                {
                    MunicipalityID = new Guid("863104B2-3845-4FBF-B0AA-0471015BA6CC"),
                    Name = "Cartagena",
                    DepartmentId = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("09EE73C3-DF0D-432E-99B6-F444BC6F25DE"),
                    Name = "Turbaco",
                    DepartmentId = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("04445038-5881-4660-9A97-9BC53687C8AA"),
                    Name = "Magangué",
                    DepartmentId = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("A1AA7F91-20A2-403D-AD2D-6EF971A46832"),
                    Name = "Soledad",
                    DepartmentId = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("F90C2016-DD81-46E0-AB68-919E7D5BE04B"),
                    Name = "Arjona",
                    DepartmentId = new Guid("25B2B57E-F928-4C8E-8EB5-23209E9A2AE1")
                },

                /* Santander */

                new Municipality
                {
                    MunicipalityID = new Guid("BA0E0021-ECA6-4E4D-BB01-31A2FBC36FE5"),
                    Name = "Bucaramanga",
                    DepartmentId = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("5376159B-6903-439F-9045-36B176354E55"),
                    Name = "Floridablanca",
                    DepartmentId = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("FB28C89A-4565-48A2-9516-B8B25DA4EFD8"),
                    Name = "Girón",
                    DepartmentId = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("26AF7150-F00E-4B4D-BBA4-A6156F161A18"),
                    Name = "Pídecuesta",
                    DepartmentId = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8")
                },

                new Municipality
                {
                    MunicipalityID = new Guid("515185C4-491C-483B-B2D1-D8E99EAA0189"),
                    Name = "Barrancabermeja",
                    DepartmentId = new Guid("C26F1779-AC31-4B71-935B-CC91864F35D8")
                }
            );
        }
    }
}
