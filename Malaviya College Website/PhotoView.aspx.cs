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

public partial class PhotoView : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string cid = Request.QueryString["cid"];
        if (cid != null)
        {
            string phdata = "";
            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "select p_id,cat_id,photoname from photogallerycontent where cat_id=" + cid;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    phdata += "<div class=\"photodiv\">" +
                            "<div class=\"photoimgdiv\"><a href=\"PhotoView_details.aspx?pid=" + reader.GetInt32(0) + "&cid="+reader.GetInt32(1)+"\" class=\"photolink\"><img class=\"photoimgcat\" src=\"Photogallery/" + reader.GetString(2) + "\" alt=\"category\"/></a></div>" +
                            "<div class=\"photocaption\"><a href=\"PhotoView_details.aspx?pid=" + reader.GetInt32(0) + "&cid=" + reader.GetInt32(1) + "\" class=\"photolinka\">" + reader.GetInt32(0) + "</a></div>" +
                            "</div>";
                }
            }
            photodivid.InnerHtml = phdata;
            con.Close();
        }
    }
        
}