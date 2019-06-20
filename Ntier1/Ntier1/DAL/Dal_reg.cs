using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Dal_reg
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ntier.mdf;Integrated Security=True");
    
    
    public void Dal_save(string Name, string Dob, string Ninumber, string Address)
    {
        if(con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Client values('"+Name.ToString()+ "','" + Dob.ToString() + "','" + Ninumber.ToString() + "','" + Address.ToString() + "')";
        cmd.ExecuteNonQuery();

    }

    public DataTable Dal_Display()
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Client";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        return dt;
    }
    public DataTable fillback(int id)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Client where id="+id+"";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        return dt;
    }
    public void Dal_update(int id,string Name, string Dob, string Ninumber, string Address)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        
       
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update Client set Name='" + Name.ToString() + "',Dob='" + Dob.ToString() + "',Ninumber='" + Ninumber.ToString() + "',Address='" + Address.ToString() + "' where id="+id+"";
        cmd.ExecuteNonQuery();

    }
    public void Dal_delete(int id)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from Client where id="+id+"";
        cmd.ExecuteNonQuery();

    }

    public DataTable Dal_Search(string Name)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();

        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Client  where name like('%" + Name.ToString() + "%')";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        return dt;
    }
}
