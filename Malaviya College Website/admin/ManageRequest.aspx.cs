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

public partial class admin_ManageRequest : System.Web.UI.Page
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
        string ssval = (string)Session["deletedreq"];
        if (ssval != "false" && ssval == "true")
        {
            status.Visible = true;
            status.InnerHtml = "Sucessfully Deleted";
            Session.Remove("deletedreq");
        }        
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from principalreq";
            cmd.Connection = cnn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds);
            mgimg.DataSource = ds;
            mgimg.DataBind();
        }
        cnn.Close();
    }
    protected void evaluate(object sender, GridViewCommandEventArgs eg)
    {

        string func = (string)eg.CommandName;
        if (func == "del")
        {
            cnn.Open();
            cmd.CommandText = "delete from [principalreq] where priid=" + eg.CommandArgument;
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["deletedreq"] = "true";
                Response.Redirect("ManageRequest.aspx");
            }
            else
            {
                Session["deletedreq"] = "false";
                Response.Redirect("ManageRequest.aspx");
            }
            cnn.Close();
        }
    }
}