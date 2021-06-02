using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTicket.MvcWebUI.Models
{
    public class AdminViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Manager> Managers { get; set; }
        public List<Payment> Payments { get; set; }
    }
}