<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Alojamientos.aspx.vb" Inherits="GestionAlojaminetos.Alojamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="FIRMA" HeaderText="FIRMA" SortExpression="FIRMA" />
            <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            <asp:BoundField DataField="DESCRIPCION ABREVIADA" HeaderText="DESCRIPCION ABREVIADA" ReadOnly="True" SortExpression="DESCRIPCION ABREVIADA" />
            <asp:BoundField DataField="TIENDA" HeaderText="TIENDA" SortExpression="TIENDA" />
            <asp:BoundField DataField="CAPACIDAD" HeaderText="CAPACIDAD" SortExpression="CAPACIDAD" />
            <asp:BoundField DataField="GASTRONOMICO" HeaderText="GASTRONOMICO" SortExpression="GASTRONOMICO" />
            <asp:BoundField DataField="SURFING" HeaderText="SURFING" SortExpression="SURFING" />
            <asp:BoundField DataField="COORDENADAS" HeaderText="COORDENADAS" SortExpression="COORDENADAS" />
            <asp:BoundField DataField="CODIGO TIPOS" HeaderText="CODIGO TIPOS" SortExpression="CODIGO TIPOS" />
            <asp:BoundField DataField="CODIGOS TIPOS EUSKERA" HeaderText="CODIGOS TIPOS EUSKERA" SortExpression="CODIGOS TIPOS EUSKERA" />
            <asp:BoundField DataField="CATEGORIA" HeaderText="CATEGORIA" SortExpression="CATEGORIA" />
            <asp:BoundField DataField="TIPO" HeaderText="TIPO" SortExpression="TIPO" />
            <asp:BoundField DataField="TIPO EUSKERA" HeaderText="TIPO EUSKERA" SortExpression="TIPO EUSKERA" />
            <asp:BoundField DataField="DESCRIPCION ABREVIADA EUSKERA" HeaderText="DESCRIPCION ABREVIADA EUSKERA" ReadOnly="True" SortExpression="DESCRIPCION ABREVIADA EUSKERA" />
            <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" ReadOnly="True" SortExpression="DESCRIPCION" />
            <asp:BoundField DataField="DESCRIPCION EUSKERA" HeaderText="DESCRIPCION EUSKERA" ReadOnly="True" SortExpression="DESCRIPCION EUSKERA" />
            <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" SortExpression="TELEFONO" />
            <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" SortExpression="DIRECCION" />
            <asp:BoundField DataField="CALIDAD ASEGURADA" HeaderText="CALIDAD ASEGURADA" SortExpression="CALIDAD ASEGURADA" />
            <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
            <asp:BoundField DataField="CLUB" HeaderText="CLUB" SortExpression="CLUB" />
            <asp:BoundField DataField="RESTAURANTE" HeaderText="RESTAURANTE" SortExpression="RESTAURANTE" />
            <asp:BoundField DataField="AUTOCARAVANA" HeaderText="AUTOCARAVANA" SortExpression="AUTOCARAVANA" />
            <asp:BoundField DataField="MUNICIPIO" HeaderText="MUNICIPIO" SortExpression="MUNICIPIO" />
            <asp:BoundField DataField="PROVINCIA" HeaderText="PROVINCIA" SortExpression="PROVINCIA" />
            <asp:BoundField DataField="CODIGO_POSTAL" HeaderText="CODIGO_POSTAL" SortExpression="CODIGO_POSTAL" />
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
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT A.`FIRMA`, A.`NOMBRE`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, K.`CATEGORIA`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA_EUSKERA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`" DeleteCommand="DELETE FROM `alojamientos` WHERE `FIRMA` = ?" InsertCommand="INSERT INTO `alojamientos` (`FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA`, `TIENDA`, `ID_RELACIONES`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS`, `CODIGO_TIPOS_EUSKERA`, `CODIGO_CATEGORIAS`, `DESCRIPCION_ABREVIADA_EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA`, `WEB`, `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)" UpdateCommand="UPDATE `alojamientos` SET `NOMBRE` = ?, `DESCRIPCION_ABREVIADA` = ?, `TIENDA` = ?, `ID_RELACIONES` = ?, `CAPACIDAD` = ?, `GASTRONOMICO` = ?, `SURFING` = ?, `COORDENADAS` = ?, `CODIGO_TIPOS` = ?, `CODIGO_TIPOS_EUSKERA` = ?, `CODIGO_CATEGORIAS` = ?, `DESCRIPCION_ABREVIADA_EUSKERA` = ?, `DESCRIPCION` = ?, `DESCRIPCION_EUSKERA` = ?, `TELEFONO` = ?, `DIRECCION` = ?, `CALIDAD_ASEGURADA` = ?, `WEB` = ?, `EMAIL` = ?, `CLUB` = ?, `RESTAURANTE` = ?, `AUTOCARAVANA` = ? WHERE `FIRMA` = ?">
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
