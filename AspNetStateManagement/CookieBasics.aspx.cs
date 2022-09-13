using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetStateManagement
{
    public partial class CookieBasics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["MyNote"] != null)
            {
                lblNote.Text = $"Gentle Reminder : {Request.Cookies["MyNote"].Value}";
            }
        }

        protected void btnSaveNote_Click(object sender, EventArgs e)
        {
            if(txtNote.Text.Length > 0)
            {
                var cookie = new HttpCookie("MyNote");
                cookie.Value = txtNote.Text;
                cookie.Expires = DateTime.Now.AddDays(7);

                Response.Cookies.Add(cookie);
            }
        }
    }
}
