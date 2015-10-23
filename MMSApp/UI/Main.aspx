<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Main.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="MMSApp.UI.Main1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContetPlaceHolder" runat="server">
    

    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  
		  <!-- Wrapper for slides -->
		  <div class="carousel-inner" role="listbox">
			<div class="item active">
			    <img src="../images/slide1.jpg" alt="..." />
			  
			</div>
			<div class="item">
			    <img src="../images/slide2.jpg" alt="..." />
			  
			</div>
			<div class="item">
			    <img src="../images/slide3.jpg" alt="..." />
			  
			</div>
		  </div>

		  <!-- Controls -->
		  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
			<span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
			<span class="sr-only">Previous</span>
		  </a>
		  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
			<span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
			<span class="sr-only">Next</span>
		  </a>
	</div>
    
    
    <!-- Bootstrap Jquery -->
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/jquery-2.1.4.min.js"></script>
    

</asp:Content>
