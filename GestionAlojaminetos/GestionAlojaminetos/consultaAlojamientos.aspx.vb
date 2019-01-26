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

        For x As Integer = 0 To 999
            ddl_Capa.Items.Add(x)
        Next
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
            cmd1.CommandText = "SELECT `INDICE` FROM `MUNICIPIOS` WHERE `MUNICIPIO` = @param"
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
        datos(0) = txt_Nombre.Text
        datos(1) = ddl_Prov.SelectedValue
        datos(2) = ddl_Muni.SelectedValue
        datos(3) = ddl_Cod.SelectedValue
        datos(4) = ddl_Tipo.SelectedValue
        datos(5) = ddl_Capa.SelectedValue
        datos(6) = If(chk_Gas.Checked, "1", "0")
        datos(7) = If(chk_Res.Checked, "1", "0")
        datos(8) = If(chk_Surf.Checked, "1", "0")
        datos(9) = If(Chk_Tie.Checked, "1", "0")
        datos(10) = If(chk_Club.Checked, "1", "0")
        datos(11) = If(chk_Auto.Checked, "1", "0")
        comprobarDatos(datos)
    End Sub

    Private Sub comprobarDatos(datos() As String)
        Dim sql As String = Nothing
        sql = "SELECT "
    End Sub
End Class