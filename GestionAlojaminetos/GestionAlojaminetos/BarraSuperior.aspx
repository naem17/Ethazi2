<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="BarraSuperior.aspx.vb" Inherits="GestionAlojaminetos.BarraSuperior" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BarraSuperior" runat="server">
    <asp:Image ID="Image1" runat="server" Height="73px" ImageUrl="~/Imagenes/Logotipo.png" ToolTip="Etxebal" Width="308px" />
&nbsp;<br />
<br />
Opciones:<br />
<asp:RadioButton ID="Update_Rbtn" runat="server" GroupName="Opciones" Text="Añadir" />
<asp:RadioButton ID="Delete_Rbtn" runat="server" GroupName="Opciones" Text="Eliminar" />
<asp:RadioButton ID="Select_Rbtn" runat="server" GroupName="Opciones" Text="Visualizar" />
&nbsp;
</asp:Content>
