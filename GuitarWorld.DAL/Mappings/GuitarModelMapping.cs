using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class GuitarModelMapping : EntityTypeConfiguration<GuitarModel>
    {
        public GuitarModelMapping()
        {
            ToTable("GuitarModels");
            HasKey(x => x.GuitarModelID);
            HasRequired(x => x.GuitarBrand).WithMany(x => x.GuitarModels).HasForeignKey(x => x.GuitarBrandID);
            Property(x => x.GuitarModelName).HasMaxLength(75);
        }
    }
}
