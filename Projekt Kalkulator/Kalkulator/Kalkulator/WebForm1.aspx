<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Kalkulator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div>
            <asp:TextBox ID="TextBox1"  name="liczba1" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" name="liczba2" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="="></asp:Label>
            <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Underline="False" ForeColor="#FF0066" Text="Komunikat"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Oblicz" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Wyczyść" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
