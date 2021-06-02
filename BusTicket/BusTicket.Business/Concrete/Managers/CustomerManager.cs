using BusTicket.Business.Abstract;
using BusTicket.DataAccess.Abstract;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Business.Concrete.Managers
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer user)
        {
            _customerDal.Add(user);
        }

        public Customer GetByEmailAndPassword(string email, string password)
        {
            return _customerDal.Get(u => u.Email == email && u.Password == password);
        }
    }
}