<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSchedule.aspx.cs" Inherits="ISchedulerPWA.Views.EditSchedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Add new schedule | i-scheduler</title>
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
				<i class="fa fa-plus" aria-hidden="true" style="color: #95989A;"></i>
			</li>
		</ul>
	</nav>
    <div class="container">
		<div class="row">
			<div class="col-12">
				<div class="page-heading">Edit schedule</div>
			</div>
		</div>
		<div class="row">
			<div class="col-6">
                <form runat="server">
				   <div class="adder-box">
					<div class="textbox">
						<label for="title">Title</label>
                        <asp:TextBox ID="schTitle" runat="server"></asp:TextBox>
					</div>
					<div class="date-picker">
						<label>Date (dd/mm/yyyy)</label>
						<ul>
							<li>
                                <asp:DropDownList ID="ddList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
							<li>
								<asp:DropDownList ID="mmList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
							<li>
								<asp:DropDownList ID="yyList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
						</ul>
					</div>
					<div class="date-picker">
						<label>Time (hh:mm)</label>
						<ul>
							<li>
								<asp:DropDownList ID="hList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
							<li>
								<asp:DropDownList ID="mList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
							<li>
								<asp:DropDownList ID="tList" runat="server" AppendDataBoundItems="true">     
                                </asp:DropDownList>
							</li>
						</ul>
					</div>
					<div class="textbox">
						<label for="location">Location</label>
                        <asp:TextBox ID="schLoc" runat="server"></asp:TextBox>
					</div>
					<div class="dropdown">
						<label for="priority">Priority</label>
						<asp:DropDownList ID="pList" runat="server" AppendDataBoundItems="true">     
                        </asp:DropDownList>
					</div>
					<div class="dropdown">
						<label for="repeat">Repeat</label>
						<asp:DropDownList ID="rList" runat="server" AppendDataBoundItems="true">     
                        </asp:DropDownList>
					</div>
					<div class="row">
						<div class="col-6 center">
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-blue" OnClick="btnSave_Click" />
						</div>
                        <div class="col-6 center">
                            <button class="btn btn-blue" onclick="window.history.back()">Cancel</button>
						</div>
				    </div>
				</div>
                </form>
			</div>
		</div>
	</div>
</body>
</html>

