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
    public partial class Delete : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            Bll_reg bl = new Bll_reg();
            bl.bll_delete(id);
            Response.Write("Deleted Succesfully");
            Response.Redirect("Display.aspx");

        }
    }
}