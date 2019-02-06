<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="consultaAlojamientos.aspx.vb" Inherits="GestionAlojaminetos.consultaAlojamientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <table style="width: 100%; margin-top: 1%;">
        <tr>
            <td colspan="6">
                <div class="titulo">
                    <br />
                    Consulta de Alojamientos:


                    <br />


                </div>
            </td>
        </tr>
        <tr>
            <td class="td_table">Nombre:</td>
            <td class="td_table" colspan="5">
                <asp:TextBox ID="txt_Nombre" runat="server" AutoCompleteType="Disabled" MaxLength="50" Width="28%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="td_table">
                <asp:Label ID="Label1" runat="server" Text="Provincia:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:DropDownList ID="ddl_Prov" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="td_table">
                <asp:Label ID="Label2" runat="server" Text="Municipio:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:DropDownList ID="ddl_Muni" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="td_table">
                <asp:Label ID="Label3" runat="server" Text="Codigo Postal:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:DropDownList ID="ddl_Cod" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="td_table">
                <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
            </td>
            <td colspan="2" class="td_table_con">
                <asp:DropDownList ID="ddl_Tipo" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="td_table">
                <asp:Label ID="Label5" runat="server" Text="Capacidad:"></asp:Label>
            </td>
            <td colspan="2" class="td_table_con">
                <asp:DropDownList ID="ddl_Capa" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="td_table">
                <asp:Label ID="Label6" runat="server" Text="Gastronomico:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="chk_Gas" runat="server" />
            </td>
            <td class="td_table">
                <asp:Label ID="Label7" runat="server" Text="Restaurante:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="chk_Res" runat="server" />
            </td>
            <td class="td_table">
                <asp:Label ID="Label8" runat="server" Text="Surfing:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="chk_Surf" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="td_table">
                <asp:Label ID="Label9" runat="server" Text="Tiendas:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="Chk_Tie" runat="server" />
            </td>
            <td class="td_table">
                <asp:Label ID="Label10" runat="server" Text="Club:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="chk_Club" runat="server" />
            </td>
            <td class="td_table">
                <asp:Label ID="Label11" runat="server" Text="Autocaravana:"></asp:Label>
            </td>
            <td class="td_table_con">
                <asp:CheckBox ID="chk_Auto" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="td_table_con">
                <asp:Button ID="Button1" runat="server" Text="Buscar" />
            </td>
        </tr>
    </table>
</asp:Content>
