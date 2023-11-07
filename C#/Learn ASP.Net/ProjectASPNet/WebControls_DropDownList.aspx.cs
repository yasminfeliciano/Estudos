using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASPNet
{
    public partial class WebControls_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedValue == "")
            {
                Label1.Text = "Please Select a City";
            }
            else
                Label1.Text = "Your Choice is: " + DropDownList1.SelectedValue;

        }
    }
}