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

public partial class EditContent : System.Web.UI.Page
{
    string linkid;
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        linkid = Request.QueryString["lid"];
        if (linkid == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!Page.IsPostBack)
        {
            
            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "select pagecontent from  [navlinks] where linkid=" + linkid;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string content = reader.GetString(0);
                Descriptionbox.Text = content;
                CKEditor1.Text = content;
            }
            //Response.Write(linkid);
           
        }
        
        
    }
    protected void updatedata(object sender, EventArgs e)
    {
        try
        {
            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "update [navlinks] set pagecontent='" + Descriptionbox.Text + "'  where linkid=" + linkid;
            int j = com.ExecuteNonQuery();
            if (j > 0)
            {
                Response.Write("done");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
            //Response.Write("update [navlinks] set pagecontent='" + Descriptionbox.Text + "'  where linkid=" + linkid);
        }
        
    }
}