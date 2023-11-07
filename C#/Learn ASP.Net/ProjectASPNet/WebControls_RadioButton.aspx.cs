using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASPNet
{
    public partial class WebControls_RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            genderId.Text = "";

            if (RadioButton1.Checked)
            {
                genderId.Text = "Your gender is " + RadioButton1.Text;
            }
            else genderId.Text = "Your gender is " + RadioButton2.Text;

        }
    }
}