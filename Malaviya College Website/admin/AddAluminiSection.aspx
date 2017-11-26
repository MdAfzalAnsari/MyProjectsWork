<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="AddAluminiSection.aspx.cs" Inherits="admin_AluminiManage" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Alumini</div>
<div class="rightcontent">
<div class="almhead">Alumini Management</div>
<div class="alhead">
    <div class="alheadcontent">
    <div class="alumdiv">Alumini Header </div>
        <div class="blockhead">
            <asp:TextBox ID="aluminihead" runat="server" CssClass="alinput" placeholder="Alumini Section Head"></asp:TextBox>
            
        </div>
        <asp:RequiredFieldValidator ID="Requiredaluminihead" runat="server" ErrorMessage="*" ControlToValidate="aluminihead"></asp:RequiredFieldValidator>
    </div>
    
</div>
<div class="alhead">
        <div class="alheadcontent">
        <div class="alumdiv">Alumini Section Details </div>
                <div class="blockhead">
                    <asp:TextBox ID="SectionDetails" runat="server" CssClass="alinput" TextMode="MultiLine" placeholder="Paste Source from Editor"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredSectionDetails" runat="server" ErrorMessage="*" ControlToValidate="SectionDetails"></asp:RequiredFieldValidator>
        </div>
</div>
    <div class="aluminipagecontents">
       <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor" runat="server">
       </CKEditor:CKEditorControl>
    </div>
    <div class="divsub">
        <asp:Button ID="Addlinkbt" runat="server" Text="Add Alumini Section" OnClick="addaluminisection"/>
    </div>
</div>
</asp:Content>

