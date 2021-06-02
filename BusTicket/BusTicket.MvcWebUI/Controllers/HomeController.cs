using BusTicket.DataAccess.Concrete.EntityFramework;
using BusTicket.Entities.Concrete;
using BusTicket.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTicket.MvcWebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        BusTicketContext context = new BusTicketContext();
        public ActionResult Index()
        {
            List<SelectListItem> location = (from i in context.Tickets.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.Location,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            List<SelectListItem> seatNumber = (from i in context.Tickets.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.SeatNumber.ToString(),
                                                   Value = i.Id.ToString()
                                               }).ToList();
            ViewBag.set = seatNumber;
            ViewBag.loc = location;

            var result = new TicketViewModel
            {
                Tickets = context.Tickets.ToList()
            };
            return View(result);
        }
        public ActionResult Bus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PayTicket(Payment payment)
        {
            context.Payments.Add(payment);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FindTicket(Ticket ticket)
        {
            var result = context.Tickets.FirstOrDefault(t => t.Location == ticket.Location || t.Date == ticket.Date || t.SeatNumber == ticket.SeatNumber);
            if (result != null)
            {
                return RedirectToAction("Index", "Ticket");
            }
            return View();
        }
    }
}