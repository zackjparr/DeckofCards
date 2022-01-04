using DeckofCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckofCards.Controllers
{
    public class HomeController : Controller
    {
        CardsDAL cd = new CardsDAL();

        public IActionResult Index()
        {
            Draw d = new Draw();
            d = cd.GetCards();
            return View("Index", d);
        }

        public IActionResult Draw()
        {
            Draw d = new Draw();
            d = cd.Draw5Cards();
            return View(d);
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
