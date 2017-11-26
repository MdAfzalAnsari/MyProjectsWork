using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AluminiRegistration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlConnection conn = new SqlConnection();
    SqlCommand comm = new SqlCommand();
    SqlDataReader reader, slinkreader;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["PddmcConnectionString"].ConnectionString;
        con.Open();
        com.Connection = con;

        con.Close();
    }
    protected void registeralm(object sender, EventArgs e)
    {
        con.Open();
        com.CommandText = "insert into aluminiRegister values('" + FirstName.Text + "','" + LastName.Text + "','" + MiddleName.Text + "','" + ResidenceAddress.Text + "','" + City.Text + "','" + PinCode.Text + "','" + StateProvince.Text + "','" + Country.Text + "','" + Residencephone.Text + "','" + CellPhone.Text + "','" + EmailAddress.Text + "','" + DateofBirth.Text + "','" + MaritalStatus.Text + "','" + AnniversaryDate.Text + "','" + PassingYear.Text + "','" + PrincipalName.Text + "','" + CurrentlyEmployed.Text + "','" + BusinessOwner.Text + "','" + Professional.Text + "','" + Student.Text + "','" + Others.Text + "','" + Brief.Text + "')";
        int i=com.ExecuteNonQuery();
        if (i > 0)
        {
            Session["addregalumini"] = "Added";
            Response.Redirect("Alumini.aspx");
        }
        con.Close();
    }
}