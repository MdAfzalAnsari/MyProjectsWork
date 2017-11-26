<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddPhotos.aspx.cs" Inherits="admin_AddPhotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Photo Category</div>
<div class="rightcontent">
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="PageDetailadd">Add New Photos</div>

    <div class="photodetails">
        <div class="row">
            <div class="lrow">Photo Name</div>
            <div class="rrow">
                <asp:TextBox ID="PhotoName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequirePhotoName" runat="server" ErrorMessage="*" ControlToValidate="PhotoName"></asp:RequiredFieldValidator>  
        </div>
        <div class="row">
            <div class="lrow">Upload Photo Image</div>
            <div class="rrow">
                <asp:FileUpload ID="PhotoImageUpload" runat="server" CssClass="almreginput"/></div>
                <asp:RequiredFieldValidator ID="RequiredPhotoImageUpload" runat="server" ErrorMessage="*" ControlToValidate="PhotoImageUpload"></asp:RequiredFieldValidator>  
        </div>
        <div class="row">
            <div class="lrow">Photo Category</div>
            <div class="rrow">
                
                <asp:DropDownList ID="categotylist" runat="server" CssClass="almreginput">
                </asp:DropDownList>
                <%--<asp:RequiredFieldValidator ID="Requiredcategotylist" runat="server" ErrorMessage="*" InitialValue="0" ControlToValidate="categotylist"></asp:RequiredFieldValidator>  --%>
            </div>
        </div>
        <asp:Button ID="AddPhoto" runat="server" Text="Add Photo" CssClass="sbtbutton" OnClick="addphotogallery"/>
        
    </div>
</div>
</asp:Content>

