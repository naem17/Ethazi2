<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Alojamientos.aspx.vb" Inherits="GestionAlojaminetos.Alojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Barra" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FIRMA" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="FIRMA" HeaderText="FIRMA" ReadOnly="True" SortExpression="FIRMA" />
            <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            <asp:BoundField DataField="DESCRIPCION_ABREVIADA" HeaderText="DESCRIPCION_ABREVIADA" SortExpression="DESCRIPCION_ABREVIADA" />
            <asp:BoundField DataField="DESCRIPCION_ABREVIADA_EUSKERA" HeaderText="DESCRIPCION_ABREVIADA_EUSKERA" SortExpression="DESCRIPCION_ABREVIADA_EUSKERA" />
            <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" SortExpression="DESCRIPCION" />
            <asp:BoundField DataField="DESCRIPCION_EUSKERA" HeaderText="DESCRIPCION_EUSKERA" SortExpression="DESCRIPCION_EUSKERA" />
            <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
            <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" SortExpression="DIRECCION" />
            <asp:BoundField DataField="CALIDAD_ASEGURADA" HeaderText="CALIDAD_ASEGURADA" SortExpression="CALIDAD_ASEGURADA" />
            <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
            <asp:BoundField DataField="WEB" HeaderText="WEB" SortExpression="WEB" />
            <asp:BoundField DataField="CLUB" HeaderText="CLUB" SortExpression="CLUB" />
            <asp:BoundField DataField="RESTAURANTE" HeaderText="RESTAURANTE" SortExpression="RESTAURANTE" />
            <asp:BoundField DataField="AUTOCARAVANA" HeaderText="AUTOCARAVANA" SortExpression="AUTOCARAVANA" />
            <asp:BoundField DataField="TIENDA" HeaderText="TIENDA" SortExpression="TIENDA" />
            <asp:BoundField DataField="CAPACIDAD" HeaderText="CAPACIDAD" SortExpression="CAPACIDAD" />
            <asp:BoundField DataField="GASTRONOMICO" HeaderText="GASTRONOMICO" SortExpression="GASTRONOMICO" />
            <asp:BoundField DataField="SURFING" HeaderText="SURFING" SortExpression="SURFING" />
            <asp:BoundField DataField="COORDENADAS" HeaderText="COORDENADAS" SortExpression="COORDENADAS" />
            <asp:BoundField DataField="CODIGO_MUNICIPIO" HeaderText="CODIGO_MUNICIPIO" SortExpression="CODIGO_MUNICIPIO" />
            <asp:BoundField DataField="CODIGO_PROVINCIA" HeaderText="CODIGO_PROVINCIA" SortExpression="CODIGO_PROVINCIA" />
            <asp:BoundField DataField="CODIGO_TIPOS" HeaderText="CODIGO_TIPOS" SortExpression="CODIGO_TIPOS" />
            <asp:BoundField DataField="CODIGO_TIPOS_EUSKERA" HeaderText="CODIGO_TIPOS_EUSKERA" SortExpression="CODIGO_TIPOS_EUSKERA" />
            <asp:BoundField DataField="CODIGO_CATEGORIAS" HeaderText="CODIGO_CATEGORIAS" SortExpression="CODIGO_CATEGORIAS" />
            <asp:BoundField DataField="ID_CODIGO_POSTAL" HeaderText="ID_CODIGO_POSTAL" SortExpression="ID_CODIGO_POSTAL" />
        </Columns>
    </asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT FIRMA, NOMBRE, DESCRIPCION_ABREVIADA, DESCRIPCION_ABREVIADA_EUSKERA, DESCRIPCION, DESCRIPCION_EUSKERA, TELEFONO, DIRECCION, CALIDAD_ASEGURADA, EMAIL, WEB, CLUB, RESTAURANTE, AUTOCARAVANA, TIENDA, CAPACIDAD, GASTRONOMICO, SURFING, COORDENADAS, CODIGO_MUNICIPIO, CODIGO_PROVINCIA, CODIGO_TIPOS, CODIGO_TIPOS_EUSKERA, CODIGO_CATEGORIAS, ID_CODIGO_POSTAL FROM alojamientos ORDER BY NOMBRE"></asp:SqlDataSource>
</asp:Content>
