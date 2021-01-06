<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DodatneOpcije.aspx.cs" Inherits="naloga_6.DodatneOpcije" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 609px;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="button_dodajstudenta" runat="server" CssClass="auto-style2" Text="Dodaj študenta" Width="250" OnClick="button_dodajstudenta_Click" />
        <asp:Button ID="button_dodajdom" runat="server" CssClass="auto-style3" Text="Dodaj dom" Width="250" OnClick="button_dodajdom_Click" />
        <p>
            <asp:Button ID="btnOdstraniStudenta" runat="server" OnClick="Odstrani_studenta" Text="Odstrani student" />
            <asp:Button ID="btnOdstraniDom" runat="server" Text="Odstrani dom" OnClick="btnOdstraniDom_Click" />
        </p>
        <p>
        <asp:Button ID="btn_uredi" runat="server" OnClick="btn_uredi_Click" Text="Uredi studenta" />
        <asp:Button ID="btn_uredidoma" runat="server" OnClick="btn_uredidoma_Click" Text="Uredi dom" />
        </p>
        <p>
        <br />
        <br />
            <asp:GridView ID="gridViewStudent" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowEditing="OnRowEditing" AutoGenerateColumns="False" OnSelectedIndexChanged="gridViewStudent_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id"/>
                    <asp:BoundField DataField="emso" HeaderText="emso"/>
                    <asp:BoundField DataField="ime" HeaderText="ime"/>
                    <asp:BoundField DataField="priimek" HeaderText="priimek"/>
                    <asp:BoundField DataField="letnicaRojstva" HeaderText="letnica rojstva"/>
                    

                    
                     <asp:TemplateField>
                        <ItemTemplate>
                            
                        </ItemTemplate>
                        <EditItemTemplate>
                            
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
            <br />
            <br />
            Domovi:<br />
            
            <asp:GridView ID="gridViewDom" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowEditing="OnRowEditingDom" AutoGenerateColumns="False" OnSelectedIndexChanged="gridViewDom_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="Gainsboro" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id"/>
                    <asp:BoundField DataField="stevilkadoma" HeaderText="stevilka doma"/>
                    <asp:BoundField DataField="imedoma" HeaderText="ime_doma"/>
                    
                     <asp:TemplateField>
                        <ItemTemplate>
                           
                        </ItemTemplate>
                        <EditItemTemplate>
                            
                        </EditItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>
        <asp:Button ID="button_dodajstudentavdom" runat="server" CssClass="auto-style4" Text="Dodaj študenta v dom" Width="250" OnClick="button_dodajstudentavdom_Click" />
        <asp:Button ID="button_odstranistudenta" runat="server" CssClass="auto-style5" Text="Odstrani študenda iz doma" Width="250" OnClick="button_odstranistudenta_Click" />
            <br />
            <br />
            <br />
            <br />
        <asp:Button ID="button_nazaj" runat="server" Text="Nazaj" OnClick="button_nazaj_Click" />
        </p>
    </form>
</body>
</html>
