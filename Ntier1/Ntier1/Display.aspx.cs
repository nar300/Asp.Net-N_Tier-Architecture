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
    public partial class Display : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bll_reg bl = new Bll_reg();
            dt = bl.bll_Display();
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Bll_reg bl = new Bll_reg();
            dt = bl.bll_Search(txtSearch.Text);
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}