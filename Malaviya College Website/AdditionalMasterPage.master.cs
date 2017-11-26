using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AdditionalMasterPage : System.Web.UI.MasterPage
{
    int lid;
    string lnname = "";
    string linkdata = "", lname, pglinknames = "";
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
        lnname = System.IO.Path.GetFileName(Request.Url.AbsolutePath);
        int i = lnname.Length;
        lnname = lnname.Substring(0, i - 5);
        if (!Page.IsPostBack)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
            con.Open();
            com.Connection = con;
            com.CommandText = "select linkid ,linkname,pglinkname from [navlinks]";
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
                        bindnavlinks(lid, lname, pglinknames, lnname);
                    }
                }
            }
            reader.Close();
            //Response.Write("Done");
            con.Close();

            //Page.Form.FindControl(st_id);
            bindsubnavlinks(lnname);
            bindslides();
        }
    }

    private void bindslides()
    {
        string data = "";
        con.Open();
        com.Connection = con;
        com.CommandText = "select * from homeslider";
        reader = com.ExecuteReader();
        if (reader.HasRows)
        {
            if (!Page.IsPostBack)
            {
                while (reader.Read())
                {
                    data += "<li><img  src=slides/" + reader.GetString(1) + " alt=" + reader.GetString(1) + "/></li>";
                }
            }
            ul1.InnerHtml = data;
        }
        reader.Close();
        //Response.Write("Done");
        con.Close();
    }

    private void bindnavlinks(int lid, string lname, string pglinks, string lnnames)
    {
        string subl = "";
        string dataval = "";
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        conn.Open();
        com.CommandText = "select sublinkid,sublinkname from sublinks where navid=" + lid;
        com.Connection = conn;
        slinkreader = com.ExecuteReader();
        //Response.Write(lnname);
        if (lnnames == "Default" && lname == "Home")
        {
            leftlink.InnerHtml += "<li class='active' id='" + lname + "' runat='server'><a href='" + lname + ".aspx'>" + lname + "</a></li>";
        }
        else if (lnnames == pglinks)
        {
            leftlink.InnerHtml += "<li class='active' id='" + lname + "' runat='server'><a href='" + pglinks + ".aspx'>" + lname + "</a></li>";
        }
        else
        {
            leftlink.InnerHtml += "<li id='" + lname + "' runat='server'><a href='" + pglinks + ".aspx'>" + lname + "</a></li>";
        }
        slinkreader.Close();

        conn.Close();
    }

    private void bindsubnavlinks(string lnnames)
    {
        int linkidd = -1;
        conn.Open();
        com.CommandText = "select linkid from navlinks where pglinkname='" + lnnames + "'";
        com.Connection = conn;
        //Response.Write("saasa="+lnnames);
        slinkreader = com.ExecuteReader();
        if (slinkreader.HasRows)
        {
            slinkreader.Read();
            linkidd = slinkreader.GetInt32(0);
        }
        else
        {
            //con.Close();

            comm.CommandText = "select navid,sublinkid,sublinkname from sublinks where sublinkname='" + lnnames + "'";
            comm.Connection = con;
            con.Open();
            reader.Close();
            reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                linkidd = reader.GetInt32(0);
                //Response.Write("dasdasdsa=" + linkidd);
            }
            con.Close();

        }
        slinkreader.Close();
        conn.Close();
        com.CommandText = "select sublinkid,sublinkname,subpglinkname from sublinks where navid=" + linkidd;
        conn.Open();
        com.Connection = conn;
        slinkreader = com.ExecuteReader();
        if (slinkreader.HasRows)
        {

            //rightlinks.InnerHtml += "<li><a href='EditContent.aspx?lid=" + lid + "'>" + lname + " Content</a></li>";
            while (slinkreader.Read())
            {

                string sublinkname = slinkreader.GetString(1);
                string pglink = slinkreader.GetString(2);
                //rightlinks.InnerHtml += "<li ><a href='" + pglink + ".aspx'>" + sublinkname + "</a></li>";

            }
            //rightlinks.InnerHtml += "<li><a href='AddPages.aspx'>Add New Page</a></li></ul>" +
            //"</li>";
        }
        else
        {
            //rightlinks.InnerHtml += "<li>" +
            //                        "<h3><span class='icon-dashboard'></span>" + lname + "</h3>" +
            //                        "<ul>" +
            //                            "<li><a href='EditContent.aspx?lid=" + lid + "'>" + lname + " Content</a></li>" +
            //                            "<li><a href='AddPages.aspx'>Add New Page</a></li>" +
            //                        "</ul>" +
            //                    "</li>";
        }
        conn.Close();
    }

}
