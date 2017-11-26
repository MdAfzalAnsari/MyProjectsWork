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

public partial class admin_AddUsefullinks : System.Web.UI.Page
{
    string linki = "";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        cnn.ConnectionString = connection;
        linki = Request.QueryString["lid"];
        if (linki != null)
        {
            Addlinkbt.Text="Update";
            cnn.Open();
            cmd.CommandText = "select * from usefulllinks where linkid=" + linki;
            cmd.Connection = cnn;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (!Page.IsPostBack)
                {
                    LinkName.Text = reader.GetString(1);
                    LinkNameAddress.Text= reader.GetString(2);
                }
                reader.Close();
            }
            cnn.Close();
        }
    }

    protected void adduselink(object sender, EventArgs e)
    {
        if (linki != null)
        {
            cnn.Open();
            cmd.CommandText = "update usefulllinks set linkname='" + LinkName.Text + "', linkhref='" + LinkNameAddress.Text + "' where linkid="+linki;
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["addlink"] = "true";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            else
            {
                Session["addlink"] = "false";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            cnn.Close();
        }
        else
        {
            cnn.Open();
            cmd.CommandText = "insert into usefulllinks values('" + LinkName.Text + "','" + LinkNameAddress.Text + "')";
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["addlink"] = "true";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            else
            {
                Session["addlink"] = "false";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            cnn.Close();
        }
    }

}