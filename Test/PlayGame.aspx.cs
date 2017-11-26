using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    string html = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        var gameId = Request.Url.Segments[2];
        int i = 0;
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con.Open();
        com.CommandText = "select p.Id, g.game_name, g.game_desc, p.Player_name, p.game_point, g.Id as [gameId]  from game g inner join player p on g.game_name = p.game_name where g.Id =" + gameId.ToString();
        com.Connection = con;
        reader = com.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                html += loadGameData(i);
                
                i = i + 1;
            }
            html += "</div>";
            lstPlayerScore.InnerHtml = html;
        }
    }

    private string loadGameData(int i)
    {
        try
        {
            var scoreHtml = "";
            int id = reader.GetInt32(0);
            string gamename = reader.GetString(1);
            string desc = reader.GetString(2);
            string playerName = reader.GetString(3);
            int gamePoint = reader.GetInt32(4);

            string playercount = reader.GetString(1);
            if (i == 0)
            {
                scoreHtml = "<h1>" + gamename + "</h1>" +
                        "<p class='description'>" + desc + "</p>" +
                        "<h2>Players and Current Stats</h2>" +
                        "<div id='standings'>" +
                            "<div class='player p" + id.ToString() + "'>" +
                                "<div class='name n" + id.ToString() + "'>" + playerName + "</div>" +
                                "<div class='score s" + id.ToString() + "'>" + gamePoint.ToString() + "</div>" +
                            "</div>";
            }
            else
            {
                scoreHtml ="<div class='player p" + id.ToString() + "'>" +
                                "<div class='name n" + id.ToString() + "'>" + playerName + "</div>" +
                                "<div class='score s" + id.ToString() + "'>" + gamePoint.ToString() + "</div>" +
                            "</div>";
            }
           
            return scoreHtml;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    [System.Web.Services.WebMethod]
    public static string AddPoints(string playerId, string playername)
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader reader;
        Int32 selectedPlayerPoint = 0;
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con.Open();
        com.CommandText = "select p.Id, p.Player_name, p.game_point from player p where p.Id =" + playerId;
        com.Connection = con;
        reader = com.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                selectedPlayerPoint = reader.GetInt32(2);
                selectedPlayerPoint = !reader.IsDBNull(2) ? reader.GetInt32(2) + 5 : 0;
            }
        }
        con.Close();

        con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con.Open();
        com.CommandText = "update player set game_point = " + selectedPlayerPoint + "where Id =" + playerId;
        com.Connection = con;
        reader = com.ExecuteReader();
        con.Close();

        return selectedPlayerPoint.ToString();
    }


    // method for clear points 
    [System.Web.Services.WebMethod]
    public static bool ResetPoints(string gameId)
    {        
        // if query executed success then
        // return true;
        // else
        // return false;
        return true;
    }

    // method for delete game
    [System.Web.Services.WebMethod]
    public static bool DeleteGame(string gameId)
    {
        // if query executed success then
        // return true;
        // else
        // return false;
        return true;
    }
}