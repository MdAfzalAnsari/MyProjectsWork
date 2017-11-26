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

public partial class admin_studentsyear : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string year = Request.QueryString["em"];
        year = year.Substring(0, 2);
        if (year == "fy")
        {
            year = "First Year";
            Mange.InnerText = "Manage First Year Students Result";
        }
        else if(year=="sy")
        {
            year = "Second Year";
            Mange.InnerText = "Manage Second Year Students Result";
        }
        else if (year == "ty")
        {
            year = "Third Year";
            Mange.InnerText = "Manage Third Year Students Result";
        }
        cnn.ConnectionString = connection;
        cnn.Open();
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from studentsummary where studentyear='" + year + "'";
            cmd.Connection = cnn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds);
            mgimg.DataSource = ds;
            mgimg.DataBind();           
        }        
        cnn.Close();            
    }
}