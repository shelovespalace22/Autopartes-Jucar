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
        public DbSet<Loss> Losses { get; set; }
        public DbSet<PriceHistory> PricesHistory { get; set; }
        public DbSet<DiscountHistory> DiscountsHistory { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<AutoPartMaterial> AutoPartMaterials { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Compartment> Compartments { get; set; }
        public DbSet<FactoryPhone> FactoryPhones { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<NaturalProvider> NaturalProviders { get; set; }
        public DbSet<LegalProvider> LegalProviders { get; set; }
        public DbSet<ProviderAddress> ProviderAddresses { get; set; }
        public DbSet<ProviderPhone> ProviderPhones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FactoryAddress> FactoryAddresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Addressee> Addressees { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Address> Addresses { get; set; } //30
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<UserPosition> UserPositions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<NaturalCustomer> NaturalCustomers { get; set; }
        public DbSet<LegalCustomer> LegalCustomers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillsDetail { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<DigitalPlataform> DigitalPlataforms { get; set; }
        public DbSet<Cash>  Cashs { get; set; }
        public DbSet<Contribution> Contributions { get; set; }






        


        //Constructor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
    }
}
