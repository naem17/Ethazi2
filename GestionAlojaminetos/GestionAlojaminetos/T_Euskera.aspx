<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="T_Euskera.aspx.vb" Inherits="GestionAlojaminetos.T_Euskera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CODIGO" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="CODIGO" HeaderText="CODIGO" ReadOnly="True" SortExpression="CODIGO" />
            <asp:BoundField DataField="TIPO_EUSKERA" HeaderText="TIPO_EUSKERA" SortExpression="TIPO_EUSKERA" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" DeleteCommand="DELETE FROM `tipos_euskera` WHERE `CODIGO` = ?" InsertCommand="INSERT INTO `tipos_euskera` (`CODIGO`, `TIPO_EUSKERA`) VALUES (?, ?)" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM `tipos_euskera` ORDER BY `CODIGO`" UpdateCommand="UPDATE `tipos_euskera` SET `TIPO_EUSKERA` = ? WHERE `CODIGO` = ?">
        <DeleteParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CODIGO" Type="Decimal" />
            <asp:Parameter Name="TIPO_EUSKERA" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TIPO_EUSKERA" Type="String" />
            <asp:Parameter Name="CODIGO" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
