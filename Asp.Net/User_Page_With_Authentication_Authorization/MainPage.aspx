<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="User_Page_With_Authentication_Authorization.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="this is the main page only authenticated and authorized users get to see this hehe"></asp:Label>
        </div>
        <div>
            <a href ="OpenPage.aspx">page3</a>
        </div>
    </form>
</body>
</html>
