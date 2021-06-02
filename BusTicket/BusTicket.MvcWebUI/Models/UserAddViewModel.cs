using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTicket.MvcWebUI.Models
{
    public class UserAddViewModel
    {
        public IEnumerable<Customer> User { get; set; }
    }
}