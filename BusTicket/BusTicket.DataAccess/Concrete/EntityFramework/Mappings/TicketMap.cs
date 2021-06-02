using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            ToTable(@"Tickets", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Date).HasColumnName("Date");
            Property(x => x.DepartureTime).HasColumnName("DepartureTime");
            Property(x => x.ArrivalTime).HasColumnName("ArrivalTime");
            Property(x => x.Location).HasColumnName("Location");
            Property(x => x.SeatNumber).HasColumnName("SeatNumber");
            Property(x => x.Price).HasColumnName("Price");
        }
    }
}