using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class RawMaterialConfiguration : IEntityTypeConfiguration<RawMaterial>
    {
        public void Configure(EntityTypeBuilder<RawMaterial> builder)
        {
            builder.HasData
            (
                new RawMaterial
                {
                    RawMaterialID = new Guid("C3818A2D-D242-4493-B437-2D74D434FA21"),
                    Name = "Acero"
                },

                new RawMaterial
                {
                    RawMaterialID = new Guid("8A7505DB-8BB3-4872-A927-8113834F0C10"),
                    Name = "Hierro"
                },

                new RawMaterial
                {
                    RawMaterialID = new Guid("DA932F1F-4BF1-4233-9FD6-283A0FF4CE6E"),
                    Name = "Cobre"
                }
            );
        }
    }
}
