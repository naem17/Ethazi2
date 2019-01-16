<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EditarPagina.aspx.vb" Inherits="GestionAlojaminetos.EditaPaginaalojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <table cellspacing="10px" cellpadding="10" style="width: 50%">
        <tr>
            <td>
                <asp:Label ID="lbl_Firma" runat="server" Text="Firma"></asp:Label><br />
                <asp:TextBox ID="txt_Firma" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre"></asp:Label><br />
                <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_Descripcion_abre" runat="server" Text="Descripcion Abreviada"></asp:Label><br />
                <asp:TextBox ID="txt_Descripcion_abre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lbl_Descripcion_abre_eus" runat="server" Text="Descripcion Abreviada Euskera"></asp:Label><br />
                <asp:TextBox ID="txt_Descripcion_abre_eus" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
