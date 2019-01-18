<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EditarPagina.aspx.vb" Inherits="GestionAlojaminetos.EditaPaginaalojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
        <table id="tabla_editar" class="tabla_edit">
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Firma" runat="server" Text="Firma:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Firma" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Direccion" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Direccion" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Telefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Email" runat="server" Text="Email:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Web" runat="server" Text="Pagina Web:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Web" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Provincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Provincia" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Municipio" runat="server" Text="Municipio:"></asp:Label>
                </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Municipio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_CodPostal" runat="server" Text="Codigo Postal:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_CodPostal" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion" runat="server" Text="Descripcion:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Descripcion" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion_Eus" runat="server" Text="Descripcion Euskera:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Descripcion_Eus" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Capacidad" runat="server" Text="Capacidad:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Capacidad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Tipos" runat="server" Text="Tipos:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_CodTipos" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Tipos_eus" runat="server" Text="Tipos Euskera:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_CodTiposEus" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Categorias" runat="server" Text="Categorias:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Categorias" runat="server"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Coordenadas" runat="server" Text="Coordenadas:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Coordenadas" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Calidad" runat="server" Text="Calidad Asegurada:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Calidad" runat="server" />
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Tienda" runat="server" Text="Tienda:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Tienda" runat="server" />
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Gastronomico" runat="server" Text="Gastronomico:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Gastronomico" runat="server" />
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Club" runat="server" Text="Club:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Club" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Restaurante" runat="server" Text="Restaurante:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Restaurante" runat="server" />
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Autocaravana" runat="server" Text="Autocaravana:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Autocarvana" runat="server" />
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Surfing" runat="server" Text="Surfing:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:CheckBox ID="chk_Surfing" runat="server" />
                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" Visible="False"></asp:DetailsView>
                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td style="padding: 10px; float: right;">
                    <asp:Button ID="Button1" runat="server" Text="Actualizar Datos" Visible="False" />
                </td>
            </tr>
        </table>
</asp:Content>
