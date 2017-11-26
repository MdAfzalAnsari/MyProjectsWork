
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Text;

public partial class ViewResult : System.Web.UI.Page
{
    string sid = "", syear = "", em = "", state = "", name="",cyear="",yearnum="";
    string connection = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader reader;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.PreviousPage != null)
        {
            ContentPlaceHolder content = (ContentPlaceHolder)Page.PreviousPage.Form.FindControl("ContentPlaceHolder1");
            name = ((HiddenField)content.FindControl("Hidde")).Value;
            cyear = ((HiddenField)content.FindControl("Hiddenyear")).Value;
            //Response.Write("year==" + cyear);
            
        }

        if (name == "" || cyear == "")
        {
            Response.Redirect("Result.aspx");
        }
        con.ConnectionString = connection;
        string assa = name;        
        //Session.Remove("rollno");        
        con.Open();
        if (cyear == "First Year")
        {
            yearnum = "1";
            com.CommandText = "select studentfirstname,studentlastname,fathername,academicyear,optsubject   from collegestudents where rollno=" + assa;
            //Response.Write("select studentfirstname,studentlastname,fathername,academicyear,optsubject   from collegestudents where rollno=" + assa);
            string subject=
                    "<li class=\"subjectli\">English <div>1</div></li>"+       
                    "<li class=\"subjectli\">Business Economics <div>2</div></li>"+        
                    "<li class=\"subjectli\">Financial Accounting <div>3</div></li>"+        
                    "<li class=\"subjectli\">Company Law <div>4</div></li>"+        
                    "<li class=\"subjectli\">Business Adm. <div>5</div></li>"+        
                    "<li class=\"subjectli\">FE/MKT/IT <div>6</div></li>"+                 
                    "<li class=\"subjectli\">MATHS/SSP <div>7</div></li>"+     
                    "<li class=\"subjectli\">Opt <div>8</div></li> "+    
                    "<li class=\"subjectli\">GRAND TOTAL <div>9</div></li>    "+ 
                    "<li class=\"subjectli\">PERCENTAGE <div>10</div></li>"+
                    "<li class=\"subjectli\">CLASS</li>";
            sublist.InnerHtml += subject;
        }
        if (cyear == "Second Year")
        {
            yearnum = "2";
            com.CommandText = "select studentfirstname,studentlastname,fathername,academicyear,optsubject   from secondstudents where rollno=" + assa;
            //Response.Write("select studentfirstname,studentlastname,fathername,academicyear,optsubject   from secondstudents where rollno=" + assa);
            string subject =
                    "<li class=\"subjectli\">English <div>1</div></li>" +
                    "<li class=\"subjectli\">CRPTAC <div>2</div></li>" +
                    "<li class=\"subjectli\">COSTAC <div>3</div></li>" +
                    "<li class=\"subjectli\">INTAX<div>4</div></li>" +
                    "<li class=\"subjectli\">Optional<div>5</div></li>" +
                    "<li class=\"subjectli\">BC<div>6</div></li>" +
                    "<li class=\"subjectli\">MFS <div>7</div></li>" +                    
                    "<li class=\"subjectli\">GRAND TOTAL <div>8</div></li>    " +
                    "<li class=\"subjectli\">PERCENTAGE <div>9</div></li>" +
                    "<li class=\"subjectli\">CLASS</li>";
            sublist.InnerHtml += subject;
        }
        if (cyear == "Third Year")
        {
            yearnum = "3";
            com.CommandText = "select studentfirstname,studentlastname,fathername,academicyear,optsubject   from thirdstudents where rollno=" + assa;
            //Response.Write("select studentfirstname,studentlastname,fathername,academicyear,optsubject   from thirdstudents where rollno=" + assa);
            string subject =
                    "<li class=\"subjectli\">English <div>1</div></li>" +
                    "<li class=\"subjectli\">BE <div>2</div></li>" +
                    "<li class=\"subjectli\">AUDITING<div>3</div></li>" +
                    "<li class=\"subjectli\">MGMTAC<div>4</div></li>" +
                    "<li class=\"subjectli\">COMP_ST <div>5</div></li>" +
                    "<li class=\"subjectli\">Opt1 <div>6</div></li>" +
                    "<li class=\"subjectli\">Opt2 <div>7</div></li>" +                    
                    "<li class=\"subjectli\">GRAND TOTAL <div>8</div></li>    " +
                    "<li class=\"subjectli\">PERCENTAGE <div>9</div></li>" +
                    "<li class=\"subjectli\">CLASS</li>";
            sublist.InnerHtml += subject;
        }
        
        com.Connection = con;
        reader = com.ExecuteReader();

        if (reader.HasRows)
        {
            reader.Read();
            rollno.InnerHtml = assa;
            studentyears.InnerHtml = cyear;
            yearinfos.InnerHtml = reader.GetString(3);
            stname.InnerHtml = reader.GetString(0) + " " + reader.GetString(2) + " " + reader.GetString(1);

        }
        else
        {
            Response.Redirect("resultdetails.aspx?ystcur=" + yearnum+"&danon=1@fd");
        }
        reader.Close();        
        con.Close();




        try
        {
            con.Open();
            com.CommandText = "select * from termmarks where rollno=" + assa + " And stu_year='" + cyear + "'";
            //Response.Write("<br/>select * from termmarks where rollno=" + assa + " And stu_year='" + cyear + "'");
            com.Connection = con;
            reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string data = "";
                decimal percentages;
                double per = 0;
                studentyears.InnerHtml = reader.GetString(11);
                if (cyear == "First Year")
                {
                    percentages = (decimal)reader.GetDecimal(13);
                    data = "<li class=\"subjectlidata\">" + reader.GetInt32(1) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(2) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(3) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(4) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(5) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(6) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(7) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(8) + "</li>" +
                             "<li class=\"subjectlidata\">" + reader.GetInt32(9) + "</li>"+
                             "<li class=\"subjectlidata\">" + percentages + "</li>";
                    per = (double)reader.GetDecimal(13);
                }
                if (cyear == "Third Year" || cyear == "Second Year")
                {
                    percentages = (decimal)reader.GetDecimal(13);
                    data = "<li class=\"subjectlidata\">" + reader.GetInt32(1) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(2) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(3) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(4) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(5) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(6) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(7) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(9) + "</li>" +
                              "<li class=\"subjectlidata\">" + percentages + "</li>";
                    per = (double)reader.GetDecimal(13);
                }
                if (per >= 60)
                {
                    data += "<li class=\"subjectlidata\">First Class</li>";
                }
                else if (per >= 48 && per < 60)
                {
                    data += "<li class=\"subjectlidata\">Second Class</li>";
                }                
                else
                {
                    data += "<li class=\"subjectlidata\">*</li>";
                }
                termmarks.InnerHtml += data;

            }
            else
            {
                string datas = "";
                if (cyear == "First Year")
                {
                    datas = "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>";
                }
                else
                {
                    datas = "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>" +
                                 "<li class=\"subjectlidata\"> **</li>";
                }
                termmarks.InnerHtml += datas;

            }
            reader.Close();
            con.Close();
        }
        catch (Exception ex)
        {
            con.Close();
            Response.Write(ex.Message.ToString());
        }

        con.Open();
        com.CommandText = "select * from pmarks where rollno=" + assa + " And stud_year='" + cyear + "'";
        //Response.Write("<br/>select * from pmarks where rollno=" + assa + " And stu_year='" + cyear + "'");
        com.Connection = con;
        reader = com.ExecuteReader();
        if (reader.HasRows)
        {
            double per = 0.00;
            decimal percentages;
            string data = "";
            reader.Read();
            if (cyear == "First Year")
            {
                percentages = (decimal)reader.GetDecimal(13);
                data = "<li class=\"subjectlidata\">" + reader.GetInt32(1) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(2) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(3) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(4) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(5) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(6) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(7) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(8) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetInt32(9) + "</li>" +
                              "<li class=\"subjectlidata\">" + reader.GetDecimal(13) + "</li>";
                per = (double)reader.GetDecimal(13);
            }
            if (cyear == "Third Year" || cyear == "Second Year")
            {
                percentages = (decimal)reader.GetDecimal(13);
                data = "<li class=\"subjectlidata\">" + reader.GetInt32(1) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(2) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(3) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(4) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(5) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(6) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(7) + "</li>" +
                          "<li class=\"subjectlidata\">" + reader.GetInt32(9) + "</li>" +

                          "<li class=\"subjectlidata\">" + reader.GetDecimal(13) + "</li>";
                per = (double)reader.GetDecimal(13);
            }
            if (per >= 75)
            {
                data += "<li class=\"subjectlidata\">First Class</li>";
            }
            else if (per >= 60 && per < 75)
            {
                data += "<li class=\"subjectlidata\">Second Class</li>";
            }
            else if (per > 50 && per < 60)
            {
                data += "<li class=\"subjectlidata\">Third Class</li>";
            }
            else
            {
                data += "<li class=\"subjectlidata\">*</li>";
            }
            premmarks.InnerHtml += data;

        }
        else
        {
            string data = "";
            if (cyear == "First Year")
            {
                data = "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>";
            }
            else
            {
                data = "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>" +
                             "<li class=\"subjectlidata\"> **</li>";
            }
            premmarks.InnerHtml += data;

        }
        reader.Close();
        con.Close();
        
    }
}