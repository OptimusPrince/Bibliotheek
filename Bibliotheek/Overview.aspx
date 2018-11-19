<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overview.aspx.cs" Inherits="Bibliotheek.Overview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style/Overview.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
            <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
        </div>

        <div class="container">
        <asp:Button ID="btnLogout" OnClick="btnLogout_Click" runat="server" Text="Logout" />
           </div>
       
        <div align="center" class="container">
            <asp:GridView ID="gvBooksOnLoan" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Title of Book" />
                    <asp:BoundField DataField="Author" HeaderText="Author" />
                </Columns>
            </asp:GridView>
        </div>

    </form>
</body>
</html>
