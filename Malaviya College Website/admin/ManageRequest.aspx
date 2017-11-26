<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageRequest.aspx.cs" Inherits="admin_ManageRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Principal Request</div>
<div class="rightcontent">
<div class="PageDetailstates" id="status" runat="server"></div>
    <div class="PageDetailadd">Manage Request</div>
    
    
    <div class="tableheadjnl">
        <div class="headsection">
            <div class="subprireq">Person Name</div>
            <div class="subprireq">Address</div>            
            <div class="subprireq">Email</div>
            <div class="subprireq">Contact No</div>
            <div class="subprireq">About Person</div>
            <div class="subprireq">Message</div>                                                                                  
            <%--<div class="addcat"><a href="ManageJournals.aspx" class="aphlink">Add SubArticle</a></div>--%>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mngjour" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("personname").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("personaddress").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("personemail").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("personphone").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("aboutperson").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("message").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
           <%-- <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddSubArticle.aspx?jid=<%#Eval("artid") %>" title="Add">Add</a>                                
                            </ItemTemplate>
            </asp:TemplateField>--%>            
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("priid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

