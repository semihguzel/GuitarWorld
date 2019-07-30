using GuitarWorld.DAL.Mappings;
using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL
{
    public class Context : DbContext
    {
        public Context() : base(@"server = .; database = GuitarWorldDb; uid = sa; pwd = 1332sa.")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<GuitarBrand> GuitarBrands { get; set; }
        public DbSet<GuitarModel> GuitarModels { get; set; }
        public DbSet<GuitarType> GuitarTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails  { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GuitarMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new GuitarBrandMapping());
            modelBuilder.Configurations.Add(new GuitarModelMapping());
            modelBuilder.Configurations.Add(new GuitarTypeMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new ShipperMapping());
            modelBuilder.Configurations.Add(new SupplierMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
