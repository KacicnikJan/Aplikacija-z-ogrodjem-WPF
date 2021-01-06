<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavadenUporabnik.aspx.cs" Inherits="naloga_6.NavadenUporabnik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {}
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div style="height: 607px">
            <asp:Button ID="button_izpisvsehstudentov" runat="server" Text="Izpis vseh študentov" CssClass="auto-style2" Width="240" OnClick="button_izpisvsehstudentov_Click" />
            <asp:Button ID="button_izpisvsehdomov" runat="server" Text="Izpis vseh domov" CssClass="auto-style1" Width="240" OnClick="button_izpisvsehdomov_Click" />                      
            <asp:Button ID="button_izpisdomaznajvecstudenti" runat="server" Text="Izpis doma z največ študenti" CssClass="auto-style3" Width="240" OnClick="button_izpisdomaznajvecstudenti_Click" />
            <asp:Button ID="button_izpisinformacijonajstarejsemstudentu" runat="server" Text="Izpis informacij o najstarejšen študentu" CssClass="auto-style4" Width="240" OnClick="button_izpisinformacijonajstarejsemstudentu_Click" />
            <asp:Button ID="button_izpispovprecnestarostistudentov" runat="server" CssClass="auto-style5" Text="Povprečna starost vseh študentov" Width="240" OnClick="button_izpispovprecnestarostistudentov_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6" Width="250px"></asp:TextBox>
            <asp:Button ID="button_izpisstudentovvdomu" runat="server" CssClass="auto-style7" Text="Izpis štundetov v domu" Width="150px" OnClick="button_izpisstudentovvdomu_Click" />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style8" Width="250px"></asp:TextBox>
            <asp:Button ID="button_izpisdomastudenta" runat="server" CssClass="auto-style9" Text="Izpis doma študenta" Width="150px" OnClick="button_izpisdomastudenta_Click" />
            <asp:TextBox ID="txtInformacijeStudent" runat="server" CssClass="auto-style10" Width="250px"></asp:TextBox>
            <asp:Button ID="button_izpisinformacijostudentu" runat="server" CssClass="auto-style11" Text="Izpis informacij o študentu" Width="159px" OnClick="button_izpisinformacijostudentu_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Seznam študentov"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="SeznamStudentov1" runat="server" AutoGenerateColumns="False" CssClass="auto-style2" Width="635px">
                <Columns>
                
                <asp:TemplateField HeaderText="ID" SortExpression="ID">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Id") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Ime" SortExpression="Ime">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Ime") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ime") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Priimek" SortExpression="Priimek">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Priimek") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Priimek") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Leto rojstva" SortExpression="Leto rojstva">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("LetoRojstva") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("LetoRojstva") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                 
                            
                  
            </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Seznam domov"></asp:Label>
            <asp:GridView ID="SeznamDomov1" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" Width="637px">
                <Columns>
                
                <asp:TemplateField HeaderText="ID" SortExpression="ID">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Stevilka doma" SortExpression="Stevilka doma">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Stevilka_Doma") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Stevilka_Doma") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Ime doma" SortExpression="Ime doma">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Ime_doma") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Ime") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Leto nastanka" SortExpression="Leto nastanka">  
                            <EditItemTemplate>  
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Leto_Nastanka") %>'></asp:TextBox>  
                            </EditItemTemplate>  
                            <ItemTemplate>  
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Leto_Nastanka") %>'></asp:Label>  
                            </ItemTemplate>  
                </asp:TemplateField>  
                 
            </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Nazaj" OnClick="Button1_Click" />
        </div>
    </form>

</body>
</html>
