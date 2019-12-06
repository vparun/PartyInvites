using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    ViewData["Message"] = "Your application description page.";
        //    ViewData["Message1"] = "Hi Welcome";
        //    return View("Myview");

        //}

        public ViewResult Index()
        {
            ViewData["Message1"] = "Hi Welcome";
            ViewData["Message"] = "Your application description page.";
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morging" : "Good Afternoon";

            return View("Myview");

        }

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponses(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }

        public ViewResult ListResponses()
        {
            
            return View(Repository.enumerableResponses.Where(r => r.WillAttend == true));
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
