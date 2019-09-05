<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScheduleViewer.aspx.cs" Inherits="ISchedulerPWA.Views.ScheduleViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Schedule | i-scheduler</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<link rel="stylesheet" type="text/css" href="../css/grid.min.css" />
	<link rel="stylesheet" type="text/css" href="../css/ischeduler.css" />
	<link rel="stylesheet" type="text/css" href="../css/fw.min.css" />
    <script src="../js/jquery.js"></script>
    <script src="../js/ischeduler.js"></script>
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
    <div class="container" style="margin-top: 20px;">
		<div class="row">
			<div class="col-6">
				<div class="viewer-box">
					<ul class="viewer-box-nav">
						<li><a style="cursor:pointer;" onclick="window.history.back()">Back</a></li>
						<li><asp:HyperLink ID="editLink" runat="server">Edit</asp:HyperLink></li>
						<li><asp:HyperLink ID="deleteLink" runat="server">Delete</asp:HyperLink></li>
					</ul>
                    <asp:Label ID="lblTitle" runat="server" Text="Label" CssClass="viewer-box-title"></asp:Label>
					<div class="viewer-box-info">
						<div>
							<i class="fa fa-calendar-o" aria-hidden="true" style="color: #ffffff;">
                                &nbsp <asp:Label ID="lblDay" runat="server" Text="" ForeColor="#ffffff"></asp:Label>
							</i>
						</div>
						<div>
							<i class="fa fa-clock-o" aria-hidden="true" style="color: #ffffff;">
                                &nbsp <asp:Label ID="lblTime" runat="server" Text="" ForeColor="#ffffff"></asp:Label>
							</i>
						</div>
						<div>
							<i class="fa fa-map-marker" aria-hidden="true" style="color: #ffffff;">
                                &nbsp &nbsp <asp:Label ID="lblLoc" runat="server" Text="" ForeColor="#ffffff"></asp:Label>
							</i>
						</div>
						<div>
							<i class="fa fa-flag" aria-hidden="true" style="color: #ffffff;">
                                &nbsp <asp:Label ID="lblPriority" runat="server" Text="" ForeColor="#ffffff"></asp:Label>
							</i>
						</div>
					</div>
				</div>
			</div>
			<div class="col-6">
			<div class="header-box header-box-red">
				<ul class="header-nav">
					<li class="header-box-title">Notes</li>
					<li class="header-box-icon">
                        <asp:HyperLink ID="addNoteLink" runat="server">
                            <i class="fa fa-plus" aria-hidden="true" style="color: #FFFFFF;"></i>
                        </asp:HyperLink>
					</li>
				</ul>
			</div>
			<div class="note-list-container">
                <asp:Label ID="noteList" runat="server" Text=""></asp:Label>
			</div>
			</div>
		</div>
	</div>
</body>
</html>
