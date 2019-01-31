Imports MySql.Data.MySqlClient
Imports System.Drawing

Module Sentencias
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Dim id_rcmp As Integer
    Public idRelaciones As Integer
    Public Function cogerIdAlojamientos()
        conectar()

        Dim alojamientos As New ArrayList
        conectar()
        sql = "Select distinct id_relaciones from alojamientos where id_relaciones IN (select id from relacion_cp_municipios_provincias where codigo_provincia IN (Select codigo from provincias where provincua='" & btn_Buscar.cmb_provincia.SelectedItem & "'))"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read
            alojamientos.add(dr.Item(0))
        End While

        dr.Close()
        Return alojamientos
        desconectar()

    End Function
    Public Sub cargar(ByVal sql As String)
        conectar()

        Dim cmd1 As New MySqlCommand

        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(das1, "Alojamientos")
        Administrador.DataGridView1.DataSource = das1.Tables("Alojamientos")
        Administrador.DataGridView1.Columns(0).Width = 150
        Administrador.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua
        desconectar()

    End Sub
    Public Sub cargarCmbCodpostal()
        conectar()

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
        desconectar()

    End Sub
    Public Sub cargarCmbProvincia2()
        conectar()
        btn_Buscar.cmb_provincia.Items.Clear()
        sql = "Select provincua from provincias"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        btn_Buscar.cmb_provincia.Items.Add("-Todas-")
        While dr.Read
            btn_Buscar.cmb_provincia.Items.Add(dr.Item(0))
        End While
        dr.Close()
        desconectar()

    End Sub
    Public Sub cargarCmbProvincia()
        conectar()

        Dim tabla As New DataTable
        sql = "Select codigo,provincua from provincias order by provincua"
        Dim cmd1 As New MySqlCommand(sql, conexion)

        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        SegundaPageInsert.cmb_Provincia.DataSource = tabla
        SegundaPageInsert.cmb_Provincia.DisplayMember = "provincua"
        SegundaPageInsert.cmb_Provincia.ValueMember = "codigo"
        desconectar()

    End Sub
    Public Sub cargarCmbMunicipio()
        conectar()

        SegundaPageInsert.cmb_Municipio.Items.Clear()
        Dim tabla As New DataTable
        sql = "Select municipio from municipios where indice in (Select indice_municipio from relacion_cp_municipios_provincias where codigo_provincia = " & SegundaPageInsert.cmb_Provincia.SelectedValue.ToString & ") order by municipio"

        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            SegundaPageInsert.cmb_Municipio.Items.Add(dr.Item(0))
        End While
        dr.Close()
        desconectar()

    End Sub
    Public Function cargarId()
        conectar()

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
        desconectar()

    End Function
    Public Sub cargarCmbTipo()
        conectar()

        sql = "select distinct tipo from tipos"

        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        Dim cont As Integer = 0
        Dim texto(7) As String

        While dr.Read
            texto(cont) = dr.Item(0)
            cont += 1
        End While

        dr.Close()
        sql = "select distinct tipo_euskera from tipos_euskera"
        cmd1.CommandText = sql
        Dim dr2 As MySqlDataReader
        dr2 = cmd1.ExecuteReader
        cont = 0
        While dr2.Read

            texto(cont) &= "/" & dr2.Item(0)
            cont += 1

        End While
        Dim x As Integer
        While x < cont

            TerceraPageInsert.cmb_Tipo.Items.Add(texto(x))
            x += 1
        End While
        dr2.Close()
        desconectar()

    End Sub
    Public Sub cargarCmbTipo2()
        conectar()
        Dim tabla As New DataTable
        sql = "Select distinct tipo from tipos"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        btn_Buscar.cmb_tipo.Items.Add("-Todas-")
        While dr.Read
            btn_Buscar.cmb_tipo.Items.Add(dr.Item(0))
        End While
        dr.Close()
        desconectar()

    End Sub

    Public Function cogerTipo()
        conectar()

        Dim coger As Integer
        conectar()
        sql = "Select codigo_tipos from alojamientos where codigo_tipos in (Select codigo from tipos where tipo='" & btn_Buscar.cmb_tipo.SelectedItem & "')"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read
            coger = dr.Item(0)
        End While
        dr.Close()
        Return coger
        desconectar()

    End Function
    Public Sub cargarCmbCategorias()
        conectar()

        Dim tabla As New DataTable
        sql = "Select categoria from categorias "
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        TerceraPageInsert.cmb_Categorias.DataSource = tabla
        TerceraPageInsert.cmb_Categorias.DisplayMember = "categoria"
        desconectar()


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
            cmd1.Parameters.AddWithValue("@descripcion_abre_eus", TerceraPageInsert.txt_descripcionAbreEus.Text)
            cmd1.Parameters.AddWithValue("@descripcion", TerceraPageInsert.txt_descripcion.Text)
            cmd1.Parameters.AddWithValue("@descripcion_eus", TerceraPageInsert.txt_descripcionNoAbreEus.Text) 'Hacer otro form
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
            cmd1.Parameters.AddWithValue("@cod_tipos_eus", TerceraPageInsert.cmb_Tipo.SelectedItem)
            cmd1.Parameters.AddWithValue("@cod_categoria", TerceraPageInsert.cmb_Categorias.SelectedItem)
            cmd1.Parameters.AddWithValue("@id_relaciones", Val(cargarId()))

            cmd1.ExecuteNonQuery()
            MsgBox("Insertado registro.")

        Catch ex As Exception
            MsgBox("Error")
            MsgBox(ex.Message)
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
        desconectar()

    End Sub
    Public Sub exEnXML()
        conectar()
        das1.WriteXml(InputBox("Nombre de Archivo"))
        desconectar()

    End Sub
    '___________________________CARGAR DATOS PARA LA VISTA________________________________________
    Public Sub cargarCmbProvinciaVISTA()
        conectar()

        Vista.cmb_Provincia.Items.Clear()

        sql = "Select provincua from provincias"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            Vista.cmb_Provincia.Items.Add(dr.Item(0))

        End While
        dr.Close()
        desconectar()

    End Sub
    Public Sub cargarCmbMunicipioVISTA()
        ' desconectar()
        conectar()

        Vista.cmb_Municipio.Items.Clear()
        Dim tabla As New DataTable
        sql = "Select distinct municipio from municipios where indice in (Select indice_municipio from relacion_cp_municipios_provincias where codigo_provincia = (SELECT codigo FROM provincias WHERE provincua='" & Vista.cmb_Provincia.SelectedItem.ToString & "'))"

        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        While dr.Read

            Vista.cmb_Municipio.Items.Add(dr.Item(0))
        End While
        dr.Close()
        desconectar()

    End Sub
    Public Sub cargarCmbCodpostalVISTA()
        '  desconectar()

        conectar()

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

        desconectar()

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
        dr.Close()
        desconectar()

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
        desconectar()

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
        desconectar()

    End Sub
    Public Function cargarIdvista()
        conectar()

        Dim tabla As New DataTable
        Dim cmd1 As New MySqlCommand("", conexion)
        cmd1.CommandText = "Select id from relacion_cp_municipios_provincias where codigo_postal = @param"
        cmd1.Parameters.AddWithValue("@param", Vista.cmb_CodPostal.Text)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            id_rcmp = dr.Item(0)

        End While
        dr.Close()

        Return id_rcmp
        desconectar()

    End Function
End Module
