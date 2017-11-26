<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Feedback</div>
<div class="rightcontent">
    <div style="color:#A2410D;"></div>
    <div class="registrationdetailsdiv">
    <div class="registrationdetails">
        <div class="personalhead">Details</div>
        <div class="row">
            <div class="lrow">Full Name *</div>
            <div class="rrow">
                <asp:TextBox ID="FirstName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ErrorMessage="*" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
        </div>        
        <div class="row">
            <div class="lrow"> Address *</div>
            <div class="rrow">
                <asp:TextBox ID="ResidenceAddress" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldResidenceAddress1" runat="server" ErrorMessage="*" ControlToValidate="ResidenceAddress"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">City * </div>
            <div class="rrow">
                <asp:TextBox ID="City" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ResidenceAddress"></asp:RequiredFieldValidator>
        </div>
       
        <div class="row">
            <div class="lrow">State/Province</div>
            <div class="rrow">
                <asp:TextBox ID="StateProvince" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ResidenceAddress"></asp:RequiredFieldValidator>
        </div>
         <div class="row">
            <div class="lrow">Pin Code</div>
            <div class="rrow">
                <asp:TextBox ID="PinCode" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredPinCode" runat="server" ErrorMessage="*" ControlToValidate="PinCode"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Country</div>
            <div class="rrow">
                <asp:TextBox ID="Country" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldCountry" runat="server" ErrorMessage="*" ControlToValidate="Country"></asp:RequiredFieldValidator>
        </div>        
        <div class="row">
            <div class="lrow">Cell Phone No.</div>
            <div class="rrow">
                <asp:TextBox ID="CellPhone" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldCellPhone" runat="server" ErrorMessage="*" ControlToValidate="CellPhone"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Email Address * </div>
            <div class="rrow">⁢⁢⁢⁢⁢⁢                
                <asp:TextBox ID="EmailAddress" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldEmailAddress" runat="server" ErrorMessage="*" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow"> Feedback *</div>
            <div class="rrow">
                <asp:TextBox ID="feed" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldfeed" runat="server" ErrorMessage="*" ControlToValidate="feed"></asp:RequiredFieldValidator>
        </div>
                        
        <div class="clearh20"></div>        
        <div class="divsub">
            <asp:Button ID="Addregister" runat="server" Text="Submit" CssClass="subnbtn" OnClick="registerfeed"/>
            <%--<asp:Button ID="Addlinkbt" runat="server" Text="Add Alumini Section" />--%>
        </div>
    </div>
    </div>
</div>
</asp:Content>

