using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ntier1
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Bll_reg bl = new Bll_reg();
            bl.bll_save(TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text);
            Response.Write("Inserted Successfully");
            Response.Redirect("Display.aspx");
        }
    }
}