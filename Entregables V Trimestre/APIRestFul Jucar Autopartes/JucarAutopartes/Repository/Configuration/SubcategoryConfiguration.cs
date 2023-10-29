//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Entities.Models.Products;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Repository.Configuration
//{
//    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
//    {
//        public void Configure(EntityTypeBuilder<Subcategory> builder)
//        {
//            builder.HasData
//            (
//                new Subcategory
//                {
//                    SubcategoryID = new Guid("B449767B-601C-4811-AD3E-8B388BEDF632"),
//                    Name = "PIN CRUCETA",
//                    CategoryId = new Guid("70DCEE4C-8FEA-43AD-9D30-A35F5B458C1A")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("6378B394-F899-4AD4-96C6-9183C6787AD4"),
//                    Name = "PIN TUERCA",
//                    CategoryId = new Guid("70DCEE4C-8FEA-43AD-9D30-A35F5B458C1A")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("52992CC2-FD87-4298-81CC-9C290E0E53BA"),
//                    Name = "PIN DISCO",
//                    CategoryId = new Guid("70DCEE4C-8FEA-43AD-9D30-A35F5B458C1A")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("37C86E98-38D1-4DDF-BBA2-DF4B3098EA67"),
//                    Name = "PIN LEVA",
//                    CategoryId = new Guid("70DCEE4C-8FEA-43AD-9D30-A35F5B458C1A")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("E08F3A12-FB06-4E53-9E37-C7D9AD42F9D3"),
//                    Name = "ARANDELA CACHO",
//                    CategoryId = new Guid("D0529DD0-A201-48D0-BBF5-447CB0D2997E")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("19E5FFF4-C619-4CE4-B250-044CA30DCA43"),
//                    Name = "ARANDELA LEVA",
//                    CategoryId = new Guid("D0529DD0-A201-48D0-BBF5-447CB0D2997E")
//                },

//                new Subcategory
//                {
//                    SubcategoryID = new Guid("3120692A-9626-418D-BAAE-315EEA262AB5"),
//                    Name = "LAINA SPLINDER",
//                    CategoryId = new Guid("AE377C3D-BBFD-4ED2-A84A-47FD42C823B6")
//                }
//            );
//        }
//    }
//}
