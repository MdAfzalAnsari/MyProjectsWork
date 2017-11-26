using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class VirtualTour : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        cnn.Open();
        cmd.CommandText = "select  * from [virtualtour]";
        cmd.Connection = cnn;
        reader=cmd.ExecuteReader();
        string data="";
        if(reader.HasRows)
        {
            while(reader.Read())
            {
                string imgname=reader.GetString(1);
                string datas=reader.GetString(2);
                data="<li style=\"width: 10%; font-size: 0px;\"><img class=\"virtimage\" src=\"slider/"+imgname+"\" alt=\"\" title=\""+datas+"\"  style=\"visibility: visible;\"/></li>";
                slide.InnerHtml += data;
            }

            reader.Close();
        }
        



        cnn.Close();
        
    }
}