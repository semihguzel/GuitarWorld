using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class SupplierMapping : EntityTypeConfiguration<Supplier>
    {
        public SupplierMapping()
        {
            ToTable("Suppliers");
            HasKey(x => x.SupplierID);
            Property(x => x.CompanyName).HasMaxLength(50);
            Property(x => x.ContactName).HasMaxLength(50);
            Property(x => x.ContactTitle).HasMaxLength(50);
            Property(x => x.Address).HasMaxLength(150);
            Property(x => x.City).HasMaxLength(20);
            Property(x => x.Region).HasMaxLength(20);
            Property(x => x.PostalCode).HasMaxLength(10);
            Property(x => x.Country).HasMaxLength(20);
            Property(x => x.Phone).HasMaxLength(24);
            Property(x => x.Fax).HasMaxLength(24);

        }
    }
}
