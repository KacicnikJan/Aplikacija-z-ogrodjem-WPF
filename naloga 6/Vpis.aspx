<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vpis.aspx.cs" Inherits="naloga_6.Vpis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 234px;
            width: 470px;
        }
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Uporabnisko ime:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Geslo:"></asp:Label>
            <br />
            <asp:TextBox ID="upime" runat="server"></asp:TextBox>
            <asp:TextBox ID="geslo" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="button_prijava" runat="server" Text="Prijava" CssClass="auto-style2" OnClick="button_prijava_Click" Width="150px" />
        </div>
    </form>
</body>
</html>
