using BusTicket.Core.DataAccess;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.DataAccess.Abstract
{
    public interface ITicketDal : IEntityRepository<Ticket>
    {

    }
}