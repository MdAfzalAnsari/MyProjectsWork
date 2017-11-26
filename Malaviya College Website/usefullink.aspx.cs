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

public partial class usefullink : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
                string data="";
                cmd.CommandText = "select * From [usefulllinks] ";
                cnn.ConnectionString = connection;
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data += "<div class=\"sublinks\"><a target=\"_blank\" href=http://" + reader.GetString(2) + " class=\"asublinks\">" + reader.GetString(1) + "</a></div>";
                    }

                    alllinks.InnerHtml = data;
                    reader.Close();
                }
                //Response.Write("select * From [journals] where jid=" + jidstring + " order by jid Desc");
                cnn.Close();
                
            
        }
    }
}