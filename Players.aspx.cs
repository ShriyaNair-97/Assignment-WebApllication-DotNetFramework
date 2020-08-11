using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassAssignment
{
    public partial class Players : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            Label1.Visible = false;
            Panel2.Visible = false;
            Label2.Visible = false;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Label1.Visible = true;
                Panel3.Visible = true;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Label2.Visible = true;
                Panel2.Visible = true;
            }
        }
    }
}