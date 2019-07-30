using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            ToTable("Customers");
            HasKey(x => x.CustomerID);

            Property(x => x.CompanyName).HasMaxLength(50);
            Property(x => x.ContactName).HasMaxLength(50);
            Property(x => x.ContactTitle).HasMaxLength(30);
            Property(x => x.Address).HasMaxLength(150);
            Property(x => x.City).HasMaxLength(20);
            Property(x => x.Region).HasMaxLength(25);
            Property(x => x.PostalCode).HasMaxLength(10);
            Property(x => x.Country).HasMaxLength(25);
            Property(x => x.Phone).HasMaxLength(24);
            Property(x => x.Fax).HasMaxLength(24);
        }
    }
}
