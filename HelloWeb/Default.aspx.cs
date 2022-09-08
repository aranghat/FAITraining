using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Grosser_Panda.JPG/1280px-Grosser_Panda.JPG";

            //if (!chkIsExempted.Checked)
            //{
            //    var ctc = int.Parse(txtCTC.Text);
            //    var gender = ddlGender.SelectedValue;

            //    var baseAmount = gender == "Female" ? 250000 : 200000;
            //    var tax = ctc >= baseAmount ? ctc * .10F : 0;

            //    lblMessage.Text = $"Your total tax is : {tax}";
            //}
            //else
            //    lblMessage.Text = "You have no tax";
        }
    }
};