using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Psychology_Centre.Models;

namespace Psychology_Centre.Controllers
{
    public class ClientsController : Controller
    {
        Client newClient = new Client();

        [HttpGet]
        public IActionResult Index()
        {
            return View(newClient);
        }

        [HttpPost]
        public IActionResult Index(Client model)
        {
            if (ModelState.IsValid)
                return Content($"{model.PhoneNumberFirst}");
            return View(model);
        }
    }
}