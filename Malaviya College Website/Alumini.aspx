<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Alumini.aspx.cs" Inherits="Alumini" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="contenthead">ALUMNI</div>
    <div class="rightcontent">
    
    <div class="status" id="state" runat="server"></div>
    <div id="aluminisec" runat="server" class="aluminisecdiv">
        <%--<div class="AluminiSection" >
            <div class="aluminhead">PDMCC alumni Rajkot</div>
            <div class="aluminisect">This community is for students and alumni’s of PDM College alumni Rajkot get in touch with college alumni to get career guidance build contacts and open up avenue for jobs & internship. Get the advice and instructions from your college seniors. Meet old friends and batch mates and your juniors stay in touch.

                [Alumni Relations strives to be your knowledgeable guide to the college.]
                If you one of the alumni you can register you self. CLICK HERE TO REGISTER</div>
        </div>--%>
    </div>
        <div class="regAluminiSection" id="regalum" runat="server">
            <div class="regaluminhead">REGISTERED ALUMNI</div>
                <div class="alumreg">
                    <div class="tabhead">
                        <div class="tabname">Name</div>
                        <div class="tabname">City</div>
                        <div class="tabname">Professional Status</div>
                    </div>
                    <div class="regcontentclass" id="regcontent" runat="server">                        
                    </div>
                </div>
        </div>
    </div>
</asp:Content>

