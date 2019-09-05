<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNote.aspx.cs" Inherits="ISchedulerPWA.Views.AddNote" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add a note | i-scheduler</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<link rel="stylesheet" type="text/css" href="../css/grid.min.css" />
	<link rel="stylesheet" type="text/css" href="../css/ischeduler.css" />
	<link rel="stylesheet" type="text/css" href="../css/fw.min.css" />
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/ischeduler.js"></script>
    <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
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
		<div class="row">
			<div class="col-12">
				<div class="page-heading">Add a note</div>
			</div>
		</div>
		<div class="row">
			<div class="col-12">
				<div class="adder-box">
                    <form runat="server">
					<div class="row">
						<div class="col-8">
							<div class="textbox">
								<label for="title">Title</label>
                                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-12 textbox">
							<label for="note">Note</label>
							<textarea id="noteBody" runat="server"></textarea>
							<script type="text/javascript">CKEDITOR.replace("noteBody")</script>
						</div>
					</div>
                    <div class="row">
                        <div class="col-2">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn btn-blue" />
                        </div>
                        <div class="col-10">
                            <button class="btn btn-blue" onclick="window.history.back()">Cancel</button>
                        </div>
                    </div>
                    </form>
				</div>
			</div>
		</div>
	</div>
</body>
</html>
