Imports MySql.Data.MySqlClient
Public Class EditaPaginaalojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim param As String
    Private Sub EditaPaginaalojamientos_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        If Not Page.IsPostBack Then
            param = Request.QueryString().ToString()

            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`FIRMA` = @param AND A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
            cmd1.Parameters.AddWithValue("@param", param)
            Dim da1 As New MySqlDataAdapter
            da1.SelectCommand = cmd1
            Dim ds As New DataSet
            da1.Fill(ds)
            Me.DetailsView1.DataSource = ds
            Me.DetailsView1.DataBind()
            Me.DetailsView1.Visible = True

            cargarDDL()

            txt_Firma.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(0).ToString)
            txt_Nombre.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(1).ToString)
            txt_Direccion.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(2).ToString)
            txt_Telefono.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(3).ToString)
            txt_Email.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(4).ToString)
            txt_Web.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(5).ToString)
            ddl_Provincia.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(6).ToString)
            ddl_Municipio.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(7).ToString)
            ddl_CodPostal.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(8).ToString)
            txt_Descripcion.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(9).ToString)
            txt_Descripcion_Eus.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(10).ToString)
            txt_Capacidad.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(11).ToString)
            ddl_Tipos.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(12).ToString)
            ddl_Tipos_eus.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(13).ToString)
            ddl_Categorias.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(14).ToString)
            txt_Coordenadas.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(15).ToString)

        End If
    End Sub

    Sub cargarDDL()
        Dim cmd2 = cnn1.CreateCommand()
        Dim cmd3 = cnn1.CreateCommand()
        Dim cmd4 = cnn1.CreateCommand()
        Dim cmd5 = cnn1.CreateCommand()

        cmd2.CommandText = "SELECT `TIPO` FROM `TIPOS`"
        cmd3.CommandText = "SELECT `TIPO_EUSKERA` FROM `TIPOS_EUSKERA`"
        cmd4.CommandText = "SELECT `CATEGORIA` FROM `CATEGORIAS`"
        cmd5.CommandText = "SELECT `PROVINCUA` FROM `PROVINCIAS`"

        Dim dar1 As MySqlDataReader

        dar1 = cmd2.ExecuteReader
        ddl_Tipos.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Tipos.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        dar1 = cmd3.ExecuteReader
        ddl_Tipos_eus.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Tipos_eus.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        dar1 = cmd4.ExecuteReader
        ddl_Categorias.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Categorias.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        dar1 = cmd5.ExecuteReader
        ddl_Provincia.Items.Add("--Seleccione--")
        ddl_Municipio.Items.Add("--Seleccione--")
        ddl_CodPostal.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Provincia.Items.Add(dar1.Item(0))
        End While
        dar1.Close()
    End Sub

    Private Sub ddl_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Provincia.SelectedIndexChanged
        cargarDemas(ddl_Provincia.SelectedValue.ToString())
    End Sub

    Sub cargarDemas(prov As String)
        If Not prov = "--Seleccione--" Then
            Dim dar1 As MySqlDataReader
            Dim codProv As String = Nothing
            Dim cmd1 = cnn1.CreateCommand()
            Dim cmd2 = cnn1.CreateCommand()
            Dim cmd3 = cnn1.CreateCommand()
            Dim sql As String
            sql = "SELECT `CODIGO` FROM `PROVINCIAS` WHERE"
            cmd1.CommandText = sql & " `PROVINCUA` LIKE @param"
            cmd1.Parameters.AddWithValue("@param", prov)
            dar1 = cmd1.ExecuteReader
            While dar1.Read
                codProv = dar1.Item(0).ToString()
            End While
            dar1.Close()

            sql = "SELECT `MUNICIPIO` FROM `MUNICIPIOS` WHERE `INDICE` IN (SELECT `INDICE_MUNICIPIO` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` WHERE"
            cmd2.CommandText = sql & " `CODIGO_PROVINCIA` = @param) ORDER BY `MUNICIPIO` ASC"
            cmd2.Parameters.AddWithValue("@param", codProv)
            dar1 = cmd2.ExecuteReader
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_Municipio.Enabled = True
            While dar1.Read
                ddl_Municipio.Items.Add(dar1.Item(0))
            End While
            dar1.Close()
        Else
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = False
            ddl_Municipio.Enabled = False
        End If

    End Sub

    Protected Sub ddl_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Municipio.SelectedIndexChanged
        If Not ddl_Municipio.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()
            Dim cmd2 = cnn1.CreateCommand()
            Dim dar1 As MySqlDataReader
            Dim indMuni As Integer
            cmd1.CommandText = "SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param"
            cmd1.Parameters.AddWithValue("@param", ddl_Municipio.SelectedValue)
            dar1 = cmd1.ExecuteReader
            While dar1.Read
                indMuni = dar1.Item(0).ToString()
            End While
            dar1.Close()

            cmd2.CommandText = "SELECT * FROM `CODIGOS_POSTALES` WHERE `CODIGO_POSTAL` IN (SELECT R.`CODIGO_POSTAL` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` R WHERE `INDICE_MUNICIPIO` IN (@param)) ORDER BY `CODIGO_POSTAL` ASC"
            cmd2.Parameters.AddWithValue("@param", indMuni)
            dar1 = cmd2.ExecuteReader
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = True
            While dar1.Read
                ddl_CodPostal.Items.Add(dar1.Item(0).ToString())
            End While
            dar1.Close()
        Else
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = False
        End If
    End Sub
End Class