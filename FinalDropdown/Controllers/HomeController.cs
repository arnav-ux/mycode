using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalDropdown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            List<SelectListItem> avenger = new List<SelectListItem>();

            SelectListItem IT = new SelectListItem();
            IT.Text = "ironman";
            IT.Value = "100";
            avenger.Add(IT);

            SelectListItem superhero = new SelectListItem();
            IT.Text = "INFOSYS";
            IT.Value = "100";
            avenger.Add(IT);



            ViewBag.Company = avenger;
            ViewBag.superhero = avenger;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}