<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="brochure.aspx.cs" Inherits="brochure" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="rightcontent">
 <div class="contentdata">
               <h2 class="contentdatahead">
                             </h2>
                
                
                <div class="contentright" id="contentr" runat="server">
                
                <div class="brochurediv">
                    <div class="brochurediv1">
                        <h3 class="brocat"><a href="pdf/mahiti.pdf" class="brolink">Download Catalogue in PDF Format</a></h3>
                        <div class="downlinkpdf">
                            <div class="dolimg"><img class="imgpdf" src="images/pdf-icon.jpg" alt="img" /> </div>
                        </div>
                        <div class="linkdiv"><a href="" class="linkimgbroc">Downloading Link for Acrobat Reader</a></div>
                    </div>
                    <div class="brochurediv1">
                        <h3 class="brocat"><a href="zip/MahitiPatrikaPDMCC.zip" class="brolink">Download Catalogue in Zip Format</a></h3>
                        <div class="downlinkpdf">
                            <div class="dolimg"><img class="imgpdf" src="images/zip-icon.jpg" alt="img" /> </div>
                        </div>
                        <div class="linkdiv"> <a href="" class="linkimgbroc">Downloading Link for WinZip</a></div>
                        </div>
                    </div>
                </div>
                        
                </div>                                
 </div>
 </div>
</asp:Content>

