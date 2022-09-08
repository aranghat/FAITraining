using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class ValidationForms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source
            , ServerValidateEventArgs args)
        {
            var password = args.Value;

            int totalSpecialChars = 0;

            char[] allowedChars = { '#', '$', '%', '1', '2', '3' };
            foreach(char c in allowedChars)
            {
                if(password.Contains(c))
                {
                    totalSpecialChars++;
                }
            }

            args.IsValid = totalSpecialChars > 2 && password.Length >= 4;
            
        }
    }
}