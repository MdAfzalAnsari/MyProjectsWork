using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Logic;

public partial class admin_AddPhotos : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
                         
        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;                
        
    }
    protected void addphotogallery(object sender, EventArgs e)
    {
        if (PhotoImageUpload.HasFile)
        {
            string filename = uploadimage();
            if (filename != "Error")
            {
                cnn.Open();

                cmd.CommandText = "insert into homeslider values('" + filename + "')";
                cmd.Connection = cnn;
                int categoryid = cmd.ExecuteNonQuery();
                if (categoryid > 0)
                {
                    Session["deleted"] = "true";
                    Response.Redirect("ManagesliderImages.aspx");
                }
                cnn.Close();
                
            }
        }
    }
    protected void acancelpro(object sender, EventArgs e)
    {
        Response.Redirect("ManagesliderImages.aspx");
    }
    

    private string uploadimage()
    {
        try
        {            
            string DirPath = Path.Combine("../", "slides");
            string FileName = PhotoImageUpload.FileName.Substring(PhotoImageUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            PhotoImageUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), PhotoImageUpload.FileName));
            return PhotoImageUpload.FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }    
}