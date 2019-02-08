Imports MySql.Data.MySqlClient
Public Class consultaAlojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            cargarDll()
            cargarProv()
        End If
    End Sub

    Sub cargarDll()
        Dim cmd1 = cnn1.CreateCommand()
        cmd1.CommandText = "SELECT `TIPO` FROM `TIPOS`"
        Dim dar1 As MySqlDataReader
        dar1 = cmd1.ExecuteReader

        ddl_Tipo.Items.Add("--Seleccione--")
        While dar1.Read
            ddl_Tipo.Items.Add(dar1.Item(0))
        End While
        dar1.Close()
        ddl_Tipo.SelectedIndex = 0

        ddl_Capa.Items.Add("--Seleccione--")
        For x As Integer = 0 To 999
            ddl_Capa.Items.Add(x)
        Next
        ddl_Capa.SelectedIndex = 0
    End Sub

    Sub cargarProv()
        If Not ddl_Prov.SelectedValue = "--Seleccione--" Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT `PROVINCUA` FROM `PROVINCIAS`"
            Dim dar1 As MySqlDataReader
            dar1 = cmd1.ExecuteReader
            ddl_Prov.Items.Add("--Seleccione--")
            While dar1.Read
                ddl_Prov.Items.Add(dar1.Item(0))
            End While
            dar1.Close()

            ddl_Muni.Items.Clear()
            ddl_Muni.Items.Add("--Seleccione--")
            ddl_Cod.Items.Clear()
            ddl_Cod.Items.Add("--Seleccione--")
            ddl_Cod.Enabled = False
            ddl_Muni.Enabled = False
        Else
            ddl_Muni.Items.Clear()
            ddl_Muni.Items.Add("--Seleccione--")
            ddl_Cod.Items.Clear()
            ddl_Cod.Items.Add("--Seleccione--")
            ddl_Cod.Enabled = False
            ddl_Muni.Enabled = False
        End If
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
            ddl_Muni.Items.Clear()
            ddl_Muni.Items.Add("--Seleccione--")
            ddl_Muni.Enabled = True
            While dar1.Read
                ddl_Muni.Items.Add(dar1.Item(0))
            End While
            dar1.Close()
        Else
            ddl_Muni.Items.Clear()
            ddl_Muni.Enabled = True
            ddl_Muni.Items.Add("--Seleccione--")
            ddl_Muni.SelectedIndex = 0
            ddl_Muni.Enabled = False
            ddl_Cod.Items.Clear()
            ddl_Cod.Enabled = True
            ddl_Cod.Items.Add("--Seleccione--")
            ddl_Cod.SelectedIndex = 0
            ddl_Cod.Enabled = False
        End If
    End Sub
    Protected Sub ddl_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Muni.SelectedIndexChanged
        If Not ddl_Muni.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()
            Dim dar1 As MySqlDataReader
            Dim indMuni As Integer
            cmd1.CommandText = "SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param AND `INDICE` BETWEEN 1 AND 255"
            cmd1.Parameters.AddWithValue("@param", ddl_Muni.SelectedValue)
            dar1 = cmd1.ExecuteReader
            While dar1.Read
                indMuni = dar1.Item(0).ToString()
            End While
            dar1.Close()
            cargarCod(indMuni)
        Else
            ddl_Cod.Items.Clear()
            ddl_Cod.Enabled = True
            ddl_Cod.Items.Add("--Seleccione--")
            ddl_Cod.SelectedIndex = 0
            ddl_Cod.Enabled = False
        End If
    End Sub

    Sub cargarCod(indMuni As String)
        If Not ddl_Muni.SelectedValue = "--Seleccione--" Then
            Dim cmd1 = cnn1.CreateCommand()
            Dim dar1 As MySqlDataReader
            cmd1.CommandText = "SELECT * FROM `CODIGOS_POSTALES` WHERE `CODIGO_POSTAL` IN (SELECT R.`CODIGO_POSTAL` FROM `RELACION_CP_MUNICIPIOS_PROVINCIAS` R WHERE `INDICE_MUNICIPIO` IN (@param)) ORDER BY `CODIGO_POSTAL` ASC"
            cmd1.Parameters.AddWithValue("@param", indMuni)
            dar1 = cmd1.ExecuteReader
            ddl_Cod.Enabled = True

            ddl_Cod.Items.Clear()
            While dar1.Read
                ddl_Cod.Items.Add(dar1.Item(0).ToString())
            End While
            dar1.Close()
        Else
            ddl_Cod.Items.Clear()
            ddl_Cod.Enabled = True
            ddl_Cod.Items.Add("--Seleccione--")
            ddl_Cod.SelectedIndex = 0
            ddl_Cod.Enabled = False
        End If
    End Sub

    Protected Sub ddl_Prov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Prov.SelectedIndexChanged
        ddl_Cod.Enabled = False
        ddl_Muni.Enabled = False
        cargarMuni(ddl_Prov.SelectedValue)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datos(12) As String
        datos(0) = If(txt_Nombre.Text.Equals(""), "NULL", txt_Nombre.Text)
        datos(1) = ddl_Prov.SelectedValue
        datos(2) = ddl_Muni.SelectedValue
        datos(3) = ddl_Cod.SelectedValue
        datos(4) = ddl_Tipo.SelectedValue
        datos(5) = ddl_Capa.SelectedValue
        datos(6) = If(chk_Gas.Checked, "1", "")
        datos(7) = If(chk_Res.Checked, "1", "")
        datos(8) = If(chk_Surf.Checked, "1", "")
        datos(9) = If(Chk_Tie.Checked, "1", "")
        datos(10) = If(chk_Club.Checked, "1", "")
        datos(11) = If(chk_Auto.Checked, "1", "")
        comprobarDatos(datos)
    End Sub

    Private Sub comprobarDatos(datos() As String)
        Dim sql As String = Nothing
        Dim cmd1 = cnn1.CreateCommand
        cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` "
        sql = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` "

        If Not datos(0).Equals("NULL") Then
            sql &= "AND A.`NOMBRE` LIKE '%" & "Pnombre" & "%' "
            sql = Replace(sql, "Pnombre", datos(0))
            cmd1.CommandText &= "AND A.`NOMBRE` LIKE '%" & "@nombre" & "%' "
            cmd1.Parameters.AddWithValue("@nombre", datos(0))
        End If

        If Not datos(1).Equals("--Seleccione--") Then
            sql &= "AND P.`PROVINCUA` = '@prov' "
            sql = Replace(sql, "@prov", datos(1))
            cmd1.CommandText &= "AND P.`PROVINCUA` = @prov "
            cmd1.Parameters.AddWithValue("@prov", datos(1))
        End If

        If Not datos(2).Equals("--Seleccione--") Then
            sql &= "AND M.`MUNICIPIO` = '@muni' "
            sql = Replace(sql, "@muni", datos(2))
            cmd1.CommandText &= "AND M.`MUNICIPIO` = @muni "
            cmd1.Parameters.AddWithValue("@muni", datos(2))
        End If

        If Not datos(3).Equals("--Seleccione--") Then
            sql &= "AND R.`CODIGO_POSTAL` = '@cod' "
            sql = Replace(sql, "@cod", datos(3))
            cmd1.CommandText &= "AND R.`CODIGO_POSTAL` = @cod "
            cmd1.Parameters.AddWithValue("@cod", datos(3))
        End If

        If Not datos(4).Equals("--Seleccione--") Then
            sql &= "AND T.`TIPO` = '@tipo' "
            sql = Replace(sql, "@tipo", datos(4))
            cmd1.CommandText &= "AND T.`TIPO` = @tipo "
            cmd1.Parameters.AddWithValue("@tipo", datos(4))
        End If

        If Not datos(5).Equals("--Seleccione--") Then
            sql &= "AND A.`CAPACIDAD` = '@capa' "
            sql = Replace(sql, "@capa", datos(5))
            cmd1.CommandText &= "AND A.`CAPACIDAD` = @capa "
            cmd1.Parameters.AddWithValue("@capa", datos(5))
        End If

        If Not datos(6).Equals("") Then
            sql &= "AND A.`GASTRONOMICO` = @gas "
            sql = Replace(sql, "@gas", datos(6))
            cmd1.CommandText &= "AND A.`GASTRONOMICO` = @gas "
            cmd1.Parameters.AddWithValue("@gas", datos(6))
        End If

        If Not datos(7).Equals("") Then
            sql &= "AND A.`RESTAURANTE` = @res "
            sql = Replace(sql, "@res", datos(7))
            cmd1.CommandText &= "AND A.`RESTAURANTE` = @res "
            cmd1.Parameters.AddWithValue("@res", datos(7))
        End If

        If Not datos(8).Equals("") Then
            sql &= "AND A.`SURFING` = @surf "
            sql = Replace(sql, "@surf", datos(8))
            cmd1.CommandText &= "AND A.`SURFING` = @surf "
            cmd1.Parameters.AddWithValue("@surf", datos(8))
        End If

        If Not datos(9).Equals("") Then
            sql &= "AND A.`TIENDA` = @tie "
            sql = Replace(sql, "@tie", datos(9))
            cmd1.CommandText &= "AND A.`TIENDA` = @tie "
            cmd1.Parameters.AddWithValue("@tie", datos(9))
        End If

        If Not datos(10).Equals("") Then
            sql &= "AND A.`CLUB` = @club "
            sql = Replace(sql, "@club", datos(10))
            cmd1.CommandText &= "AND A.`CLUB` = @club "
            cmd1.Parameters.AddWithValue("@club", datos(10))
        End If

        If Not datos(11).Equals("") Then
            sql &= "AND A.`AUTOCARAVANA` = @auto "
            sql = Replace(sql, "@auto", datos(11))
            cmd1.CommandText &= "AND A.`AUTOCARAVANA` = @auto "
            cmd1.Parameters.AddWithValue("@auto", datos(11))
        End If

        cmd1.CommandText &= "ORDER BY A.`NOMBRE`"
        sql &= "ORDER BY A.`NOMBRE`"

        Session("select") = sql

        Response.Redirect("verAlojamientos.aspx", False)
    End Sub
End Class