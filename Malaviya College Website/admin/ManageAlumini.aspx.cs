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


public partial class ManageAlumini : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string stateval = (string)Session["deleted"];
        if (stateval=="true")
        {
            status.InnerText = "Alumini Deletion Succesfully";
            Session.Remove("deleted");
        }
        if (stateval == "false")
        {
            status.InnerText = "Alumini Deletion Failed";
            Session.Remove("deleted");
        }
        if (stateval == "updated")
        {
            status.InnerText = "Alumini Updated Succesfully";
            Session.Remove("deleted");
        }
        cnn.ConnectionString = connection;
        cnn.Open();
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from aluminisection";
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
            cmd.CommandText = "delete from aluminisection where aluminiid=" + eg.CommandArgument;
            
            int delerw=cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["deleted"] = "true";
                Response.Redirect("ManageAlumini.aspx");
            }
            else
            {
                Session["deleted"] = "false";
                Response.Redirect("ManageAlumini.aspx");
            }

       }
        if (func == "edit")
        {

        }
    }
    
}