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
                    CategoryID = Guid.NewGuid(),
                    Name = "PIN"
                },

                new Category
                {
                    CategoryID = Guid.NewGuid(),
                    Name = "ARANDELA"
                },

                new Category
                {
                    CategoryID = Guid.NewGuid(),
                    Name = "LAINA"
                },

                new Category
                {
                    CategoryID = Guid.NewGuid(),
                    Name = "EMPAQUE CARNAZA"
                },

                new Category
                {
                    CategoryID = Guid.NewGuid(),
                    Name = "TELEFONO CAUCHO"
                },

                new Category
                {
                    CategoryID = Guid.NewGuid(),
                    Name = "MEDIA LUNA"
                }
            );
        } 
    }
}
