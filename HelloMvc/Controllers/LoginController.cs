using HelloMvc.Models;
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
            var user = UserService.Authenticate(username, password);

            if(user != null)
            { 
                FormsAuthentication
                    .RedirectFromLoginPage(username,false);
            }
            else
                ViewBag.Error = "Login Failed";

            return View();
        }
    }
}