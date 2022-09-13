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
        }
    }
}