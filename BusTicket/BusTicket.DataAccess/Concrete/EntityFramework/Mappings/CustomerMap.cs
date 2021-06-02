using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customers", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");
            Property(x => x.Phone).HasColumnName("Phone");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Password).HasColumnName("Password");
        }
    }
}