<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddPhotocategory.aspx.cs" Inherits="admin_AddPhotocategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Photo Category</div>
<div class="rightcontent">
    <div class="cathead">
        <asp:TextBox ID="photocathead" runat="server" placeholder="Enter Photo Category Name" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Requirephotocathead" runat="server" ErrorMessage="*" ControlToValidate="photocathead"></asp:RequiredFieldValidator>  
    </div>
    <div class="imageadddiv">
        <asp:FileUpload ID="Uploadphotocat" runat="server" /> 
        <asp:RequiredFieldValidator ID="RequiredUploadphotocat" runat="server" ErrorMessage="*" ControlToValidate="Uploadphotocat"></asp:RequiredFieldValidator>       
    </div>
    <div class="Buttondiv">
        <asp:Button ID="Addlinkbt" runat="server" Text="Add Photocategory" OnClick="Addcategoryphoto"/>
    </div>    
</div>
</asp:Content>

