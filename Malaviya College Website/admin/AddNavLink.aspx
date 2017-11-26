<%@ Page Title="AddLink" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddNavLink.aspx.cs" Inherits="AddNavLink" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Add Navigation</div>
<div class="rightcontent">
<div class="PageDetail">
<div class="PageDetailadd">Add New Navigation Link</div>
<div class="PageDetaildetails">
    <div class="pgrow">
        <div class="pgleft">Navigationlink Name:</div>
        <div class="pgright">
            <asp:TextBox ID="NavigationlinkName" CssClass="Navigationlink" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequNavigationlinkName" runat="server" ErrorMessage="*" ControlToValidate="NavigationlinkName"></asp:RequiredFieldValidator>  
        </div>  
        
    </div>
    <div class="pgrow">
        <div class="pgleft">Page Linkname:</div>
        <div class="pgright"><asp:TextBox ID="PageTitle" CssClass="Navigationlink"  runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredPageTitle" runat="server" ErrorMessage="*" ControlToValidate="PageTitle"></asp:RequiredFieldValidator>  </div>    
    </div>
    <div class="pgrow">
        <div class="pgleft">Page Name:</div>
        <div class="pgright"><asp:TextBox ID="LinkName" CssClass="Navigationlink"  runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredLinkName" runat="server" ErrorMessage="*" ControlToValidate="LinkName"></asp:RequiredFieldValidator>
        </div>    
    </div>
    <div class="pgrow">
        <div class="pgleft">Page InnerHead Name:</div>
        <div class="pgright"><asp:TextBox ID="PageInnerHead" CssClass="Navigationlink"  runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredPageInnerHead" runat="server" ErrorMessage="*" ControlToValidate="PageInnerHead"></asp:RequiredFieldValidator>
        </div>    
    </div>
    
    <div class="PageDetailadd">Add Content to Page</div>
    <div>Image Link Format:Pictures/[imagename.jpg/.png]</div>
    <div class="">
       <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor" runat="server">
       </CKEditor:CKEditorControl>
    </div>
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
            <asp:Button ID="Addlinkbt" runat="server" Text="Add Link" OnClick="NewAddlink"/></div>    
    </div>    
</div>
</div>
</div>
</asp:Content>

