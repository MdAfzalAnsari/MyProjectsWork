using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_AluminiManage : System.Web.UI.Page
{
    string lid = "";
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
            string lid = Request.QueryString["lid"];
            con.Open();
            if (lid != null)
            {
                Addlinkbt.Text = "Update";
                com.CommandText = "select * from [aluminisection] where aluminiid=" + lid;                
                com.Connection = con;
                reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (!Page.IsPostBack)
                    {
                        aluminihead.Text = reader.GetString(1);
                        SectionDetails.Text = reader.GetString(2);
                        CKEditor1.Text = reader.GetString(2);
                    }
                }
            }
            
            con.Close();
    }
    protected void addaluminisection(object sender, EventArgs e)
    {
            
        string sect = "";
        con.Open();
        if (lid != null)
        {
            sect = SectionDetails.Text;
            sect.Replace("'", "&#39;");            
            com.CommandText = "update [aluminisection] set aluminihead='" + aluminihead.Text + "',aluminidetails='" + sect + "'";
            int i = com.ExecuteNonQuery();
            if (i > 0)
            {
                Session["deleted"] = "updated";
                Response.Redirect("ManageAlumini.aspx");
            }
        }            
        else
        {
                sect=SectionDetails.Text;
                sect.Replace("'", "&#39;");                            
                com.CommandText = "insert into [aluminisection] values('" + aluminihead.Text + "','" + sect + "')";
                int i= com.ExecuteNonQuery();                        
                
        }
        con.Close();
            
    }
    
}