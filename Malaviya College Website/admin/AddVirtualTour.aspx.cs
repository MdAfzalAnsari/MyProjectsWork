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

public partial class admin_AddVirtualTour : System.Web.UI.Page
{
    string linki = "";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = connection;
        linki = Request.QueryString["lid"];
        //status.Visible = false;
        //string sessval = (string)Session["imageval"];
        //if (sessval != null)
        //{
        //    status.Visible = true;
        //    Session.Remove("imageval");
        //}
        if (linki != null)
        {
            Addlinkbt.Text = "Update";
            con.Open();
            com.CommandText = "select * from virtualtour where virtualimg_id=" + linki;
            com.Connection = con;            
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (!Page.IsPostBack)
                {
                    photocathead.Text = reader.GetString(1);
                    PhotoDetails.Text = reader.GetString(2);
                }
                reader.Close();
            }
            con.Close();
        }

    }
    protected void addimg(object sender, EventArgs e)
    {
        if (Uploadphotocat.HasFile)
        {
            string thumbname = uploadImage();
            if (thumbname != "failed")
            {
                if (linki != null)
                {
                    con.Open();
                    com.CommandText = "update virtualtour set imagename='" + photocathead.Text + thumbname + "',imagedata='" + PhotoDetails.Text + "'";
                    com.Connection = con;
                    com.ExecuteNonQuery();
                    Session["deleted"] = "uploaded";
                    Response.Redirect("ManageVirtualtour.aspx");
                }
                else
                {
                    con.Open();
                    com.CommandText = "insert into virtualtour values('" + photocathead.Text + thumbname + "','" + PhotoDetails.Text + "')";
                    com.Connection = con;
                    com.ExecuteNonQuery();
                    Session["deleted"] = "uploaded";
                    Response.Redirect("ManageVirtualtour.aspx");
                }
                
                //Response.Write(thumbname + "dasdsadsad");
            }
            //else
            //{
            //    Response.Write(thumbname + "dasdsadsad");
            //}
        }
        else
        {
            Response.Write("Failed To Upload Try Again");
        }

    }
    private string uploadImage()
    {
        try
        {
            string DirPath = Path.Combine("../","slider");
            string FileName = Uploadphotocat.FileName.Substring(Uploadphotocat.FileName.LastIndexOf("."));

            //FileName = ID.ToString() + FileName;


            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            Uploadphotocat.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), photocathead.Text + FileName));

            return FileName;
        }
        catch (Exception ex)
        {
            return "failed";
        }

    }
}