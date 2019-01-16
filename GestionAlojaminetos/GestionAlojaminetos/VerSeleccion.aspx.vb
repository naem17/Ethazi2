Imports MySql.Data.MySqlClient
Public Class VerSeleccion
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim tabla As String
    Dim param As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim datos() As String = Split(Request.QueryString().ToString(), "+")

        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        Dim cmd1 = cnn1.CreateCommand()
        param = datos(0)
        tabla = datos(1).ToLower()
        Dim sql As String
        sql = "SELECT * FROM " & tabla.ToString
        Select Case tabla
            Case "alojamientos"
                cmd1.CommandText = sql & " WHERE FIRMA = @param"
            Case "categorias"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "codigos_postales"
                cmd1.CommandText = sql & " WHERE ID = @param"
            Case "municipios"
                cmd1.CommandText = sql & " WHERE INDICE = @param"
            Case "provincias"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "tipos"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "tipos_euskera"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case Else
                MsgBox("No se a creado select")
        End Select
        cmd1.Parameters.AddWithValue("@param", param)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
        Me.DetailsView1.DataSource = dt
        Me.DetailsView1.DataBind()
    End Sub

    Private Sub DetailsView1_ModeChanging(sender As Object, e As DetailsViewModeEventArgs) Handles DetailsView1.ModeChanging
        Response.Redirect("EditarPagina" & tabla & ".aspx?" & param)
    End Sub
End Class