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
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    { 
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasData
            (
                new Subcategory
                {
                    SubcategoryID = 1,
                    Name = "PIN CRUCETA",
                    CategoryID = 1
                },

                new Subcategory
                {
                    SubcategoryID = 2,
                    Name = "PIN TUERCA",
                    CategoryID = 1
                },

                new Subcategory
                {
                    SubcategoryID = 3,
                    Name = "PIN DISCO",
                    CategoryID = 1
                },

                new Subcategory
                {
                    SubcategoryID = 4,
                    Name = "PIN LEVA",
                    CategoryID = 1
                },

                new Subcategory
                {
                    SubcategoryID = 5,
                    Name = "ARANDELA CACHO",
                    CategoryID = 2
                },

                new Subcategory
                {
                    SubcategoryID = 6,
                    Name = "ARANDELA LEVA",
                    CategoryID = 2
                },

                new Subcategory
                {
                    SubcategoryID = 7,
                    Name = "LAINA SPLINDER",
                    CategoryID = 3 
                }
            );
        }
    }
}
