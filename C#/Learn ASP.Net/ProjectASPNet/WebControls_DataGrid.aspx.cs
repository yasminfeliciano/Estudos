using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASPNet
{
    public partial class WebControls_DataGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Rows.Add("101", "Deepak Kumar", "deepak@example.com");
            table.Rows.Add("102", "John", "john@example.com");
            table.Rows.Add("103", "Subramanium Swami", "subramanium@example.com");
            table.Rows.Add("104", "Abdul Khan", "abdul@example.com");
            DataGrid1.DataSource = table;
            DataGrid1.DataBind();

        }
    }
}