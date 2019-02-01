Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class Vista
    Dim hexColor As Color
    Dim misDatos(17) As String
    Dim sql As String
    Dim id As String
    Dim euskera As Boolean
    Dim guardar As Boolean
    Dim cp As String
    Public idRelaciones As Integer
    Dim prueba As String
    Dim codigo_muni As Integer
    Dim tipo, cat, tipoEus As String
    Private editable As Boolean = True
    Public Sub datosACargar(firma As String)
        id = firma
        conectar()
        Dim sql As String
        sql = "SELECT * FROM ALOJAMIENTOS WHERE FIRMA = '" & firma & "'"
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
            '-----------------------TIPOS---------------------------
            If IsDBNull(datos(19)) Then
                Me.cmb_Tipo.Text = ""
            Else
                tipo = datos(19)
                Select Case datos(19)
                    Case 1
                        Me.cmb_Tipo.Text = "Albergues"
                    Case 2
                        Me.cmb_Tipo.Text = "Campings"
                    Case 3
                        Me.cmb_Tipo.Text = "Agroturismos"
                    Case 4
                        Me.cmb_Tipo.Text = "Casas Rurales"
                End Select
                tipoEus = datos(19)
                Select Case datos(19)
                    Case 1
                        Me.cmb_tiposEuskera.Text = "Aterpetxeak"
                    Case 2
                        Me.cmb_tiposEuskera.Text = "Kanpinak"
                    Case 3
                        Me.cmb_tiposEuskera.Text = "Nekazaritza-turismoak"
                    Case 4
                        Me.cmb_tiposEuskera.Text = "Landetxeak"
                End Select

            End If
            '-------------------------CATEGORAIS-------------------------
            If IsDBNull(datos(21)) Then
                Me.cmb_Tipo.Text = ""
            Else
                cat = datos(21)
                Select Case datos(21)
                    Case 1
                        Me.cmb_Categoria.Text = "S"
                    Case 2
                        Me.cmb_Categoria.Text = "T"
                    Case 3
                        Me.cmb_Categoria.Text = "P"
                End Select
            End If
            Sentencias.idRelaciones = datos(22)

        End While
        datos.Close()

        '-----------------------------CARGAR Tipos CMB--------------------------------------
        Dim sql2 As String
        sql2 = "SELECT CODIGO FROM TIPOS"
        Dim cmd2 As New MySqlCommand(sql2, conexion)
        Dim dr As MySqlDataReader
        dr = cmd2.ExecuteReader
        While dr.Read
            If dr.Item(0) = 1 Then
                Me.cmb_Tipo.Items.Add("Albergues")
            ElseIf dr.Item(0) = 2 Then
                Me.cmb_Tipo.Items.Add("Campings")
            ElseIf dr.Item(0) = 3 Then
                Me.cmb_Tipo.Items.Add("Agroturismos")
            ElseIf dr.Item(0) = 4 Then
                Me.cmb_Tipo.Items.Add("Casas Rurales")
            End If
        End While
        dr.Close()
        '----------------------------------------------CARGAR TIPOS EUSKERA---------------------
        Dim sql4 As String
        sql4 = "SELECT CODIGO FROM TIPOS_EUSKERA"
        Dim cmd4 As New MySqlCommand(sql4, conexion)
        Dim dr4 As MySqlDataReader
        dr4 = cmd4.ExecuteReader
        While dr4.Read
            If dr4.Item(0) = 1 Then
                Me.cmb_tiposEuskera.Items.Add("Aterpetxeak")
            ElseIf dr4.Item(0) = 2 Then
                Me.cmb_tiposEuskera.Items.Add("Kanpinak")
            ElseIf dr4.Item(0) = 3 Then
                Me.cmb_tiposEuskera.Items.Add("Nekazaritza-turismoak")
            ElseIf dr4.Item(0) = 4 Then
                Me.cmb_tiposEuskera.Items.Add("Landetxeak")
            End If

        End While
        dr4.Close()
        '-----------------------------CARGAR CATEGORIAS CMB--------------------------------------
        Dim sql3 As String
        sql3 = "SELECT CODIGO FROM CATEGORIAS"
        Dim cmd3 As New MySqlCommand(sql3, conexion)
        Dim dr1 As MySqlDataReader
        dr1 = cmd3.ExecuteReader
        While dr1.Read
            If dr1.Item(0) = 1 Then
                Me.cmb_Categoria.Items.Add("S")
            ElseIf dr1.Item(0) = 2 Then
                Me.cmb_Categoria.Items.Add("P")
            ElseIf dr1.Item(0) = 3 Then
                Me.cmb_Categoria.Items.Add("T")
            End If
        End While
        dr1.Close()
        '----------------------------------------------------------------------------------------

        desconectar()
    End Sub
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
            Me.cmb_tiposEuskera.Enabled = True
            cargarCmbProvinciaVISTA()
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
            Me.cmb_tiposEuskera.Enabled = False
            guardar = False
           
            
            If Not Me.cmb_Municipio.Text = "-Todos-" And Not Me.cmb_CodPostal.Text = "" Then
                actualizar()
            Else
                MsgBox("Nose puede actualizar municipio y codigo vacio")
            End If

        End If

    End Sub
    Public Sub actualizar()
        Dim codTipo As String = Nothing
        Dim codTipoEus As String = Nothing
        Dim codCat As String = Nothing
        conectar()

        Try
            sql = "UPDATE ALOJAMIENTOS SET NOMBRE=@nombre, DESCRIPCION_ABREVIADA=@desc_abre,DESCRIPCION_ABREVIADA_EUSKERA=@desc_abre_eus,DESCRIPCION=@desc,DESCRIPCION_EUSKERA=@desc_eus,TELEFONO=@phone,DIRECCION=@address,"
            sql &= "CALIDAD_ASEGURADA=@calidad,EMAIL=@mail,WEB=@web,CLUB=@club,RESTAURANTE=@restaurante,AUTOCARAVANA=@caravana,TIENDA=@shop,CAPACIDAD=@capacidad,GASTRONOMICO=@gastro,SURFING=@surf,COORDENADAS=@coordenadas,"
            sql &= "CODIGO_TIPOS=@cTipos,CODIGO_TIPOS_EUSKERA=@cTiposEus,CODIGO_CATEGORIAS=@cCategorias,ID_RELACIONES=@idRelaciones"
            sql &= " where FIRMA=@firma"
            Dim cmd1 = New MySqlCommand(sql, conexion)
            cmd1.Parameters.AddWithValue("@firma", Me.txt_Firma.Text)
            cmd1.Parameters.AddWithValue("@nombre", Me.txt_Nombre.Text)
            cmd1.Parameters.AddWithValue("@desc_abre", Me.txt_descripcionAbre.Text)
            cmd1.Parameters.AddWithValue("@desc_abre_eus", Me.txt_descripcionAbreEus.Text)
            cmd1.Parameters.AddWithValue("@desc", Me.txt_descripcionNOabre.Text)
            cmd1.Parameters.AddWithValue("@desc_eus", Me.txt_descripcionNoAbreEus.Text) 'Hacer otro form
            cmd1.Parameters.AddWithValue("@phone", Me.txt_Telefono.Text)
            cmd1.Parameters.AddWithValue("@address", Me.txt_Direccion.Text) ' ver como sería
            If CuartaPageInsert.ckb_Calidad.Checked Then
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
                cmd1.Parameters.AddWithValue("@caravana", 1)
            Else
                cmd1.Parameters.AddWithValue("@caravana", 0)
            End If
            If CuartaPageInsert.ckb_Tienda.Checked Then
                cmd1.Parameters.AddWithValue("@shop", 1)
            Else
                cmd1.Parameters.AddWithValue("@shop", 0)
            End If
            cmd1.Parameters.AddWithValue("@capacidad", Me.txt_Capacidad.Text)
            If CuartaPageInsert.ckb_Gastronomico.Checked Then
                cmd1.Parameters.AddWithValue("@gastro", 1)
            Else
                cmd1.Parameters.AddWithValue("@gastro", 0)
            End If
            If CuartaPageInsert.ckb_Surfing.Checked Then
                cmd1.Parameters.AddWithValue("@surf", 1)
            Else
                cmd1.Parameters.AddWithValue("@surf", 0)
            End If
            cmd1.Parameters.AddWithValue("@coordenadas", Me.txt_Coordenadas.Text)
            Select Case Me.cmb_Tipo.Text
                Case "Albergues"
                    codTipo = 1
                Case "Campings"
                    codTipo = 2
                Case "Agroturismos"
                    codTipo = 3
                Case "Casas Rurales"
                    codTipo = 4
            End Select

            cmd1.Parameters.AddWithValue("@cTipos", codTipo)
            Select Case Me.cmb_Tipo.Text
                Case "Aterpetxeak"
                    codTipoEus = 1
                Case "Kanpinak"
                    codTipoEus = 2
                Case "Nekazaritza-turismoak"
                    codTipoEus = 3
                Case "Landetxeak"
                    codTipoEus = 4
            End Select
            cmd1.Parameters.AddWithValue("@cTiposEus", codTipoEus)


            Select Case Me.cmb_Categoria.Text
                Case "S"
                    codCat = 1
                Case "P"
                    codCat = 2
                Case "T"
                    codCat = 3
            End Select
            cmd1.Parameters.AddWithValue("@cCategorias", codCat)
            cmd1.Parameters.AddWithValue("@idRelaciones", cargarIdvista())

            cmd1.ExecuteNonQuery() ' devulve el numero de filas

            sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
            sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
            Sentencias.cargar(sql)
        Catch ex As Exception
            MsgBox("ERROR")
            MsgBox(ex.Message)

        End Try
        desconectar()

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pb_Restablecer.Click
        If editable Then
            datosACargar(id)
        Else
            Administrador.Show()
            Me.Close()
        End If

    End Sub
    Private Sub Vista_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Administrador.Show()
    End Sub
    Private Sub Vista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_descripcionNOabre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
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
        Me.cmb_tiposEuskera.Enabled = False
        Me.cmb_tiposEuskera.Visible = False
        guardar = False
        cargarProvinciaIdVISTA()
        cargarMunicipioIDVISTA()
        cargarCodPostalIDVISTA()
        'Me.cmb_Categoria.SelectedIndex = 0
        Select Case tipo
            Case 1
                Me.cmb_Tipo.Text = "Albergues"
            Case 2
                Me.cmb_Tipo.Text = "Campings"
            Case 3
                Me.cmb_Tipo.Text = "Agroturismos"
            Case 4
                Me.cmb_Tipo.Text = "Casas Rurales"
        End Select
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Select Case tipoEus
            Case 1
                Me.cmb_tiposEuskera.Text = "Aterpetxeak"
            Case 2
                Me.cmb_tiposEuskera.Text = "Kanpinak"
            Case 3
                Me.cmb_tiposEuskera.Text = "Nekazaritza-turismoak"
            Case 4
                Me.cmb_tiposEuskera.Text = "Landetxeak"
        End Select
        Me.cmb_tiposEuskera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Select Case cat
            Case 1
                Me.cmb_Categoria.Text = "S"
            Case 2
                Me.cmb_Categoria.Text = "T"
            Case 3
                Me.cmb_Categoria.Text = "P"
        End Select

        Me.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList


    End Sub
    Private Sub btn_euskera_Click(sender As Object, e As EventArgs) Handles btn_euskera.Click
        If Not euskera Then
            btn_euskera.Text = "*Español"
            Me.lbl_descripcionAbre.Text = "Deskribapen laburtuta"
            Me.lbl_DescripcionNOABRE.Text = "Deskribapen luzea"
            hexColor = ColorTranslator.FromHtml("#BDF8FF")
            Me.txt_descripcionAbreEus.BackColor = hexColor
            Me.txt_descripcionNoAbreEus.BackColor = hexColor
            Me.cmb_tiposEuskera.BackColor = hexColor
            Me.lbl_Firma.Text = "Sinadura:"
            Me.lbl_Nombre.Text = "Izena:"
            Me.lbl_Direccion.Text = "Helbidea:"
            Me.lbl_Telefono.Text = "Telefonoa:"
            Me.lbl_Municipio.Text = "Udalerri:"
            Me.lbl_Provincia.Text = "Probintzia:"
            Me.lbl_Codpostal.Text = "Posta Kodea:"
            Me.lbl_Coordenadas.Text = "Kodeernatuak:"
            Me.lbl_Tipo.Text = "Mota:"
            Me.lbl_Capacidad.Text = "Edukiera:"
            Me.lbl_Categoria.Text = "Kategoriak:"
            Me.ckb_calidad.Text = "Kalitatea"
            Me.ckb_Gastro.Text = "Gastronomiko"
            Me.ckb_Autocaravana.Text = "Autokarabana"
            Me.ckb_Tienda.Text = "Denda"
            Me.txt_descripcionAbreEus.Visible = True
            Me.txt_descripcionNoAbreEus.Visible = True
            Me.cmb_Tipo.Visible = False
            Me.cmb_tiposEuskera.Visible = True
            euskera = True
        ElseIf euskera Then
            btn_euskera.Text = "*Euskera"
            Me.lbl_descripcionAbre.Text = "Descripcion abreviada"
            Me.lbl_DescripcionNOABRE.Text = "Descripcion extensa"
            Me.lbl_Firma.Text = "Firma:"
            Me.lbl_Nombre.Text = "Nombre:"
            Me.lbl_Direccion.Text = "Direccion:"
            Me.lbl_Telefono.Text = "Telefono:"
            Me.lbl_Municipio.Text = "Municipio:"
            Me.lbl_Provincia.Text = "Provincia:"
            Me.lbl_Codpostal.Text = "Cod.Postal:"
            Me.lbl_Coordenadas.Text = "Coordenadas:"
            Me.lbl_Capacidad.Text = "Capacidad:"
            Me.lbl_Tipo.Text = "Tipo:"
            Me.lbl_Categoria.Text = "Categoria:"
            Me.ckb_calidad.Text = "Calidad"
            Me.ckb_Gastro.Text = "Gastronomico"
            Me.ckb_Autocaravana.Text = "Autocarabana"
            Me.ckb_Tienda.Text = "Tienda"
            Me.txt_descripcionAbreEus.Visible = False
            Me.txt_descripcionNoAbreEus.Visible = False
            Me.cmb_Tipo.Visible = True
            Me.cmb_tiposEuskera.Visible = False

            euskera = False
        End If
    End Sub
    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        Me.cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CodPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmb_Municipio.Text = "-Todos-"
        cmb_CodPostal.Text = ""
        cargarCmbMunicipioVISTA()
    End Sub
    Private Sub cmb_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Municipio.SelectedIndexChanged
        If cmb_Municipio.SelectedIndex = 0 Then
            cmb_CodPostal.Text = ""
        End If
        cargarCmbCodpostalVISTA()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Mapa.mostrarAlojamiento(Me.txt_Firma.Text)
        Mapa.ShowDialog()


    End Sub
    Public Sub mostrarInformeEspecifico(nombre As String)
        Dim oInforme As New CrystalReport2rpt
        ' establecer la fórmula de selección de registros
        oInforme.RecordSelectionFormula = "{ALOJAMIENTOS1.NOMBRE} = '" & nombre & "'"
        Informe.CrystalReportViewer1.ReportSource = oInforme
    End Sub
    Private Sub btn_reporte_Click(sender As Object, e As EventArgs) Handles btn_reporte.Click
        Me.mostrarInformeEspecifico(Me.txt_Nombre.Text)
        Informe.informeEspecifico = True
        Informe.ShowDialog()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Administrador.Show()
    End Sub
    Private Sub txt_Telefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono.KeyPress

        Me.txt_Telefono.MaxLength = 9
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")
        Else
            e.Handled = False
        End If
    End Sub
    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Sub txt_Email_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Email.KeyPress
        Dim sMail As String
        Dim mailCorrecto As Boolean
        sMail = Me.txt_Email.Text
        If Not validar_Mail(sMail) Or txt_Email.Text = "" Then
            PictureBox2.Visible = True
            mailCorrecto = False
        Else
            mailCorrecto = True
            PictureBox2.Visible = False
        End If
      
    End Sub
    Private Sub txt_Capacidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Capacidad.KeyPress
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar(Me.txt_Firma.Text)
        Me.Close()

        sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        Sentencias.cargar(sql)
        Administrador.Show()

    End Sub
    Private Sub txt_Web_TextChanged(sender As Object, e As EventArgs) Handles txt_Web.TextChanged
        Dim sWeb As String
        Dim webCorrecto As Boolean
        sWeb = Me.txt_Web.Text
        If Not validar_Web(sWeb) Then
            PictureBox3.Visible = True
            webCorrecto = False
        Else
            PictureBox3.Visible = False
            webCorrecto = True
        End If
    End Sub
    Private Function validar_Web(ByVal sWeb As String) As Boolean
        Dim valido As Boolean
        ' retorna true o false   
        Dim web() As String
        If txt_Web.Text.Contains(".") Then
            web = Split(txt_Web.Text, ".")
            If web(1) <> "" Then
                If web.Length > 1 Then
                    valido = True
                Else
                    valido = False
                End If

            End If
        End If


        Return valido
    End Function
End Class