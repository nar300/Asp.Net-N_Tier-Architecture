using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ntier1
{
    public partial class Update : System.Web.UI.Page
    {
        DataTable dt;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            Session["id"] = id;
            Bll_reg bl = new Bll_reg();
            dt = bl.fillback(id);
            foreach(DataRow dr in dt.Rows)
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Dob"].ToString();
                TextBox3.Text = dr["Ninumber"].ToString();
                TextBox4.Text = dr["Address"].ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Bll_reg bl = new Bll_reg();
            bl.bll_update(Convert.ToInt32(Session["id"].ToString()),TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text);
            Response.Redirect("Display.aspx");
        }
    }
}