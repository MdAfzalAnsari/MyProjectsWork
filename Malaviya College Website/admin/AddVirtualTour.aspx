<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddVirtualTour.aspx.cs" Inherits="admin_AddVirtualTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Virtual Tour</div>
<div class="rightcontent">
    <div class="cathead">
        <asp:TextBox ID="photocathead" runat="server" placeholder="Enter Photo Name" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Requiredphotocathead" runat="server" ErrorMessage="*" ControlToValidate="photocathead"></asp:RequiredFieldValidator>  
    </div>
    <div class="cathead">
        <asp:TextBox ID="PhotoDetails" runat="server" placeholder="Short Data ex. Name of person in pic/image" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredPhotoDetails1" runat="server" ErrorMessage="*" ControlToValidate="PhotoDetails"></asp:RequiredFieldValidator>  
    </div>   
    <div class="imageadddiv">
        <asp:FileUpload ID="Uploadphotocat" runat="server" /> 
        <asp:RequiredFieldValidator ID="RequiredUploadphotocat" runat="server" ErrorMessage="*" ControlToValidate="Uploadphotocat"></asp:RequiredFieldValidator>       
    </div>
    <div class="Buttondiv">
        <asp:Button ID="Addlinkbt" runat="server" Text="Add Photo" OnClick="addimg"/>
    </div>    
</div>
</asp:Content>

