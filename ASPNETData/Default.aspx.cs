using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNETData
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionStr = ConfigurationManager
                                        .ConnectionStrings["SREE_EMPLOYEEDBConnectionString"]
                                        .ConnectionString;

            using (var con = new SqlConnection(connectionStr))
            {
                SqlCommand cmd    = new SqlCommand("select * from customers", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand  = cmd;

                DataTable table = new DataTable();
                da.Fill(table);

                GridView2.DataSource = table;
                GridView2.DataBind();
            }

        }
    }
}