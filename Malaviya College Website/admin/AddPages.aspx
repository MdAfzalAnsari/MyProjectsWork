<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddPages.aspx.cs" Inherits="AddPages" MasterPageFile="AdminPage.master"%>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %> 


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenthead">Add SubPages</div>
        <div class="rightcontent">
        <div id="status" class="PageDetailstates" runat="server"></div>
        <table class="addtablepage">
        <tr>
            <td>
                Sublink Name:
            </td>
            <td>
                <asp:TextBox ID="SublinkName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredSublinkName" runat="server" ErrorMessage="*" ControlToValidate="SublinkName"></asp:RequiredFieldValidator>  
            </td>
        </tr>
        <tr>
            <td>
                Pagelink Name:
            </td>
            <td>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredtxtTitle" runat="server" ErrorMessage="*" ControlToValidate="txtTitle"></asp:RequiredFieldValidator>  
            </td>
        </tr>
        <tr>
            <td>
                Page Inner Head
            </td>
            <td>
                <asp:TextBox ID="txtTags" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredtxtTags" runat="server" ErrorMessage="*" ControlToValidate="txtTags"></asp:RequiredFieldValidator>  
            </td>
        </tr>
        <tr>
            <td>
                Page Title
            </td>
            <td>
                <asp:TextBox ID="PageTitle" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredPageTitle" runat="server" ErrorMessage="*" ControlToValidate="PageTitle"></asp:RequiredFieldValidator>  
            </td>
        </tr>
        <%--<tr>
            <td>
               Upload Image
            </td>
            <td>
                <asp:FileUpload ID="imgupload" runat="server" />
            </td>
        </tr>--%>
        <tr>
            <td>
                Description
            </td>
            <td>
                <asp:TextBox ID="txtContent" runat="server" CssClass="textareaa" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredtxtContent" runat="server" ErrorMessage="*" ControlToValidate="txtContent"></asp:RequiredFieldValidator>  
            </td>
        </tr>                         
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnGenerate" runat="server" OnClick="btnGenerate_Click" Text="Generate Page" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <ul>
                    <li><font color="red">You may use basic html tags like &lt;H1&gt; &lt;H2&gt; &lt;B&gt;
                        &lt;I&gt; &lt;FONT&gt; etc. </font></li>
                    <li><font color="red">Tags like &lt;BODY&gt; &lt;HEAD&gt; &lt;TABLE&gt; are NOT allowed.</font></li>
                    <li><font color="red">Please check spelling before posting articles. Use Below Editor And click on Source Button of editor copy source from editor to description</font></li>
                </ul>
            </td>
        </tr>
    </table>
    <div class="pagecontents">
       <CKEditor:CKEditorControl ID="CKEditor1" BasePath="ckeditor" runat="server">
       </CKEditor:CKEditorControl>
    </div>

    </div>
</asp:Content>



        
        

    
    
  