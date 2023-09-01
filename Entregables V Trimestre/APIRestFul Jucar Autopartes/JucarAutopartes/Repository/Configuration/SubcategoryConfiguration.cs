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
        private readonly RepositoryContext _repositoryContext;

        public SubcategoryConfiguration(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasData
            (
                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN CRUCETA",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "PIN").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN TUERCA",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "PIN").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN DISCO",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "PIN").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "PIN LEVA",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "PIN").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "ARANDELA CACHO",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "ARANDELA").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "ARANDELA LEVA",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "ARANDELA").CategoryID
                },

                new Subcategory
                {
                    SubcategoryID = Guid.NewGuid(),
                    Name = "LAINA SPLINDER",
                    CategoryID = _repositoryContext.Categories.Single(c => c.Name == "LAINA").CategoryID
                }
            );
        }
    }
}
