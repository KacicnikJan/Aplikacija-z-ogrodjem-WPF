<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DodajDom.aspx.cs" Inherits="naloga_6.DodajDom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 341px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Ime doma:"></asp:Label>
            <br />
            <asp:TextBox ID="textime" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Stevilka doma"></asp:Label>
            <br />
            <asp:TextBox ID="textstevilka" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Leto nastanka"></asp:Label>
            <br />
            <asp:TextBox ID="textletonastanka" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <asp:Button ID="button_potrdi" runat="server" Text="Potrdi" CssClass="auto-style2" Width="197px" OnClick="button_potrdi_Click" />
            <br />
            <br />

        <asp:Button ID="button_nazaj" runat="server" Text="Nazaj" OnClick="button_nazaj_Click" />
        </div>
    </form>
</body>
</html>
