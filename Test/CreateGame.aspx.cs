using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Afzal\Documents\LeaderBoard.mdf; Integrated Security = True;
    }
    protected void create_game(object sender, EventArgs e)
    {
        string gname = game_name.Text;
        int n = 2;
        string gdesc = game_desc.InnerText;
        string p1 = player1.Text;
        string p2 = player2.Text;
        string p3 = player3.Text;
        string p4 = player4.Text;
        string p5 = player5.Text;
        //game_desc.Text.ToString();
        if (gname == "" || gdesc == "" || p1 == "" || p2 == "")
        {
            Response.Redirect("CreateGame.aspx");
        }


        if (p3 != "")
        {
            n++;
        }
        if (p4 != "")
        {
            n++;
        }
        if (p5 != "")
        {
            n++;
        }

        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        com.CommandText = "insert into game values('" + gname + "','" + n + "','" + gdesc + "')";
        con.Open();
        com.Connection = con;
        int s = com.ExecuteNonQuery();
        con.Close();
        con.Dispose();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con.Open();

        com.CommandText = "insert into player values('" + p1 + "','" + gname + "','" + 0 + "')";
        com.ExecuteNonQuery();
        com.CommandText = "insert into player values('" + p2 + "','" + gname + "','" + 0 + "')";
        com.ExecuteNonQuery();
        if (p3 != "")
        {
            com.CommandText = "insert into player values('" + p3 + "','" + gname + "','" + 0 + "')";
            com.ExecuteNonQuery();
        }
        if (p4 != "")
        {
            com.CommandText = "insert into player values('" + p4 + "','" + gname + "','" + 0 + "')";
            com.ExecuteNonQuery();
        }
        if (p5 != "")
        {
            com.CommandText = "insert into player values('" + p5 + "','" + gname + "','" + 0 + "')";
            com.ExecuteNonQuery();
        }
        con.Close();
        Response.Redirect("GameAdded.aspx");
    }
}