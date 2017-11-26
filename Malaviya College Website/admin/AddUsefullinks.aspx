<%@ Page Title="Useful Links" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddUsefullinks.aspx.cs" Inherits="admin_AddUsefullinks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Useful Links</div>
    <div class="rightcontent">
        <div class="PageDetailadd">Add Useful Links</div>
        <div class="cathead">
            <asp:TextBox ID="LinkName" runat="server" placeholder="Enter LinkName" CssClass="photoheadinput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredLinkName" runat="server" ErrorMessage="*" ControlToValidate="LinkName"></asp:RequiredFieldValidator>  
        </div>
        <div class="cathead">
            <asp:TextBox ID="LinkNameAddress" runat="server" placeholder="Enter LinkNameAddress" CssClass="photoheadinput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredLinkNameAddress" runat="server" ErrorMessage="*" ControlToValidate="LinkNameAddress"></asp:RequiredFieldValidator>  
        </div>           
        <div class="Buttondiv">
            <asp:Button ID="Addlinkbt" runat="server" Text="Add Link" OnClick="adduselink"/>
        </div>    
    </div>
</asp:Content>

