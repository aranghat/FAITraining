using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelloMvc.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username
            , string password)
        {
            if (username == "sree" 
                && password == "12345")
            {
                FormsAuthentication
                    .RedirectFromLoginPage("sree",false);
            }
            else
                ViewBag.Error = "Login Failed";

            return View();
        }
    }
}