<%@ Page Language="C#" AutoEventWireup="true" EnableViewState="true" CodeBehind="WriteCookie.aspx.cs" Inherits="Cookie_WebApp.WriteCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRedirect" runat="server" OnClick="btnRedirect_Click" Text="Redirect" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
