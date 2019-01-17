Imports MySql.Data.MySqlClient
Public Class EditaPaginaalojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim param As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        param = Request.QueryString().ToString()

        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        Dim cmd1 = cnn1.CreateCommand()
        cmd1.CommandText = "SELECT `FIRMA`, `NOMBRE`, `DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, `DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, `DESCRIPCION`, `DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, `EMAIL`, `WEB`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA`, `TIENDA`, `CAPACIDAD`, `GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGOS TIPOS`, `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, `ID_RELACIONES` AS `ID RELACIONES` FROM `alojamientos` WHERE `FIRMA` = @param"
        cmd1.Parameters.AddWithValue("@param", param)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class