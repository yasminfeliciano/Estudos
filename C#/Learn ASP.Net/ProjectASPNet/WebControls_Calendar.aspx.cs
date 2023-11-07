using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASPNet
{
    public partial class WebControls_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectiChanged(object sender, EventArgs e)
        {

            ShowDate.Text = "You Selected: " + Calendar1.SelectedDate.ToString("D");

        }
    }
}