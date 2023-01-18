<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableView.aspx.cs" Inherits="Employee_Department_WebApp.TableView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server" Height="140px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="159px" AutoGenerateSelectButton="True" DataKeyNames="DID">

            </asp:GridView>
            <asp:Button ID="BtnShow" runat="server" OnClick="BtnShow_Click" Text="Show Departments" />
        </div>
        <p>
            <asp:Label ID="lbl2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbl1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
