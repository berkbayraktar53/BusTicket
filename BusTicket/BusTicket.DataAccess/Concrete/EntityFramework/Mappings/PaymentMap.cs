using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap()
        {
            ToTable(@"Payments", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");
            Property(x => x.Phone).HasColumnName("Phone");
            Property(x => x.Price).HasColumnName("Price");
        }
    }
}