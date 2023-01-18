<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerSide.aspx.cs" Inherits="Cookie_WebApp.ServerSide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 70px">
            <asp:Label ID="Label1" runat="server" Text="Session"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Application"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PrintHello" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Session Count:"></asp:Label>
        </p>
    </form>
</body>
</html>
