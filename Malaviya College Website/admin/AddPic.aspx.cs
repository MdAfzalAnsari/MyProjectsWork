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

public partial class AddPic : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = connection;
        status.Visible = false;
        string sessval = (string)Session["imageval"];
        if (sessval != null)
        {
            status.Visible = true;
            Session.Remove("imageval");
        }

    }
    protected void addimg(object sender, EventArgs e)
    {
        if (ImageUpload.HasFile)
        {
            string thumbname = uploadImage();
            if (thumbname != "failed")
            {
                con.Open();
                com.CommandText = "insert into addedimages values('" + thumbname + "')";
                com.Connection = con;
                com.ExecuteNonQuery();
                Session["imageval"] = "uploaded";
                Response.Redirect("AddPic.aspx");
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
            string DirPath = Path.Combine("Pictures");
            string FileName = ImageUpload.FileName.Substring(ImageUpload.FileName.LastIndexOf("."));

            FileName = ID.ToString() + FileName;


            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            ImageUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), ImageUpload.FileName));

            return ImageUpload.FileName;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }

    }
}