<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Tipos.aspx.vb" Inherits="GestionAlojaminetos.Tipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CODIGO" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" ReadOnly="True" SortExpression="CODIGO" InsertVisible="False" />
            <asp:BoundField DataField="TIPO" HeaderText="TIPO" SortExpression="TIPO" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:reto_gp2ConnectionString2 %>" DeleteCommand="DELETE FROM `tipos` WHERE `CODIGO` = ?" InsertCommand="INSERT INTO `tipos` (`CODIGO`, `TIPO`) VALUES (?, ?)" ProviderName="<%$ ConnectionStrings:reto_gp2ConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM `TIPOS` ORDER BY `CODIGO`" UpdateCommand="UPDATE `tipos` SET `TIPO` = ? WHERE `CODIGO` = ?">
        <DeleteParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
            <asp:Parameter Name="TIPO" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TIPO" Type="String" />
            <asp:Parameter Name="CODIGO" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
