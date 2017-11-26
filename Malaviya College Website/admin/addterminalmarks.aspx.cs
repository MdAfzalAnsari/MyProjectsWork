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


public partial class admin_addterminalmarks : System.Web.UI.Page
{
    string sid = "", syear = "",state="" ,em="";
    int rollno;
    
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        sid = Request.QueryString["sid"];        
        syear = Request.QueryString["yr"];
        con.ConnectionString = connection;
        if (sid == null || syear == null)
        {
            Response.Redirect("ManageResult.aspx");
        }
        if (syear == "First Year")
        {
            em = "fy";
        }
        else if (syear == "Second Year")
        {
            em = "sy";
            Emarks.Attributes.Add("placeholder", "English");
            Eecomarks.Attributes.Add("placeholder", "CRPTAC");
            EAccomarks.Attributes.Add("placeholder", "COSTAC");
            ELawmarks.Attributes.Add("placeholder", "INTAX");
            EAdmmarks.Attributes.Add("placeholder", "Optional");
            Eoptmarks.Attributes.Add("placeholder", "BC");
            EMATmarks.Attributes.Add("placeholder", "MFS");
            OEMATmark.Visible = false;
           // OEMATmark.Attributes.Add("placeholder", "Emarksssss");
        }
        else if (syear == "Third Year")
        {
            em = "ty";
            Emarks.Attributes.Add("placeholder", "English");
            Eecomarks.Attributes.Add("placeholder", "BE");
            EAccomarks.Attributes.Add("placeholder", "AUDITING");
            ELawmarks.Attributes.Add("placeholder", "MGMTAC");
            EAdmmarks.Attributes.Add("placeholder", "COMP_ST");
            Eoptmarks.Attributes.Add("placeholder", "Opt1");
            EMATmarks.Attributes.Add("placeholder", "Opt2");
            OEMATmark.Visible = false;
        }
        con.Open();
        com.CommandText = "select rollno from studentsummary where stuud=" + sid + " And studentyear='" + syear + "'";
        com.Connection = con;
        reader = com.ExecuteReader();

        if (reader.HasRows)
        {
            reader.Read();
            rollno = reader.GetInt32(0);
        }
        reader.Close();

        con.Close();

        con.Open();
        com.CommandText = "select * from termmarks where stud_id="+sid+" And stu_year='"+syear+"'";
        com.Connection = con;
        reader=com.ExecuteReader();
        
            if (reader.HasRows)
            {
                
                reader.Read();                
                state = "update";                
                Addlinkbt.Text = "Update Result";
                if (!Page.IsPostBack)
                {
                    Emarks.Text     = reader.GetInt32(1).ToString();
                    Eecomarks.Text  = reader.GetInt32(2).ToString();
                    EAccomarks.Text = reader.GetInt32(3).ToString();
                    ELawmarks.Text  = reader.GetInt32(4).ToString();
                    EAdmmarks.Text  = reader.GetInt32(5).ToString();
                    Eoptmarks.Text  = reader.GetInt32(6).ToString();
                    EMATmarks.Text  = reader.GetInt32(7).ToString();
                    OEMATmark.Text  = reader.GetInt32(8).ToString();
                }

            }
            reader.Close();
        
