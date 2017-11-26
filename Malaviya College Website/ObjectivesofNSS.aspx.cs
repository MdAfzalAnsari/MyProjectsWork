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

public partial class ObjectivesofNSS : System.Web.UI.Page
{
    int ID = 0,lid;
    string thumbname = "",lname="";
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
            com.CommandText = "select * from [sublinks] where sublinkid=40";
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lid = reader.GetInt32(0);
                    lname = reader.GetString(2);
                    //bnavlinks(lid,lname);
                    contentr.InnerHtml =reader.GetString(3);
                }
            }
            reader.Close();
            //Response.Write("Done");
            con.Close();
        }
    }
    //private void bindnavlinks(int lid,string lname)
}