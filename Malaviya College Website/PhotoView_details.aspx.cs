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

public partial class PhotoView_details : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string cid = Request.QueryString["cid"];
        string pid = Request.QueryString["pid"];
        if (cid != null && pid != null)
        {
            string phdata = "";
            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "select p_id,cat_id,photoname from photogallerycontent where p_id=" + pid;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();               
                phdata = "<img Class=\"largeview\" src=Photogallery/" + reader.GetString(2) + "/>";
                reader.Close();
            }
            else
            {

            }
            com.Connection = con;
            com.CommandText = "select p_id,cat_id,photoname from photogallerycontent where p_id <" + pid + "AND cat_id=" + cid + "order by p_id";
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                {
                    int p_id = reader.GetInt32(0);
                    prev.NavigateUrl = "PhotoView_details.aspx?pid=" + p_id + "&cid=" + cid;
                }
                reader.Close();
            }
            else
            {

            }
            con.Close();
            com.Connection = con;
            com.CommandText = "select p_id,cat_id,photoname from photogallerycontent where p_id >"+pid+"AND cat_id="+cid+"order by p_id";
            con.Open();
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                {
                    int p_id = reader.GetInt32(0);
                    next.NavigateUrl = "PhotoView_details.aspx?pid=" + p_id + "&cid=" + cid;
                }
                reader.Close();
            }
            else
            {
                
            }
            photodivid.InnerHtml = phdata;
            con.Close();
        }
        else
        {
            Response.Redirect("Photogallery.aspx");
        }
    }
}