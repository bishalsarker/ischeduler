<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Congratulations.aspx.cs" Inherits="ISchedulerPWA.Views.Congratulations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thank your for registering with us | i-scheduler</title>
    <script>
        window.onload = function () {
            setTimeout(function () {
                window.location.href = "../";
            }, 5000);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center; color: #95989A">
        <h1>
            Congratulations! Your account has been created!
        </h1>
        <p>Please wait while we are redirecting you to login page...</p>
    </div>
    </div>
    </form>
</body>
</html>
