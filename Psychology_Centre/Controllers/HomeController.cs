using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Psychology_Centre.Models;

namespace Psychology_Centre.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DataTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "good afternoon";
        }
    }
}
