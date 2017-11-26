<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="ManageImages.aspx.cs" Inherits="ManageImages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Images</div>
<div class="rightcontent">
<div class="PageDetail">
<div class="PageDetailadd">Manage Application Images</div>
<div class="addpro"><a href="AddPic.aspx">Add New Image</a></div>    
<asp:GridView ID="manageimg" runat="server" AutoGenerateColumns="False" CssClass="mgimg"
                        BorderWidth="0px"  GridLines="Horizontal" PagerStyle-CssClass="paging"
                        DataKeyNames="imgid"  
                    HeaderStyle-BorderColor="Maroon" 
                        HeaderStyle-CssClass="headtable" ShowHeader="false" 
                    HeaderStyle-Width="100%" 
                    > 
                        
                                                                  
                    <Columns>                               
                        <asp:TemplateField>
                        <HeaderTemplate >
                           <asp:Label ID="Label1" Text="Featured Item" runat="server"/>
                        </HeaderTemplate>
                            <ItemTemplate>                                   
                                <%--<asp:CheckBox ID="chkview" runat="server" AutoPostBack="true"/>--%>                                                                                                            
                                <%--<label for="chkview"></label>  --%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-BorderWidth="0" >                                
                            <ItemTemplate >                                                                                 
                                <%# Imagebind(Eval("imgid").ToString(), Eval("imagename").ToString())%>                                                        
                            </ItemTemplate>
                        <ItemStyle BorderWidth="0px"></ItemStyle>
                        </asp:TemplateField>
                        <%--<asp:TemplateField> 
                            <ItemTemplate>  
                            <a class="edibtn" href="AddProductDetails.aspx?productname=<%#Eval("imagename") %>&productid=<%#Eval("imgid") %>" title="Edit" >Edit</a>                                
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:TemplateField>
                            <ItemTemplate>  
                                <asp:LinkButton class="edibtn" ID="DeleteProduct" runat="server" CommandName="Del" CommandArgument='<%#Eval("imgid") %>' >Delete</asp:LinkButton>
                                <asp:HiddenField ID="hide" Value='<%#Eval("imgid") %>' runat="server"/>
                            </ItemTemplate>
                        </asp:TemplateField>       
                                                 
                    </Columns>
                    
                <HeaderStyle BorderColor="Maroon" BorderWidth="0px" CssClass="headtable"></HeaderStyle>
                    
                </asp:GridView>   
</div>
</div>
</asp:Content>

