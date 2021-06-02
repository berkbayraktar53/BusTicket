using BusTicket.Business.Abstract;
using BusTicket.Business.Concrete.Managers;
using BusTicket.DataAccess.Abstract;
using BusTicket.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();

            Bind<IManagerService>().To<ManagerManager>().InSingletonScope();
            Bind<IManagerDal>().To<EfManagerDal>().InSingletonScope();

            Bind<ITicketService>().To<TicketManager>().InSingletonScope();
            Bind<ITicketDal>().To<EfTicketDal>().InSingletonScope();

            Bind<IPaymentService>().To<PaymentManager>().InSingletonScope();
            Bind<IPaymentDal>().To<EfPaymentDal>().InSingletonScope();

            Bind<DbContext>().To<BusTicketContext>();
        }
    }
}