<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="PhotoView_details.aspx.cs" Inherits="PhotoView_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="rightcontent">
    <div class="rightphoto">
        <div class="piclarge" id="photodivid" runat="server">
            <asp:Image ID="bigimg" runat="server" CssClass="largeview" ImageUrl="images/journal.jpg"/>
        </div>
        <div class="pagingg">
            <asp:HyperLink ID="prev" runat="server" CssClass="navhyper" NavigateUrl=""><< Previous</asp:HyperLink>
            <asp:HyperLink ID="next" runat="server" CssClass="navhyper">Next >></asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

