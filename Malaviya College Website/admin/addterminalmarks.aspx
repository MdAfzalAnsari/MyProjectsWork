<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminPage.master" AutoEventWireup="true" CodeFile="addterminalmarks.aspx.cs" Inherits="admin_addterminalmarks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Terminal Result</div>
        <div class="rightcontent">
            <div class="PageDetailadd">Enter Marks For Terminal Results Out Of 50</div>
            <div class="cathead">
                <asp:TextBox ID="Emarks" runat="server" placeholder="Enter English Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEmarks" runat="server" ErrorMessage="*" ControlToValidate="Emarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="Eecomarks" runat="server" placeholder="Enter Businesseconomics Marks " CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEecomarks" runat="server" ErrorMessage="*" ControlToValidate="Eecomarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="EAccomarks" runat="server" placeholder="Enter FinancialAccounting Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEAccomarks" runat="server" ErrorMessage="*" ControlToValidate="EAccomarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="ELawmarks" runat="server" placeholder="Enter CompanyLaw Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredELawmarks" runat="server" ErrorMessage="*" ControlToValidate="ELawmarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="EAdmmarks" runat="server" placeholder="Enter BusinessAdm Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEAdmmarks" runat="server" ErrorMessage="*" ControlToValidate="EAdmmarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="Eoptmarks" runat="server" placeholder="Enter FE/ME/IT Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEoptmarks" runat="server" ErrorMessage="*" ControlToValidate="Eoptmarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="EMATmarks" runat="server" placeholder="MATHS/SSP Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEMATmarks" runat="server" ErrorMessage="*" ControlToValidate="EMATmarks"></asp:RequiredFieldValidator>  
            </div>
            <div class="cathead">
                <asp:TextBox ID="OEMATmark" runat="server" placeholder="Opt Marks" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredOEMATmark" runat="server" ErrorMessage="*" ControlToValidate="OEMATmark"></asp:RequiredFieldValidator>  
            </div> 
            <div class="Buttondiv">
                <asp:Button ID="Addlinkbt" runat="server" Text="Add Marks" OnClick="addstd"/>
            </div>           
        </div>
    </asp:Content>

