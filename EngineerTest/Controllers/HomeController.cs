using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EngineerTest.Models;

namespace EngineerTest.Controllers
{
    public class HomeController : Controller
    {
        //private MvcBasicContext db = new MvcBasicContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DataViewer()
        {
            return View();
        }

        /**public IActionResult List()
        {
            return View(db.Members);
        }**/

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
