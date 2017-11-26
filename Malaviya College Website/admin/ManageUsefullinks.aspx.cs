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

public partial class admin_ManageUsefullinks : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        status.Visible = false;
        cnn.ConnectionString = connection;
        cnn.Open();
        string ssval = (string)Session["addlink"];
        if (ssval != "false" && ssval == "true")
        {
            status.Visible = true;
            status.InnerHtml = "Sucessfully Added";
            Session.Remove("addlink");
        }
        string ssvald = (string)Session["deletedlink"];
        if (ssvald != "false" && ssvald == "true")
        {
            status.Visible = true;
            status.InnerHtml = "Sucessfully Deleted";
            Session.Remove("deletedlink");
        }
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from usefulllinks";
            cmd.Connection = cnn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds);
            mgalimg.DataSource = ds;
            mgalimg.DataBind();
        }
        cnn.Close();
    }
    protected void evaluate(object sender, GridViewCommandEventArgs eg)
    {

        string func = (string)eg.CommandName;
        if (func == "del")
        {
            cnn.Open();
            cmd.CommandText = "delete from [usefulllinks] where linkid=" + eg.CommandArgument;
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["deletedlink"] = "true";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            else
            {
                Session["deletedlink"] = "false";
                Response.Redirect("ManageUsefullinks.aspx");
            }
            cnn.Close();
        }
    }
}