﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Web.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
