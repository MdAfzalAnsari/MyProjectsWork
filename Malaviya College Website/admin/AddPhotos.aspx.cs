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
        string success = (string)Session["photoadded"];        
        if (success != null&&success=="Added")
        {
            status.InnerHtml = "Successfully Added";
            Session.Remove("photoadded");
        }
        if (success != null && success == "fail")
        {
            status.InnerHtml = "Please Try Again";
            Session.Remove("photoadded");
        }
        string pid = Request.QueryString["lid"];
        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        cnn.Open();
        cmd.CommandText = "select  category_id,categoryname from [photogallery]";
        cmd.Connection = cnn;
        da.SelectCommand = cmd;
        ds.Clear();
        da.Fill(ds);
        if (!IsPostBack)
        {
           
            categotylist.DataSource = ds.Tables[0];
            categotylist.DataMember = "category_id";
            categotylist.DataValueField = "categoryname";            
            categotylist.DataBind();
        }
        cnn.Close();
        if (pid != null)
        {
            cmd.CommandText = "select  cat_id,photoname from [photogallerycontent]";
            cmd.Connection = cnn;
            cnn.Open();
            reader=cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                if (!Page.IsPostBack)
                {

                    PhotoName.Text = reader.GetString(1);
                    //categotylist.Text = reader.GetString(0);
                }
            }
        }
        
    }
    protected void addphotogallery(object sender, EventArgs e)
    {
        if (PhotoImageUpload.HasFile)
        {
            string filename = uploadimage();
            if (filename != "Error")
            {
                cnn.Open();
                string catid = categotylist.SelectedValue.ToString();
                cmd.CommandText = "select category_id from [photogallery] where categoryname='" + catid + "'";
                int categoryid = (int)cmd.ExecuteScalar();
                cnn.Close();
                if (categoryid > 0)
                {
                    cnn.Open();
                    cmd.CommandText = "insert into [photogallerycontent] values('" + categoryid + "','" + filename + "')";
                    int addno = cmd.ExecuteNonQuery();
                    if (addno > 0)
                    {
                        Session["photoadded"] = "Added";
                        Response.Redirect("AddPhotos.aspx");
                    }
                    else
                    {
                        Session["photoadded"] = "fail";
                        Response.Redirect("AddPhotos.aspx");
                    }
                    cnn.Close();

                }
            }
        }
    }

    private string uploadimage()
    {
        try
        {            
            string DirPath = Path.Combine("../", "Photogallery");
            string FileName = PhotoImageUpload.FileName.Substring(PhotoImageUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            PhotoImageUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), PhotoName.Text.ToString() + FileName));
            return PhotoName.Text.ToString() + FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }    
}