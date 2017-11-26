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

public partial class AddNavLink : System.Web.UI.Page
{
    int ID = 0;
    string thumbname = "";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void NewAddlink(object sender, EventArgs e)
    {


        String root = Server.MapPath("~");

        //String pgTemplate = root + "\\Malaviya\\admin\\LinkPageTemplate.tmp";
        String pgTemplate = root + "\\admin\\LinkPageTemplate.tmp";


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
        string page_title = NavigationlinkName.Text;
        //Page Name Creator
        Title = PageTitle.Text.Replace(' ', '-').Replace('.', '-').Replace('#', '-').Replace('%', '-').Replace('&', '-').Replace('*', '-').Replace('@', '-').Replace('!', '-').Replace('|', '-').Replace(':', '-').Replace(';', '-').Replace(',', '-').Replace('/', '-').Replace('\\', '-').Replace('?', '-').Replace('<', '-').Replace('>', '-').Replace('"', '-').Replace('“', '-').Replace('”', '-');
        SaveFileName = "\\" + Title + ".aspx";
        SaveFilePath = root + SaveFileName;
       // SaveFilePath = root + "Malaviya" + SaveFileName;
        FileStream fsSave = File.Create(SaveFilePath);
        //Adding .cs file codebehind file
        //String pgTemplatecs = root + "\\Malaviya\\admin\\LinkPageTemplatecs.tmp";
        String pgTemplatecs = root + "\\admin\\LinkPageTemplatecs.tmp";
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
        SaveFilePath = root + SaveFileName;
        //SaveFilePath = root + "Malaviya" + SaveFileName;
        FileStream fsSavecs = File.Create(SaveFilePath);

        if (line != null)
        {
            //line.Replace("[MetaTitle]", NavigationlinkName.Text.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
            //line.Replace("[PageContent]", Descriptionbox.Text.ToString());
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
                //lblMessage.Text = ex.Message;
            }
            finally
            {
                sw.Close();
            }

            con.ConnectionString = connection;
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into [navlinks] values('" + NavigationlinkName.Text + "','" + Title + "','" + PageInnerHead.Text + "','" + Descriptionbox.Text + "','" + LinkName.Text + "')";
            int lno = com.ExecuteNonQuery();
            con.Close();
            if (lno > 0)
            {
                com.CommandText = "select linkid from [navlinks] where pglinkname='" + Title + "'";
                con.Open();
                com.Connection = con;
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int id = reader.GetInt32(0);
                    con.Close();
                    com.CommandText = "insert into [sublinks] values(" + id + ",'" + Title + " Content')";
                    con.Open();
                    //com.ExecuteNonQuery();
                    con.Close();
                    reader.Close();
                    Response.Write("Adf");
                }
                else
                {
                    con.Close();
                    reader.Close();
                    Response.Write("Canceldase");
                }
            }
            Response.Write("Done");


        }
        if (linecs != null)
        {
            int li_id = -1;
            com.CommandText = "select linkid from [navlinks] where pglinkname='" + Title + "'";
            con.Open();
            com.Connection = con;           
            reader = com.ExecuteReader();
            //li_id = (int)com.ExecuteScalar();
            if (reader.HasRows)
            {
                reader.Read();
                li_id=reader.GetInt32(0);
            }
            linecs.Replace("[classname]", Title.ToString());
            Response.Write(Title);
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
}