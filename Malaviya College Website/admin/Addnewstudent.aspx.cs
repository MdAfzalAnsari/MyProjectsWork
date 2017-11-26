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

public partial class admin_Addnewstudent : System.Web.UI.Page
{
    int stid;
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    string commanad = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        optionl.Enabled = true;
        option2.Visible = false;
        option3.Visible = false;
        con.ConnectionString = connection;
    }
    protected void custval_ServerValidate(object sender, EventArgs e)
    {        
        if (optionl.SelectedIndex == 0 && option2.SelectedIndex == 0 && option3.SelectedIndex == 0)
        {            
            custval.IsValid = false;
        }
    }
    protected void addstd(object sender, EventArgs e)
    {
        try
        {                                                                                    
                if (Studyear.SelectedItem.ToString() == "First Year")
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into studentsummary values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + Studyear.SelectedItem + "','" + optionl.SelectedItem + "','" + rollno.Text + "')";
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    if (i > 0)
                    {

                        con.Open();
                        com.Connection = con;
                        com.CommandText = "select stuud  from studentsummary where rollno=" + rollno.Text;
                        stid = (int)com.ExecuteScalar();
                        con.Close();

                        con.Open();
                        com.Connection = con;
                        com.CommandText = "insert into collegestudents values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + Studyear.SelectedItem + "','" + optionl.SelectedItem + "','" + rollno.Text + "','" + stid + "')";                        
                        int j = com.ExecuteNonQuery();
                        Response.Write("<br/>here=" + j);
                        
                        con.Close();
                        if (j > 0)
                        {
                            Response.Redirect("Managestlist.aspx");
                        }
                    }
                

                    //Response.Write(commanad);
                    
                }
                else if (Studyear.SelectedItem.ToString() == "Second Year")
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into studentsummary values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + Studyear.SelectedItem + "','" + option2.SelectedItem + "','" + rollno.Text + "')";
                    int i = com.ExecuteNonQuery();
                    Response.Write("<br/>here=");  
                    if (i > 0)
                    {
                                              
                        com.Connection = con;
                        com.CommandText = "select stuud from studentsummary where rollno=" + rollno.Text;

                        stid = (int)com.ExecuteScalar();
                        con.Close();

                        con.Open();
                        com.Connection = con;
                        com.CommandText = "insert into secondstudents values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + option2.SelectedItem + "','" + rollno.Text + "','" + stid + "')";
                        int j = com.ExecuteNonQuery();
                        
                        
                        con.Close();
                        if (j > 0)
                        {
                            Response.Redirect("Managestlist.aspx");
                        }
                    }                                       
                }
                else if (Studyear.SelectedItem.ToString() == "Third Year")
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into studentsummary values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + Studyear.SelectedItem + "','" + option3.SelectedItem + "','" + rollno.Text + "')";
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    if (i > 0)
                    {

                        con.Open();
                        com.Connection = con;
                        com.CommandText = "select stuud from studentsummary where rollno=" + rollno.Text;
                        stid = (int)com.ExecuteScalar();
                        con.Close();

                        con.Open();
                        com.Connection = con;
                        com.CommandText = "insert into thirdstudents values('" + StudentName.Text + "','" + Surname.Text + "','" + FatherName.Text + "','" + AcademicYear.Text + "','" + option3.SelectedItem + "','" + rollno.Text + "','" + stid + "')";
                        int j = com.ExecuteNonQuery();
                        Response.Write("<br/>here=" + j);
                        
                        con.Close();
                        if (j > 0)
                        {
                            Response.Redirect("Managestlist.aspx");
                        }
                    }                                                        
                }                                   


            
            //Response.Write(commanad);
            
        }
        catch(Exception ex)
        {
            Response.Write(ex.ToString());
        }
        //Response.Redirect("Managestlist.aspx");
        
    }
    protected void changesub(object sender, EventArgs e)
    {
        //Response.Write(Studyear.SelectedItem);
        string year = Studyear.SelectedItem.ToString();
        if (year == "First Year")
        {
            optionl.Visible = true;
            option2.Visible = false;
            option3.Visible = false;
            //optionl.Enabled = true;            
        }
        if (year == "Second Year")
        {
            optionl.Visible = false;
            option3.Visible = false;
            option2.Visible = true;
        }
        if (year == "Third Year")
        {
            optionl.Visible = false;
            option3.Visible = true;
            option2.Visible = false;
        }
    }
}