<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="ViewArticle.aspx.cs" Inherits="ViewArticle" %>

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
                            <div class="jiss" id="issueno" runat="server">Issue No.</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="jiss" id="issueMonth" runat="server">Month</div>
                        </div>
                        <%--<div class="jrighttopul">                            
                            <div class="jiss"><a class="jounnav" href=""><< Previous</a><a class="jounnav" href="">Next >></a> </div>
                        </div>--%>
                    </div>
                    <div style="clear:both;height:10px;display:block;"></div>
                <div class="journalcontents" id="articlecontent" runat="server">
                    <div class="journalcontentheader">Content</div>
                    <%--<div>
                        <div class="jrighttopul">                            
                            <div class="editorial">From The Editor's Desk</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="prinmess">1. Editorial </div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="Authordiv">Prin. (Dr.) K.M. Jani </div>
                        </div>
                    </div>
                    <div>
                        <div class="jrighttopul">                            
                            <div class="editorial">A Message From Presidentk</div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="prinmess">2. Message From The Chairman  </div>
                        </div>
                        <div class="jrighttopul">                            
                            <div class="Authordiv">V. P. Malaviya</div>
                        </div>
                    </div>--%>
                </div>
                <div class="jrighttop">                        
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

