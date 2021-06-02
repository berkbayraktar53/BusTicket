using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTicket.MvcWebUI.Models
{
    public class UserViewModel
    {
        public Customer User { get; set; }
        public List<Customer> Users { get; set; }
    }
}