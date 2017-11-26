<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="Managestlist.aspx.cs" Inherits="admin_Managestlist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenthead">Current Students</div>
    <div class="rightcontent">
    <div class="PageDetailadd">Manage Students</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tableheadjnl">
        <div class="headsection">
            <div class="Studentjr">Student Name</div>
            <div class="Studentjr">Surname</div>            
            <div class="Studentjr">Father Name</div>
            <div class="Studentjr">Academic Year</div>
            <div class="Studentjr">Current Year</div>                                                             
            <div class="addcat"><a href="Addnewstudent.aspx" class="aphlink">New Student</a></div>
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server" OnRowCommand="evaluate" AutoGenerateColumns="False" ShowHeader="false" CssClass="mngjour" GridLines="Horizontal" BorderWidth="0px">
            <Columns>
            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("studentfirstname").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("studentlastname").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>            
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("fathername").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("academicyear").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>  
                                <div class="alheadjour"><%# Eval("studentyear").ToString()%></div>                                
                            </ItemTemplate>
            </asp:TemplateField>
            
           <%-- <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="AddSubArticle.aspx?jid=<%#Eval("artid") %>" title="Add">Add</a>                                
                            </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="Addnewstudent.aspx?sttid=<%#Eval("stuud") %>" title="Edit">Edit</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("stuud") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

