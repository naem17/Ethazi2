Imports MySql.Data.MySqlClient
Public Class VerSeleccion
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim param As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        param = Request.QueryString().ToString()

        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        Dim cmd1 = cnn1.CreateCommand()
        cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, A.`DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`FIRMA` = @param AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE`"
        cmd1.Parameters.AddWithValue("@param", param)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
        Me.DetailsView1.DataSource = dt
        Me.DetailsView1.DataBind()
    End Sub

    Private Sub DetailsView1_ModeChanging(sender As Object, e As DetailsViewModeEventArgs) Handles DetailsView1.ModeChanging
        Response.Redirect("EditarPagina.aspx?" & param)
    End Sub
End Class