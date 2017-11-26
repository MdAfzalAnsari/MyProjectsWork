<%@ Page Title="" Language="C#" MasterPageFile="AdminPage.master" AutoEventWireup="true" CodeFile="generateresult.aspx.cs" Inherits="admin_generateresult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Primary Result</div>
        <div class="rightcontent">
            <div class="PageDetailadd">Enter Marks For Primary Results Out Of 100</div>
            <div class="cathead">
                <asp:TextBox ID="Emarks" runat="server" placeholder="Enter English" CssClass="photoheadinput" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEmarksbox" runat="server" ErrorMessage="*" ControlToValidate="Emarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="Eecomarks" runat="server" placeholder="Enter Businesseconomics" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEecomarks1" runat="server" ErrorMessage="*" ControlToValidate="Eecomarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="EAccomarks" runat="server" placeholder="Enter FinancialAccounting" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequireEAccomarks" runat="server" ErrorMessage="*" ControlToValidate="EAccomarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="ELawmarks" runat="server" placeholder="Enter CompanyLaw" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredELawmarks" runat="server" ErrorMessage="*" ControlToValidate="ELawmarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="EAdmmarks" runat="server" placeholder="Enter BusinessAdm" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEAdmmarks4" runat="server" ErrorMessage="*" ControlToValidate="EAdmmarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="Eoptmarks" runat="server" placeholder="Enter FE/ME/IT" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEoptmarks" runat="server" ErrorMessage="*" ControlToValidate="Eoptmarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="EMATmarks" runat="server" placeholder="MATHS/SSP" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEMATmarks6" runat="server" ErrorMessage="*" ControlToValidate="EMATmarks"></asp:RequiredFieldValidator>
            </div>
            <div class="cathead">
                <asp:TextBox ID="OEMATmark" runat="server" placeholder="Opt" CssClass="photoheadinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredOEMATmark" runat="server" ErrorMessage="*" ControlToValidate="OEMATmark"></asp:RequiredFieldValidator>
            </div> 
            <div class="Buttondiv">
                <asp:Button ID="Addlinkbt" runat="server" Text="Add Marks" OnClick="addstd"/>
            </div>             
        </div>

</asp:Content>

