<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="VerSeleccion.aspx.vb" Inherits="GestionAlojaminetos.VerSeleccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cuerpo" runat="server">
    <br />
    <asp:Button ID="Button1" runat="server" Text="Editar" />
    &nbsp;
    &nbsp;
    <asp:Button ID="Button2" runat="server" Text="Eliminar" />
    <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="15%" HorizontalAlign="Left" AutoGenerateEditButton="False" CssClass="Grid">
        <AlternatingRowStyle Width="40%" BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" Width="40%" />
        <EditRowStyle Width="40%" BackColor="#999999" HorizontalAlign="Left" />
        <EmptyDataRowStyle Width="40%" />
        <FieldHeaderStyle Width="40%" BackColor="#E9ECF1" Font-Bold="True" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Width="15%" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Width="15%" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle Width="40%" BackColor="#F7F6F3" ForeColor="#333333" Wrap="False" />
    </asp:DetailsView>
    <br />
    </asp:Content>
