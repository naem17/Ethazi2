Imports MySql.Data.MySqlClient
Imports System.Drawing

Module Sentencias
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Dim id_rcmp As Integer
    Public idRelaciones As Integer

    Public Function cogerIdAlojamientos()
        Dim coger As Integer
        conectar()

        sql = "Select * from alojamientos where id_relaciones IN (select id from relacion_cp_municipios_provincias where codigo_provincia IN (Select codigo from provincias where provincua='" & Buscar.cmb_provincia.SelectedValue.ToString & "'))"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            coger = dr.Item(0)
        End While
        dr.Close()
        Return coger
    End Function
    Public Sub cargar(ByVal sql As String)

        Dim cmd1 As New MySqlCommand

        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(das1, "Alojamientos")
        Administrador.DataGridView1.DataSource = das1.Tables("Alojamientos")
        Administrador.DataGridView1.Columns(0).Width = 150
        Administrador.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua

    End Sub
    Public Sub cargarCmbCodpostal()
        Dim tabla As New DataTable
        Dim codigo_muni As Integer
        sql = "Select indice from municipios where municipio = '" & SegundaPageInsert.cmb_Municipio.SelectedItem & "'"
        Dim dr As MySqlDataReader
        Dim cmd2 As New MySqlCommand(sql, conexion)
        dr = cmd2.ExecuteReader
        While dr.Read
            codigo_muni = dr.Item(0)
        End While
        dr.Close()
        sql = "Select CODIGO_POSTAL, INDICE_MUNICIPIO from relacion_cp_municipios_provincias  where INDICE_MUNICIPIO=" & codigo_muni
        Dim cmd1 As New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()
        adap1.Fill(tabla)
        SegundaPageInsert.cmb_CodPostal.DataSource = tabla
        SegundaPageInsert.cmb_CodPostal.DisplayMember = "CODIGO_POSTAL"
    End Sub
    Public Sub cargarCmbProvincia2()
        Dim tabla As New DataTable
        sql = "Select codigo,provincua from provincias"
        Dim cmd1 As New MySqlCommand(sql, conexion)

        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        Buscar.cmb_provincia.DataSource = tabla
        Buscar.cmb_provincia.DisplayMember = "provincua"
        Buscar.cmb_provincia.ValueMember = "codigo"


    End Sub
    Public Sub cargarCmbProvincia()
        Dim tabla As New DataTable
        sql = "Select codigo,provincua from provincias"
        Dim cmd1 As New MySqlCommand(sql, conexion)

        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        SegundaPageInsert.cmb_Provincia.DataSource = tabla
        SegundaPageInsert.cmb_Provincia.DisplayMember = "provincua"
        SegundaPageInsert.cmb_Provincia.ValueMember = "codigo"
    End Sub
    Public Sub cargarCmbMunicipio()
        SegundaPageInsert.cmb_Municipio.Items.Clear()
        Dim tabla As New DataTable
        sql = "Select municipio from municipios where indice in (Select indice_municipio from relacion_cp_municipios_provincias where codigo_provincia = " & SegundaPageInsert.cmb_Provincia.SelectedValue.ToString & ")"

        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            SegundaPageInsert.cmb_Municipio.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub
    Public Function cargarId()
        Dim tabla As New DataTable
        Dim cmd1 As New MySqlCommand("", conexion)
        cmd1.CommandText = "Select `id` from `relacion_cp_municipios_provincias` where `codigo_postal`= @param"
        cmd1.Parameters.AddWithValue("@param", SegundaPageInsert.cmb_CodPostal.SelectedValue.ToString())
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            id_rcmp = dr.Item(0)

        End While
        dr.Close()
        Return id_rcmp
    End Function
    Public Sub cargarCmbTipo()
        Dim tabla As New DataTable
        sql = "Select tipo from tipos "
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        TerceraPageInsert.cmb_Tipo.DataSource = tabla
        TerceraPageInsert.cmb_Tipo.DisplayMember = "tipo"
    End Sub
    Public Sub cargarCmbTipo2()
        conectar()

        Dim tabla As New DataTable
        sql = "Select tipo from tipos "
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            Buscar.cmb_tipo.Items.Add(dr.Item(0))

        End While
        dr.Close()
    End Sub
    Public Function cogerTipo()
        Dim coger As Integer
        conectar()

        sql = "Select codigo_tipos from alojamientos where codigo_tipos in (Select codigo from tipos where tipo='" & Buscar.cmb_tipo.SelectedItem & "')"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            coger = dr.Item(0)
        End While
        dr.Close()
        Return coger
    End Function
    Public Sub cargarCmbCategorias()
        Dim tabla As New DataTable
        sql = "Select categoria from categorias "
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        TerceraPageInsert.cmb_Categorias.DataSource = tabla
        TerceraPageInsert.cmb_Categorias.DisplayMember = "categoria"
        '  SegundaPageInsert.cmb_Provincia.ValueMember = "codigo"

    End Sub
    Public Sub insertar()
        ConexionBBDD.conectar()

        Try
            sql = "INSERT INTO alojamientos (FIRMA, NOMBRE, DESCRIPCION_ABREVIADA, DESCRIPCION_ABREVIADA_EUSKERA, DESCRIPCION, DESCRIPCION_EUSKERA, TELEFONO, DIRECCION, "
            sql &= "CALIDAD_ASEGURADA, EMAIL, WEB, CLUB, RESTAURANTE, AUTOCARAVANA, TIENDA, CAPACIDAD, GASTRONOMICO, SURFING, COORDENADAS, "
            sql &= "CODIGO_TIPOS, CODIGO_TIPOS_EUSKERA, CODIGO_CATEGORIAS,ID_RELACIONES) "

            '-----------------------------------
            sql &= "VALUES (@firma, @nombre, @descripcion_abre, @descripcion_abre_eus, @descripcion, @descripcion_eus,"
            sql &= "@telefono, @direccion, @calidad, @email, @web, @club, @restaurante, @autocaravana, @tienda, @capacidad, @gastronomico, @surfing, @coordenadas,"
            sql &= "@cod_tipos, @cod_tipos_eus, @cod_categoria, @id_relaciones)"


            Dim cmd1 = New MySqlCommand(sql, conexion)
            cmd1.Parameters.AddWithValue("@firma", PrimeraPageInsert.txt_Firma.Text)
            cmd1.Parameters.AddWithValue("@nombre", PrimeraPageInsert.txt_Nombre.Text)
            cmd1.Parameters.AddWithValue("@descripcion_abre", TerceraPageInsert.txt_Corta.Text)
            cmd1.Parameters.AddWithValue("@descripcion_abre_eus", "Celaya")
            cmd1.Parameters.AddWithValue("@descripcion", TerceraPageInsert.txt_Larga.Text)
            cmd1.Parameters.AddWithValue("@descripcion_eus", "123654789") 'Hacer otro form
            cmd1.Parameters.AddWithValue("@telefono", PrimeraPageInsert.txt_Telefono.Text)
            cmd1.Parameters.AddWithValue("@direccion", SegundaPageInsert.txt_Direccion.Text) ' ver como sería
            If CuartaPageInsert.ckb_Calidad.Checked Then
                cmd1.Parameters.AddWithValue("@calidad", 1)
            Else
                cmd1.Parameters.AddWithValue("@calidad", 0)
            End If
            cmd1.Parameters.AddWithValue("@email", PrimeraPageInsert.txt_Email.Text)
            cmd1.Parameters.AddWithValue("@web", PrimeraPageInsert.txt_Web.Text)
            If CuartaPageInsert.ckb_Club.Checked Then
                cmd1.Parameters.AddWithValue("@club", 1)
            Else
                cmd1.Parameters.AddWithValue("@club", 0)
            End If
            If CuartaPageInsert.ckb_Restaurante.Checked Then
                cmd1.Parameters.AddWithValue("@restaurante", 1)
            Else
                cmd1.Parameters.AddWithValue("@restaurante", 0)
            End If
            If CuartaPageInsert.ckb_Autocaravana.Checked Then
                MsgBox("Estoy mirando si esta checkeado auto")
                cmd1.Parameters.AddWithValue("@autocaravana", 1)
            Else
                cmd1.Parameters.AddWithValue("@autocaravana", 0)
            End If
            If CuartaPageInsert.ckb_Tienda.Checked Then
                cmd1.Parameters.AddWithValue("@tienda", 1)
            Else
                cmd1.Parameters.AddWithValue("@tienda", 0)
            End If
            cmd1.Parameters.AddWithValue("@capacidad", TerceraPageInsert.txt_Capacidad.Text)
            If CuartaPageInsert.ckb_Gastronomico.Checked Then
                cmd1.Parameters.AddWithValue("@gastronomico", 1)
            Else
                cmd1.Parameters.AddWithValue("@gastronomico", 0)
            End If
            If CuartaPageInsert.ckb_Surfing.Checked Then
                cmd1.Parameters.AddWithValue("@surfing", 1)
            Else
                cmd1.Parameters.AddWithValue("@surfing", 0)
            End If
            cmd1.Parameters.AddWithValue("@coordenadas", SegundaPageInsert.txt_Coordenadas.Text)
            cmd1.Parameters.AddWithValue("@cod_tipos", TerceraPageInsert.cmb_Tipo.SelectedItem)
            cmd1.Parameters.AddWithValue("@cod_tipos_eus", 1)
            cmd1.Parameters.AddWithValue("@cod_categoria", TerceraPageInsert.cmb_Categorias.SelectedItem)
            cmd1.Parameters.AddWithValue("@id_relaciones", Val(cargarId()))
            MsgBox(sql)
            cmd1.ExecuteNonQuery()
            MsgBox("Insertado registro.")

        Catch ex As Exception
            MsgBox("Error")
            MsgBox(ex.Message)
            'sql = "DELETE * from customers where customerid=@uno"
            'Dim cmd2 = New OleDbCommand(sql, cnn1)
            'cmd2.Parameters.AddWithValue("@uno", "Bilbo")
            'Dim result As Integer = cmd2.ExecuteNonQuery
            'MsgBox("Borrado " & result & " resgistro.")
        End Try
        ConexionBBDD.desconectar()
    End Sub
    Public Sub eliminar()
        conectar()
        sql = "DELETE from Alojamientos where firma=@iden"
        'Crear un comando
        Dim cmd1 As New MySqlCommand(sql, conexion)
        Dim miFila As Integer
        Dim firma As String
        miFila = Administrador.DataGridView1.CurrentRow.Index
        firma = Administrador.DataGridView1.Item(0, miFila).Value

        cmd1.Parameters.AddWithValue("@iden", firma)
        Dim result As Integer
        Try
            result = cmd1.ExecuteNonQuery ' devulve el numero de filas
            MsgBox("Fila: " & result & " borrada")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Sub exEnXML()
        das1.WriteXml(InputBox("Nombre de Archivo"))
    End Sub
    '___________________________CARGAR DATOS PARA LA VISTA________________________________________
    Public Sub cargarCmbProvinciaVISTA()
        Dim tabla As New DataTable
        sql = "Select codigo,provincua from provincias"
        Dim cmd1 As New MySqlCommand(sql, conexion)

        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        Vista.cmb_Provincia.DataSource = tabla
        Vista.cmb_Provincia.DisplayMember = "provincua"
        Vista.cmb_Provincia.ValueMember = "codigo"
        'MsgBox(Vista.cmb_Provincia.SelectedValue.ToString)
    End Sub
    Public Sub cargarCmbMunicipioVISTA()
        MsgBox(Vista.cmb_Provincia.SelectedItem.ToString)
        Vista.cmb_Municipio.Items.Clear()
        Dim tabla As New DataTable
        sql = "Select municipio from municipios where indice in (Select indice_municipio from relacion_cp_municipios_provincias where codigo_provincia = " & Vista.cmb_Provincia.SelectedValue.ToString & ")"

        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            Vista.cmb_Municipio.Items.Add(dr.Item(0))
        End While
        dr.Close()
    End Sub
    Public Sub cargarCmbCodpostalVISTA()
        Dim tabla As New DataTable
        Dim codigo_muni As Integer
        sql = "Select indice from municipios where municipio = '" & Vista.cmb_Municipio.SelectedItem & "'"
        Dim dr As MySqlDataReader
        Dim cmd2 As New MySqlCommand(sql, conexion)
        dr = cmd2.ExecuteReader
        While dr.Read
            codigo_muni = dr.Item(0)
        End While
        dr.Close()
        sql = "Select CODIGO_POSTAL, INDICE_MUNICIPIO from relacion_cp_municipios_provincias  where INDICE_MUNICIPIO=" & codigo_muni
        Dim cmd1 As New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()
        adap1.Fill(tabla)
        Vista.cmb_CodPostal.DataSource = tabla
        Vista.cmb_CodPostal.DisplayMember = "CODIGO_POSTAL"
    End Sub
    Public Sub cargarProvinciaIdVISTA()
        conectar()

        Dim provincia As String = ""
        sql = "Select p.provincua from provincias p, RELACION_CP_MUNICIPIOS_PROVINCIAS r where codigo=codigo_provincia and r.id=" & idRelaciones
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read
            provincia = dr.Item(0)
        End While
        Vista.cmb_Provincia.Text = provincia

        desconectar()
        dr.Close()
    End Sub
    Public Sub cargarMunicipioIDVISTA()
        conectar()
        Dim municipios As String = ""
        sql = "Select m.municipio from municipios m, RELACION_CP_MUNICIPIOS_PROVINCIAS r where indice=r.indice_municipio and r.id=" & idRelaciones
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read
            municipios = dr.Item(0)
        End While
        Vista.cmb_Municipio.Text = municipios
        dr.Close()
    End Sub
    Public Sub cargarCodPostalIDVISTA()
        conectar()
        Dim codigo As Integer
        sql = "Select CODIGO_POSTAL FROM RELACION_CP_MUNICIPIOS_PROVINCIAS where id=" & idRelaciones
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read
            codigo = dr.Item(0)
        End While
        Vista.cmb_CodPostal.Text = codigo
        dr.Close()
    End Sub
End Module
