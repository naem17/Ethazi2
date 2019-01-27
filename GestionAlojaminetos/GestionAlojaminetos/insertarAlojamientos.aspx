﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="insertarAlojamientos.aspx.vb" Inherits="GestionAlojaminetos.insertarAlojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <table id="tabla_editar" class="tabla_edit">
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_aste" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_Firma" runat="server" Text="Firma:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Firma" runat="server" MaxLength="8" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_Nombre" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Nombre" runat="server" MaxLength="50"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_Direccion" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Direccion" runat="server" MaxLength="250"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Telefono" runat="server" MaxLength="15"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Email" runat="server" Text="Email:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Email" runat="server" MaxLength="50"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Web" runat="server" Text="Pagina Web:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Web" runat="server" MaxLength="100"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_Provincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Provincia" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="td_table">
                    <asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_Municipio" runat="server" Text="Municipio:"></asp:Label>
                </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Municipio" runat="server" AppendDataBoundItems="false" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label><asp:Label ID="lbl_CodPostal" runat="server" Text="Codigo Postal:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_CodPostal" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion" runat="server" Text="Descripcion:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Descripcion" runat="server" MaxLength="1500" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Descripcion_Eus" runat="server" Text="Descripcion Euskera:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Descripcion_Eus" runat="server" MaxLength="1500" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Capacidad" runat="server" Text="Capacidad:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Cap" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="td_table">
                    <asp:Label ID="lbl_Tipos" runat="server" Text="Tipos:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Tipos" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Tipos_eus" runat="server" Text="Tipos Euskera:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Tipos_eus" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Categorias" runat="server" Text="Categorias:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:DropDownList ID="ddl_Categorias" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="td_table">
                    <asp:Label ID="lbl_Coordenadas" runat="server" Text="Coordenadas:"></asp:Label>
                    </td>
                <td class="td_table_con">
                    <asp:TextBox ID="txt_Coordenadas" runat="server" MaxLength="200"></asp:TextBox>
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

                    <asp:Label ID="lbl_FIRM" runat="server" Visible="False"></asp:Label>

                </td>
                <td class="td_table">

                </td>
            </tr>
            <tr>
                <td class="td_table" colspan="3" style="color: #FF0000">
                    * Los campos son obligatorios</td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td class="td_table">

                </td>
                <td style="padding: 10px; float: right;">
                    <asp:Button ID="btn_Insert" runat="server" Text="Insertar Alojamiento" BackColor="#006D9C" BorderColor="#006D9C" BorderStyle="Solid" Font-Bold="True" ForeColor="White" />
                </td>
            </tr>
        </table>
</asp:Content>