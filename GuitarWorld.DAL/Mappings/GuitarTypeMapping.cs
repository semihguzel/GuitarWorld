using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class GuitarTypeMapping : EntityTypeConfiguration<GuitarType>
    {
        public GuitarTypeMapping()
        {
            ToTable("GuitarTypes");
            HasKey(x => x.GuitarTypeID);
            Property(x => x.GuitarTypeName).HasMaxLength(30);
        }
    }
}
