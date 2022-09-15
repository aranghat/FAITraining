using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETMasterPage
{
    public partial class Detaule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label label = (Label)Master.FindControl("lblAppName");
            label.Text = "My Sample App";
        }
    }
}