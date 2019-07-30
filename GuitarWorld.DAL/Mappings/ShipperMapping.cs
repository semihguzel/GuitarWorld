using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class ShipperMapping : EntityTypeConfiguration<Shipper>
    {
        public ShipperMapping()
        {
            ToTable("Shippers");
            HasKey(x => x.ShipperID);

            Property(x => x.CompanyName).HasMaxLength(50);
            Property(x => x.Phone).HasMaxLength(24);

        }
    }
}
