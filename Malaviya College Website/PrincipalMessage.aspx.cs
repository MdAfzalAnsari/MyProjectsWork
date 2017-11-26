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

public partial class PrincipalMessage : System.Web.UI.Page
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
        string ssval = (string)Session["send"];
        if (ssval != "false" && ssval == "true")
        {
            status.Visible = true;
            status.InnerHtml = "Sucessfully Submitted";
            Session.Remove("send");
        }
       
    }
    protected void sendmessage(object sender, EventArgs e)
    {
        cnn.Open();
        string data = message.Text;
        data.Replace("'","");
        cmd.CommandText = "insert into [principalreq] values('" + FullName.Text.ToString() + "','" + ResidenceAddress.Text + "','" + EmailAddress.Text + "','" + Residencephone.Text + "','" + brief.Text + "','" + message.Text + "','" + Subject.Text + "')";
        cmd.Connection = cnn;
        int insertdata = cmd.ExecuteNonQuery();
        if (insertdata > 0)
        {
            Session["send"] = "true";
            Response.Redirect("PrincipalMessage.aspx");
        }
        else
        {
            Session["send"] = "false";
            Response.Redirect("PrincipalMessage.aspx");
        }
        cnn.Close();
    }
    
}