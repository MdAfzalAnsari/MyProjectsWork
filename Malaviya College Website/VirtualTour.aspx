<%@ Page Title="" Language="C#" MasterPageFile="AdditionalMasterPage.master" AutoEventWireup="true" CodeFile="VirtualTour.aspx.cs" Inherits="VirtualTour" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<%--<link rel="stylesheet" href="css2/mainstyle.css" type="text/css" media="screen"/>--%>
	<link rel="stylesheet" type="text/css" href="css2/style.css"/>
	<script type="text/javascript" async="" src="js2/ga.js"></script>
    <%--<script type="text/javascript" src="js2/jquery.js"></script>--%><style type="text/css"></style>
	<!-- End WOWSlider.com HEAD section -->

<style type="text/css">

</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="tourrightcontent">
        <div class="ruled1">	
	<!-- Start WOWSlider.com BODY section -->
	            <div id="wowslider-container1" style="font-size: 10px;">
	            <div class="ws_images">
                <ul style="position: absolute; top: 0px; -webkit-animation: none; width: 1000%; left: -400%; visibility: visible;" id="slide" runat="server">
                    <%--<li style="width: 10%; font-size: 0px;"><img src="slider/panorama.jpg" alt="Willemstad panorama: wordpress gallery code" title="Willemstad panorama"  style="visibility: visible;"/></li>
                    <li style="width: 10%; font-size: 0px;"><img src="slider/pelican.jpg" alt="Pelican: wordpress image gallery" title="Pelican"  style="visibility: visible;"/></li>
                    <li style="width: 10%; font-size: 0px;"><img src="slider/plantation.jpg" alt="Aloe Vera plantation: wordpress gallery plugin" title="Aloe Vera plantation"  style="visibility: visible;"/></li>
                    <li style="width: 10%; font-size: 0px;"><img src="slider/playaforti.jpg" alt="Playa Forti beach: wordpress gallery random order" title="Playa Forti beach"  style="visibility: visible;"/></li>
                    <li style="width: 10%; font-size: 0px;"><img src="slider/sheteboka.jpg" alt="Shete Boka National Park: wordpress gallery widget" title="Shete Boka National Park" style="visibility: visible;"/></li>
                    <li style="width: 10%; font-size: 0px;"><img src="slider/windmills.jpg" alt="Windmills: wordpress gallery css" "="" title="Windmills" style="visibility: visible;"/></li>--%>
                </ul>
                <%--<canvas width="960" height="360" style="z-index: 8; position: absolute; width: 100%; height: 100%; left: 0px; top: 0px; visibility: hidden; opacity: 0;"></canvas><canvas width="960" height="360" style="z-index: 8; position: absolute; width: 100%; height: 100%; left: 0px; top: 0px; visibility: visible; opacity: 0;"></canvas>--%></div>

                
	                <div class="ws_shadow"></div>
	                <a href="" class="ws_next"></a><a href="" class="ws_prev"></a><div class="ws-title" style="display: block;"><%--<span style="position: relative; visibility: visible; left: 0px; top: 0px; opacity: 1;">Shete Boka National Park</span><div style="position: relative; visibility: visible; left: 0px; top: 0px; opacity: 1;">The Caribbean island of Curaçao</div>--%></div><a href="http://wowslider.com/wordpress-gallery-sky-blur-demo.html#" class="ws_playpause ws_play"></a></div>
	                <script type="text/javascript" src="js2/wowslider.js"></script>
	                <script type="text/javascript" src="js2/script.js"></script>
	                <!-- End WOWSlider.com BODY section -->
                <br/>
        </div>
</div>
</asp:Content>

