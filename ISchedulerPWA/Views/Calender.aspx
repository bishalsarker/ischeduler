<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="ISchedulerPWA.Views.Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calender</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<link rel="stylesheet" type="text/css" href="../css/grid.min.css" />
	<link rel="stylesheet" type="text/css" href="../css/ischeduler.css" />
	<link rel="stylesheet" type="text/css" href="../css/fw.min.css" />
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/ischeduler.js"></script>
</head>
<body>
    <div id="mySidenav" class="sidenav">
	  <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
	  <a href="/login">Home</a>
	  <a href="#">Settings</a>
	  <a href="/logout">Logout</a>
      <a>(<asp:Label ID="idname" runat="server" Text=""></asp:Label>)</a>
	</div>
	<nav>
		<ul id="navcon" class="row nav-container">
			<li id="menu-icon" class="col-1 nav-icon">
				<i class="fa fa-bars" aria-hidden="true" style="color: #95989A;" onclick="openNav()"></i>
			</li>
			<li id="logo" class="col-10 logo center">
                <a href="/login">
                    &nbsp&nbsp i-scheduler
                </a>
			</li>
			<li id="add-icon" class="col-1 nav-icon">
				<a href="/addSchedule">
                    <i class="fa fa-plus" aria-hidden="true" style="color: #95989A;"></i>
				</a>
			</li>
		</ul>
	</nav>
    <div class="container">
		<div class="center month-slider-container">
		<ul class="month-slider">
			<li class="month-slider-control">
                <asp:HyperLink ID="linkPrev" runat="server">
                    <i class="fa fa-chevron-left" aria-hidden="true"></i>
                </asp:HyperLink>
			</li>
			<li><asp:Label ID="lblMonth" runat="server" Text="" CssClass="month-slider-month"></asp:Label></li>
			<li class="month-slider-control">
                <asp:HyperLink ID="linkNext" runat="server">
                    <i class="fa fa-chevron-right" aria-hidden="true"></i>
                </asp:HyperLink>
			</li>
		</ul>
		<div><asp:Label ID="lblYear" runat="server" Text="" CssClass="month-slider-year"></asp:Label></div>
		</div>

		<div class="row">
			<div class="col-4">
				<div class="date-card-large">
					<div>
                        <asp:Label ID="lblDay" runat="server" Text="" CssClass="date-card-large-day"></asp:Label>
					</div>
					<div>
                        <asp:Label ID="lblDate" runat="server" Text="" CssClass="date-card-large-date"></asp:Label>
					</div>
				</div>
			</div>
			<div class="col-8 event-container">
                <asp:Label ID="evList" runat="server" Text="">
                </asp:Label>
			</div>
		</div>

		<div>
            <asp:Label ID="cardList" runat="server" Text="" CssClass="cards-container"></asp:Label>
		</div>
	</div>
</body>
</html>
