<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrediStudenta.aspx.cs" Inherits="naloga_6.UrediStudenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 411px;
        }
        .auto-style2 {
            height: 415px;
        }
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="id" runat="server" Text="ID"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="emso" runat="server" Text="Emso"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="ime" runat="server" Text="Ime"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="priimek" runat="server" Text="Priimek"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="leto_rojstva" runat="server" Text="Leto rojstva"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btn_uredi" runat="server" Text="Uredi studenta" OnClick="btn_uredi_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Nazaj" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
