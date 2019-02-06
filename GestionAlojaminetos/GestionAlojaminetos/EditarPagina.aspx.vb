Imports MySql.Data.MySqlClient
Public Class EditaPaginaalojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Dim param As String
    Dim Pprov, Pmuni, PcodPos As String
    Private Sub EditaPaginaalojamientos_PreLoad(sender As Object, e As EventArgs) Handles Me.PreLoad
        If Not Page.IsPostBack Then
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
                Dim ds As New DataSet
                da1.Fill(ds)

                Pprov = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(6).ToString)
                Pmuni = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(7).ToString)
                PcodPos = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(8).ToString)

                cargarDDL()

                txt_Firma.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(0).ToString)
                txt_Nombre.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(1).ToString)
                txt_Direccion.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(2).ToString)
                txt_Telefono.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(3).ToString)
                txt_Email.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(4).ToString)
                txt_Web.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(5).ToString)
                cargarProv()
                ddl_CodPostal.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(8).ToString)
                txt_Descripcion.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(9).ToString)
                txt_Descripcion_Eus.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(10).ToString)
                ddl_Cap.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(11).ToString)
                ddl_Tipos.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(12).ToString)
                ddl_Tipos_eus.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(13).ToString)
                ddl_Categorias.SelectedValue = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(14).ToString)
                txt_Coordenadas.Text = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(15).ToString)
                chk_Calidad.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(16).ToString)
                chk_Tienda.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(17).ToString)
                chk_Gastronomico.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(18).ToString)
                chk_Club.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(19).ToString)
                chk_Restaurante.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(20).ToString)
                chk_Autocarvana.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(21).ToString)
                chk_Surfing.Checked = HttpUtility.HtmlDecode(ds.Tables(0).Rows(0).Item(22).ToString)
            Else
                MsgBox("Se produjo algun error al intentar editar el alojamiento.")
                Response.Redirect("verAlojamientos.aspx")
            End If
        End If
    End Sub

    Sub cargarDDL()
        Dim cmd1 = cnn1.CreateCommand()
        Dim cmd2 = cnn1.CreateCommand()
        Dim cmd3 = cnn1.CreateCommand()


        cmd1.CommandText = "SELECT `TIPO` FROM `TIPOS`"
        cmd2.CommandText = "SELECT `TIPO_EUSKERA` FROM `TIPOS_EUSKERA`"
        cmd3.CommandText = "SELECT `CATEGORIA` FROM `CATEGORIAS`"


        Dim dar1 As MySqlDataReader

        dar1 = cmd1.ExecuteReader
        ddl_Tipos.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Tipos.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        dar1 = cmd2.ExecuteReader
        ddl_Tipos_eus.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Tipos_eus.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        dar1 = cmd3.ExecuteReader
        ddl_Categorias.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Categorias.Items.Add(dar1.Item(0))
        End While
        dar1.Close()

        For x As Integer = 1 To 999
            ddl_Cap.Items.Add(x)
        Next
    End Sub

    Sub cargarProv()
        If Not ddl_Provincia.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT `PROVINCUA` FROM `PROVINCIAS`"
            Dim dar1 As MySqlDataReader
            dar1 = cmd1.ExecuteReader
            ddl_Provincia.Items.Add("--Seleccione--")
            While dar1.Read
                ddl_Provincia.Items.Add(dar1.Item(0))
            End While
            dar1.Close()
            ddl_Provincia.SelectedValue = Pprov
            cargarMuni(Pprov)
        Else
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = False
            ddl_Municipio.Enabled = False
        End If
    End Sub

    Private Sub ddl_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Provincia.SelectedIndexChanged
        ddl_CodPostal.Enabled = False
        ddl_Municipio.Enabled = False
        cargarMuni(ddl_Provincia.SelectedValue)
    End Sub

    Sub cargarMuni(prov As String)
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
            ddl_Municipio.SelectedValue = Pmuni
            dar1.Close()

            Dim indMuni As Integer
            cmd3.CommandText = "SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param"
            cmd3.Parameters.AddWithValue("@param", Pmuni)
            dar1 = cmd3.ExecuteReader
            While dar1.Read
                indMuni = dar1.Item(0).ToString()
            End While
            dar1.Close()
            cargarCod(indMuni)
        Else
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Enabled = True
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_Municipio.SelectedIndex = 0
            ddl_Municipio.Enabled = False
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Enabled = True
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.SelectedIndex = 0
            ddl_CodPostal.Enabled = False
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim datos(22) As String
        datos(0) = txt_Firma.Text
        datos(1) = txt_Nombre.Text
        datos(2) = txt_Direccion.Text
        datos(3) = txt_Telefono.Text
        datos(4) = txt_Email.Text
        datos(5) = txt_Web.Text
        datos(6) = ddl_Provincia.Text
        datos(7) = ddl_Municipio.Text
        datos(8) = ddl_CodPostal.Text
        datos(9) = txt_Descripcion.Text
        datos(10) = txt_Descripcion_Eus.Text
        datos(11) = ddl_Cap.Text
        datos(12) = ddl_Tipos.Text
        datos(13) = ddl_Tipos_eus.Text
        datos(14) = ddl_Categorias.Text
        datos(15) = txt_Coordenadas.Text
        datos(16) = If(chk_Calidad.Checked, "1", "0")
        datos(17) = If(chk_Tienda.Checked, "1", "0")
        datos(18) = If(chk_Gastronomico.Checked, "1", "0")
        datos(19) = If(chk_Club.Checked, "1", "0")
        datos(20) = If(chk_Restaurante.Checked, "1", "0")
        datos(21) = If(chk_Autocarvana.Checked, "1", "0")
        datos(22) = If(chk_Surfing.Checked, "1", "0")
        If datos(0).Length = 0 Then
            MsgBox("Por favor rellene el campo Firma.")
        ElseIf datos(1).Length = 0 Then
            MsgBox("Por favor rellene el campo Nombre.")
        ElseIf datos(2).Length = 0 Then
            MsgBox("Por favor rellene el campo Direccion.")
        ElseIf datos(6).Equals("--Seleccione--") Then
            MsgBox("Por favor seleccione una Provincia.")
        ElseIf datos(7).Equals("--Seleccione--") Then
            MsgBox("Por favor seleccione un Municipio.")
        ElseIf datos(8).Equals("--Seleccione--") Then
            MsgBox("Por favor seleccione un Codigo Postal.")
        Else
            prepararUpdate(datos)
        End If
    End Sub

    Private Sub prepararUpdate(ByVal ParamArray datos() As String)
        Try
            'Consigo el id de relacion pasandole los datos que ha seleccionado el usuario
            Dim dar1 As MySqlDataReader
            Dim cmd1 = cnn1.CreateCommand()
            Dim id_rela As String = Nothing
            cmd1.CommandText = "SELECT R.`ID` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` R WHERE R.`CODIGO_PROVINCIA` = (SELECT P.`CODIGO` FROM `PROVINCIAS` P WHERE P.`PROVINCUA` = @prov) AND R.`INDICE_MUNICIPIO` = (SELECT M.`INDICE` FROM `MUNICIPIOS` M WHERE M.`MUNICIPIO` = @muni) AND R.`CODIGO_POSTAL` = @codPos"
            cmd1.Parameters.AddWithValue("@prov", datos(6))
            cmd1.Parameters.AddWithValue("@muni", datos(7))
            cmd1.Parameters.AddWithValue("@codPos", datos(8))
            dar1 = cmd1.ExecuteReader
            While dar1.Read
                id_rela = dar1.Item(0).ToString
            End While
            dar1.Close()

            'Creo los campos de descripciones abreviadas
            Dim desc_abre, desc_abre_eus As String
            If datos(9).Length > 110 Then
                desc_abre = datos(9).Substring(0, 107) & "..."
            ElseIf datos(9).Length < 107 Then
                desc_abre = datos(9) & "..."
            Else
                desc_abre = datos(9)
            End If

            If datos(10).Length > 110 Then
                desc_abre_eus = datos(10).Substring(0, 107) & "..."
            ElseIf datos(10).Length < 107 Then
                desc_abre_eus = datos(10) & "..."
            Else
                desc_abre_eus = datos(10)
            End If

            Dim cmd3 = cnn1.CreateCommand()
            Dim cod_Tipo As String = Nothing
            cmd3.CommandText = "SELECT `CODIGO` FROM `TIPOS` WHERE `TIPO` = @param"
            cmd3.Parameters.AddWithValue("@param", datos(12))
            dar1 = cmd3.ExecuteReader
            While dar1.Read
                cod_Tipo = dar1.Item(0).ToString
            End While
            dar1.Close()

            Dim cmd4 = cnn1.CreateCommand()
            Dim cod_Tipo_eus As String = Nothing
            cmd4.CommandText = "SELECT `CODIGO` FROM `TIPOS_EUSKERA` WHERE `TIPO_EUSKERA` = @param"
            cmd4.Parameters.AddWithValue("@param", datos(13))
            dar1 = cmd4.ExecuteReader
            While dar1.Read
                cod_Tipo_eus = dar1.Item(0).ToString
            End While
            dar1.Close()

            Dim cmd5 = cnn1.CreateCommand()
            Dim cod_Cat As String = Nothing
            cmd5.CommandText = "SELECT `CODIGO` FROM `CATEGORIAS` WHERE `CATEGORIA` = @param"
            cmd5.Parameters.AddWithValue("@param", datos(14))
            dar1 = cmd5.ExecuteReader
            While dar1.Read
                cod_Cat = dar1.Item(0).ToString
            End While
            dar1.Close()

            Dim params(23) As String
            params(0) = datos(0)
            params(1) = datos(1)
            params(2) = desc_abre
            params(3) = desc_abre_eus
            params(4) = datos(9)
            params(5) = datos(10)
            params(6) = datos(3)
            params(7) = datos(2)
            params(8) = datos(16)
            params(9) = datos(4)
            params(10) = datos(5)
            params(11) = datos(19)
            params(12) = datos(20)
            params(13) = datos(21)
            params(14) = datos(17)
            params(15) = datos(11)
            params(16) = datos(18)
            params(17) = datos(22)
            params(18) = datos(15)
            params(19) = cod_Tipo
            params(20) = cod_Tipo_eus
            params(21) = cod_Cat
            params(22) = id_rela
            params(23) = datos(0)

            Dim cmd2 = cnn1.CreateCommand()
            cmd2.CommandText = "UPDATE `ALOJAMIENTOS` SET `FIRMA` = @param0, `NOMBRE` = @param1, `DESCRIPCION_ABREVIADA` = @param2, `DESCRIPCION_ABREVIADA_EUSKERA` = @param3, `DESCRIPCION` = @param4, `DESCRIPCION_EUSKERA` = @param5, `TELEFONO` = @param6, `DIRECCION` = @param7, `CALIDAD_ASEGURADA` = @param8, `EMAIL` = @param9, `WEB` = @param10, `CLUB` = @param11, `RESTAURANTE` = @param12, `AUTOCARAVANA` = @param13, `TIENDA` = @param14, `CAPACIDAD` = @param15, `GASTRONOMICO` = @param16, `SURFING` = @param17, `COORDENADAS` = @param18, `CODIGO_TIPOS` = @param19, `CODIGO_TIPOS_EUSKERA` = @param20, `CODIGO_CATEGORIAS` = @param21, `ID_RELACIONES` = @param22 WHERE `ALOJAMIENTOS`.`FIRMA` = @param23"
            For x As Integer = 0 To params.Length - 1
                cmd2.Parameters.AddWithValue("@param" & x, params(x))
            Next
            Dim res As Integer = cmd2.ExecuteNonQuery()
            If res > 0 Then
                MsgBox("El alojamiento ha sido actualizado.")
                Response.Redirect("VerSeleccion.aspx?" & params(23), False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Protected Sub ddl_Tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Tipos.SelectedIndexChanged
        Dim dar1 As MySqlDataReader
        Dim cmd1 = cnn1.CreateCommand()
        Dim value As String
        Dim cod As String = Nothing
        value = ddl_Tipos.SelectedValue
        cmd1.CommandText = "SELECT `CODIGO` FROM `TIPOS` WHERE `TIPO` = @param"
        cmd1.Parameters.AddWithValue("@param", value)
        dar1 = cmd1.ExecuteReader
        While dar1.Read
            cod = dar1.Item(0).ToString
        End While
        dar1.Close()
        ddl_Tipos_eus.SelectedIndex = (cod + 1)
    End Sub

    Protected Sub ddl_Tipos_eus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Tipos_eus.SelectedIndexChanged
        Dim dar1 As MySqlDataReader
        Dim cmd1 = cnn1.CreateCommand()
        Dim value As String
        Dim cod As String = Nothing
        value = ddl_Tipos_eus.SelectedValue
        cmd1.CommandText = "SELECT `CODIGO` FROM `TIPOS_EUSKERA` WHERE `TIPO_EUSKERA` = @param"
        cmd1.Parameters.AddWithValue("@param", value)
        dar1 = cmd1.ExecuteReader
        While dar1.Read
            cod = dar1.Item(0).ToString
        End While
        dar1.Close()
        ddl_Tipos.SelectedIndex = (cod + 1)
    End Sub

    Protected Sub ddl_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Municipio.SelectedIndexChanged
        If Not ddl_Municipio.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()

            Dim dar1 As MySqlDataReader
            Dim indMuni As Integer
            cmd1.CommandText = "SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param"
            cmd1.Parameters.AddWithValue("@param", ddl_Municipio.SelectedValue)
            dar1 = cmd1.ExecuteReader
            While dar1.Read
                indMuni = dar1.Item(0).ToString()
            End While
            dar1.Close()
            cargarCod(indMuni)
        Else
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Enabled = True
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.SelectedIndex = 0
            ddl_CodPostal.Enabled = False
        End If
    End Sub

    Sub cargarCod(indMuni As String)
        If Not ddl_Municipio.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()
            Dim dar1 As MySqlDataReader
            cmd1.CommandText = "SELECT * FROM `CODIGOS_POSTALES` WHERE `CODIGO_POSTAL` IN (SELECT R.`CODIGO_POSTAL` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` R WHERE `INDICE_MUNICIPIO` IN (@param)) ORDER BY `CODIGO_POSTAL` ASC"
            cmd1.Parameters.AddWithValue("@param", indMuni)
            dar1 = cmd1.ExecuteReader
            ddl_CodPostal.Enabled = True

            ddl_CodPostal.Items.Clear()
            While dar1.Read
                ddl_CodPostal.Items.Add(dar1.Item(0).ToString())
            End While
            dar1.Close()
        Else
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Enabled = True
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.SelectedIndex = 0
            ddl_CodPostal.Enabled = False
        End If
    End Sub
End Class