using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String ConnString = ConfigurationManager.ConnectionStrings["MYDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnString))
            {

                SqlCommand cmd = new SqlCommand("Select * from programmer", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();



            }
        }
        }
}