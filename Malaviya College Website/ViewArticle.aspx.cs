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

public partial class ViewArticle : System.Web.UI.Page
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
        string jidstring = Request.QueryString["vjid"];
        cnn.ConnectionString = connection;
        if (!Page.IsPostBack)
        {
            if (jidstring != null)
            {
                cmd.CommandText = "select * From [journals] where jid=" + jidstring;
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
                bindjournaldetails(jidstring);
                bindarticles(jidstring);
            }
        }
    }

    private void bindjournaldetails(string jidstring)
    {
        cmd.CommandText = "select * From [journals] where jid=" + jidstring;
        cmd.Connection = cnn;
        cnn.Open();
        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {

            reader.Read();
            {

                articlecontent.InnerHtml += "<div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"editorial\">From The Editor's Desk</div>" +
                                                "</div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"prinmess\">1. " + reader.GetString(2) + "</a></div>" +
                                                "</div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"Authordiv\"><a target=\"_blank\" href=\"artfiles/" + reader.GetString(3) + "\">" + reader.GetString(4) + "</a></div>" +
                                                "</div>" +
                                            "</div>";
                articlecontent.InnerHtml += "<div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"editorial\">A Message From President</div>" +
                                                "</div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"prinmess\">2. " + reader.GetString(5) + "</a></div>" +
                                                "</div>" +
                                                "<div class=\"jrighttopul\">" +
                                                    "<div class=\"Authordiv\"><a target=\"_blank\" href=\"artfiles/" + reader.GetString(6) + "\">" + reader.GetString(7) + "</a></div>" +
                                                "</div>" +
                                            "</div>";
                
            }
        }
        reader.Close();
        cnn.Close();
    }

    private void bindarticles(string jidstring)
    {
                cmd.CommandText = "select * From [journalTopic] where jid_topic=" + jidstring;
                cmd.Connection = cnn;
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 3;
                    while(reader.Read())
                    {
                        
                        articlecontent.InnerHtml +="<div>"+
                                                        "<div class=\"jrighttopul\">"+                            
                                                            "<div class=\"editorial\">"+reader.GetString(2)+"</div>"+
                                                        "</div>"+
                                                        "<div class=\"jrighttopul\">"+
                                                            "<div class=\"prinmess\">" + i + ". " + reader.GetString(4) + "</a></div>" + 
                                                        "</div>"+
                                                        "<div class=\"jrighttopul\">"+
                                                            "<div class=\"Authordiv\"><a target=\"_blank\" href=\"artfiles/" + reader.GetString(5) + "\">" + reader.GetString(6) + "</a></div>" +
                                                        "</div>"+
                                                    "</div>";
                        i++;
                    }
                }
                reader.Close();
                cnn.Close();
    }
}