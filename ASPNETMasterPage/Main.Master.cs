using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETMasterPage
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSetAppName_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)ContentPlaceHolder1.FindControl("txtAppName");
            lblAppName.Text = textBox.Text;
        }
    }
}