<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EditarPagina.aspx.vb" Inherits="GestionAlojaminetos.EditaPaginaalojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
        <table class="tabla_madre">
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Firma" runat="server" Text="Firma:"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txt_Firma" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion_abre" runat="server" Text="Descripcion Abreviada:"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txt_Descripcion_abre" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion_abre_eus" runat="server" Text="Descripcion Abreviada Euskera:"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txt_Descripcion_abre_eus" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Actualizar Datos" />
                </td>
            </tr>
        </table>
</asp:Content>
