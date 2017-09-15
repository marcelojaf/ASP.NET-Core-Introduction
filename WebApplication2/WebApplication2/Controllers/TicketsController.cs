using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TicketsController : Controller
    {
        [HttpGet("/tix")]
        public IActionResult Index()
        {
            //GO TO THE DATABASE
            //GET SOME MODELS (STUFF)
            var s = new Seat()
            {
                Location = "Orchestra",
                Price = 300.00
            };


            return View(s);
        }

        public string Index2()
        {
            return "Hello from Tickets!";
        }
    }
}