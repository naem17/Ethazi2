Imports MySql.Data.MySqlClient

Public Class Vista

    Dim misDatos(17) As String
    Dim sql As String
    Dim id As Integer
    Dim euskera As Boolean
    Dim guardar As Boolean
    Public idRelaciones As Integer
    Public Sub datosACargar(firma)
        conectar()
        Dim sql As String
        sql = "select * from alojamientos where firma = '" & firma & "'"
        Dim cmd As New MySqlCommand(sql, ConexionBBDD.conexion)

        Dim datos As MySqlDataReader
        datos = cmd.ExecuteReader
        While datos.Read

            Me.txt_Firma.Text = datos(0)
            If IsDBNull(datos(1)) Then
                Me.txt_Nombre.Text = ""
            Else
                Me.txt_Nombre.Text = datos(1)
            End If
            If IsDBNull(datos(2)) Then
                Me.txt_descripcionAbre.Text = ""
            Else
                Me.txt_descripcionAbre.Text = datos(2)
            End If
            If IsDBNull(datos(3)) Then
                Me.txt_descripcionAbreEus.Text = ""
            Else
                Me.txt_descripcionAbreEus.Text = datos(3)
            End If
            If IsDBNull(datos(4)) Then
                Me.txt_descripcionNOabre.Text = ""
            Else
                Me.txt_descripcionNOabre.Text = datos(4)
            End If
            If IsDBNull(datos(5)) Then
                Me.txt_descripcionNoAbreEus.Text = ""
            Else
                Me.txt_descripcionNoAbreEus.Text = datos(5)
            End If
            If IsDBNull(datos(6)) Then
                Me.txt_Telefono.Text = ""
            Else
                Me.txt_Telefono.Text = datos(6)
            End If

            If IsDBNull(datos(7)) Then

                Me.txt_Direccion.Text = ""
            Else
                Me.txt_Direccion.Text = datos(7)
            End If
            If IsDBNull(datos(8)) Then

                Me.ckb_calidad.Checked = ""
            Else

                Me.ckb_calidad.Checked = datos(8)
            End If
            If IsDBNull(datos(9)) Then

                Me.txt_Email.Text = ""
            Else

                Me.txt_Email.Text = datos(9)
            End If
            If IsDBNull(datos(10)) Then

                Me.txt_Web.Text = ""
            Else
                Me.txt_Web.Text = datos(10)
            End If

            Me.ckb_Club.Checked = datos(11)
            Me.ckb_Restaurante.Checked = datos(12)
            Me.ckb_Autocaravana.Checked = datos(13)
            Me.ckb_Tienda.Checked = datos(14)

            If IsDBNull(datos(15)) Then
                Me.txt_Capacidad.Text = ""
            Else
                Me.txt_Capacidad.Text = datos(15)
            End If
            Me.ckb_Gastro.Checked = datos(16)
            Me.ckb_Surfing.Checked = datos(17)

            If IsDBNull(datos(18)) Then
                Me.txt_Coordenadas.Text = ""
            Else
                Me.txt_Coordenadas.Text = datos(18)
            End If
            If IsDBNull(datos(19)) Then
                Me.cmb_Tipo.Text = ""
            Else
                Select Case datos(19)
                    Case 0
                        Me.cmb_Tipo.Text = "Albergue"
                    Case 1
                        Me.cmb_Tipo.Text = "Campings"
                    Case 2
                        Me.cmb_Tipo.Text = "Agroturismos"
                    Case 3
                        Me.cmb_Tipo.Text = "Casas Rurales"

                End Select
            End If
            If IsDBNull(datos(21)) Then
                Me.cmb_Tipo.Text = ""
            Else
                Select Case datos(21)
                    Case 0
                        Me.cmb_Categoria.Text = "S"
                    Case 1
                        Me.cmb_Categoria.Text = "T"
                    Case 2
                        Me.cmb_Categoria.Text = "P"


                End Select
            End If
            'Me saca el id del alojamiento'
            If IsDBNull(datos(22)) Then
                Me.cmb_Provincia.Text = ""
                Me.cmb_Municipio.Text = ""
                Me.cmb_CodPostal.Text = ""
            Else
                Sentencias.idRelaciones = datos(22)
                
            End If
        End While
        datos.Close()


        '-----------------------------CARGAR Tipos CMB--------------------------------------
        Dim sql2 As String
        sql2 = "select distinct codigo_tipos from alojamientos"
        Dim cmd2 As New MySqlCommand(sql2, conexion)
        Dim dr As MySqlDataReader
        dr = cmd2.ExecuteReader

        While dr.Read
            ' Administrador.DataGridView1.SelectedColumns.Item(7) = 0 
            If dr.Item(0) = 0 Then
                Me.cmb_Tipo.Items.Add("Albergues")
            ElseIf dr.Item(0) = 1 Then
                Me.cmb_Tipo.Items.Add("Campings")
            ElseIf dr.Item(0) = 2 Then
                Me.cmb_Tipo.Items.Add("Agroturismos")
            ElseIf dr.Item(0) = 3 Then
                Me.cmb_Tipo.Items.Add("Casas Rurales")
            End If
        End While
        dr.Close()
        '-----------------------------CARGAR CATEGORIAS CMB--------------------------------------
        Dim sql3 As String
        sql3 = "select distinct codigo_categorias from alojamientos"
        Dim cmd3 As New MySqlCommand(sql3, conexion)
        Dim dr1 As MySqlDataReader
        dr1 = cmd3.ExecuteReader
        While dr1.Read
            If dr1.Item(0) = 0 Then
                Me.cmb_Categoria.Items.Add("S")
            ElseIf dr1.Item(0) = 1 Then
                Me.cmb_Categoria.Items.Add("P")
            ElseIf dr1.Item(0) = 2 Then
                Me.cmb_Categoria.Items.Add("T")
            End If
        End While
        dr1.Close()
        '----------------------------------------------------------------------------------------
        ''--------------------------------cargar CMB PROVINCIAS-----------------------------------
        'Dim sql4 As String
        'sql4 = "select provincua from provincias "
        'Dim cmd4 As New MySqlCommand(sql4, conexion)
        'Dim dr4 As MySqlDataReader
        'dr4 = cmd4.ExecuteReader
        'While dr4.Read
        '    Me.cmb_Provincia.Items.Add(dr4.Item(0))

        'End While
        'dr4.Close()
        '----------------------------------------------------------------------------------------
        desconectar()
    End Sub
    'Private Sub cargarConId()
    '    conectar()

    '    'Dim sql5 As String
    '    'sql5 = "Select distinct p.provincua,m.municipio,r.codigo_postal from relacion_cp_municipios_provincias r, provincias p, municipios m where r.id=" & idRelaciones

    '    'Dim cmd5 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr5 As MySqlDataReader
    '    'dr5 = cmd5.ExecuteReader
    '    'While dr5.Read
    '    '    Me.cmb_Provincia.Items.Add(dr5.Item(0))
    '    '    Me.cmb_Municipio.Items.Add(dr5.Item(1))
    '    '    Me.cmb_CodPostal.Items.Add(dr5.Item(2))

    '    'End While
    '    'dr5.Close()

    '    'Dim indice_municipio As Integer
    '    'sql5 = "Select distinct indice_municipio from relacion_cp_municipios_provincias where id =" & idRelaciones
    '    'Dim cmd6 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr6 As MySqlDataReader
    '    'dr6 = cmd6.ExecuteReader
    '    'While dr6.Read
    '    '    indice_municipio = dr6.Item(0)
    '    'End While
    '    'dr6.Close()

    '    'Dim municipio As String
    '    'sql5 = "Select distinct  municipio from municipios where indice=" & indice_municipio
    '    'Dim cmd7 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr7 As MySqlDataReader
    '    'dr7 = cmd7.ExecuteReader
    '    'While dr7.Read
    '    '    municipio = dr7.Item(0)
    '    'End While
    '    'dr7.Close()

    '    'Me.cmb_Municipio.SelectedItem = municipio





    '    'Dim indice_provincia As Integer
    '    'sql5 = "Select distinct codigo_provincia from relacion_cp_municipios_provincias where id =" & idRelaciones
    '    'Dim cmd8 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr8 As MySqlDataReader
    '    'dr8 = cmd8.ExecuteReader
    '    'While dr8.Read
    '    '    indice_provincia = dr8.Item(0)
    '    'End While
    '    'dr8.Close()

    '    'Dim provincia As String
    '    'sql5 = "Select distinct provincua from provincias where codigo=" & indice_provincia
    '    'Dim cmd9 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr9 As MySqlDataReader
    '    'dr9 = cmd9.ExecuteReader
    '    'While dr9.Read
    '    '    provincia = dr9.Item(0)
    '    'End While
    '    'dr9.Close()

    '    'Me.cmb_Provincia.Text = provincia

    '    'Dim codigo_postal As Integer
    '    'sql5 = "Select distinct codigo_postal from relacion_cp_municipios_provincias where id =" & idRelaciones
    '    'Dim cmd10 As New MySqlCommand(sql5, ConexionBBDD.conexion)
    '    'Dim dr10 As MySqlDataReader
    '    'dr10 = cmd10.ExecuteReader
    '    'While dr10.Read
    '    '    codigo_postal = dr10.Item(0)
    '    'End While
    '    'dr10.Close()

    '    'Me.cmb_CodPostal.Text = codigo_postal




    '    desconectar()
    'End Sub
    Private Sub btn_actualizarDato_Click(sender As Object, e As EventArgs) Handles btn_actualizarDato.Click
        btn_actualizarDato.Text = "Actualizar datos"
        If Not guardar Then
            Me.txt_Nombre.Enabled = True
            Me.txt_Telefono.Enabled = True
            Me.txt_Email.Enabled = True
            Me.txt_Direccion.Enabled = True
            Me.txt_descripcionNoAbreEus.Enabled = True
            Me.txt_descripcionNOabre.Enabled = True
            Me.txt_descripcionAbreEus.Enabled = True
            Me.txt_descripcionAbre.Enabled = True
            Me.txt_Capacidad.Enabled = True
            Me.cmb_Tipo.Enabled = True
            Me.cmb_Categoria.Enabled = True
            Me.txt_Coordenadas.Enabled = True
            Me.cmb_CodPostal.Enabled = True
            Me.cmb_Provincia.Enabled = True
            Me.cmb_Municipio.Enabled = True
            Me.txt_Web.Enabled = True
            Me.ckb_Autocaravana.Enabled = True
            Me.ckb_calidad.Enabled = True
            Me.ckb_Club.Enabled = True
            Me.ckb_Restaurante.Enabled = True
            Me.ckb_Gastro.Enabled = True
            Me.ckb_Tienda.Enabled = True
            Me.ckb_Surfing.Enabled = True
            guardar = True
        ElseIf guardar Then
            Me.btn_actualizarDato.Text = "Editar Datos"
            Me.txt_Nombre.Enabled = False
            Me.txt_Telefono.Enabled = False
            Me.txt_Email.Enabled = False
            Me.txt_Direccion.Enabled = False
            Me.txt_descripcionNoAbreEus.Enabled = False
            Me.txt_descripcionNOabre.Enabled = False
            Me.txt_descripcionAbreEus.Enabled = False
            Me.txt_descripcionAbre.Enabled = False
            Me.txt_Capacidad.Enabled = False
            Me.cmb_Tipo.Enabled = False
            Me.cmb_Categoria.Enabled = False
            Me.txt_Coordenadas.Enabled = False
            Me.cmb_CodPostal.Enabled = False
            Me.cmb_Provincia.Enabled = False
            Me.cmb_Municipio.Enabled = False
            Me.txt_Web.Enabled = False
            Me.ckb_Autocaravana.Enabled = False
            Me.ckb_calidad.Enabled = False
            Me.ckb_Club.Enabled = False
            Me.ckb_Restaurante.Enabled = False
            Me.ckb_Gastro.Enabled = False
            Me.ckb_Tienda.Enabled = False
            Me.ckb_Surfing.Enabled = False
            guardar = False
            cargarCmbProvinciaVISTA()
            'actualizar()
        End If

    End Sub
    Public Sub actualizar()
        sql = "UPDATE alojamientos SET nombre=@nombre,descripcion_Abre=@desc_abre,descripcion_Abre_eus=@desc_abre_eus,descripcion=@desc,descripcion_eus=@desc_eus,telefono=@phone,direccion=@address,"
        sql &= "calidad=@calidad,email=@mail,web=@web,club=@club,restaurante=@restaurante,autocaravana=@caravana,tienda=@shop,capacidad=@capacidad,gatronomico=@gatronomico,surfing=@surf,coordenadas=@coordenadas,"
        sql &= "codigo_tipos=@cTipos,codigo_tipos_euskera=@cTiposEus,codigo_categorias=@cCategorias,id_relaciones=@idRelaciones "
        sql &= "where firma=@firma"
        Dim cmd1 = New MySqlCommand(sql, conexion)
        cmd1.Parameters.AddWithValue("@firma", Me.txt_Firma.Text)
        cmd1.Parameters.AddWithValue("@nombre", Me.txt_Nombre.Text)
        cmd1.Parameters.AddWithValue("@desc_abre", Me.txt_descripcionAbre.Text)
        cmd1.Parameters.AddWithValue("@desc_abre_eus", Me.txt_descripcionAbreEus.Text)
        cmd1.Parameters.AddWithValue("@desc", Me.txt_descripcionNOabre.Text)
        cmd1.Parameters.AddWithValue("@desc_eus", Me.txt_descripcionAbreEus.Text)
        cmd1.Parameters.AddWithValue("@phone", Me.txt_Telefono.Text)
        cmd1.Parameters.AddWithValue("@address", Me.txt_Direccion.Text)
        If Me.ckb_calidad.Checked Then
            cmd1.Parameters.AddWithValue("@calidad", 1)
        Else
            cmd1.Parameters.AddWithValue("@calidad", 0)
        End If
        cmd1.Parameters.AddWithValue("@mail", Me.txt_Email.Text)
        cmd1.Parameters.AddWithValue("@web", Me.txt_Web.Text)
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
        cmd1.Parameters.AddWithValue("@capacidad", Me.txt_Capacidad.Text)
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
        cmd1.Parameters.AddWithValue("@coordenadas", Me.txt_Coordenadas.Text)
        cmd1.Parameters.AddWithValue("@cod_tipos", Me.cmb_Tipo.SelectedItem)
        cmd1.Parameters.AddWithValue("@cod_tipos_eus", 1)
        cmd1.Parameters.AddWithValue("@cod_categoria", Me.cmb_Categoria.SelectedItem)
        cmd1.Parameters.AddWithValue("@id_relaciones", Val(cargarId()))

        Dim result As Integer
        Try
            result = cmd1.ExecuteNonQuery ' devulve el numero de filas
            MsgBox("Modificadas: " & result & " filas")
            sql = "Select * from Alojamientos"
            Sentencias.cargar(sql)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_Restablecer.Click
        datosACargar(txt_Firma)
    End Sub
    Private Sub Vista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btn_actualizarDato.Text = "Actualizar Dato"
        Me.txt_Nombre.Enabled = False
        Me.txt_Telefono.Enabled = False
        Me.txt_Email.Enabled = False
        Me.txt_Direccion.Enabled = False
        Me.txt_descripcionNoAbreEus.Enabled = False
        Me.txt_descripcionNOabre.Enabled = False
        Me.txt_descripcionAbreEus.Enabled = False
        Me.txt_descripcionAbre.Enabled = False
        Me.txt_Capacidad.Enabled = False
        Me.cmb_Tipo.Enabled = False
        Me.cmb_Categoria.Enabled = False
        Me.txt_Coordenadas.Enabled = False
        Me.cmb_CodPostal.Enabled = False
        Me.cmb_Provincia.Enabled = False
        Me.cmb_Municipio.Enabled = False
        Me.txt_Web.Enabled = False
        Me.ckb_Autocaravana.Enabled = False
        Me.ckb_calidad.Enabled = False
        Me.ckb_Club.Enabled = False
        Me.ckb_Restaurante.Enabled = False
        Me.ckb_Gastro.Enabled = False
        Me.ckb_Tienda.Enabled = False
        Me.ckb_Surfing.Enabled = False
        guardar = False
        cargarProvinciaIdVISTA()
        cargarMunicipioIDVISTA()
        cargarCodPostalIDVISTA()

        'ver()
    End Sub
    Private Sub btn_euskera_Click(sender As Object, e As EventArgs) Handles btn_euskera.Click
        If Not euskera Then
            btn_euskera.Text = "*Español"
            Me.lbl_descripcionAbre.Visible = True
            Me.lbl_DescripcionNOABRE.Visible = True
            Me.lbl_descripcionAbre.Text = "Deskribapen laburtuta"
            Me.lbl_DescripcionNOABRE.Text = "Deskribapen luzea"
            Me.txt_descripcionAbreEus.Visible = True
            Me.txt_descripcionNoAbreEus.Visible = True
            euskera = True
        ElseIf euskera Then
            btn_euskera.Text = "*Euskera"
            Me.lbl_DescripcionNOABRE.Visible = True
            Me.lbl_descripcionAbre.Visible = True
            Me.lbl_descripcionAbre.Text = "Descripcion abreviada"
            Me.lbl_DescripcionNOABRE.Text = "Descripcion extensa"
            Me.txt_descripcionAbreEus.Visible = False
            Me.txt_descripcionNoAbreEus.Visible = False
            euskera = False
        End If


    End Sub
    Private Sub cmb_CodPostal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CodPostal.SelectedIndexChanged

    End Sub

    Private Sub cmb_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Municipio.SelectedIndexChanged
        cargarCmbCodpostalVISTA()
    End Sub

    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        cargarCmbMunicipioVISTA()
    End Sub
End Class