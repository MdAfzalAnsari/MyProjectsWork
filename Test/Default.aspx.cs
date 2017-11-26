using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlDataReader reader;
    string html;
    protected void Page_Load(object sender, EventArgs e)
    {

        //con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Afzal\\Documents\\LeaderBoard.mdf; Integrated Security = True";
        //con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Test\\App_Data\\LeaderBoard.mdf;Integrated Security=True";
        con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        con.Open();
        com.CommandText = "select top 5 g.Id,g.game_name,(select count(*) from player where game_name = g.game_name) no_of_player from game g order by g.Id DESC";
        com.Connection = con;
        reader = com.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                html = loadgames();
                product.InnerHtml += html;
            }
        }
    }
    private string loadgames()
    {

        try
        {
            int gameId = reader.GetInt32(0);
            string gamename = reader.GetString(1);
            int playercount = reader.GetInt32(2);

            html = "<div class='row'>" +
                "<div class='action'>" +
                        "<a href = '/PlayGame/" + gameId.ToString() + "'>" +
                              "<img src = 'Leaderboard_files/play_game.png'/>" +
                          "</a>" +
                      "</div><div class='game'>" + gamename + "</div>" +
                      "<div class='players'>" + playercount.ToString() + "</div>" +
                 "</div>";
            return html;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}