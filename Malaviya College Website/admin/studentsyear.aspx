<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="studentsyear.aspx.cs" Inherits="admin_studentsyear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenthead">Current Students</div>
    <div class="rightcontent">
    <div class="PageDetailadd" runat="server" id="Mange">Manage Students</div>
    <div class="PageDetailstates" id="status" runat="server"></div>
    <div class="clearh" style="clear:both;height:10px;"></div>
    <div class="tableheadjnl">
        <div class="headsection">
            <div class="Studentyearjr">Student Name</div>
            <div class="Studentyearjr">Surname</div>            
            <div class="Studentyearjr">Father Name</div>
            <div class="Studentyearjr">Duration</div>                                                                           
        </div>
    </div>
    <asp:GridView ID="mgimg" runat="server"  AutoGenerateColumns="False" ShowHeader="false" CssClass="mngjour" GridLines="Horizontal" BorderWidth="0px">
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
                            <a class="almedibtn" href="addterminalmarks.aspx?sid=<%#Eval("stuud") %>&yr=<%#Eval("studentyear") %>" title="Add">Add Term Result</a>                                
                            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="almedibtn" href="generateresult.aspx?sid=<%#Eval("stuud") %>&yr=<%#Eval("studentyear") %>" title="Add">Add Primary Result</a>                                
                            </ItemTemplate>
            </asp:TemplateField>            
           <%-- <asp:TemplateField>
                            <ItemTemplate>                                                                  
                                <asp:LinkButton ID="deletbtn" runat="server" CssClass="editbtn" CommandName="del" CommandArgument='<%#Eval("studid") %>'>Delete</asp:LinkButton>
                            </ItemTemplate>
            </asp:TemplateField>--%>
            </Columns>
            </asp:GridView>
</div>
</asp:Content>

