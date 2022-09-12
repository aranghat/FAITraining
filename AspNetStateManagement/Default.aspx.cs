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
            if(!IsPostBack)
            {
                foreach(var product in ProductRepository.GetProducts())
                {
                    HyperLink link = new HyperLink();
                    link.Text = product.Name;
                    link.NavigateUrl = $"/Details.aspx?pid={product.Id}";

                    Page.Controls.Add(link);
                    Literal literal = new Literal();
                    literal.Text = "<br />";
                    Page.Controls.Add(literal);
                }
            }
        }
    }
}