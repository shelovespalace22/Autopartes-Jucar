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
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN CRUCETA",
                    CategoryID = Guid.Parse("7aa51602-6cfa-4b17-b1b8-853f0e0388c6")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN TUERCA",
                    CategoryID = Guid.Parse("7aa51602-6cfa-4b17-b1b8-853f0e0388c6")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN DISCO",
                    CategoryID = Guid.Parse("7aa51602-6cfa-4b17-b1b8-853f0e0388c6")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN LEVA",
                    CategoryID = Guid.Parse("7aa51602-6cfa-4b17-b1b8-853f0e0388c6")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "ARANDELA CACHO",
                    CategoryID = Guid.Parse("b78ff6fb-eeea-4685-940e-5aa3b2de64f1")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "ARANDELA LEVA",
                    CategoryID = Guid.Parse("b78ff6fb-eeea-4685-940e-5aa3b2de64f1")
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "LAINA SPLINDER",
                    CategoryID = Guid.Parse("655a812b-f7b0-42cc-b438-8d06ece10291")
                }
            );
        }
    }
}
