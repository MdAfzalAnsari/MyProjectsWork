<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageJournals.aspx.cs" Inherits="admin_ManageJournals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Journals</div>
<div class="rightcontent">
    <div class="PageDetailadd">Manage Journals</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tableheadjnl">
        <div class="headsection">
            <div class="subheadjrn">Editorhead</div>
            <div class="subheadjrn">EditorPDF</div>            
            <div class="subheadjrn">MsgHead</div>
            <div class="subheadjrn">MsgPDF</div>
            <div class="subheadjrn">Month&Year</div>             
            <div class="subheadArticles">Article</div>                
            <div class="addcat"><a href="Addjournal.aspx" class="aphlink">Add Journal</a></div>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mngjour" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("editorhead").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("editorpdf").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("messasgehead").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("messagepdf").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("journ_month").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddSubArticle.aspx?jid=<%#Eval("jid") %>" title="Add">Add</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="Addjournal.aspx?jid=<%#Eval("jid") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("jid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

