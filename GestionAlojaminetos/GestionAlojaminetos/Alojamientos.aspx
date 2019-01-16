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
            <asp:BoundField DataField="DESCRIPCION ABREVIADA" HeaderText="DESCRIPCION ABREVIADA" SortExpression="DESCRIPCION ABREVIADA" ReadOnly="True" />
            <asp:BoundField DataField="TIENDA" HeaderText="TIENDA" SortExpression="TIENDA" />
            <asp:BoundField DataField="ID RELACIONES" HeaderText="ID RELACIONES" SortExpression="ID RELACIONES" />
            <asp:BoundField DataField="CAPACIDAD" HeaderText="CAPACIDAD" SortExpression="CAPACIDAD" />
            <asp:BoundField DataField="GASTRONOMICO" HeaderText="GASTRONOMICO" SortExpression="GASTRONOMICO" />
            <asp:BoundField DataField="SURFING" HeaderText="SURFING" SortExpression="SURFING" />
            <asp:BoundField DataField="COORDENADAS" HeaderText="COORDENADAS" SortExpression="COORDENADAS" />
            <asp:BoundField DataField="CODIGO TIPOS" HeaderText="CODIGO TIPOS" SortExpression="CODIGO TIPOS" />
            <asp:BoundField DataField="CODIGOS TIPOS EUSKERA" HeaderText="CODIGOS TIPOS EUSKERA" SortExpression="CODIGOS TIPOS EUSKERA" />
            <asp:BoundField DataField="CODIGO CATEGORIAS" HeaderText="CODIGO CATEGORIAS" SortExpression="CODIGO CATEGORIAS" />
            <asp:BoundField DataField="DESCRIPCION ABREVIADA EUSKERA" HeaderText="DESCRIPCION ABREVIADA EUSKERA" SortExpression="DESCRIPCION ABREVIADA EUSKERA" ReadOnly="True" />
            <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" SortExpression="DESCRIPCION" ReadOnly="True" />
            <asp:BoundField DataField="DESCRIPCION EUSKERA" HeaderText="DESCRIPCION EUSKERA" SortExpression="DESCRIPCION EUSKERA" ReadOnly="True" />
            <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
            <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" SortExpression="DIRECCION" />
            <asp:BoundField DataField="CALIDAD ASEGURADA" HeaderText="CALIDAD ASEGURADA" SortExpression="CALIDAD ASEGURADA" />
            <asp:BoundField DataField="..." HeaderText="..." SortExpression="..." ReadOnly="True" />
            <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
            <asp:BoundField DataField="CLUB" HeaderText="CLUB" SortExpression="CLUB" />
            <asp:BoundField DataField="RESTAURANTE" HeaderText="RESTAURANTE" SortExpression="RESTAURANTE" />
            <asp:BoundField DataField="AUTOCARAVANA" HeaderText="AUTOCARAVANA" SortExpression="AUTOCARAVANA" />
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT `FIRMA`, `NOMBRE`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, `TIENDA`,`ID_RELACIONES` AS `ID RELACIONES`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGO TIPOS`, `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA_EUSKERA, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(DESCRIPCION, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(DESCRIPCION_EUSKERA, 1, 50),'...') AS `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, '...', `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA` FROM `alojamientos` ORDER BY `NOMBRE`" DeleteCommand="DELETE FROM `alojamientos` WHERE `FIRMA` = ?" InsertCommand="INSERT INTO `alojamientos` (`FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA`, `TIENDA`, `ID_RELACIONES`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS`, `CODIGO_TIPOS_EUSKERA`, `CODIGO_CATEGORIAS`, `DESCRIPCION_ABREVIADA_EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA`, `WEB`, `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" UpdateCommand="UPDATE `alojamientos` SET `NOMBRE` = ?, `DESCRIPCION_ABREVIADA` = ?, `TIENDA` = ?, `ID_RELACIONES` = ?, `CAPACIDAD` = ?, `GASTRONOMICO` = ?, `SURFING` = ?, `COORDENADAS` = ?, `CODIGO_TIPOS` = ?, `CODIGO_TIPOS_EUSKERA` = ?, `CODIGO_CATEGORIAS` = ?, `DESCRIPCION_ABREVIADA_EUSKERA` = ?, `DESCRIPCION` = ?, `DESCRIPCION_EUSKERA` = ?, `TELEFONO` = ?, `DIRECCION` = ?, `CALIDAD_ASEGURADA` = ?, `WEB` = ?, `EMAIL` = ?, `CLUB` = ?, `RESTAURANTE` = ?, `AUTOCARAVANA` = ? WHERE `FIRMA` = ?">
    <DeleteParameters>
        <asp:Parameter Name="FIRMA" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="FIRMA" Type="String" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA" Type="String" />
        <asp:Parameter Name="TIENDA" Type="Int16" />
        <asp:Parameter Name="ID_RELACIONES" Type="Decimal" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="GASTRONOMICO" Type="Int16" />
        <asp:Parameter Name="SURFING" Type="Int16" />
        <asp:Parameter Name="COORDENADAS" Type="String" />
        <asp:Parameter Name="CODIGO_TIPOS" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS_EUSKERA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_CATEGORIAS" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA_EUSKERA" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="DESCRIPCION_EUSKERA" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CALIDAD_ASEGURADA" Type="Int16" />
        <asp:Parameter Name="WEB" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLUB" Type="Int16" />
        <asp:Parameter Name="RESTAURANTE" Type="Int16" />
        <asp:Parameter Name="AUTOCARAVANA" Type="Int16" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA" Type="String" />
        <asp:Parameter Name="TIENDA" Type="Int16" />
        <asp:Parameter Name="ID_RELACIONES" Type="Decimal" />
        <asp:Parameter Name="CAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="GASTRONOMICO" Type="Int16" />
        <asp:Parameter Name="SURFING" Type="Int16" />
        <asp:Parameter Name="COORDENADAS" Type="String" />
        <asp:Parameter Name="CODIGO_TIPOS" Type="Decimal" />
        <asp:Parameter Name="CODIGO_TIPOS_EUSKERA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_CATEGORIAS" Type="Decimal" />
        <asp:Parameter Name="DESCRIPCION_ABREVIADA_EUSKERA" Type="String" />
        <asp:Parameter Name="DESCRIPCION" Type="String" />
        <asp:Parameter Name="DESCRIPCION_EUSKERA" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CALIDAD_ASEGURADA" Type="Int16" />
        <asp:Parameter Name="WEB" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CLUB" Type="Int16" />
        <asp:Parameter Name="RESTAURANTE" Type="Int16" />
        <asp:Parameter Name="AUTOCARAVANA" Type="Int16" />
        <asp:Parameter Name="FIRMA" Type="String" />
    </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
