﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusTicket.MvcWebUI.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}