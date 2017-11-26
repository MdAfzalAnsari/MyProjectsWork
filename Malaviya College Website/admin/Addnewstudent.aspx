<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="Addnewstudent.aspx.cs" Inherits="admin_Addnewstudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenthead">Student Details</div>
<div class="rightcontent">
    <div class="cathead">
        <asp:TextBox ID="StudentName" runat="server" placeholder="Enter Student FirstName" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequStudentName" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  
    </div>
    <div class="cathead">
        <asp:TextBox ID="Surname" runat="server" placeholder="Enter Surname" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  
    </div>
    <div class="cathead">
        <asp:TextBox ID="FatherName" runat="server" placeholder="Enter Father's Name" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  
    </div>
    <div class="cathead">
        <asp:DropDownList ID="Studyear" runat="server" CssClass="photoheadinputdr" OnSelectedIndexChanged="changesub" AutoPostBack="true">
            <asp:ListItem Value="0" Text="Select Year"></asp:ListItem>
            <asp:ListItem Value="1" Text="First Year"></asp:ListItem>
            <asp:ListItem Value="2" Text="Second Year"></asp:ListItem>
            <asp:ListItem Value="3" Text="Third Year"></asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="reqStudyear" runat="server" ErrorMessage="*" InitialValue="0" ControlToValidate="Studyear"></asp:RequiredFieldValidator>
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  --%>
        <%--<asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Academic Year" CssClass="photoheadinput"></asp:TextBox>--%>
    </div>
    <div class="cathead">
        <asp:DropDownList ID="optionl" runat="server" CssClass="photoheadinputdr">
            <asp:ListItem Value="0" Text="Select Optional Subject"></asp:ListItem>
            <asp:ListItem Value="1" Text="FE"></asp:ListItem>
            <asp:ListItem Value="2" Text="MKT"></asp:ListItem>
            <asp:ListItem Value="3" Text="IT"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="option2" runat="server" CssClass="photoheadinputdr">
            <asp:ListItem Value="0" Text="Select Optional Subject"></asp:ListItem>
            <asp:ListItem Value="1" Text="Banking"></asp:ListItem>
            <asp:ListItem Value="2" Text="Computer"></asp:ListItem>
            <asp:ListItem Value="3" Text="Ad.A/c."></asp:ListItem>
            <asp:ListItem Value="4" Text="Stati"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="option3" runat="server" CssClass="photoheadinputdr">
            <asp:ListItem Value="0" Text="Select Optional Subject"></asp:ListItem>
            <asp:ListItem Value="1" Text="Banking"></asp:ListItem>
            <asp:ListItem Value="2" Text="Computer"></asp:ListItem>
            <asp:ListItem Value="3" Text="Ad.A/c."></asp:ListItem>
            <asp:ListItem Value="4" Text="Stati"></asp:ListItem>
        </asp:DropDownList>
        <asp:CustomValidator ID="custval" 
            runat="server" ErrorMessage="*" onservervalidate="custval_ServerValidate" />
       <%-- <asp:RequiredFieldValidator ID="RequiredFieldoptionl" runat="server" ErrorMessage="*" InitialValue="0" ControlToValidate="optionl"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldoption2" runat="server" ErrorMessage="*" InitialValue="0" ControlToValidate="option2"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldoption3" runat="server" ErrorMessage="*" InitialValue="0" ControlToValidate="option3"></asp:RequiredFieldValidator>--%>
    </div>
    <div class="cathead">
        <asp:TextBox ID="AcademicYear" runat="server" placeholder="Enter Academic Year" CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  
    </div>
    <div class="cathead">
        <asp:TextBox ID="rollno" runat="server" placeholder="Enter RollNo." CssClass="photoheadinput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="StudentName"></asp:RequiredFieldValidator>  
    </div>
    

    <%--<div class="cathead">
        <asp:TextBox ID="PhotoDetails" runat="server" placeholder="First/Second/Third Year" CssClass="photoheadinput"></asp:TextBox>
    </div>--%>       
    <div class="Buttondiv">
        <asp:Button ID="Addlinkbt" runat="server" Text="Add Student" OnClick="addstd"/>
    </div>    
</div>
</asp:Content>

