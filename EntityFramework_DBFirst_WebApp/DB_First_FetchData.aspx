<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DB_First_FetchData.aspx.cs" Inherits="EntityFramework_DBFirst_WebApp.DB_First_FetchData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 344px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="BtnInsert" runat="server" OnClick="BtnInsert_Click" Text="Insert" />
            <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
            <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="BtnSelect" runat="server" OnClick="Button1_Click" Text="Select" />
        </div>
    </form>
</body>
</html>
