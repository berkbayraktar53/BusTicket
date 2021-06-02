using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Abstract
{
    public interface ICustomerService
    {
        Customer GetByEmailAndPassword(string email, string password);
        void Add(Customer user);
    }
}