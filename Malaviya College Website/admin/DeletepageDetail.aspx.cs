using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class admin_DeletepageDetail : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string lid = Request.QueryString["did"];
        Response.Write(lid);
        con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        con.Open();
        com.Connection = con;
        com.CommandText = "delete from navlinks where linkid="+lid;
        int i=com.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Redirect("ManageNavLink.aspx");
        }

    }
}