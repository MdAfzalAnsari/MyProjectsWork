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


public partial class resultdetails : System.Web.UI.Page
{
    string curryear = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        curryear = Request.QueryString["ystcur"];
        string daastate=Request.QueryString["danon"];
        if (curryear == null)
        {
            Response.Redirect("Result.aspx");
           
        }
        if (curryear == "1")
        {            
            curryear="First Year";
        }
        else if (curryear == "2")
        {
            curryear="Second Year";
        }
        else if (curryear == "3")
        {
            curryear = "Third Year";
        }
        else
        {
            Response.Redirect("Result.aspx");
        }
        if (daastate == "1@fd")
        {
            studta.InnerText = "No data Found";
        }
        yearnoae.InnerHtml = curryear;

    }
    protected void getresult(object sender, EventArgs e)
    {
        int roll=Convert.ToInt32(rollno.Text);        
        Hidde.Value = roll.ToString();
        Hiddenyear.Value = curryear;
        Server.Transfer("ViewResult.aspx");
    }
}