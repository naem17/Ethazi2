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
        Dim cmd2 = cnn1.CreateCommand()
        Dim cmd3 = cnn1.CreateCommand()
        Dim cmd4 = cnn1.CreateCommand()
        cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`FIRMA` = @param AND A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
        cmd1.Parameters.AddWithValue("@param", param)
        cmd2.CommandText = "SELECT `TIPO` FROM `TIPOS`"
        cmd3.CommandText = "SELECT `TIPO_EUSKERA` FROM `TIPOS_EUSKERA`"
        cmd4.CommandText = "SELECT `CATEGORIA` FROM `CATEGORIAS`"
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
        Me.DetailsView1.DataSource = dt
        Me.DetailsView1.DataBind()
        Me.DetailsView1.Visible = False

        da1.SelectCommand = cmd2
        dt.Clear()
        da1.Fill(dt)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                ddl_Tipos.Items.Add(dt.Rows(i)(0).ToString())
            Next
        End If
        txt_Firma.Text = Me.DetailsView1.Rows(0).Cells(1).Text
        txt_Nombre.Text = Me.DetailsView1.Rows(1).Cells(1).Text
        txt_Direccion.Text = Me.DetailsView1.Rows(2).Cells(1).Text

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class