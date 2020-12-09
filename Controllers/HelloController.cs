using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int number = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = number;
            return View();
        }
    }
}