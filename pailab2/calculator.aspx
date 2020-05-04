<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="calculator.aspx.vb" Inherits="pailab2.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="a = "></asp:Label>
        <asp:TextBox ID="a" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="b = "></asp:Label>
            <asp:TextBox ID="b" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="+" Value="1"></asp:ListItem>
                <asp:ListItem Text="-" Value="2"></asp:ListItem>
                <asp:ListItem Text="*" Value="3"></asp:ListItem>
                <asp:ListItem Text="/" Value="4"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:TextBox ID="result" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Oblicz" />
    </form>
</body>
</html>
