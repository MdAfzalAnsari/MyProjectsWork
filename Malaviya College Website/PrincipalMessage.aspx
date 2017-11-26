<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="PrincipalMessage.aspx.cs" Inherits="PrincipalMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="rightcontent">
    <div style="color:#A2410D;"></div>
    <div class="registrationdetailsdiv">
    <div class="registrationdetails">
    <div class="PageDetailstates" id="status" runat="server"></div>
        <div class="personalhead">Post A Message</div>
        <div class="row">
            <div class="lrow">Full Name *</div>
            <div class="rrow">
                <asp:TextBox ID="FullName" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldFullName" runat="server" ErrorMessage="*" ControlToValidate="FullName"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Email Address * </div>
            <div class="rrow">
                <asp:TextBox ID="EmailAddress" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldEmail" runat="server" ErrorMessage="*" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
        </div>   
        <div class="row">
            <div class="lrow">Residence phone</div>
            <div class="rrow">
                <asp:TextBox ID="Residencephone" runat="server"  CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldResidencephone" runat="server" ErrorMessage="*" ControlToValidate="Residencephone"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Address *</div>
            <div class="rrow">
                <asp:TextBox ID="ResidenceAddress" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldResidenceAddress" runat="server" ErrorMessage="*" ControlToValidate="ResidenceAddress"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Subject </div>
            <div class="rrow">
                <asp:TextBox ID="Subject" runat="server" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldSubject" runat="server" ErrorMessage="*" ControlToValidate="Subject"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="lrow">Brief About Yourself *</div>
            <div class="rrow">
                <asp:TextBox ID="brief" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldbrief" runat="server" ErrorMessage="*" ControlToValidate="brief"></asp:RequiredFieldValidator>
        </div>
       <div class="row">
            <div class="lrow">Message *</div>
            <div class="rrow">
                <asp:TextBox ID="message" runat="server" TextMode="MultiLine" CssClass="almreginput"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldmessage" runat="server" ErrorMessage="*" ControlToValidate="message"></asp:RequiredFieldValidator>
        </div>                                       
        <div class="clearh20"></div> 
        <div class="row">
            <div class="lrow">&nbsp;</div>
            <div class="rrow">
                <asp:Button ID="Addregister" runat="server" Text="Submit" CssClass="subnbtn" OnClick="sendmessage"/>
            </div>
        </div>                                
    </div>
    </div>
</div>
</asp:Content>

