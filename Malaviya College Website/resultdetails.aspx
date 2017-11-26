<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="resultdetails.aspx.cs" Inherits="resultdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="contenthead">Result</div>
    <div class="rightcontent">
        <div style="color:#A2410D;"></div>        
        <div class="registrationdetailsdiv">
        <div class="reslinks">
            <div class="resnewheader" id="yearnoae" runat="server">F.Y. B.Com.</div>
            <div class="ressublinks" id="studta" runat="server"></div>            
            <div class="ressublinks"><div class="Rolldivre">Roll No:</div><div class="rdatatext"><asp:TextBox ID="rollno" CssClass="rollnoinput" runat="server"></asp:TextBox></div></div>            
            <div class="subdiv"><asp:Button ID="Addlinkbt" runat="server" Text="Find Result" OnClick="getresult"/>
                <asp:HiddenField ID="Hidde" runat="server" />
                <asp:HiddenField ID="Hiddenyear" runat="server" />
                
            </div>
            <div class="" id="hiddfiled" runat="server"></div>
        </div>
        </div>
    </div>
</asp:Content>

