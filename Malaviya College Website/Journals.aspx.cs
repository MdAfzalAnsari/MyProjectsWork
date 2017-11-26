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

public partial class Journals : System.Web.UI.Page
{
    int currentjid, nji;
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection cnn = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        string jidstring = Request.QueryString["pgjid"];
        cnn.ConnectionString = connection;
        if (!Page.IsPostBack)
        {
            if (jidstring == null)
            {
                cmd.CommandText = "select * From [journals] order by jid Desc";
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    currentjid = reader.GetInt32(0);
                    issueno.InnerHtml += ":" + reader.GetInt32(0);
                    issueMonth.InnerHtml += ":" + reader.GetString(8);
                    reader.Close();
                }
                cnn.Close();
                cmd.CommandText = "select jid From [journals] where jid<" + currentjid + " order by jid Desc ";
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    prev.HRef = "Journals.aspx?pgjid=" + reader.GetInt32(0);
                }
                else
                {
                    prev.Visible = false;
                }
                cnn.Close();
                reader.Close();
                cnn.Open();
                cmd.CommandText = "select jid From [journals] where jid>" + currentjid + " order by jid Desc ";
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    next.HRef = "Journals.aspx?pgjid=" + reader.GetInt32(0);
                }
                else
                {
                    next.Visible = false;

                }
                reader.Close();
                cnn.Close();
                viewart.HRef = "ViewArticle.aspx?vjid=" + currentjid;
                
            }
            else
            {
                cmd.CommandText = "select * From [journals] where jid="+jidstring;
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    currentjid = reader.GetInt32(0);
                    issueno.InnerHtml += ":" + reader.GetInt32(0);
                    issueMonth.InnerHtml += ":" + reader.GetString(8);
                    reader.Close();
                }
                //Response.Write("select * From [journals] where jid=" + jidstring + " order by jid Desc");
                cnn.Close();
                cmd.CommandText = "select jid From [journals] where jid<" + jidstring + " order by jid Desc ";
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    prev.HRef = "Journals.aspx?pgjid=" + reader.GetInt32(0);
                }
                else
                {
                    prev.Visible = false;
                }
                cnn.Close();
                reader.Close();
                cnn.Open();
                cmd.CommandText = "select jid From [journals] where jid>" + jidstring + " order by jid Desc ";
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    next.HRef = "Journals.aspx?pgjid=" + reader.GetInt32(0);
                }
                else
                {
                    next.Visible = false;

                }
                reader.Close();
                cnn.Close();
                viewart.HRef = "ViewArticle.aspx?vjid=" + jidstring;

            }
            
        }
    }
}