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

public partial class ManageVirtualtour : System.Web.UI.Page
{
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        string sessval = (string)Session["deleted"];
        if (sessval == "true")
        {
            status.InnerText = "Image Deleted Succesfully";
            Session.Remove("deleted");
        }
        if (sessval == "uploaded")
        {
            status.InnerText = "Image Added Succesfully";
            Session.Remove("deleted");
        }

        cnn.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        cnn.Open();
        cmd.CommandText = "select  * from [virtualtour]";
        cmd.Connection = cnn;
        da.SelectCommand = cmd;
        ds.Clear();
        da.Fill(ds);
        if (!IsPostBack)
        {
            mgimg.DataSource = ds;
            mgimg.DataBind();
        }
        
    }
    protected string getimg(string virtualid,string imagename)   
    {
        string strhtml = "";
        try
        {
            if (!string.IsNullOrEmpty(imagename))
            {
                string ImageName = imagename;
                string DirPath = Path.Combine("../", "slider");
                DirPath = DirPath.Replace("\\", "/");

                if (File.Exists(Path.Combine(Server.MapPath(DirPath), ImageName)))
                {
                    // strhtml = "<td align='left' valign='top' style='width:12%;'>";AddProductDetails.aspx?category=" + category_name + "
                    strhtml += "<td width=\"50\"><div style='padding: 8px;float:left;'><img src='" + DirPath + "/" + ImageName + "' alt='' class='grid_pro_image'  /></td>";
                    strhtml += "<td><div class='productretrive'>" + imagename + "</td></div></div>";
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
            cmd.CommandText = "delete from [virtualtour] where virtualimg_id=" + eg.CommandArgument;

            int delerw = cmd.ExecuteNonQuery();
            if (delerw > 0)
            {
                Session["deleted"] = "true";
                Response.Redirect("ManageVirtualtour.aspx");
            }
            else
            {
                Session["deleted"] = "false";
                Response.Redirect("ManageVirtualtour.aspx");
            }

        }
    }
}