<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ISchedulerPWA.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign in to your account</title>
    <link rel="stylesheet" type="text/css" href="../css/grid.min.css" />
	<link rel="stylesheet" type="text/css" href="../css/ischeduler.css" />
	<link rel="stylesheet" type="text/css" href="../css/fw.min.css" />
	<script type="text/javascript" src="js/jquery.js"></script>
	<script type="text/javascript" src="js/ischeduler.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <div class="row">
                    <div class="col-12 center">
                        <h1 style="color:#95989A;">i-scheduler</h1>
                        <h3 style="color: #3E3C3C;">Sign in to your account</h3>
                    </div>
                </div>
                <div class="row" style="background-color: #F3F3F3;">
                    <div class="col-12">
                        <div class="row">
                            <div class="col-1"></div>
                            <div class="col-10">
                                <div style="padding-top:5px; padding-bottom: 5px">
                                    <asp:Label ID="err" runat="server" Text="" ForeColor="#FF846B"></asp:Label>
                                </div>
                                <div class="textbox">
							        <label for="title">Username</label>
                                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
						        </div>
                                <div class="textbox">
							        <label for="title">Password</label>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
						        </div>
                            </div>
                            <div class="col-1"></div>
                        </div>
                        <div class="row center">
                            <div class="col-12">
                                <asp:Button ID="btnSubmit" runat="server" Text="Login" CssClass="btn btn-blue" OnClick="btnSubmit_Click" />
                            </div>
                        </div>
                        <div class="row"><div class="col-12"></div></div>
                    </div>
                </div>
            </div>
            <div class="col-4"></div>
        </div>
    </form>
</body>
</html>
