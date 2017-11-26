<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="EditsubContent.aspx.cs" Inherits="EditsubContent" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Edit SubPages</div>
<div class="rightcontent">
<div class="PageDetail">
<div class="PageDetailadd">Edit Content</div>

        <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor" runat="server">
        </CKEditor:CKEditorControl>
        <div class="PageDetaildetails">
        <div class="pgrow">
        <div class="pgleft">Page Content</div>
        <div class="pgright">
            <asp:TextBox ID="Descriptionbox" CssClass="Navigationlink" TextMode="MultiLine" runat="server" placeholder="Copy source from Editor and paste here"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredDescriptionbox" runat="server" ErrorMessage="*" ControlToValidate="Descriptionbox"></asp:RequiredFieldValidator>
            </div>    
        </div>
        <div class="pgrow">
        <div class="pgleft"></div>
        <div class="pgright">
            <asp:Button ID="Addlinkbt" runat="server" Text="Add Link" OnClick="updatedata"/></div>    
        </div>   
</div>
</div>
</div>
</asp:Content>

