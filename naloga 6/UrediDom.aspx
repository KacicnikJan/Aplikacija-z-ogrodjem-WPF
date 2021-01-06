<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrediDom.aspx.cs" Inherits="naloga_6.UrediDom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 377px;
        }
        .auto-style2 {
            height: 372px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="ID Doma"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Stevilka doma"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ime doma"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_uredidom" runat="server" Text="Uredi dom" OnClick="btn_uredidom_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Nazaj" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
