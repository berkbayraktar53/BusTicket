using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ManagerMap : EntityTypeConfiguration<Manager>
    {
        public ManagerMap()
        {
            ToTable(@"Managers", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Password).HasColumnName("Password");
        }
    }
}