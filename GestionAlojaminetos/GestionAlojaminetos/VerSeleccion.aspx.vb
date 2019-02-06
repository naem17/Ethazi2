Imports MySql.Data.MySqlClient
Public Class VerSeleccion
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim param As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        param = Session("firma")
        If Not (param.Equals("") Or param = Nothing) Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`FIRMA` = @param AND A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
            cmd1.Parameters.AddWithValue("@param", param)
            Dim da1 As New MySqlDataAdapter
            da1.SelectCommand = cmd1
            Dim dt As New DataTable
            da1.Fill(dt)
            Me.DetailsView1.DataSource = dt
            Me.DetailsView1.DataBind()
        Else
            MsgBox("Se produjo algun error al mostrar los detalles.")
            Response.Redirect("verAlojamientos.aspx")
        End If
    End Sub

    Private Sub DetailsView1_ItemDeleting(sender As Object, e As DetailsViewDeleteEventArgs) Handles DetailsView1.ItemDeleting
        Dim param As String = Me.DetailsView1.Rows(0).Cells(1).Text
        Dim alojamiento As String = Me.DetailsView1.Rows(1).Cells(1).Text
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
            Response.Redirect("Alojamientos.aspx")
        End If
    End Sub

    Private Sub DetailsView1_ModeChanging(sender As Object, e As DetailsViewModeEventArgs) Handles DetailsView1.ModeChanging
        Response.Redirect("EditarPagina.aspx")
    End Sub
End Class