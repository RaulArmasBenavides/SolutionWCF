using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraASPClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page peru.";

            return View();
        }

        public ActionResult Quejas()
        {
            ViewBag.Message = "Este es mi nueva pantalla para quejas.";

            return View();
        }
        public ActionResult inicio()
        {
            ViewBag.Message = "Este es mi nueva pantalla de inicio";

            return View();
        }
    }
}