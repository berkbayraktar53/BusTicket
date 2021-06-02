using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTicket.MvcWebUI.Models
{
    public class TicketViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public Ticket Ticket { get; set; }
    }
}