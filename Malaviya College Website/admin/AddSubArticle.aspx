<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddSubArticle.aspx.cs" Inherits="admin_AddSubArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Journal's Article</div>
<div class="rightcontent">
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="PageDetailadd">Add Journal's Articles</div>

    <div class="photodetails">
        <div class="PageDetailaddsec">Add Articles Details</div>
        <div class="row">
            <div class="lrow">Article Subject</div>
            <div class="rrow">
                <asp:TextBox ID="ArticleName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredArticleName" runat="server" ErrorMessage="*" ControlToValidate="ArticleName"></asp:RequiredFieldValidator>  
        </div>
        <div class="row">
            <div class="lrow">Article Head</div>
            <div class="rrow">
                <asp:TextBox ID="ArticleHead" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="rewqArticleHead" runat="server" ErrorMessage="*" ControlToValidate="ArticleHead"></asp:RequiredFieldValidator>  
        </div>
        <div class="row">
            <div class="lrow">Upload Article Pdf</div>
            <div class="rrow">
                <asp:FileUpload ID="ArticleUpload" runat="server" CssClass="almreginput"/></div>
                <asp:RequiredFieldValidator ID="RequiArticleUpload" runat="server" ErrorMessage="*" ControlToValidate="ArticleUpload"></asp:RequiredFieldValidator>  
        </div>
        <div class="row">
            <div class="lrow">Article Author</div>
            <div class="rrow">
                <asp:TextBox ID="ArticleAuthor" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredArticleAuthor" runat="server" ErrorMessage="*" ControlToValidate="ArticleAuthor"></asp:RequiredFieldValidator>  
        </div>                
                <asp:Button ID="AddJourn" runat="server" Text="Add Article" CssClass="sbtbutton" OnClick="addarticle"/>
        </div>        
        
        
    
</div>
</asp:Content>

