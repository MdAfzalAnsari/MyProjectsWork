<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddSlideimg.aspx.cs" Inherits="admin_AddPhotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Photo Category</div>
<div class="rightcontent">
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="PageDetailadd">Add New Photos</div>

    <div class="photodetails">
       
        <div class="row">
            <div class="lrow">Upload Photo Image</div>
            <div class="rrow">
                <asp:FileUpload ID="PhotoImageUpload" runat="server" CssClass="almreginput" ValidationGroup="validateform"/></div>
                <asp:RequiredFieldValidator ID="RequiredPhotoImageUpload" runat="server" ErrorMessage="*" ValidationGroup="validateform" ControlToValidate="PhotoImageUpload"></asp:RequiredFieldValidator>  
        </div>
        
        <asp:Button ID="AddPhoto" runat="server" Text="Add Photo" CssClass="sbtbutton" OnClick="addphotogallery" ValidationGroup="validateform"/>
        <asp:Button ID="canPhoto" runat="server" Text="Cancel" CssClass="sbtbutton" OnClick="acancelpro"/>
        
    </div>
</div>
</asp:Content>

