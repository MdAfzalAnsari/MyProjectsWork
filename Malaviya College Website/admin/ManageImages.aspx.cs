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

public partial class ManageImages : System.Web.UI.Page
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
            cmd.CommandText = "select * from addedimages";
            cmd.Connection = cnn;
            da.SelectCommand = cmd;
            ds.Clear();
            da.Fill(ds);
            manageimg.DataSource = ds;
            manageimg.DataBind();
        }
        cnn.Close();
    }
    protected string Imagebind(string img_id, string image_name)
    {
        string data="";
        cmd.CommandText = "select * from addedimages";
        cmd.Connection = cnn;
        cmd.CommandText = "select imagename from addedimages where imgid=" + img_id;
        reader=cmd.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Read();
            string ImageName=reader.GetString(0);
            data = "<div><img  src='Pictures/" + ImageName + "' alt='"+ImageName+"' class='grid_pro_image' /><div class='nameimg'>Pictures/"+ImageName+"</div></div>";
        }
        reader.Close();
        return data;
    }
}