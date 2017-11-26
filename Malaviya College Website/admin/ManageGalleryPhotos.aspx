<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageGalleryPhotos.aspx.cs" Inherits="admin_ManageGalleryPhotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Photo Gallery</div>
<div class="rightcontent">
    <div class="PageDetailadd">Gallery Photos</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="tablehead">
        <div class="headsection">
            <div class="photosubhead">Image</div>
            <div class="photosubhead">Image Name</div>            
             <div class="photosubhead">Category Name</div>            
            <div class="addcat"><a href="AddPhotos.aspx" class="aphlink">Add New Photo</a></div>
        </div>
    </div>
    
            <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgimg" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <%# getimg(Eval("p_id").ToString(),Eval("cat_id").ToString(),Eval("photoname").ToString()) %>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <%# getcatname(Eval("cat_id").ToString()) %>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddPhotos.aspx?lid=<%#Eval("p_id") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("p_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

