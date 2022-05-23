<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01AplikacjeInternetoweWstep.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       

        <asp:Button ID="btnPrzycisk" OnClick="btnPrzycisk_Click" runat="server" Text="Przycisk ASP" />
        
        <p><asp:Label ID="lblWynik" runat="server" Text="---"></asp:Label></p>

        <p><%= Napis  %></p>



        <input type="button" value="Przycisk HTML" id="btnPrzyciskHTML" />
        
     


    </form>
</body>
</html>
