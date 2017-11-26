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

public partial class photogallery : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string phdata = "";
        con.ConnectionString = connection;
        con.Open();
        com.Connection = con;
        com.CommandText = "select categoryname,categoryimage,category_id from photogallery";
        reader = com.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                phdata +="<div class=\"photodiv\">"+
                        "<div class=\"photoimgdiv\"><a href=\"PhotoView.aspx?cid=" + reader.GetInt32(2) + "\" class=\"photolink\"><img class=\"photoimgcat\" src=\"PhotoCategoryImages/" + reader.GetString(1) + "\" alt=\"category\"/></a></div>" +
                        "<div class=\"photocaption\"><a href=\"PhotoView.aspx?cid=" + reader.GetInt32(2) + "\" class=\"photolinka\">" + reader.GetString(0) + "</a></div>" +
                        "</div>";
            }
        }
        photodivid.InnerHtml = phdata;
    }
}