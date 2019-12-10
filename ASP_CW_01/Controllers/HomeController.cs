using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_CW_01.Models;

namespace ASP_CW_01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Hello = ", World!";
            return View();
        }

        public string Hello()
        {
            return "Hello, World";
        }

        public double Sqr(double arg)
        {
            return Math.Sqrt(arg);
        }

        public ActionResult Sum(int a, int b)
        {
            ViewBag.Sum = a + b;
            return View();
        }

        public ActionResult List()
        {
            IEnumerable<Books> books = new List<Books>
            {
                new Books{Id=1, Title="1984", Author="George Orwewll", Price = 300.0},
                new Books{Id=2, Title="The Way Station", Author="Clifard  Simak", Price = 399.0},
                new Books{Id=3, Title="Goblin Reservation", Author="Roger Zhelazny", Price = 250.0},
            };
            //ViewBag.books = books;
            return View(books);
        }
    }
}