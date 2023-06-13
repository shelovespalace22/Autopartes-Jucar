using JucarAutopartesAplicacionWeb.Models.Factories;
using JucarAutopartesAplicacionWeb.Models.Products;
using JucarAutopartesAplicacionWeb.Models.Providers;
using JucarAutopartesAplicacionWeb.Models.Sales;
using JucarAutopartesAplicacionWeb.Models.Ubications;
using JucarAutopartesAplicacionWeb.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JucarAutopartesAplicacionWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {
                
        }

        public DbSet<User> Userss { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<UserPosition> UserPositions { get; set; }
        public DbSet<Autopart> Autoparts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Loss> Losses { get; set; }
        public DbSet<PriceHistory> PriceHistories { get; set; }
        public DbSet<DiscountHistory> DiscountHistories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<AutopartMaterial> AutopartMaterials { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Addressee> Addressees { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LegalCustomer> LegalCustomers { get; set; }
        public DbSet<NaturalCustomer> NaturalCustomers { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<WayToPay> WayToPays { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<LegalProvider> LegalProviders { get; set; }
        public DbSet<NaturalProvider> NaturalProviders { get; set; }
        public DbSet<ProviderPhone> ProviderPhones { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<ProviderAddress> ProviderAddresses { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryAddress> FactoryAddresses { get; set; }
        public DbSet<FactoryPhone> FactoryPhones { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Shelving> Shelvings { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }






    }
}
