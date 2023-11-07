using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASPNet
{
    public partial class WebControls_DataGridExampleDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI"))
            {
                SqlDataAdapter sde = new SqlDataAdapter("Select * from student", con);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();

            }
        }
    }
}