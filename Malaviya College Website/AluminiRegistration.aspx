<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="AluminiRegistration.aspx.cs" Inherits="AluminiRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Alumini Registration</div>
<div class="rightcontent">
    <div style="color:#A2410D;">[Alumni Relations strives to be your knowledgeable guide to the college.]</div>
    <div class="registrationdetailsdiv">
    <div class="registrationdetails">
        <div class="personalhead">1.Personal Details</div>
        <div class="row">
            <div class="lrow">First Name *</div>
            <div class="rrow">
                <asp:TextBox ID="FirstName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldFirstNameName" runat="server" ErrorMessage="*" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Middle Name</div>
            <div class="rrow">
                <asp:TextBox ID="MiddleName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredMiddleName1" runat="server" ErrorMessage="*" ControlToValidate="MiddleName"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Last Name</div>
            <div class="rrow">
                <asp:TextBox ID="LastName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieLastName" runat="server" ErrorMessage="*" ControlToValidate="LastName"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Residence Address *</div>
            <div class="rrow">
                <asp:TextBox ID="ResidenceAddress" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredResidenceAddressor3" runat="server" ErrorMessage="*" ControlToValidate="ResidenceAddress"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">City * </div>
            <div class="rrow">
                <asp:TextBox ID="City" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ErrorMessage="*" ControlToValidate="City"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Pin Code</div>
            <div class="rrow">
                <asp:TextBox ID="PinCode" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldPinCode" runat="server" ErrorMessage="*" ControlToValidate="PinCode"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">State/Province</div>
            <div class="rrow">
                <asp:TextBox ID="StateProvince" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldStateProvince" runat="server" ErrorMessage="*" ControlToValidate="StateProvince"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Country</div>
            <div class="rrow">
                <asp:TextBox ID="Country" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldVCountry" runat="server" ErrorMessage="*" ControlToValidate="Country"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Residence phone</div>
            <div class="rrow">
                <asp:TextBox ID="Residencephone" runat="server"  CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldResidencephone" runat="server" ErrorMessage="*" ControlToValidate="Residencephone"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Cell Phone No.</div>
            <div class="rrow">
                <asp:TextBox ID="CellPhone" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldCellPhone" runat="server" ErrorMessage="*" ControlToValidate="CellPhone"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Email Address * </div>
            <div class="rrow">
                <asp:TextBox ID="EmailAddress" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFEmailAddress" runat="server" ErrorMessage="*" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Date of Birth *</div>
            <div class="rrow">
                <asp:TextBox ID="DateofBirth" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldDateofBirth1" runat="server" ErrorMessage="*" ControlToValidate="DateofBirth"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Marital Status</div>
            <div class="rrow">
                <asp:TextBox ID="MaritalStatus" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldMaritalStatus" runat="server" ErrorMessage="*" ControlToValidate="MaritalStatus"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Anniversary Date</div>
            <div class="rrow">
                <asp:TextBox ID="AnniversaryDate" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldAnniversaryDate" runat="server" ErrorMessage="*" ControlToValidate="AnniversaryDate"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">College Passing Year *</div>
            <div class="rrow">
                <asp:TextBox ID="PassingYear" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldPassingYear" runat="server" ErrorMessage="*" ControlToValidate="PassingYear"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow"> 	Name of Principal *</div>
            <div class="rrow">
                <asp:TextBox ID="PrincipalName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldPrincipalName" runat="server" ErrorMessage="*" ControlToValidate="PrincipalName"></asp:RequiredFieldValidator>
        </div>
        <div class="clearh20"></div>
        <div class="personalhead">2.Professional Details</div>
        <div class="row">
            <div class="lrow">Currently Employed</div>
            <div class="rrow">
                <asp:TextBox ID="CurrentlyEmployed" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldCurrentlyEmployed" runat="server" ErrorMessage="*" ControlToValidate="CurrentlyEmployed"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Business Owner</div>
            <div class="rrow">
                <asp:TextBox ID="BusinessOwner" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldVBusinessOwner" runat="server" ErrorMessage="*" ControlToValidate="BusinessOwner"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Professional</div>
            <div class="rrow">
                <asp:TextBox ID="Professional" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldProfessional" runat="server" ErrorMessage="*" ControlToValidate="Professional"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Student</div>
            <div class="rrow">
                <asp:TextBox ID="Student" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldStudent" runat="server" ErrorMessage="*" ControlToValidate="Student"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Others</div>
            <div class="rrow">
                <asp:TextBox ID="Others" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldOthers" runat="server" ErrorMessage="*" ControlToValidate="Others"></asp:RequiredFieldValidator>
        </div>
        <div class="clearh20"></div>
        <div class="personalhead">3.In Brief About your Self</div>
        <div class="row">
            <div class="lrow"><asp:TextBox ID="Brief" TextMode="MultiLine" runat="server" CssClass="almreginput"></asp:TextBox></div>         
            <asp:RequiredFieldValidator ID="RequiredFieldBriefr21" runat="server" ErrorMessage="*" ControlToValidate="Brief"></asp:RequiredFieldValidator>   
        </div>
        <div class="divsub">
            <asp:Button ID="Addregister" runat="server" Text="Submit" CssClass="subnbtn" OnClick="registeralm"/>
            <%--<asp:Button ID="Addlinkbt" runat="server" Text="Add Alumini Section" />--%>
        </div>
    </div>
    </div>
</div>
</asp:Content>

