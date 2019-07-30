using GuitarWorld.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DAL.Mappings
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            ToTable("Employees");
            HasKey(x => x.EmployeeID);

            HasRequired(x => x.Employee1).WithMany(x => x.Employees).HasForeignKey(x => x.ReportsTo);

            Property(x => x.LastName).HasMaxLength(30);
            Property(x => x.FirstName).HasMaxLength(30);
            Property(x => x.Title).HasMaxLength(30);
            Property(x => x.TitleOfCourtesy).HasMaxLength(30);
            Property(x => x.Address).HasMaxLength(150);
            Property(x => x.City).HasMaxLength(20);
            Property(x => x.Region).HasMaxLength(30);
            Property(x => x.PostalCode).HasMaxLength(10);
            Property(x => x.Country).HasMaxLength(20);
            Property(x => x.HomePhone).HasMaxLength(24);
        }
    }
}
