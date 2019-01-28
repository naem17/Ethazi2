<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="verAlojamientos.aspx.vb" Inherits="GestionAlojaminetos.verAlojamientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <br />
    <asp:Button ID="btn_New" runat="server" BackColor="#006D9C" BorderColor="#006D9C" BorderStyle="Solid" Font-Bold="True" ForeColor="White" Text="Nuevo Alojamiento" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="True" Width="100%" />
    <br />
    <asp:Label ID="lbl_Num" runat="server" Text="NoRows" BackColor="#006D9C" Font-Bold="True" Font-Overline="True" Font-Size="Medium" Font-Underline="True" ForeColor="White" Width="100%"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField SelectText="Detalles" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#006D9C" Font-Bold="True" ForeColor="White" />
        <PagerSettings Mode="NumericFirstLast" PageButtonCount="15" Position="TopAndBottom" />
        <PagerStyle BackColor="#006D9C" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    </asp:Content>
