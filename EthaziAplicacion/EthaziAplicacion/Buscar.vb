Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim sql As String
    Dim sql2 As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox(Me.txt_Nombre.Text)
        Dim campos As String
        campos = ""
        sql2 = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        sql2 &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M,"
        sql2 &= " PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO "
        sql2 &= "AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO "
        Dim sqlFinal As String = " ORDER BY A.NOMBRE"
        Dim alojamiento As New ArrayList
        alojamiento = cogerIdAlojamientos()
        If Not Me.cmb_provincia.Text = "-Todas-" Then
            sql2 &= "AND nombre LIKE '" & Me.txt_Nombre.Text & "%'"
            sql2 &= " AND id_relaciones IN ("
            For Each item In alojamiento
                sql2 &= item & ","
            Next
            sql2 = sql2.Substring(0, sql2.Length - 1)
            sql2 &= ")"
            If Me.txt_capacidad.Text <> "" Then
                MsgBox("He entrado en el if de capacidad")
                sql2 &= " AND capacidad >=" & Me.txt_capacidad.Text
            End If
            If Me.cmb_tipo.Text <> "-Todas-" Then
                sql2 &= " AND codigo_tipos=" & cogerTipo()
            End If
        Else
            sql2 &= "AND nombre LIKE '" & Me.txt_Nombre.Text & "%'"

            If Me.txt_capacidad.Text <> "" Then
                MsgBox("He entrado en el if de capacidad2")
                sql2 &= " AND capacidad >=" & Me.txt_capacidad.Text
            End If
            If Me.cmb_tipo.Text <> "-Todas-" Then
                sql2 &= " AND codigo_tipos=" & cogerTipo()
            End If
        End If
        sql2 &= " ORDER BY A.NOMBRE"
        MsgBox(sql2)
        MsgBox("sa gs")
        '----------------------------------------------------------------------------------------------------------------------
        cargar(sql2)
    End Sub

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cargarCmbProvincia2()
        cargarCmbTipo2()
        Me.cmb_provincia.SelectedIndex = 0
        Me.cmb_tipo.SelectedIndex = 0
        sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        cargar(sql)

    End Sub

    Private Sub txt_capacidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_capacidad.KeyPress
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmb_provincia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_provincia.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmb_tipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_tipo.KeyPress
        e.Handled = True
    End Sub
End Class