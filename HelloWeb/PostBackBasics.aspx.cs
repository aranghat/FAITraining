using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class PostBackBasics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hdnSomeContent.Value = "Some Important Data";
                ddlFavHeros.Items.Add(new ListItem("Iron Man", "1"));
                ddlFavHeros.Items.Add(new ListItem("Captain America", "2"));
                ddlFavHeros.Items.Add(new ListItem("Hulk", "3"));

                ddlFavHeros.SelectedIndex = -1;
                ddlFavHeros.Items[0].Selected = false;
                
            }
        }

        protected void btnSeletHero_Click(object sender, EventArgs e)
        {
           
        }

        protected void ddlFavHeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = $@" Selected Value : {ddlFavHeros.SelectedValue} 
                            Selected Text : {ddlFavHeros.SelectedItem.Text}
                            Selected Index : {ddlFavHeros.SelectedIndex}";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = TextBox1.Text;
        }
    }
}