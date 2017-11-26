<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageVirtualtour.aspx.cs" Inherits="ManageVirtualtour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Virtual Tour</div>
<div class="rightcontent">
    <div class="PageDetailadd">Manage VirtualTour Images</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tablehead">
        <div class="headsection">
            <div class="subhead">Image</div>
            <div class="subhead">Image Name</div>            
            <div class="addcat"><a href="AddVirtualTour.aspx" class="aphlink">Add New Image</a></div>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mgimg" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <%# getimg(Eval("virtualimg_id").ToString(), Eval("imagename").ToString())%>
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddVirtualTour.aspx?lid=<%#Eval("virtualimg_id") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("virtualimg_id") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