        con.Close();
    }
    protected void addstd(object sender, EventArgs e)
    {
        
        if (state == "update")
        {
            //if (!Page.IsPostBack)
            {
                try
                {

                    Response.Write("srar=" + state);
                    con.Open();
                    int tmarks = 0;
                    if (syear == "First Year")
                    {
                        tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text) + Convert.ToInt32(OEMATmark.Text);
                        com.CommandText = "update termmarks set english='" + Emarks.Text + "',Businesseconomics='" + Eecomarks.Text + "',FinancialAccounting='" + EAccomarks.Text + "',CompanyLaw='" + ELawmarks.Text + "',BusinessAdm='" + EAdmmarks.Text + "',FE_ME_IT='" + Eoptmarks.Text + "',MATHS_SSP='" + EMATmarks.Text + "',Opt='" + OEMATmark.Text + "',GRANDTOTAL='" + tmarks + "',percentage='"+(tmarks*100)/400+"'  where stud_id=" + sid;                        
                    }
                    else if (syear == "Second Year")
                    {
                        tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text);
                        com.CommandText = "update termmarks set english='" + Emarks.Text + "',Businesseconomics='" + Eecomarks.Text + "',FinancialAccounting='" + EAccomarks.Text + "',CompanyLaw='" + ELawmarks.Text + "',BusinessAdm='" + EAdmmarks.Text + "',FE_ME_IT='" + Eoptmarks.Text + "',MATHS_SSP='" + EMATmarks.Text + "',GRANDTOTAL='" + tmarks + "',percentage='" + (tmarks * 100) / 350 + "'  where stud_id=" + sid;                        
                        
                    }
                    else if (syear == "Third Year")
                    {
                        tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text);
                        com.CommandText = "update termmarks set english='" + Emarks.Text + "',Businesseconomics='" + Eecomarks.Text + "',FinancialAccounting='" + EAccomarks.Text + "',CompanyLaw='" + ELawmarks.Text + "',BusinessAdm='" + EAdmmarks.Text + "',FE_ME_IT='" + Eoptmarks.Text + "',MATHS_SSP='" + EMATmarks.Text + "',GRANDTOTAL='" + tmarks + "',percentage='" + (tmarks * 100) / 350 + "'  where stud_id=" + sid;                        
                    }
                    
                    com.Connection = con;
                    int i = com.ExecuteNonQuery();                    
                    con.Close();
                    Response.Redirect("studentsyear.aspx?em=" + em + "gtres1x1dfrsdgh");
                }
                catch (Exception ex)
                {

                }
            }
        }
        else
        {
            try
            {
                con.Open();
                int tmarks = 0;
                if (syear == "First Year")
                {
                    tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text) + Convert.ToInt32(OEMATmark.Text);
                    com.CommandText = "insert into termmarks values('" + Emarks.Text + "','" + Eecomarks.Text + "','" + EAccomarks.Text + "','" + ELawmarks.Text + "','" + EAdmmarks.Text + "','" + Eoptmarks.Text + "','" + EMATmarks.Text + "','" + OEMATmark.Text + "','" + tmarks + "','" + Convert.ToInt32(sid) + "','" + syear + "','" + rollno + "','"+(tmarks*100)/400+"')";
                    //Response.Write("insert into termmarks values('" + Emarks.Text + "','" + Eecomarks.Text + "','" + EAccomarks.Text + "','" + ELawmarks.Text + "','" + EAdmmarks.Text + "','" + Eoptmarks.Text + "','" + EMATmarks.Text + "','" + OEMATmark.Text + "','" + tmarks + "','" + Convert.ToInt32(sid) + "','" + syear + "','" + rollno + "')");
                }
                else if (syear == "Second Year")
                {
                    tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text);
                    com.CommandText = "insert into termmarks values('" + Emarks.Text + "','" + Eecomarks.Text + "','" + EAccomarks.Text + "','" + ELawmarks.Text + "','" + EAdmmarks.Text + "','" + Eoptmarks.Text + "','" + EMATmarks.Text + "','','" + tmarks + "','" + Convert.ToInt32(sid) + "','" + syear + "','" + rollno + "','" + (tmarks * 100) / 350 + "')";
                    //Response.Write("insert into termmarks values('" + Emarks.Text + "','" + Eecomarks.Text + "','" + EAccomarks.Text + "','" + ELawmarks.Text + "','" + EAdmmarks.Text + "','" + Eoptmarks.Text + "','" + EMATmarks.Text + "','','" + tmarks + "','" + Convert.ToInt32(sid) + "','" + syear + "','" + rollno + "')");
                }
                else if (syear == "Third Year")
                {
                    tmarks = Convert.ToInt32(Emarks.Text) + Convert.ToInt32(Eecomarks.Text) + Convert.ToInt32(EAccomarks.Text) + Convert.ToInt32(ELawmarks.Text) + Convert.ToInt32(EAdmmarks.Text) + Convert.ToInt32(Eoptmarks.Text) + Convert.ToInt32(EMATmarks.Text);
                    com.CommandText = "insert into termmarks values('" + Emarks.Text + "','" + Eecomarks.Text + "','" + EAccomarks.Text + "','" + ELawmarks.Text + "','" + EAdmmarks.Text + "','" + Eoptmarks.Text + "','" + EMATmarks.Text + "','','" + tmarks + "','" + Convert.ToInt32(sid) + "','" + syear + "','" + rollno + "','" + (tmarks * 100) / 350 + "')";
                }
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                
                con.Close();
                Response.Redirect("studentsyear.aspx?em=" + em + "gtres1x1dfrsdgh");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}