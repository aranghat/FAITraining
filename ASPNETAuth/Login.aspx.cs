using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETAuth
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"[{DateTime.Now}] -> User Initiating Authenitcaiton");
            Trace.Write($"[{DateTime.Now}] -> User {txtUserName.Text} has signed in");

            if (FormsAuthentication
                .Authenticate(txtUserName.Text, txtPassword.Text))
            {
                Debug.WriteLine($"[{DateTime.Now}] -> User {txtUserName.Text} has signed in");
                Trace.Write($"[{DateTime.Now}] -> User {txtUserName.Text} has signed in");
                FormsAuthentication
                    .RedirectFromLoginPage(txtUserName.Text
                    , false);
            }
            else
                Debug.WriteLine($"[{DateTime.Now}] -> Login failed for {txtUserName.Text}");

            throw new Exception("Some random exception occured");
        }
    }
}