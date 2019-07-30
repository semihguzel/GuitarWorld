using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            ToTable("Orders");
            HasKey(x => x.OrderID);

            HasRequired(x => x.Employee).WithMany(x => x.Orders).HasForeignKey(x => x.EmployeeID);
            HasRequired(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerID);
            HasRequired(x => x.Shipper).WithMany(x => x.Orders).HasForeignKey(x => x.ShipVia);

            Property(x => x.OrderDate).HasColumnType("datetime2");
            Property(x => x.RequiredDate).HasColumnType("datetime2");
            Property(x => x.ShippedDate).HasColumnType("datetime2");
            Property(x => x.Freight).HasColumnType("money");
            Property(x => x.ShipName).HasMaxLength(50);
            Property(x => x.ShipAddress).HasMaxLength(50);
            Property(x => x.ShipCity).HasMaxLength(50);
            Property(x => x.ShipRegion).HasMaxLength(50);
            Property(x => x.ShipPostalCode).HasMaxLength(10);
            Property(x => x.ShipCountry).HasMaxLength(15);

        }
    }
}
