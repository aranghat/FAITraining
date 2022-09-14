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
        List<Product> products = new List<Product>();

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

            products.Add(new Product { Id = 1001, Name = "Coffee"
                , ImageUrl= "https://images.pexels.com/photos/90946/pexels-photo-90946.jpeg?auto=compress&cs=tinysrgb&w=600"});
            products.Add(new Product { Id = 1002, Name = "Tea"
             , ImageUrl= "https://images.pexels.com/photos/734983/pexels-photo-734983.jpeg?auto=compress&cs=tinysrgb&w=600"
            });
            products.Add(new Product { Id = 1003, Name = "Juice",
            ImageUrl = "https://images.pexels.com/photos/1337825/pexels-photo-1337825.jpeg?auto=compress&cs=tinysrgb&w=600"
            });
            products.Add(new Product { Id = 1004, Name = "Green Tea"
                ,ImageUrl = "https://images.pexels.com/photos/814264/pexels-photo-814264.jpeg?auto=compress&cs=tinysrgb&w=600"
            });

            GridView4.DataSource = products;
            GridView4.DataBind();

        }
    }
}