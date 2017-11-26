<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageAlumini.aspx.cs" Inherits="ManageAlumini" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Alumini</div>
<div class="rightcontent">
<div class="PageDetailadd">Manage Alumin Section</div>
<div class="PageDetailstates" id="status" runat="server"></div>
    <div class="aluminitablehead">
        <div class="headsection">
            <div class="subhead">Alumini SectionHead</div>
            <div class="subhead">Alumini SectionContent</div>            
            <div class="addcat"><a href="AddAluminiSection.aspx" class="aphlink">Add AluminiSection</a></div>
        </div>
    </div>
    <asp:GridView ID="mgalimg" runat="server" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgalimg" GridLines="Horizontal" BorderWidth="0px" OnRowCommand="evaluate">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadmg"><%# Eval("aluminihead").ToString() %></div>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <asp:TextBox ID="alumcontent" runat="server" Text='<%# Eval("aluminidetails").ToString() %>' TextMode="MultiLine" Enabled="false" CssClass="alumtext"></asp:TextBox>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddAluminiSection.aspx?lid=<%#Eval("aluminiid") %>" title="Edit">Edit</a>                 
                            <%--<asp:LinkButton ID="edibtn" runat="server" CssClass="editbtn" CommandName="edit" CommandArgument='<%#Eval("aluminiid") %>'>Edit</asp:LinkButton> --%>              
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                                          
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("aluminiid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

