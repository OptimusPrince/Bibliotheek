<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bibliotheek.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style/login.css" />
    <title>Login for Calco Library</title>
</head>
<body>
    <form id="counterLogInForm" runat="server">
        <div class="container">
            <h1>Welcome to the Calco Library</h1>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="errorContainer">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
        <div class="container">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
