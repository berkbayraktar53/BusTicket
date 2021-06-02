using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.Entities.Concrete;
using BusTicket.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BusTicket.MvcWebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public AdminController()
        {

        }
        BusTicketContext context = new BusTicketContext();
        public ActionResult Index()
        {
            var result = new AdminViewModel
            {
                Customers = context.Customers.ToList(),
                Tickets = context.Tickets.ToList(),
                Payments = context.Payments.ToList()
            };
            return View(result);
        }
        public ActionResult Setting()
        {
            var result = new AdminViewModel
            {
                Managers = context.Managers.ToList()
            };
            return View(result);
        }
        public ActionResult Customer()
        {
            var result = new AdminViewModel
            {
                Customers = context.Customers.ToList()
            };
            return View(result);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        public ActionResult GetCustomer(int id)
        {
            var result = context.Customers.Find(id);
            return View("GetCustomer", result);
        }
        public ActionResult DeleteCustomer(int id)
        {
            var b = context.Customers.Find(id);
            context.Customers.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Customer");
        }
        public ActionResult UpdateCustomer(Customer customer)
        {
            var result = context.Customers.Find(customer.Id);
            result.Name = customer.Name;
            result.Surname = customer.Surname;
            result.Phone = customer.Phone;
            result.Email = customer.Email;
            result.Password = customer.Password;
            context.SaveChanges();
            return RedirectToAction("Customer");
        }
        public ActionResult GetManager(int id)
        {
            var result = context.Managers.Find(id);
            return View("GetManager", result);
        }
        public ActionResult UpdateManager(Manager manager)
        {
            var result = context.Managers.Find(manager.Id);
            result.Name = manager.Name;
            result.Email = manager.Email;
            result.Password = manager.Password;
            context.SaveChanges();
            return RedirectToAction("Setting");
        }
        public ActionResult DeleteTicket(int id)
        {
            var b = context.Tickets.Find(id);
            context.Tickets.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddManager()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddManager(Manager manager)
        {
            context.Managers.Add(manager);
            context.SaveChanges();
            return RedirectToAction("Setting");
        }
        public ActionResult DeleteManager(int id)
        {
            var b = context.Managers.Find(id);
            context.Managers.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Setting");
        }
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction("Customer");
        }
        public ActionResult GetTicket(int id)
        {
            var result = context.Tickets.Find(id);
            return View("GetTicket", result);
        }
        public ActionResult UpdateTicket(Ticket ticket)
        {
            var result = context.Tickets.Find(ticket.Id);
            result.Date = ticket.Date;
            result.DepartureTime = ticket.DepartureTime;
            result.ArrivalTime = ticket.ArrivalTime;
            result.SeatNumber = ticket.SeatNumber;
            result.Location = ticket.Location;
            result.Price = ticket.Price;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AddTicket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeletePayment(int id)
        {
            var b = context.Payments.Find(id);
            context.Payments.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}