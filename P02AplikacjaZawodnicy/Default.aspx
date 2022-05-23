<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P02AplikacjaZawodnicy.Default" %>


<%--http://tomaszles.pl/2019/03/17/szablon-dashboard/--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="float: left">
            <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" />
            <br />
            <%-- <asp:TextBox ID="txtWynik" runat="server"></asp:TextBox>--%>
            <asp:ListBox ID="lbDane" Height="250" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged" runat="server"></asp:ListBox>
        </div>

        <div style="margin-left: 10px; float: left" id="szczegolyZAwodnika">
            <asp:Panel ID="pnlSzczegolyZawodnika" runat="server">

                <table>
                    <tr>
                        <td>Imie</td>
                        <td>
                            <asp:TextBox ID="txtImie" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Nazwisko</td>
                        <td>
                            <asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Kraj</td>
                        <td>
                            <asp:TextBox ID="txtKraj" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Data urodzenia</td>
                        <td>
                            <asp:TextBox ID="txtDataUrodzenia" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Waga</td>
                        <td>
                            <asp:TextBox ID="txtWaga" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Wzrost</td>
                        <td>
                            <asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </asp:Panel>
            <div>
                <asp:Button ID="btnZapisz" OnClick="btnZapisz_Click" runat="server" Text="Zapisz" />
                <asp:Button ID="btnUsun" OnClick="btnUsun_Click" runat="server" Text="Usuń" />
                <asp:Button ID="btnNowy" OnClick="btnNowy_Click" Text="Dodaj" runat="server" />
                <asp:Button ID="btnCzysc" OnClick="btnCzysc_Click" Text="Czyść" runat="server" />
            </div>
        </div>




    </form>
</body>
</html>
