<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageNavLink.aspx.cs" Inherits="DeleteNavLink" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Navigation Links</div>
<div class="rightcontent">
    <div class="PageDetail">
    <div class="PageDetailadd">Manage Navigation Link</div>
       
            <asp:GridView ID="mgimg" runat="server" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgimg" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="nameimg"><%#Eval("linkname") %></div>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="edibtn" href="EditContent.aspx?lid=<%#Eval("linkid") %>" title="Edit" >Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                  
                                <a class="edibtn" href="DeletepageDetail.aspx?did=<%#Eval("linkid") %>" >Delete</a> 
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
        
    </div>
</div>
</asp:Content>

