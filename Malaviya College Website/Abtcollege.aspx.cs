using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

public partial class Abtcollege : System.Web.UI.Page
{
    int ID = 0, lid;
    string thumbname = "", lname = "";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from [navlinks] where linkid=3";
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lid = reader.GetInt32(0);
                    lname = reader.GetString(1);
                    //bnavlinks(lid,lname);
                    contentr.InnerHtml = reader.GetString(4);
                }
            }
            reader.Close();
            //Response.Write("Done");
            con.Close();
        }
    }
}