using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class GuitarMapping : EntityTypeConfiguration<Guitar>
    {
        public GuitarMapping()
        {
            ToTable("Guitars");
            HasKey(x => x.GuitarID);
            //Mappings between tables with PK - FK
            HasRequired(x => x.GuitarType).WithMany(x => x.Guitars).HasForeignKey(x => x.GuitarTypeID);
            HasRequired(x => x.GuitarModel).WithMany(x => x.Guitars).HasForeignKey(x => x.GuitarModelID);
            HasRequired(x => x.Supplier).WithMany(x => x.Guitars).HasForeignKey(x => x.SupplierID);
            //Specified column types
            Property(x => x.GuitarName).HasMaxLength(75);
            Property(x => x.GuitarColor).HasMaxLength(25);
            Property(x => x.GuitarPrice).HasColumnType("money");
            Property(x => x.ShortDescription).HasMaxLength(125);
            Property(x => x.LongDescription).HasMaxLength(750);
            Property(x => x.GuitarPicture1).HasMaxLength(150);
            Property(x => x.GuitarPicture2).HasMaxLength(150);
            Property(x => x.GuitarPicture3).HasMaxLength(150);
            Property(x => x.GuitarPicture4).HasMaxLength(150);

        }
    }
}
