using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class GroupControls : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbFavFruits.Items.Add(new ListItem("Mango", "Mango"));
                lbFavFruits.Items.Add(new ListItem("Apple", "Apple"));
                lbFavFruits.Items.Add(new ListItem("Banana", "Banana"));
                lbFavFruits.Items.Add(new ListItem("Grapes", "Grapes"));
            }
        }

        protected void btnSaveFavFruits_Click(object sender, EventArgs e)
        {
            string favFruits = "";
            foreach(ListItem item in lbFavFruits.Items)
            {
                if(item.Selected)
                {
                    favFruits += item.Text + ",";
                }
            }

            lblSelection.Text = favFruits.Length > 0 ? favFruits : "Please select atleast one item";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible ^= true; 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Enabled ^= true;
        }
    }
}