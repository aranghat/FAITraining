using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPNETAuth
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\FATraining\Temp\WebAppLog.txt", $"[{DateTime.Now}] -> First User is here/Application started\n");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\FATraining\Temp\WebAppLog.txt", $"[{DateTime.Now}] -> User Time Out/Application Ended\n");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\FATraining\Temp\WebAppLog.txt", $"[{DateTime.Now}] -> Session started\n");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\FATraining\Temp\WebAppLog.txt", $"[{DateTime.Now}] -> Session ended\n");
        }

         protected void Application_Error(object sender, EventArgs e)
        {
            var lastError = Server.GetLastError();
            File.AppendAllText(@"D:\FATraining\Temp\WebAppLog.txt", $"[{DateTime.Now}] -> ERROR: {lastError.InnerException.Message}\n");
            Response.Redirect("Error.aspx");
        }
    }
}