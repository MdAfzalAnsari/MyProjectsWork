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

public partial class admin_ManageGalleryPhotos : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string sessval = (string)Session["photodeleted"];
        if (sessval == "true")
        {
            status.InnerText = "Photo Deleted Succesfully";
            Session.Remove("photodeleted");
        }
        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        cnn.Open();
        cmd.CommandText = "select  * from [photogallerycontent]";
        cmd.Connection = cnn;
        da.SelectCommand = cmd;
        ds.Clear();
        da.Fill(ds);
        if (!IsPostBack)
        {
            mgimg.DataSource = ds;
            mgimg.DataBind();
        }
        cnn.Close();
    }

    protected string getcatname(string category_id)
    {
        //cnn.Open();
        cmd.CommandText = "select categoryname from [photogallery] where category_id=" + category_id;
        //reader = cmd.ExecuteReader();
        string catname=(string)cmd.ExecuteScalar();
        //cnn.Close();
        return "<div class=\"photocatname\">"+catname+"</div>";
        
 
    }
    protected string getimg(string category_id, string category_image, string photoname)
    {
        string strhtml = "";
        try
        {
            if (!string.IsNullOrEmpty(category_image))
            {
                string ImageName = photoname;
                string DirPath = Path.Combine("../", "Photogallery");
                DirPath = DirPath.Replace("\\", "/");

                if (File.Exists(Path.Combine(Server.MapPath(DirPath), ImageName)))
                {
                    // strhtml = "<td align='left' valign='top' style='width:12%;'>";AddProductDetails.aspx?category=" + category_name + "
                    strhtml += "<td width=\"50\"><div style='padding: 8px;float:left;'><img src='" + DirPath + "/" + ImageName + "' alt='' class='grid_pro_image'  /></td>";
                    strhtml += "<td><div class='productretrive'>" + photoname + "</td></div></div>";
                    // strhtml += "<div class='clear h20'></div>";
                }
            }
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }

        return strhtml;
    }
    protected void evaluate(object sender, GridViewCommandEventArgs eg)
    {

        string func = (string)eg.CommandName;
        if (func == "del")
        {
            cnn.Open();
            cmd.CommandText = "delete from [photogallerycontent] where p_id=" + eg.CommandArgument;

            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["photodeleted"] = "true";
                Response.Redirect("ManageGalleryPhotos.aspx");
            }
            else
            {
                Session["photodeleted"] = "false";
                Response.Redirect("ManageGalleryPhotos.aspx");
            }
            cnn.Close();

        }
    }
}