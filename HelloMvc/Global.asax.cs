using HelloMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelloMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            
        }

       

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            if(User != null && User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                var user = UserService.FindById(userName);

                GenericIdentity identity = new GenericIdentity(userName);
                IPrincipal principal = new GenericPrincipal(identity, new string[] { user.Role });

                Context.User = principal;

            }
        }

    }
}
