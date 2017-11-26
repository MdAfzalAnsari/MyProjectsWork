<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">Result</div>
    <div class="rightcontent">
        <div style="color:#A2410D;"></div>
        <div class="registrationdetailsdiv">
        <div class="reslinks">
            <div class="resnewheader">Available Results</div>
            <div class="ressublinks"><a href="resultdetails.aspx?ystcur=1" class="aressublinks">1. 	 F.Y. B.Com.</a></div>
            <div class="ressublinks"><a href="resultdetails.aspx?ystcur=2" class="aressublinks">2. 	 S.Y. B.Com.</a></div>
            <div class="ressublinks"><a href="resultdetails.aspx?ystcur=3" class="aressublinks">3. 	 T.Y. B.Com.</a></div>            
        </div>
        </div>
    </div>
</asp:Content>

