<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Municipios.aspx.vb" Inherits="GestionAlojaminetos.Municipios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="INDICE" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" SortExpression="CODIGO" />
            <asp:BoundField DataField="MUNICIPIO" HeaderText="MUNICIPIO" SortExpression="MUNICIPIO" />
            <asp:BoundField DataField="INDICE" HeaderText="INDICE" ReadOnly="True" SortExpression="INDICE" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" DeleteCommand="DELETE FROM `municipios` WHERE `INDICE` = ?" InsertCommand="INSERT INTO `municipios` (`CODIGO`, `MUNICIPIO`, `INDICE`) VALUES (?, ?, ?)" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM `municipios` ORDER BY `CODIGO`" UpdateCommand="UPDATE `municipios` SET `CODIGO` = ?, `MUNICIPIO` = ? WHERE `INDICE` = ?">
        <DeleteParameters>
            <asp:Parameter Name="INDICE" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
            <asp:Parameter Name="MUNICIPIO" Type="String" />
            <asp:Parameter Name="INDICE" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
            <asp:Parameter Name="MUNICIPIO" Type="String" />
            <asp:Parameter Name="INDICE" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
