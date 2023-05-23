using JucarAutopartesCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace JucarAutopartesCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Mapeo Clases
        public DbSet<AutoPart> AutoParts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<AutoPartMeasurements> AutoPartMeasurements { get; set; }
        public DbSet<AutoPartWeight> AutoPartWeights { get; set; }
        public DbSet<Loss> Losss { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Stock> Stocks { get; set; }



        


        //Constructor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
    }
}
