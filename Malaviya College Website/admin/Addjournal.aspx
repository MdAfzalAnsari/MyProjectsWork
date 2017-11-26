<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="Addjournal.aspx.cs" Inherits="admin_Addjournal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Journal</div>
<div class="rightcontent">
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="PageDetailadd">Add New Journal</div>

    <div class="photodetails">
        <div class="PageDetailaddsec">Add Editorial Section Details</div>
        <div class="row">
            <div class="lrow">Editorial Name</div>
            <div class="rrow">
                <asp:TextBox ID="EditorialName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredSEditorialNames" runat="server" ErrorMessage="*" ControlToValidate="EditorialName"></asp:RequiredFieldValidator>
        </div>
        
        <div class="row">
            <div class="lrow">Upload Editorial Pdf</div>
            <div class="rrow">
                <asp:FileUpload ID="EditorialUpload" runat="server" CssClass="almreginput"/></div>
                <asp:RequiredFieldValidator ID="RequiredEditorialUpload" runat="server" ErrorMessage="*" ControlToValidate="EditorialUpload"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Editorial Author</div>
            <div class="rrow">
                <asp:TextBox ID="Author" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredAuthor" runat="server" ErrorMessage="*" ControlToValidate="Author"></asp:RequiredFieldValidator>
        </div>
        <div class="PageDetailaddsec">Add Message Section Details</div>
        <div class="row">
            <div class="lrow">Message From Name</div>
            <div class="rrow">
                <asp:TextBox ID="Messagehead" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredMessagehead" runat="server" ErrorMessage="*" ControlToValidate="Messagehead"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Upload Message Pdf</div>
            <div class="rrow">
                <asp:FileUpload ID="MessageUpload" runat="server" CssClass="almreginput"/></div>
                <asp:RequiredFieldValidator ID="RequiredMessageUpload" runat="server" ErrorMessage="*" ControlToValidate="MessageUpload"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Message By</div>
            <div class="rrow">
                <asp:TextBox ID="Messageby" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredMessageby" runat="server" ErrorMessage="*" ControlToValidate="Messageby"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Journal Image</div>
            <div class="rrow">
                <asp:FileUpload ID="JImageUpload" runat="server" CssClass="almreginput"/></div>
                <asp:RequiredFieldValidator ID="RequiredJImageUpload" runat="server" ErrorMessage="*" ControlToValidate="JImageUpload"></asp:RequiredFieldValidator>   
             </div>
                <asp:Button ID="AddJourn" runat="server" Text="Add Article" CssClass="sbtbutton" OnClick="addjournal"/>
        </div>        
        
        
    
</div>
</asp:Content>

