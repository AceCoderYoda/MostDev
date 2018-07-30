#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Web.HomeController.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MostDev.Web.Models;

#endregion

namespace MostDev.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Console.WriteLine("Constructor!");
            Test();
            Console.WriteLine("Constructor! End");
        }

        private async Task Test()
        {
            Console.WriteLine("Hi!");
            await Task.Delay(10000);
            Console.WriteLine("Hi! End");
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            Thread.Sleep(10_000);

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}