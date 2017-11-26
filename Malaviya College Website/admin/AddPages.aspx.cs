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
public partial class AddPages : System.Web.UI.Page
{
    int ID = 0;
    string thumbname = "";
    string navid;
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string sesspage = (string)Session["NewPage"];
        if (sesspage != null)
        {
            status.InnerText = "Page Generate Succesfully";
            Session.Remove("NewPage");
        }
        navid=Request.QueryString["pgid"];
        if (navid == "" || navid == null)
        {
            Response.Redirect("Default.aspx");
        }        
    }
    String Title = String.Empty;
    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        String root = Server.MapPath("~");

        //String pgTemplate = root + "Malaviya\\admin\\AddPageTemplate.tmp";
        String pgTemplate = root + "\\admin\\AddPageTemplate.tmp";

        StringBuilder line = new StringBuilder();

        using (StreamReader rwOpenTemplate = new StreamReader(pgTemplate))
        {
            while (!rwOpenTemplate.EndOfStream)
            {
                line.Append(rwOpenTemplate.ReadToEnd());
            }
        }


        string SaveFilePath = "";
        string SaveFileName = "";
        Random ran = new Random();
        ID = ran.Next();
        string page_title = txtTitle.Text;
        //Page Name Creator
        Title = txtTitle.Text.Replace(' ', '-').Replace('.', '-').Replace('#', '-').Replace('%', '-').Replace('&', '-').Replace('*', '-').Replace('@', '-').Replace('!', '-').Replace('|', '-').Replace(':', '-').Replace(';', '-').Replace(',', '-').Replace('/', '-').Replace('\\', '-').Replace('?', '-').Replace('<', '-').Replace('>', '-').Replace('"', '-').Replace('“', '-').Replace('”', '-');
        SaveFileName = "\\" + Title + ".aspx";
        SaveFilePath = root +SaveFileName;
        //SaveFilePath = root + "Malaviya" + SaveFileName; //Online purpose
        FileStream fsSave = File.Create(SaveFilePath);

        //Aspx.cs file generation 
        String pgTemplatecs = root + "\\admin\\AddPageTemplatecs.tmp"; //localserver
        //String pgTemplatecs = root + "Malaviya\\admin\\AddPageTemplatecs.tmp"; //online server
        StringBuilder linecs = new StringBuilder();
        using (StreamReader rwOpenTemplatecs = new StreamReader(pgTemplatecs))
        {
            while (!rwOpenTemplatecs.EndOfStream)
            {
                linecs.Append(rwOpenTemplatecs.ReadToEnd());
            }
        }
        SaveFilePath = "";
        SaveFileName = "";
        SaveFileName = "\\" + Title + ".aspx.cs";
        SaveFilePath = root + SaveFileName; //local
        //SaveFilePath = root + "Malaviya" + SaveFileName; //online
        FileStream fsSavecs = File.Create(SaveFilePath);


        if (line != null)
        {
            //line.Replace("[MetaTitle]", txtTitle.Text.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
            //line.Replace("[PageContent]", txtContent.Text);
            //line.Replace("[MetaKeywords]", txtTags.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-'));
            //line.Replace("[Content]", txtContent.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-'));
            //line.Replace("[ID]", ID.ToString());
            line.Replace("[myPageCode.cs]", Title + ".aspx.cs");
            line.Replace("[myPageCode]", Title.ToString());
            //if (imgupload.HasFile)
            //{
            //    thumbname = uploadImage();
            //    if (thumbname != null)
            //    {
            //        line.Replace("[PageContentImage]", "<img src='DyanamicImages/" + thumbname + "' alt='No image'>");
            //    }
            //    if (thumbname == "failed")
            //    {
            //        line.Replace("[PageContentImage]", "<div></div>");
            //    }

            //}
            //if (!imgupload.HasFile)
            //{
            //    line.Replace("[PageContentImage]", "");
            //}

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fsSave);
                sw.Write(line);
                // lnkNewPage.Text = SaveFilePath;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sw.Close();
            }
            string tcontent = txtContent.Text;
            tcontent.Replace("'", "&#39;");
            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into [AddedPages] values('" + Title + "','" + thumbname + "','" + tcontent + "')";
            //com.ExecuteNonQuery();
            Session["NewPage"] = "added";
            con.Close();
            con.Open();
            com.CommandText = "insert into [sublinks] values('" + navid + "','" + SublinkName.Text + "','" + tcontent + "','" + txtTags.Text + "','" + PageTitle.Text + "','" + txtTitle.Text + "')";
            com.ExecuteNonQuery();
            con.Close();
           // Response.Redirect("AddPages.aspx");
        }
        if (linecs != null)
        {
            int li_id = -1;
            com.CommandText = "select sublinkid from [sublinks] where sublinkname='" + SublinkName.Text + "' AND navid=" + navid;
            con.Open();
            com.Connection = con;
            reader = com.ExecuteReader();
            //li_id = (int)com.ExecuteScalar();
            Response.Write("select sublinkid from [sublinks] where sublinkname='" + SublinkName.Text + "' AND navid=" + navid);
            if (reader.HasRows)
            {
               // Response.Write("gsdsf");
                reader.Read();
                li_id = reader.GetInt32(0);
            }
            reader.Close();
            linecs.Replace("[classname]", Title.ToString());
            //Response.Write(Title);
            linecs.Replace("[LINK_ID]", li_id.ToString());
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fsSavecs);
                sw.Write(linecs);
                // lnkNewPage.Text = SaveFilePath;
            }
            catch (Exception ex)
            {
                //lblMessage.Text = ex.Message;
            }
            finally
            {
                sw.Close();
            }
        }

    }

    //private string uploadImage()
    //{
    //    try
    //    {
    //        string DirPath = Path.Combine("DyanamicImages");
    //        string FileName = imgupload.FileName.Substring(imgupload.FileName.LastIndexOf("."));

    //        FileName =ID.ToString()+FileName;
            

    //        CommonLogic.CreateDirectory(Server.MapPath(DirPath));
    //        imgupload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), FileName));

    //        return FileName;
    //    }
    //    catch (Exception ex)
    //    {
    //        return "failed";
    //    }
        
    //}
}