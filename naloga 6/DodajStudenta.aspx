<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DodajStudenta.aspx.cs" Inherits="naloga_6.DodajŠtudenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        #form1 {
            height: 418px;
        }
        .auto-style2 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
        <br />
        <asp:TextBox ID="textid" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Emso" runat="server" Text="EMSO:"></asp:Label>
        <br />
        <asp:TextBox ID="textemso" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Ime" runat="server" Text="Ime:"></asp:Label>
        <br />
        <asp:TextBox ID="textime" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Priimek" runat="server" Text="Priimek:"></asp:Label>
        <br />
        <asp:TextBox ID="textpriimek" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Letorojstva" runat="server" Text="Leto rojstva:"></asp:Label>
        <br />
        <asp:TextBox ID="textletorojstva" runat="server"></asp:TextBox>
        <br />
        

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
    </form>
</body>
</html>
