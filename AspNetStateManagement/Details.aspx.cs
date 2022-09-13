using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetStateManagement
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Application["PageViewCount"] == null)
                Application["PageViewCount"] = 1;
            else
                Application["PageViewCount"] = (int)Application["PageViewCount"] + 1;

            if (Session["PageViewCount"] == null)
                Session["PageViewCount"] = 1;
            else
                Session["PageViewCount"] = (int)Session["PageViewCount"] + 1;

            if (Request["pid"] != null)
            {
                var productid = Request.QueryString["pid"];
                Product p = ProductRepository
                    .FindById(int.Parse(productid));

                lblProductName.Text = p.Name;
            }

            if(PreviousPage != null)
            {
                var ddl = (DropDownList)PreviousPage
                    .FindControl("ddlSelectProduct");
                Product p = ProductRepository
                    .FindById(int.Parse(ddl.SelectedValue));

                lblProductName.Text = p.Name;
            }

            if (Session["StartTime"] != null)
                lblProductName.Text = Session["StartTime"].ToString();

            lblPageView.Text = Session["PageViewCount"].ToString();
            Label1.Text = Application["PageViewCount"].ToString();
        }
    }
}