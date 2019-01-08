<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Loggin.aspx.vb" Inherits="GestionAlojaminetos.Indice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height: 100%">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Labetxe</title>
         <link rel="stylesheet" type="text/css" href="Estilos.css"/>
        <style type="text/css">
            .auto-style1 {
                width: 17%;
                background-color: #529E47;
                position: fixed;
                margin-left: 9%;
                margin-top: 9%;
                top: 25%;
                left: 34%;
                text-align: center;
                border-color: #508848;
            }
        </style>
    </head>
    <body class="fondo">
        <form id="form_Loggin" runat="server">
            <div>
                <asp:Login ID="Login1" runat="server" CssClass="auto-style-1, box" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="Medium" ForeColor="#333333" Height="142px" Width="354px">
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                </asp:Login>
            </div>
        </form>
    </body>
</html>
