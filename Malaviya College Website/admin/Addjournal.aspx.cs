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

public partial class admin_Addjournal : System.Web.UI.Page
{
    string thumbname = "", linkid="";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = connection;
        linkid = Request.QueryString["jid"];
        if (linkid != null)
        {

            if (!Page.IsPostBack)
            {
                con.Open();
                AddJourn.Text = "Update";
                com.CommandText = "select * from [journals] where jid=" + linkid;
                com.Connection = con;
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!Page.IsPostBack)
                    {
                        EditorialName.Text = reader.GetString(2);
                        Author.Text = reader.GetString(4);
                        Messagehead.Text = reader.GetString(5);
                        Messageby.Text = reader.GetString(7);
                    }
                    reader.Close();
                }
                con.Close();
            }

        }
    }
    protected void addjournal(object sender, EventArgs e)
    {
        if (linkid == null)
        {
            if (EditorialUpload.HasFile)
            {
                string pdff = uploadeditorialfile();
                if (pdff != "Error")
                {
                    if (MessageUpload.HasFile)
                    {
                        string msgpdff = uploadmessagefile();
                        if (msgpdff != "Error")
                        {
                            if (JImageUpload.HasFile)
                            {
                                string jimage = uploadjimaegefile();
                                if (jimage != "Error")
                                {
                                    con.Open();
                                    com.CommandText = "insert into journals values('" + EditorialName.Text + "','" + EditorialName.Text + "','" + EditorialUpload.FileName + "','" + Author.Text + "','" + Messagehead.Text + "','" + MessageUpload.FileName + "','" + Messageby.Text + "','" + DateTime.Now.Month + "/" + DateTime.Now.Year + "','" + jimage + "')";
                                    com.Connection = con;
                                    int i = com.ExecuteNonQuery();
                                    con.Close();
                                    Response.Redirect("ManageJournals.aspx");
                                }
                            }
                        }
                    }

                }
            }
        }
        else
        {
            if (EditorialUpload.HasFile)
            {
                string pdff = uploadeditorialfile();
                if (pdff != "Error")
                {
                    if (MessageUpload.HasFile)
                    {
                        string msgpdff = uploadmessagefile();
                        if (msgpdff != "Error")
                        {
                            if (JImageUpload.HasFile)
                            {
                                string jimage = uploadjimaegefile();
                                if (jimage != "Error")
                                {
                                    con.Open();
                                    com.CommandText = "update journals set editorhead='" + EditorialName.Text + "',editorpdf='" + EditorialUpload.FileName + "',editorby='" + Author.Text + "',messasgehead='" + Messagehead.Text + "',messagepdf='" + MessageUpload.FileName + "',messageby='" + Messageby.Text + "',journ_image='" + jimage + "' where jid="+linkid;
                                    com.Connection = con;                                    
                                    int i = com.ExecuteNonQuery();
                                    con.Close();
                                    Session["updated"] = "updated";
                                    Response.Redirect("ManageJournals.aspx");
                                }
                            }
                        }
                    }

                }
            }
        }
        
        
    }

    private string uploadjimaegefile()
    {
        try
        {
            string DirPath = Path.Combine("../", "jimagefiles");
            string FileName = JImageUpload.FileName.Substring(JImageUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            JImageUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), JImageUpload.FileName));
            return JImageUpload.FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }

    private string uploadeditorialfile()
    {
        try
        {
            string DirPath = Path.Combine("../", "files");
            string FileName = EditorialUpload.FileName.Substring(EditorialUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            EditorialUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), EditorialUpload.FileName));
            return EditorialUpload.FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }
    private string uploadmessagefile()
    {
        try
        {
            string DirPath = Path.Combine("../", "Mfiles");
            string FileName = MessageUpload.FileName.Substring(MessageUpload.FileName.LastIndexOf("."));
            CommonLogic.CreateDirectory(Server.MapPath(DirPath));
            MessageUpload.PostedFile.SaveAs(Path.Combine(Server.MapPath(DirPath), MessageUpload.FileName));
            return MessageUpload.FileName;
        }
        catch (Exception ex)
        {
            //throw new FileNotFoundException();
            return "Error";
        }
    }    
}