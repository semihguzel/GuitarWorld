using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class OrderDetailMapping : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            ToTable("OrderDetails");
            HasKey(x => x.OrderDetailID);

            HasRequired(x => x.Guitar).WithMany(x => x.OrderDetails).HasForeignKey(x => x.GuitarID);
            HasRequired(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderID);

            Property(x => x.UnitPrice).HasColumnType("money");
            Property(x => x.Quantity).HasColumnType("smallint");
            Property(x => x.Discount).HasColumnType("real");
        }
    }
}
