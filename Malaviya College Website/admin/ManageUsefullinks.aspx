<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageUsefullinks.aspx.cs" Inherits="admin_ManageUsefullinks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Useful Links</div>
<div class="rightcontent">
<div class="PageDetailadd">Manage Useful Links</div>
<div class="PageDetailstates" id="status" runat="server"></div>
    <div class="aluminitablehead">
        <div class="headsection">
            <div class="linkshead">Link Name</div>
            <div class="linkshead">link Address</div>            
            <div class="addcat"><a href="AddUsefullinks.aspx" class="aphlink">Add Usefullinks</a></div>
        </div>
    </div>
    <asp:GridView ID="mgalimg" runat="server" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgalimg" GridLines="Horizontal" BorderWidth="0px" OnRowCommand="evaluate">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("linkname").ToString()%></div>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="prireq"><%# Eval("linkhref").ToString()%></div>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddUsefullinks.aspx?lid=<%#Eval("linkid") %>" title="Edit">Edit</a>                 
                            <%--<asp:LinkButton ID="edibtn" runat="server" CssClass="editbtn" CommandName="edit" CommandArgument='<%#Eval("aluminiid") %>'>Edit</asp:LinkButton> --%>              
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                                          
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("linkid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
   </asp:GridView>
</div>
</asp:Content>

