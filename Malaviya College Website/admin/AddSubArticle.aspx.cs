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

public partial class admin_AddSubArticle : System.Web.UI.Page
{
    string thumbname = "", linkid = "", jmonth = "", arti = "", jlinkid = "";
    int jyear;
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = connection;
        linkid = Request.QueryString["jid"];
        jlinkid = Request.QueryString["arjid"];
        arti = Request.QueryString["artid"];
        if (linkid != null)
        {
            con.Open();
            com.CommandText = "select journ_month from [journals] where jid=" + linkid;
            com.Connection = con;
            reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                jmonth = reader.GetString(0);
                //jyear = reader.GetInt32(1);
            }
            reader.Close();
            con.Close();
        }
        if (jlinkid != null)
        {

            if (!Page.IsPostBack)
            {
                AddJourn.Text = "Update";
                con.Open();
                com.CommandText = "select * from [journalTopic] where artid=" + arti + "AND jid_topic=" + jlinkid;
                Response.Write("select * from [journalTopic] where artid=" + jlinkid + "AND jid_topic=" + arti);
                com.Connection = con;
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!Page.IsPostBack)
                    {
                        ArticleName.Text = reader.GetString(2);
                        ArticleHead.Text = reader.GetString(4);                        
                        ArticleAuthor.Text = reader.GetString(6);
                    }
                    reader.Close();
                }
                con.Close();
            }

        }
    }
    protected void addarticle(object sender, EventArgs e)
    {
        if (jlinkid != null)
        {
            if (ArticleUpload.HasFile)
            {
                string jimage = uploadeditorialfile();
                if (jimage != "Error")
                {
                    con.Open();
                    com.CommandText = "update journalTopic set articlefilename='" + ArticleName.Text + "',articletopichead='" + ArticleHead.Text + "',articlepdf='" + ArticleUpload.FileName + "',articleby='" + ArticleAuthor.Text + "' where artid=" + jlinkid;
                    com.Connection = con;
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    //Response.Write("insert into journalTopic values('" + linkid + "','" + ArticleName.Text + "','" + jmonth + "','" + jyear + "','" + ArticleHead.Text + "','" + ArticleUpload.FileName + "','" + ArticleAuthor.Text + "')");
                    Response.Redirect("ManageSubjArticle.aspx");
                }
            }
        }
        if(linkid!=null)
        {
            if (ArticleUpload.HasFile)
            {
                string jimage = uploadeditorialfile();
                if (jimage != "Error")
                {
                    con.Open();
                    com.CommandText = "insert into journalTopic values('" + linkid + "','" + ArticleName.Text + "','" + jmonth + "','" + ArticleHead.Text + "','" + ArticleUpload.FileName + "','" + ArticleAuthor.Text + "')";
                    com.Connection = con;
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    //Response.Write("insert into journalTopic values('" + linkid + "','" + ArticleName.Text + "','" + jmonth + "','" + jyear + "','" + ArticleHead.Text + "','" + ArticleUpload.FileName + "','" + ArticleAuthor.Text + "')");
                    Response.Redirect("ManageSubjArticle.aspx");
                }
            }
        }

    }
    private string uploadeditorialfile()
    {
        try
        {
            string DirPath = Path.Combine("../", "artfiles");
            string FileName = ArticleUpload.FileName.Substring(ArticleUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            ArticleUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), ArticleUpload.FileName));
            return ArticleUpload.FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }
}