using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Products;
using Entities.Models.Providers;
using Entities.Models.Sales;
using Entities.Models.Ubications;
using Entities.Models.Users;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubcategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AutopartConfiguration());
            modelBuilder.ApplyConfiguration(new RawMaterialConfiguration());
        }

        /* Products */
        public DbSet<Autopart>? Autoparts { get; set; }

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Loss>? Losses { get; set; }

        public DbSet<Movement>? Movements { get; set; }

        public DbSet<RawMaterial>? RawMaterials { get; set; }

        public DbSet<Stock>? Stocks { get; set; }

        public DbSet<Subcategory>? Subcategories { get; set; }

        /* Providers */

        public DbSet<Provider>? Providers { get; set; }

        public DbSet<ProviderAddress>? ProviderAddresses { get; set; }

        public DbSet<ProviderPhone>? ProviderPhones { get; set; }

        /* Sales */

        public DbSet<Contribution>? Contributions { get; set; }

        public DbSet<Customer>? Customers { get; set; }

        public DbSet<CustomerAddress>? CustomerAddresses { get; set; }

        public DbSet<CustomerPhone>? CustomerPhones { get; set; }

        public DbSet<Order>? Orders { get; set; }

        public DbSet<OrderDetail>? OrderDetails { get; set; }

        public DbSet<PaymentMethod>? PaymentMethods { get; set; }

        /* Ubications */

        public DbSet<Department>? Departments { get; set; }

        public DbSet<Municipality>? Municipalities { get; set; }

        public DbSet<Neighborhood>? Neighborhoods { get; set; }

        /* Users */

        //public DbSet<Position>? Positions { get; set; }

        //public DbSet<User>? Users { get; set; }

        //public DbSet<UserAddress>? UserAddresses { get; set; }

        //public DbSet<UserPhone>? UserPhones { get; set; }

        //public DbSet<UserPosition>? UserPositions { get; set; }
    }
}
