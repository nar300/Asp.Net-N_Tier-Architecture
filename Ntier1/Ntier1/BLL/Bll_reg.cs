using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class Bll_reg
{
    public void bll_save(string Name,string Dob,string Ninumber,string Address)
    {
        Dal_reg dl = new Dal_reg();
        dl.Dal_save(Name.ToString(), Dob.ToString(), Ninumber.ToString(), Address.ToString());
    }
    public DataTable bll_Display()
    {
        Dal_reg dl = new Dal_reg();
        return dl.Dal_Display();
    }

    public DataTable fillback(int id)
    {
        Dal_reg dl = new Dal_reg();
        return dl.fillback(id);
    }
    public void bll_update(int id,string Name, string Dob, string Ninumber, string Address)
    {
        Dal_reg dl = new Dal_reg();
        dl.Dal_update(id,Name.ToString(), Dob.ToString(), Ninumber.ToString(), Address.ToString());
    }
    public void bll_delete(int id)
    {
        Dal_reg dl = new Dal_reg();
        dl.Dal_delete(id);
    }

    public DataTable bll_Search(string Name)
    {
        Dal_reg dl = new Dal_reg();
        return dl.Dal_Search(Name.ToString());
    }
}
