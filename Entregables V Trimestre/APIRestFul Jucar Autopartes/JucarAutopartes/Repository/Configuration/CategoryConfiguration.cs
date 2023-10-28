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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
            (
                new Category
                {
                    CategoryID = new Guid("70DCEE4C-8FEA-43AD-9D30-A35F5B458C1A"),
                    Name = "PIN"
                },

                new Category
                {
                    CategoryID = new Guid("D0529DD0-A201-48D0-BBF5-447CB0D2997E"),
                    Name = "ARANDELA"
                },

                new Category
                {
                    CategoryID = new Guid("AE377C3D-BBFD-4ED2-A84A-47FD42C823B6"),
                    Name = "LAINA"
                },

                new Category
                {
                    CategoryID = new Guid("29961716-B4FE-43A9-874D-0ACDC993A5B8"),
                    Name = "EMPAQUE CARNAZA"
                },

                new Category
                {
                    CategoryID = new Guid("2E6B11A6-3F6C-47F6-BEB6-F7EDD8645175"),
                    Name = "TELEFONO CAUCHO"
                },

                new Category
                {
                    CategoryID = new Guid("6B158255-0B3E-47F0-BC22-5BA2EC06FFEF"),
                    Name = "MEDIA LUNA"
                }
            );
        }
    }
}
