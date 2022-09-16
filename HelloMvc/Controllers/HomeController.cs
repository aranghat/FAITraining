using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvc.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //Action
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int ctc,string gender)
        {
            var baseTaxAmount = gender == "Male" ? 200000 : 250000;
            if (ctc > baseTaxAmount)
            {
                ViewBag.Tax = ctc * .10;
            }

            return View();
        }


        public ActionResult AboutUs()
        {
            return View();
        }
    }
}