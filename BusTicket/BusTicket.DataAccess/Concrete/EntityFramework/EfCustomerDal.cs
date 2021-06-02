using BusTicket.Core.DataAccess.EntityFramework;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, BusTicketContext>, ICustomerDal
    {

    }
}