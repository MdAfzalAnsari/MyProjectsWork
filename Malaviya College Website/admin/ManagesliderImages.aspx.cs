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
        string success = (string)Session["deleted"];
        if (success != null && success == "true")
        {
            status.InnerHtml = "Successfully Added";
            Session.Remove("deleted");
        }
        if (success != null && success == "false")
        {
            status.InnerHtml = "Please Try Again";
            Session.Remove("deleted");
        }
        if (success != null && success == "deleteed")
        {
            status.InnerHtml = "Successfully Deleted";
            Session.Remove("deleted");
        }
        cnn.ConnectionString = connection;
        cnn.Open();
        if (!Page.IsPostBack)
        {
            cmd.CommandText = "select * from homeslider";
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
        //cnn.Open();
        cmd.Connection = cnn;
        cmd.CommandText = "select sliderimg from homeslider where slideid=" + img_id;
        reader=cmd.ExecuteReader();
        if (reader.HasRows)
        {
            reader.Read();
            string ImageName=reader.GetString(0);
            data = "<div><img  src='../slides/" + ImageName + "' alt='"+ImageName+"' class='grid_pro_image' /><div class='nameimg'>"+ImageName+"</div></div>";
        }
        reader.Close();
        //cnn.Close();
        return data;
    }
    protected void evaluate(object sender, GridViewCommandEventArgs eg)
    {

        string func = (string)eg.CommandName;
        if (func == "Del")
        {
            Response.Write("asdasdsad");
            cmd.CommandText = "delete from [homeslider] where slideid=" + eg.CommandArgument;
            cnn.Open();
            cmd.Connection = cnn;
            int delerw = cmd.ExecuteNonQuery();
            cnn.Close();
            if (delerw > 0)
            {
                Session["deleted"] = "deleteed";
                Response.Redirect("ManagesliderImages.aspx");
            }
            else
            {
                Session["deleted"] = "false";
                Response.Redirect("ManagesliderImages.aspx");
            }

        }
    }
}