<%@ Page Language="C#" Title="Play Game" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="PlayGame.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="subnav">
        <div class="nav_items">
            <div class="item">
                <a href="/game/add-player/<%=Request.Url.Segments[2] %>" title="Add Player">
                    <img src="/Leaderboard_files/add_player.png" alt="Add Player"></a>
            </div>
            <div class="item">
                <a href="/game/start-over/<%=Request.Url.Segments[2] %>" title="Start Over" class="confirmRestart">
                    <img src="/Leaderboard_files/start_over.png" alt="Start Over"></a>
            </div>
            <div class="item">
                <a href="/game/delete-game/<%=Request.Url.Segments[2] %>" title="Delete Game" class="confirmDelete">
                    <img src="/Leaderboard_files/delete_game.png" alt="Delete Game"></a>
            </div>
        </div>
    </div>
    <div id="content">


        <div id="lstPlayerScore" runat="server"></div>
        <div id="add_scores">
            <div class="player_name">Click a player to select</div>
            <div class="player_score" style="display: none;">
                <div class="updated_player_name"></div>
                <div class="selected_player_id" style="display:none;"></div>
                
                <div class="score">
                    <form>
                        <input type="submit" id="addscore" value="" style="background: transparent url(/Leaderboard_files/add_score.png); border: none; width: 124px; height: 43px;">
                    </form>
                </div>
            </div>
        </div>
        <script>
            $(document).ready(function () {
                $(".player_score").hide();
                $('#standings > div').click(function () {
                    var className = $(this).attr('class');
                    var res = className.split(" ");
                    var playerId = res[1].substr(res[1].length - 1);
                    //var playerId = res[1].substring(res[1]);
                    //alert(playerId);
                    updatePlayers(
                            $('.p' + playerId),
                            $('.n' + playerId).html(),
                            $('.s' + playerId),
                            playerId
                        );

                });

               
                function updatePlayers(p, n, s, playerId) {
                    $(".player").css("background-color", "#FFFFFF");
                    $(".score").css("color", "#777777");
                    p.css("background-color", "#FFF600");
                    s.css("color", "#000000");
                    $(".updated_player_name").html(n);
                    $(".selected_player_id").html(playerId);;
                    $(".player_name").hide();
                    $(".player_score").show();
                }

                $("#addscore").click(function () {
                    var selPlayerId = $(".selected_player_id").html();
                    var playername = $(".updated_player_name").html();
                    $.ajax({
                        type: "POST",
                        url: "<%= ResolveUrl("~/PlayGame.aspx/AddPoints") %>",
                        data: JSON.stringify({ 'playerId': selPlayerId, 'playername': playername }),                        
                        contentType: "application/json; charset=utf-8",
                        async: false,
                        dataType: "json",
                        success: function (response) {
                            $('.s' + selPlayerId).html(response.d);
                        },
                        failure: function (response) {
                            //alert(response.d);
                        }
                    });

                    return false;
                });

                $(".confirmRestart").click(function () {
                    var question = 'Are you sure you want to clear all points and start over?';
                    if (confirm(question)) {
                        // Make a ajax call same as above method, in that method you need to write a query that clear points in database then return true value                        
                        // do not code anything here, just call ajax method and that method will handle all things.
                        return true;
                    } else {
                        return false;
                    }
                });

                $(".confirmDelete").click(function () {
                    var question = 'Are you sure you want to delete this game?';
                    if (confirm(question)) {
                        // Make a ajax call same as above method, in that method you need to write a query that clear points in database then return true value
                        // do not code anything here, just call ajax method and that method will handle all things.
                        return true;
                    }
                    else {
                        return false;
                    }
                });
            });
        </script>
    </div>
</asp:Content>
