using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class GuitarBrandMapping : EntityTypeConfiguration<GuitarBrand>
    {
        public GuitarBrandMapping()
        {
            ToTable("GuitarBrands");
            HasKey(x => x.GuitarBrandID);
            Property(x => x.GuitarBrandName).HasMaxLength(100);
        }
    }
}
