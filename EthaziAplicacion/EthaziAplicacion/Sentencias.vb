Imports MySql.Data.MySqlClient
Imports System.Drawing

Module Sentencias
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    'sql="Select indice,cp from alojamientos group by codigo,indice"
    '----------------------------------------------------------------------
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
        sql = "Select ID,CODIGO_POSTAL from codigos_postales"
        Dim cmd1 As New MySqlCommand(sql, conexion)

        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()

        adap1.Fill(tabla)
        SegundaPageInsert.cmb_CodPostal.DataSource = tabla
        SegundaPageInsert.cmb_CodPostal.DisplayMember = "codigo_postal"
        SegundaPageInsert.cmb_CodPostal.ValueMember = "id"


    End Sub
    Public Sub cargarCmbProvincia()
        Dim tabla As New DataTable
        sql = "Select codigo,provincua from provincias"
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        adap1 = New MySqlDataAdapter(cmd1)
        das1.Clear()
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            SegundaPageInsert.cmb_Provincia.Items.Add(dr.Item(1))
        End While
        dr.Close()
        'SegundaPageInsert.cmb_Provincia.DisplayMember = "provincua"
        'SegundaPageInsert.cmb_Provincia.ValueMember = "codigo"


    End Sub
    Public Sub ver()

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
    Public Sub cargarCmbMunicipio()
        SegundaPageInsert.cmb_Municipio.Items.Clear()
        Dim tabla As New DataTable
        sql = "Select distinct codigo_municipio from alojamientos where codigo_provincia = " & SegundaPageInsert.cmb_Provincia.SelectedItem
        Dim cmd1 As New MySqlCommand
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd1.ExecuteReader
        'adap1 = New MySqlDataAdapter(cmd1)
        'das1.Clear()
        While dr.Read
            SegundaPageInsert.cmb_Municipio.Items.Add(dr.Item(0))
            'hay que cmabiar esta mal esto
            'No sale lo del cmb de cambiar
        End While
        dr.Close()
        'adap1.Fill(tabla)
        'SegundaPageInsert.cmb_Municipio.DataSource = tabla

    End Sub
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
        '  SegundaPageInsert.cmb_Provincia.ValueMember = "codigo"

    End Sub
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
            sql = "INSERT INTO alojamientos (FIRMA, NOMBRE, DESCRIPCION_ABREVIADA, DESCRIPCION_ABREVIADA_EUSKERA, DESCRIPCION, DESCRIPCION_EUSKERA, TELEFONO, DIRECCION, CALIDAD_ASEGURADA, EMAIL, WEB, CLUB, RESTAURANTE, AUTOCARAVANA, TIENDA, CAPACIDAD, GASTRONOMICO, SURFING, COORDENADAS, CODIGO_MUNICIPIO, CODIGO_PROVINCIA, CODIGO_TIPOS, CODIGO_TIPOS_EUSKERA, CODIGO_CATEGORIAS, ID_CODIGO_POSTAL) " ' Arreglar sentencia
            '-----------------------------------
            sql &= "VALUES (@firma, @nombre, @descripcion_abre, @descripcion_abre_eus, @descripcion, @descripcion_eus,"
            sql &= " @telefono, @direccion, @calidad, @email, @web, @club, @restaurante, @autocaravana, @tienda, @capacidad, @gastronomico, @surfing, @coordenadas,"
            sql &= " @cod_municipio, @cod_provincia, @cod_tipos, @cod_tipos_eus, @cod_categoria, @id_cod_postal)"


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
            cmd1.Parameters.AddWithValue("@cod_municipio", SegundaPageInsert.cmb_Municipio.SelectedItem)
            cmd1.Parameters.AddWithValue("@cod_provincia", 20)

            ' Convert.ToInt32(SegundaPageInsert.cmb_Provincia.SelectedValue.ToString)
            cmd1.Parameters.AddWithValue("@cod_tipos", TerceraPageInsert.cmb_Tipo.SelectedItem)
            cmd1.Parameters.AddWithValue("@cod_tipos_eus", 65)
            cmd1.Parameters.AddWithValue("@cod_categoria", TerceraPageInsert.cmb_Categorias.SelectedItem)
            cmd1.Parameters.AddWithValue("@id_cod_postal", SegundaPageInsert.cmb_CodPostal.SelectedItem)

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
End Module
