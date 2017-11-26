<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="Managephotocategory.aspx.cs" Inherits="admin_Managephotogallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Photo Gallery</div>
<div class="rightcontent">
    <div class="PageDetailadd">Manage PhotoCategory</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tablehead">
        <div class="headsection">
            <div class="subhead">Category Image</div>
            <div class="subhead">Category Name</div>            
            <div class="addcat"><a href="AddPhotocategory.aspx" class="aphlink">Add New PhotoCategory</a></div>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgimg" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <%# getimg(Eval("category_id").ToString(),Eval("categoryimage").ToString(),Eval("categoryname").ToString()) %>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddPhotocategory.aspx?lid=<%#Eval("category_id") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("category_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

