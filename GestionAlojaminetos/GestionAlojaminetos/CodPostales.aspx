<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="CodPostales.aspx.vb" Inherits="GestionAlojaminetos.CodPostales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:labetxeConnectionString %>" DeleteCommand="DELETE FROM `codigos_postales` WHERE `ID` = ?" InsertCommand="INSERT INTO `codigos_postales` (`ID`, `CODIGO_POSTAL`) VALUES (?, ?)" ProviderName="<%$ ConnectionStrings:labetxeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM `codigos_postales` ORDER BY `ID`" UpdateCommand="UPDATE `codigos_postales` SET `CODIGO_POSTAL` = ? WHERE `ID` = ?">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ID" Type="Decimal" />
            <asp:Parameter Name="CODIGO_POSTAL" Type="Decimal" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CODIGO_POSTAL" Type="Decimal" />
            <asp:Parameter Name="ID" Type="Decimal" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
