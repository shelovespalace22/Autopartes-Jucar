using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class AutopartConfiguration : IEntityTypeConfiguration<Autopart>
    {
        public void Configure(EntityTypeBuilder<Autopart> builder)
        {
            builder.HasData
            (
                new Autopart
                {
                    AutopartID = new Guid("2A2BB8A4-EF22-4875-9CDF-1D83B06DEFE8"),
                    Name = "PIN CRUCETA 334",
                    Description = "N/N",
                    SubcategoryId = new Guid("B449767B-601C-4811-AD3E-8B388BEDF632"),
                    RawMaterialId = new Guid("DA932F1F-4BF1-4233-9FD6-283A0FF4CE6E")

                },

                new Autopart
                {
                    AutopartID = new Guid("DEF7808B-1F75-4ED9-875A-54A09659B77E"),
                    Name = "PIN TUERCA HOUSING 950 PLANO",
                    Description = "N/N",
                    SubcategoryId = new Guid("6378B394-F899-4AD4-96C6-9183C6787AD4"),
                    RawMaterialId = new Guid("DA932F1F-4BF1-4233-9FD6-283A0FF4CE6E")
                },

                new Autopart
                {
                    AutopartID = new Guid("2653E777-21CB-43A5-B585-3BCBF7E513FE"),
                    Name = "PIN DISCO QUINTA RUEDA",
                    Description = "N/N",
                    SubcategoryId = new Guid("52992CC2-FD87-4298-81CC-9C290E0E53BA"),
                    RawMaterialId = new Guid("DA932F1F-4BF1-4233-9FD6-283A0FF4CE6E")
                },

                new Autopart
                {
                    AutopartID = new Guid("65F4A9E7-30A8-48F2-ABFF-843EBE0F3333"),
                    Name = "PIN LEVA 1 1/4",
                    Description = "N/N",
                    SubcategoryId = new Guid("37C86E98-38D1-4DDF-BBA2-DF4B3098EA67"),
                    RawMaterialId = new Guid("C3818A2D-D242-4493-B437-2D74D434FA21")
                },

                new Autopart
                {
                    AutopartID = new Guid("D0EC66B5-378B-44C1-AA29-08614564DE98"),
                    Name = "ARANDELA CACHO AGRALE MODELO NUEVO",
                    Description = "N/N",
                    SubcategoryId = new Guid("E08F3A12-FB06-4E53-9E37-C7D9AD42F9D3"),
                    RawMaterialId = new Guid("C3818A2D-D242-4493-B437-2D74D434FA21")
                },

                new Autopart
                {
                    AutopartID = new Guid("322F81E3-7781-4BCD-947F-D32ACC672CE6"),
                    Name = "ARANDELA LEVA 3/4",
                    Description = "N/N",
                    SubcategoryId = new Guid("19E5FFF4-C619-4CE4-B250-044CA30DCA43"),
                    RawMaterialId = new Guid("C3818A2D-D242-4493-B437-2D74D434FA21")
                },

                new Autopart
                {
                    AutopartID = new Guid("2D57D220-0899-4F97-AE4C-C75D132A8921"),
                    Name = "LAINA SPLINDER NPR",
                    Description = "N/N",
                    SubcategoryId = new Guid("3120692A-9626-418D-BAAE-315EEA262AB5"),
                    RawMaterialId = new Guid("C3818A2D-D242-4493-B437-2D74D434FA21")
                },

                new Autopart
                {
                    AutopartID = new Guid("D5AFD5FC-4094-4003-A242-FD35342F6BC0"),
                    Name = "LAINA SPLINDER KENWORTH",
                    Description = "N/N",
                    SubcategoryId = new Guid("3120692A-9626-418D-BAAE-315EEA262AB5"),
                    RawMaterialId = new Guid("8A7505DB-8BB3-4872-A927-8113834F0C10")
                },

                new Autopart
                {
                    AutopartID = new Guid("8DB21635-4DB7-453D-8010-831137E72D63"),
                    Name = "LAINA SPLINDER HINO FC 500",
                    Description = "N/N",
                    SubcategoryId = new Guid("3120692A-9626-418D-BAAE-315EEA262AB5"),
                    RawMaterialId = new Guid("8A7505DB-8BB3-4872-A927-8113834F0C10")
                },

                new Autopart
                {
                    AutopartID = new Guid("F9E4D631-4015-45E1-9C11-8B88262AD802"),
                    Name = "LAINA SPLINDER NISSAN MT 3000",
                    Description = "N/N",
                    SubcategoryId = new Guid("3120692A-9626-418D-BAAE-315EEA262AB5"),
                    RawMaterialId = new Guid("8A7505DB-8BB3-4872-A927-8113834F0C10")
                }
            );
        }
    }
}
