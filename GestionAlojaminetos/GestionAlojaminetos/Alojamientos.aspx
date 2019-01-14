<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Alojamientos.aspx.vb" Inherits="GestionAlojaminetos.Alojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="FIRMA" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="FIRMA" HeaderText="FIRMA" ReadOnly="True" SortExpression="FIRMA" />
            <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            <asp:BoundField DataField="DESCRIPCION_ABREVIADA" HeaderText="DESCRIPCION ABREVIADA" SortExpression="DESCRIPCION_ABREVIADA" />
            <asp:BoundField DataField="DESCRIPCION_ABREVIADA_EUSKERA" HeaderText="DESCRIPCION ABREVIADA EUSKERA" SortExpression="DESCRIPCION_ABREVIADA_EUSKERA" />
            <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" SortExpression="DESCRIPCION" />
            <asp:BoundField DataField="DESCRIPCION_EUSKERA" HeaderText="DESCRIPCION EUSKERA" SortExpression="DESCRIPCION_EUSKERA" />
            <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
            <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" SortExpression="DIRECCION" />
            <asp:BoundField DataField="CALIDAD_ASEGURADA" HeaderText="CALIDAD ASEGURADA" SortExpression="CALIDAD_ASEGURADA" />
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
            <asp:BoundField DataField="CODIGO_MUNICIPIO" HeaderText="CODIGO MUNICIPIO" SortExpression="CODIGO_MUNICIPIO" />
            <asp:BoundField DataField="CODIGO_PROVINCIA" HeaderText="CODIGO PROVINCIA" SortExpression="CODIGO_PROVINCIA" />
            <asp:BoundField DataField="CODIGO_TIPOS" HeaderText="CODIGO TIPOS" SortExpression="CODIGO_TIPOS" />
            <asp:BoundField DataField="CODIGO_TIPOS_EUSKERA" HeaderText="CODIGO TIPOS EUSKERA" SortExpression="CODIGO_TIPOS_EUSKERA" />
            <asp:BoundField DataField="CODIGO_CATEGORIAS" HeaderText="CODIGO CATEGORIAS" SortExpression="CODIGO_CATEGORIAS" />
            <asp:BoundField DataField="ID_CODIGO_POSTAL" HeaderText="ID CODIGO POSTAL" SortExpression="ID_CODIGO_POSTAL" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT FIRMA, NOMBRE, DESCRIPCION_ABREVIADA, DESCRIPCION_ABREVIADA_EUSKERA, DESCRIPCION, DESCRIPCION_EUSKERA, TELEFONO, DIRECCION, CALIDAD_ASEGURADA, EMAIL, WEB, CLUB, RESTAURANTE, AUTOCARAVANA, TIENDA, CAPACIDAD, GASTRONOMICO, SURFING, COORDENADAS, CODIGO_MUNICIPIO, CODIGO_PROVINCIA, CODIGO_TIPOS, CODIGO_TIPOS_EUSKERA, CODIGO_CATEGORIAS, ID_CODIGO_POSTAL FROM alojamientos ORDER BY NOMBRE" DeleteCommand="DELETE FROM 'alojamientos' WHERE 'FIRMA' = ?" InsertCommand="INSERT INTO 'alojamientos' ('FIRMA', 'NOMBRE', 'DESCRIPCION_ABREVIADA', 'DESCRIPCION_ABREVIADA_EUSKERA', 'DESCRIPCION', 'DESCRIPCION_EUSKERA', 'TELEFONO', 'DIRECCION', 'CALIDAD_ASEGURADA', 'EMAIL', 'WEB', 'CLUB', 'RESTAURANTE', 'AUTOCARAVANA', 'TIENDA', 'CAPACIDAD', 'GASTRONOMICO', 'SURFING', 'COORDENADAS', 'CODIGO_MUNICIPIO', 'CODIGO_PROVINCIA', 'CODIGO_TIPOS', 'CODIGO_TIPOS_EUSKERA', 'CODIGO_CATEGORIAS', 'ID_CODIGO_POSTAL') VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" UpdateCommand="UPDATE 'alojamientos' SET 'NOMBRE' = ?, 'DESCRIPCION_ABREVIADA' = ?, 'DESCRIPCION_ABREVIADA_EUSKERA' = ?, 'DESCRIPCION' = ?, 'DESCRIPCION_EUSKERA' = ?, 'TELEFONO' = ?, 'DIRECCION' = ?, 'CALIDAD_ASEGURADA' = ?, 'EMAIL' = ?, 'WEB' = ?, 'CLUB' = ?, 'RESTAURANTE' = ?, 'AUTOCARAVANA' = ?, 'TIENDA' = ?, 'CAPACIDAD' = ?, 'GASTRONOMICO' = ?, 'SURFING' = ?, 'COORDENADAS' = ?, 'CODIGO_MUNICIPIO' = ?, 'CODIGO_PROVINCIA' = ?, 'CODIGO_TIPOS' = ?, 'CODIGO_TIPOS_EUSKERA' = ?, 'CODIGO_CATEGORIAS' = ?, 'ID_CODIGO_POSTAL' = ? WHERE 'FIRMA' = ?">
    <DeleteParameters>
        <asp:Parameter Name="FIRMA" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="FIRMA" Type="String" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA_EUSKERA" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="DESCRIPCION_EUSKERA" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CALIDAD_ASEGURADA" Type="Int16" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="WEB" Type="String" />
        <asp:Parameter Name="CLUB" Type="Int16" />
        <asp:Parameter Name="RESTAURANTE" Type="Int16" />
        <asp:Parameter Name="AUTOCARAVANA" Type="Int16" />
        <asp:Parameter Name="TIENDA" Type="Int16" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="GASTRONOMICO" Type="Int16" />
        <asp:Parameter Name="SURFING" Type="Int16" />
        <asp:Parameter Name="COORDENADAS" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_PROVINCIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS_EUSKERA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_CATEGORIAS" Type="Decimal" />
        <asp:Parameter Name="ID_CODIGO_POSTAL" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA_EUSKERA" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="DESCRIPCION_EUSKERA" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CALIDAD_ASEGURADA" Type="Int16" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="WEB" Type="String" />
        <asp:Parameter Name="CLUB" Type="Int16" />
        <asp:Parameter Name="RESTAURANTE" Type="Int16" />
        <asp:Parameter Name="AUTOCARAVANA" Type="Int16" />
        <asp:Parameter Name="TIENDA" Type="Int16" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="GASTRONOMICO" Type="Int16" />
        <asp:Parameter Name="SURFING" Type="Int16" />
        <asp:Parameter Name="COORDENADAS" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_PROVINCIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS_EUSKERA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_CATEGORIAS" Type="Decimal" />
        <asp:Parameter Name="ID_CODIGO_POSTAL" Type="Decimal" />
        <asp:Parameter Name="FIRMA" Type="String" />
    </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
