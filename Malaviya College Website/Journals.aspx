<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="Journals.aspx.cs" Inherits="Journals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="tourrightcontent">
    <div class="journaldiv">
        <div class="jdiv">
            <div class="jorhead">
                <img class="jourimg" src="images/vinimay_head.jpg" alt=""/>
            </div>
            <div class="innerjourhead">A JOURNAL OF P.D. MALAVIYA COLLEGE OF COMMERCE. RAJKOT</div>
            <div class="jjleft">
                <div class="jleftcontent">
                    <div class="inerhead">EDITORS</div>
                    <div class="">
                        <ul class="editul">
                        <li>Dr. K.M.Jani</li>
                        <li>Prof. Pradeep V. Jobanputra</li>
                        </ul>
                    </div>
                    <div class="inerhead">DESIGN</div>
                    <div class="">
                        <ul class="editul">
                            
                            <li>Pradeep Jobanputra</li>
                        </ul>
                    </div>
                    <div class="inerhead">News</div>
                    <div class="">
                        <ul class="editul">
                            
                            <li>The Second Issue Feel Free tosend your Articles and Research Papers to us</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="jjright">
                <div class="jrightcontent">
                    <div class="jrighttop">
                        <div class="jrighttopul">                            
                            <div class="jisshead" id="issueno" runat="server">Issue No.</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jisshead" id="issueMonth" runat="server">Month</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jiss"><a class="jounnav" href="" id="prev" runat="server"><< Previous</a><a class="jounnav" href="" id="next" runat="server">Next >></a> </div>
                        </div>
                    </div>
                <div class="journalcontents">
                    <div class="journalcontenthead"><img class="journalcontentimg" src="DyanamicImages/2066846211.png" alt="" /></div>
                    
                </div>
                <div class="jrighttop">
                        <div class="jrighttopul">                            
                            <div class="jiss"><a class="jounnav" href="" id="viewart" runat="server">View Article</a></div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jiss"><a class="jounnav" href="">Submit Article</a></div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jiss">SHREE P.D. MALAVIYA COLLEGE OF COMMERCE</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jiss">RAJKOT-360 004.</div>
                        </div>
                 </div>
                </div>
            </div>
        </div>
    
    </div>
</div>
</asp:Content>

