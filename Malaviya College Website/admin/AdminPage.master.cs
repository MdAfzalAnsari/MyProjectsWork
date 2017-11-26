using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AdminPage : System.Web.UI.MasterPage
{
    int lid;
    string linkdata = "", lname, pglinknames="";
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        if (!Page.IsPostBack)
        {
            
            con.Open();
            com.Connection = con;
            com.CommandText = "select linkid ,linkname,pglinkname from navlinks";
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    if (!Page.IsPostBack)
                    {
                        lid = reader.GetInt32(0);
                        lname = reader.GetString(1);
                        pglinknames = reader.GetString(2);
                        bindnavlinks(lid, lname, pglinknames);
                    }
                }
            }
            reader.Close();
            //Response.Write("Done");
            con.Close();
        }
    }

    private void bindnavlinks(int lid,string lname,string pglinks)
    {
       
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        conn.Open();
        com.CommandText = "select sublinkid,sublinkname from sublinks where navid=" + lid;
        com.Connection = conn;
        slinkreader= com.ExecuteReader();
       
        if (slinkreader.HasRows)
        {
            leftlink.InnerHtml += "<li>" +
                                          "<h3><span class='icon-dashboard'></span>" + lname + "</h3>" +
                                          "<ul>";
            leftlink.InnerHtml += "<li><a href='EditContent.aspx?lid=" + lid + "' class='contentpage'>" + lname + " Content</a></li>";
            while (slinkreader.Read())
            {
                
                string sublinkname=slinkreader.GetString(1);
                leftlink.InnerHtml += "<li><a class='asublink' href='EditsubContent.aspx?lid="+slinkreader.GetInt32(0)+"'>" + sublinkname + "</a><a href='deletesublink.aspx?dpagid=" + slinkreader.GetInt32(0) + "' class='delepg'><img src='images/delete_icon_2.png' alt='' class='dimage'/></a></li>";                
                
            }
            leftlink.InnerHtml += "<li><a href='AddPages.aspx?pgid=" + lid + "' class='contentpage'>Add New Page</a></li></ul>" +
            "</li>";
        }
        else
        {
            leftlink.InnerHtml += "<li>" +
                                    "<h3><span class='icon-dashboard'></span>" + lname + "</h3>" +
                                    "<ul>" +
                                        "<li><a href='EditContent.aspx?lid=" + lid + "' class='contentpage'>" + lname + " Content</a></li>" +
                                        "<li><a href='AddPages.aspx?pgid=" + lid + "' class='contentpage'>Add New Page</a></li>" +  
                                    "</ul>" +
                                "</li>";
        }
        conn.Close();
    }

    //private object bindsublinks(int lid, string lname)
    //{
        
    //}

}
