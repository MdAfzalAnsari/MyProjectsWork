<%@ Page Title="Create game" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CreateGame.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
	    <h1>Create New Game</h1>
	        <p>You can add more players after you've created your first 2.</p>
	        <p><span style="font-size: 80%;"><span style="color: #FF0000;">*</span> indicates a required field</span></p>
	    <div class="errors"></div>
        <form id="form2" runat="server">    
        <table width="400px;">        
        <tr>
        <td class="table" style="width:200px;">*Name of the Game:</td>
        <td><asp:TextBox ID="game_name"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="game_name" ValidationGroup="create"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td class="table"> *Game Description:</td>
            <td>
                <textarea id="game_desc" cols="24" rows="5" runat="server" CssClass="area"> </textarea>
                
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="create" ErrorMessage="*" ControlToValidate="game_desc"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td class="table" style="width:200px;">*Player 1:</td>
        <td><asp:TextBox ID="player1"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="player1" ValidationGroup="create"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <tr>
        <td class="table" style="width:200px;">*Player 2:</td>
        <td><asp:TextBox ID="player2"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="player2" ValidationGroup="create"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td class="table" style="width:200px;">Player 3:</td>
        <td><asp:TextBox ID="player3"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        </tr>
        <tr>
        <td class="table" style="width:200px;">Player 4:</td>
        <td><asp:TextBox ID="player4"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        </tr>
        <tr>
        <td class="table" style="width:200px;">Player 5:</td>
        <td><asp:TextBox ID="player5"  runat="server" placeholder="" style="width:200px;" class="table"></asp:TextBox></td>
        </tr>
        <tr>
        
        </tr>       
        </table>
            <div class="row">
            <asp:Button ID="savegame" runat="server" Alt="Submit" class="btn" ValidationGroup="create"
                onclick="create_game" /></div>
        </form> 
              
	    </div>
    
</asp:Content>
