<%@ Page Language="C#" AutoEventWireup="true" EnableViewState ="true" CodeBehind="ReadCookie.aspx.cs" Inherits="Cookie_WebApp.ReadCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ReadCookie" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblCurrentTime" runat="server" Text="Current Time"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblTime" runat="server" Text="Time"></asp:Label>
        </p>
    </form>
</body>
</html>
