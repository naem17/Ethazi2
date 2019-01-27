Imports MySql.Data.MySqlClient
Public Class insertarAlojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            cargarDDL()
            cargarProv()
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
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT `PROVINCUA` FROM `PROVINCIAS`"
            Dim dar1 As MySqlDataReader
            dar1 = cmd1.ExecuteReader
            ddl_Provincia.Items.Add("--Seleccione--")
            While dar1.Read
                ddl_Provincia.Items.Add(dar1.Item(0))
            End While
            dar1.Close()

            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = False
            ddl_Municipio.Enabled = False
        Else
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_CodPostal.Items.Clear()
            ddl_CodPostal.Items.Add("--Seleccione--")
            ddl_CodPostal.Enabled = False
            ddl_Municipio.Enabled = False
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
            ddl_Municipio.Items.Clear()
            ddl_Municipio.Items.Add("--Seleccione--")
            ddl_Municipio.Enabled = True
            While dar1.Read
                ddl_Municipio.Items.Add(dar1.Item(0))
            End While
            dar1.Close()
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

    Protected Sub ddl_Prov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl_Provincia.SelectedIndexChanged
        ddl_CodPostal.Enabled = False
        ddl_Municipio.Enabled = False
        cargarMuni(ddl_Provincia.SelectedValue)
    End Sub

    Protected Sub btn_Insert_Click(sender As Object, e As EventArgs) Handles btn_Insert.Click
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
        ElseIf chkFirma(datos(0)) Then
            MsgBox("No Wey")
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
            Dim datuak As String = Nothing
            For Each dato As String In datos
                datuak &= dato & "; "
            Next
            MsgBox(datuak)
        End If
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

    Function chkFirma(ByVal dato As String) As Boolean
        Dim cmd1 = cnn1.CreateCommand
        Dim ch As Boolean = True
        Dim dar1 As MySqlDataReader
        cmd1.CommandText = "SELECT FIRMA FROM ALOJAMIENTOS WHERE FIRMA = @param"
        cmd1.Parameters.AddWithValue("@param", dato)
        dar1 = cmd1.ExecuteReader
        If dar1.HasRows Then
            ch = False
        End If
    End Function
End Class