<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPTraine.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="loginForm" runat="server">
        <div>
            <asp:TextBox ID="txbLogin" runat="server" />
            <asp:TextBox ID="txbPassword" runat="server" />
            <asp:Label ID="lblMessage" runat="server" />
            <asp:Button ID="loginBtn" Text="Login" OnClick="loginBtn_Click" runat="server" />
        </div>
    </form>
</body>
</html>
