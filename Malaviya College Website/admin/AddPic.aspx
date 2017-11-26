<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddPic.aspx.cs" Inherits="AddPic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="contenthead">Add Pictures </div>
<div class="rightcontent">
<div class="PageDetail">
<div class="PageDetailadd">Add New Image</div>
    <div class="PageDetaildetails">
            <div class="PageDetailstates" id="status" runat="server">Image Uploaded Succesfully</div>       
            <div class="fileUpload btn btn-primary">
                <span>Upload Image :</span>
                <asp:FileUpload ID="ImageUpload" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredImageUploadst" runat="server" ErrorMessage="*" ControlToValidate="ImageUpload"></asp:RequiredFieldValidator>  
            </div>
            
        
        <div class="pgrow">
        <div class="pgleft"><asp:Button ID="Addlinkbt" runat="server" Text="Upload" OnClick="addimg" /></div>
        <div class="pgright">
            
        </div>    
        </div>   
    </div>
</div>
</div>
</asp:Content>

