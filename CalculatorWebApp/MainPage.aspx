<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="CalculatorWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pierwsza liczba:<br />
            <asp:TextBox ID="LiczbaPierwsza" runat="server"></asp:TextBox>
            <br />
            <br />
            Druga liczba<br />
            <asp:TextBox ID="LiczbaDruga" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="Dzialanie" runat="server">
                <asp:ListItem Value="0">Dodawanie</asp:ListItem>
                <asp:ListItem Value="1">Odejmowanie</asp:ListItem>
                <asp:ListItem Value="2">Mnożenie</asp:ListItem>
                <asp:ListItem Value="3">Dzielenie</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Oblicz" runat="server" OnClick="Oblicz_Click" Text="Oblicz" Width="132px" />
            <br />
            <br />
            <asp:Label ID="Wynik" runat="server"></asp:Label>
            <br />
            <br />
            Historia operacji<br />
            <asp:ListBox ID="Historia" runat="server" Width="151px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Odwtorz" runat="server" Text="Odtwórz" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
