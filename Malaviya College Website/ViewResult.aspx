<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewResult.aspx.cs" Inherits="ViewResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Results</title>
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <link href="css/accord.css" rel="stylesheet" type="text/css" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
    <script src="js/deon.js" type="text/javascript"></script>
    <link rel="stylesheet" href="css/style.css" type="text/css"/>
</head>
<body style="background-color:#FFF;">
    <form id="form1" runat="server">
    <div class="Maindiv">
        <div class="clearh20"></div>
        <div class="Topdiv">
            <div class="tophead">SHRI POPATLAL DHANJIBHAI MALAVIYA COLLEGE OF COMMERCE, RAJKOT.</div>
        </div>
        <div class="sechead">CONSOLIDATED STATEMENT OF MARKS OF TERMINAL & PRELIMINARY EXAMINATIONS</div>
        <div class="infodiv">
            <div class="imgdiv"><img src="images/resultlogo.jpg" alt="" class="logimg"/></div>
            <div class="rightinfo">
                <div class="firstdet"><div class="stinfo">Class</div><div class="yearinfo" id="studentyears" runat="server"> </div></div>
                <div class="yeardiv"><div class="stinfo">Year</div><div class="yearinfo" id="yearinfos" runat="server"></div></div>                
                <div class="rolldiv"><div class="stinfo">Roll No.</div><div class="yearinfo" id="rollno" runat="server"></div></div>
                <div class="stname"><div class="stinfo">NAME</div><div class="yearinfo" id="stname" runat="server"></div></div>
                <div class="rdata">
                    <div class="summarydiv" id="falin" runat="server">FAIL IN 6 Subs.</div>
                    <div id="optsub" runat="server">Optional Sub. IT/BM</div>            
                </div>
            </div>
            
        </div>
        <div class="studentdata">
            <div class="studentdatadiv">
            <div class="subjectdiv">
                <%--<div class="subjectlayerul">Subject</div>--%>
                <ul class="subjectul" id="sublist" runat="server">
                    <li class="subjectlihead"><span class="subjectlayerul"><strong>Subject</strong></span></li>   
                    <%--<li class="subjectli">English <div>1</div></li>       
                    <li class="subjectli">Business Economics <div>2</div></li>        
                    <li class="subjectli">Financial Accounting <div>3</div></li>        
                    <li class="subjectli">Company Law <div>4</div></li>        
                    <li class="subjectli">Business Adm. <div>5</div></li>        
                    <li class="subjectli">FE/MKT/IT <div>6</div></li>                 
                    <li class="subjectli">MATHS/SSP <div>7</div></li>     
                    <li class="subjectli">Opt <div>8</div></li>     
                    <li class="subjectli">GRAND TOTAL <div>9</div></li>     
                    <li class="subjectli">PERCENTAGE <div>10</div></li>
                    <li class="subjectli">CLASS</li>--%>
                </ul>
                <ul class="subjectulbetweeom" id="termmarks" runat="server">
                    <li class="subjectlihead"><span class="subjectlayerul"><strong>TERMINAL</strong> MARKS OBTAINED OUT OF <strong>50</strong></span></li>   
                    <%--<li class="subjectlidata">**</li>       
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>       
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>--%>
                </ul>
                <ul class="subjectulbtom" id="premmarks" runat="server">
                    <li class="subjectlihead"><span class="subjectlayerul"><strong>PRELIMINARY</strong> MARKS OBTAINED OUT OF <strong>100</strong></span></li>   
                    <%--<li class="subjectlidata">**</li>       
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>       
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>
                    <li class="subjectlidata">**</li>--%>
                </ul>
                <ul class="subjectulbtom">
                    <div class="criteriadiv"><strong>PASSING STANDARD: </strong>- Pass: TERMINAL 18 Marks – PRELIMINARY 36 Marks, Second Class: 48%, First Class: 60%</div>
                    <div class="criteriadiv"><strong>NOTE: </strong>  PRODUCE THIS MARK SHEET AT THE TIME OF NEXT YEAR’S ADMISSION</div>
                    <div class="datediv">RAJKOT Dt.  </div>
                    <div class="pridiv">PRINCIPAL</div>
                </ul>
            </div>
            </div>
        
            
            
        </div>
    </div>
    </form>
</body>
</html>
