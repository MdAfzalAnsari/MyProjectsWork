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

public partial class admin_Managestlist : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        cnn.ConnectionString = connection;
        cnn.Open();
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from studentsummary";
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
            cmd.CommandText = "delete from [studentsummary] where stuud=" + eg.CommandArgument;
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["deleted"] = "true";
                Response.Redirect("Managestlist.aspx");
            }
            else
            {
                Session["deleted"] = "false";
                Response.Redirect("Managestlist.aspx");
            }
            cnn.Close();
        }
    }
}