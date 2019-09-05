<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoteViewer.aspx.cs" Inherits="ISchedulerPWA.Views.NoteViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    <div class="container" style="margin-top: 40px;">
		<div class="row">
			<div class="col-12">
				<ul class="note-viewer-nav">
					<li><a style="cursor:pointer;" onclick="window.history.back()">Back</a></li>
					<li><asp:HyperLink ID="editLink" runat="server">Edit</asp:HyperLink></li>
					<li><asp:HyperLink ID="deleteLink" runat="server">Delete</asp:HyperLink></li>
				</ul>
			</div>
		</div>
		<div class="row">
			<div class="col-12">
                <asp:Label ID="nTitle" runat="server" Text="" CssClass="note-title"></asp:Label>
			</div>
		</div>
		<div class="row">
			<div class="col-12">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
				<asp:Label ID="nBody" runat="server" Text="" CssClass="note-body"></asp:Label>
			</div>
		</div>
	</div>
</body>
</html>
