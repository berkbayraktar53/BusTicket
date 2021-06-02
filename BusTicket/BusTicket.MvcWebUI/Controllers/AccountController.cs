using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BusTicket.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        public ActionResult Login()
        {
            return View();
        }
        BusTicketContext context = new BusTicketContext();
        [HttpPost]
        public ActionResult Login(Customer c, Manager m)
        {
            var customer = context.Customers.FirstOrDefault(u => u.Email == c.Email && u.Password == c.Password);
            var manager = context.Managers.FirstOrDefault(u => u.Email == m.Email && u.Password == m.Password);
            if (customer != null)
            {
                FormsAuthentication.SetAuthCookie(customer.Email, false);
                return RedirectToAction("Index", "Home");
            }
            if (manager != null)
            {
                FormsAuthentication.SetAuthCookie(manager.Email, false);
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Customer user)
        {
            context.Customers.Add(user);
            context.SaveChanges();
            return RedirectToAction("Login", "Account");
        }
    }
}