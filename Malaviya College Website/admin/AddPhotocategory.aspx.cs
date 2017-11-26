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

public partial class admin_AddPhotocategory : System.Web.UI.Page
{
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Addcategoryphoto(object sender, EventArgs e)
    {
        addimg();
    }
    protected void addimg()
    {
        if (Uploadphotocat.HasFile)
        {
            string thumbname = uploadImage();
            if (thumbname != "failed")
            {
                con.ConnectionString = connection;
                con.Open();
                com.CommandText = "insert into photogallery values('" + photocathead .Text+ "','" + thumbname + "')";
                com.Connection = con;
                com.ExecuteNonQuery();
                Session["photoimageval"] = "uploaded";
                Response.Redirect("Managephotocategory.aspx");
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
            string DirPath = Path.Combine("../", "PhotoCategoryImages");
            string FileName = Uploadphotocat.FileName.Substring(Uploadphotocat.FileName.LastIndexOf("."));

            FileName = ID.ToString() + FileName;


            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            Uploadphotocat.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), Uploadphotocat.FileName));

            return Uploadphotocat.FileName;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }

    }
    
}