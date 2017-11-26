using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Alumini : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    //SqlConnection conn = new SqlConnection();
    // SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string sessval = (string)Session["addregalumini"];
        if (sessval != null)
        {
            state.InnerText = "Alumini Registered Succesfully";
            Session.Remove("addregalumini");
        }
        con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        con.Open();
        con.Close();
        
        if (!Page.IsPostBack)
        {
            binddataalumini();
            bindregisteralumini();
        }
        
    }

    private void binddataalumini()
    {
        string alumiheadname = "", aluminisection = "",  idata = "";
        int i = 0;
        com.CommandText = "select aluminihead,aluminidetails from aluminisection";
        con.Open();
        com.Connection = con;
        reader = com.ExecuteReader();
        if (reader.HasRows)
        {
            //Response.Write("&#39;");
            while (reader.Read())
            {
                i++;
                alumiheadname = reader.GetString(0);
                aluminisection = reader.GetString(1);                
                idata += "<div class=\"AluminiSection\" >" +
                        "<div class=\"aluminhead\">" + alumiheadname + "</div>" +
                        "<div class=\"aluminisect\">" +aluminisection+ "</div></div>";
                aluminisec.InnerHtml = idata;
            }
            
        }
        con.Close();
        reader.Close();
    }

    private void bindregisteralumini()
    {
        string aluminame = "", aluminicity = "", aluminiprofession = "", data = "", aluminilastname="";
        com.CommandText = "select reg_id,first_name,last_name,city,Professional from aluminiRegister";
        con.Open();
        com.Connection = con;
        reader=com.ExecuteReader();
        if (reader.HasRows)
        {
            //Response.Write("&#39;");
            while (reader.Read())
            {
                aluminame = reader.GetString(1);
                aluminilastname = reader.GetString(2);
                aluminicity = reader.GetString(3);
                aluminiprofession = reader.GetString(4);
                data += "<div class=\"tabcontent\">" +
                            "<div class=\"tabdata\">" + aluminame +" "+ aluminilastname+"</div>" +
                            "<div class=\"tabdata\">" + aluminicity + "</div>" +
                            "<div class=\"tabdata\">" + aluminiprofession + "</div>" +
                        "</div>";
                regcontent.InnerHtml = data;
            }
            
        }
        con.Close();
        reader.Close();
    }
}