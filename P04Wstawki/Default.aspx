<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P04Wstawki.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <%= "ala ma kota" %>

        <% 
           
            string s = "ala ma kota i ma psa";
            s = s.ToUpper();

            Response.Write(s);

            %>


        <% 

            for (int i = 0; i < 10; i++)
            {
                Response.Write("ala ma kota! <br>");
            }

            %>


        <p>Najleesze podjescie</p>



        <%
            for (int i = 0; i < 10; i++)
            {

        %>

            <p><%= "heej" %></p>


         <% }

            %>




    </form>
</body>
</html>
