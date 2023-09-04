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
//    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//    {
//        public void Configure(EntityTypeBuilder<Category> builder)
//        {
//            builder.HasData
//            (
//                new Category
//                {
//                    CategoryID = 1,
//                    Name = "PIN"
//                },

//                new Category
//                {
//                    CategoryID = 2,
//                    Name = "ARANDELA"
//                },

//                new Category
//                {
//                    CategoryID = 3,
//                    Name = "LAINA"
//                },

//                new Category
//                {
//                    CategoryID = 4,
//                    Name = "EMPAQUE CARNAZA"
//                },

//                new Category
//                {
//                    CategoryID = 5,
//                    Name = "TELEFONO CAUCHO"
//                },

//                new Category
//                {
//                    CategoryID = 6,
//                    Name = "MEDIA LUNA"
//                }
//            );
//        }
//    }
//}
