<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageSubjArticle.aspx.cs" Inherits="admin_ManageSubjArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Journal Articles</div>
<div class="rightcontent">
    <div class="PageDetailadd">Manage SubArticle</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tableheadjnl">
        <div class="headsection">
            <div class="subarticlejr">Subject</div>
            <div class="subarticlejr">Article Head</div>            
            <div class="subarticlejr">ArticlePdf</div>
            <div class="subarticlejr">Author</div>
            <div class="subarticlejr">Month&Year</div>                                         
            <div class="addcat"><a href="ManageJournals.aspx" class="aphlink">Add SubArticle</a></div>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mngjour" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("articlefilename").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("articletopichead").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("articlepdf").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("articleby").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("articlemonth").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            
           <%-- <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddSubArticle.aspx?jid=<%#Eval("artid") %>" title="Add">Add</a>                                
                            </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddSubArticle.aspx?artid=<%#Eval("artid") %>&arjid=<%#Eval("jid_topic") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("artid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

