<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ISchedulerPWA.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up | i-scheduler</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<link rel="stylesheet" type="text/css" href="../css/grid.min.css" />
	<link rel="stylesheet" type="text/css" href="../css/ischeduler.css" />
	<link rel="stylesheet" type="text/css" href="../css/fw.min.css" />
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/ischeduler.js"></script>
</head>
<body>
	<nav>
		<ul class="row nav-container">
			<li class="col-12 logo">
				&nbsp&nbsp i-scheduler
			</li>
		</ul>
	</nav>
    <div class="container">
		<div class="row">
			<div class="col-12">
				<div class="page-heading">Sign up with i-scheduler</div>
			</div>
		</div>
		<div class="row">
			<div class="col-6">
                <form runat="server">
                    <div class="adder-box">
					<div class="row">
						<div class="col-12">
							<div class="textbox">
								<label for="title">Fullname</label>
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                <asp:Label ID="errName" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
							</div>
                            <div class="textbox">
								<label for="title">Username</label>
								<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                                <asp:Label ID="errUsername" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
							</div>
                            <div class="textbox">
								<label for="title">Email</label>
								<asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                                <asp:Label ID="errEmail" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
							</div>
                            <div class="textbox">
								<label for="title">Password</label>
								<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:Label ID="errPassword" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
							</div>
                            <div class="textbox">
								<label for="title">Retype Password</label>
								<asp:TextBox ID="txtRetypePassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:Label ID="errRetypePassword" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
							</div>
						</div>
					</div>
                    <div class="row">
						<div class="col-12">
                            <asp:Button ID="btnSubmit" runat="server" Text="Register" CssClass="btn btn-blue" OnClick="btnSubmit_Click" />
						</div>
				    </div>
				</div>
                </form>
			</div>
		</div>
	</div>
</body>
</html>
