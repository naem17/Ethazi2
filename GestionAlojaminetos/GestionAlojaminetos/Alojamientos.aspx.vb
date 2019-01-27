Imports MySql.Data.MySqlClient
Public Class Alojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Try
        '    If cnn1.State = ConnectionState.Closed Then
        '        cnn1.Open()
        '    End If
        '    Dim cmd1 As New MySqlCommand
        '    Dim sql As String = "SELECT * FROM alojamientos"
        '    'Dim sql As String = "SELECT `FIRMA`, `NOMBRE`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA, 1, 50),'...')" & _
        '    '" AS `DESCRIPCION ABREVIADA`, `TIENDA`,`ID_RELACIONES` AS `ID RELACIONES`, `CAPACIDAD`, " & _
        '    '"`GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGO TIPOS`," & _
        '    '" `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`," & _
        '    '" CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA_EUSKERA, 1, 50),'...') AS" & _
        '    '" `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(DESCRIPCION, 1, 50),'...')" & _
        '    '" AS `DESCRIPCION`, CONCAT(SUBSTRING(DESCRIPCION_EUSKERA, 1, 50),'...') AS" & _
        '    '" `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`," & _
        '    '" `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA` FROM `alojamientos` ORDER BY `NOMBRE`"

        '    'cmd1.CommandText = "SELECT `FIRMA`, `NOMBRE`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA, 1, 50),'...')" +
        '    '    " AS `DESCRIPCION ABREVIADA`, `TIENDA`,`ID_RELACIONES` AS `ID RELACIONES`, `CAPACIDAD`, " +
        '    '    "`GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGO TIPOS`," +
        '    '    " `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`," +
        '    '    " CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA_EUSKERA, 1, 50),'...') AS" +
        '    '    " `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(DESCRIPCION, 1, 50),'...')" +
        '    '    " AS `DESCRIPCION`, CONCAT(SUBSTRING(DESCRIPCION_EUSKERA, 1, 50),'...') AS" +
        '    '    " `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`," +
        '    '    " `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA` FROM `alojamientos` ORDER BY `NOMBRE`"
        '    cmd1 = New MySqlCommand(sql, cnn1)
        '    Dim da1 As New MySqlDataAdapter(cmd1)
        '    'da1.SelectCommand = cmd1
        '    Dim ds As New DataSet
        '    ds.Clear()
        '    da1.Fill(ds, "ALOJAMIENTOS")
        '    Me.GridView1.DataSource = ds.Tables("ALOJAMIENTOS")
        '    Me.GridView1.DataBind()
        '    'Me.GridView1.AllowPaging = True
        '    'Me.GridView1.AllowSorting = True
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString & ex.ToString)
        'End Try
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("firma") = Me.GridView1.SelectedRow.Cells(1).Text
        Response.Redirect("VerSeleccion.aspx")
    End Sub

    Private Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Dim param As String = Me.GridView1.Rows(e.RowIndex).Cells(1).Text
        Dim alojamiento As String = Me.GridView1.Rows(e.RowIndex).Cells(2).Text
        If MsgBox("Quieres eliminar el alojamiento " & alojamiento & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cmd1 As MySqlCommand = cnn1.CreateCommand
            cmd1.CommandText = "DELETE FROM `ALOJAMIENTOS` WHERE `ALOJAMIENTOS`.`FIRMA` = @param"
            cmd1.Parameters.AddWithValue("@param", param)
            Dim dar1 As MySqlDataReader
            dar1 = cmd1.ExecuteReader()
            While dar1.Read
                MsgBox("Alojamiento " & alojamiento & " eliminado.")
            End While
            dar1.Close()
        End If
    End Sub
    Private Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        Response.Redirect("EditarPagina.aspx?" & Me.GridView1.Rows(e.NewEditIndex).Cells(1).Text)
    End Sub
End Class