using BusTicket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Location { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
    }
}