using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetStateManagement
{
    public partial class Default : System.Web.UI.Page
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



            if (Session["StartTime"] == null)
            {
                Session["StartTime"] = DateTime.Now;
            }

            if (!IsPostBack)
            {
                
                //foreach(var product in ProductRepository.GetProducts())
                //{
                //    HyperLink link = new HyperLink();
                //    link.Text = product.Name;
                //    link.NavigateUrl = $"/Details.aspx?pid={product.Id}";

                //    Page.Controls.Add(link);
                //    Literal literal = new Literal();
                //    literal.Text = "<br />";
                //    Page.Controls.Add(literal);
                //}

                foreach(var product in ProductRepository.GetProducts())
                {
                    ddlSelectProduct.Items.Add(new ListItem(product.Name, product.Id.ToString()));
                }


                ViewState["PageLoadTime"] = DateTime.Now;
            }

            if (IsPostBack)
            {
                lblProduct.Text = ViewState["SelectedProduct"] != null ? ViewState["SelectedProduct"].ToString()  : "";
            }

            lblPageView.Text = Session["PageViewCount"].ToString();
            Label1.Text = Application["PageViewCount"].ToString();
        }

        protected void ddlSelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["SelectedProduct"] = ddlSelectProduct.SelectedValue;
        }
    }
}