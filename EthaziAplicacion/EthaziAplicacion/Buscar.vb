Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim sql As String
    Dim sql2 As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Dim cont As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox(Me.txt_Nombre.Text)
        If Me.txt_Nombre.Text <> "" Then

            If Not Me.cmb_provincia.Text <> "-Todas-" Then
                sql2 = "SELECT * FROM alojamientos WHERE nombre LIKE '%" & Me.txt_Nombre.Text & "%' AND id_relaciones IN (SELECT id FROM relacion_cp_municipios_provincias)"
            Else
                sql2 = "SELECT * FROM alojamientos"
            End If
        End If

        'If capacidad <> "" Then
        '    sql2 &= "nombre like '" & nombre & "%' and codigo_tipos=" & cogerTipo() & " and id_relaciones=" & cogerIdAlojamientos()
        'Else
        '    sql2 &= "nombre like '" & nombre & "%' and capacidad = " & capacidad & " and codigo_tipos=" & cogerTipo() & " and id_relaciones=" & cogerIdAlojamientos()
        'End If
        'If ckb_tipos.Checked Then
        '    sql2 &= ""
        'Else
        '    sql2 &= "where codigo_tipos=" & cogerTipo()
        'End If
        'If ckb_provincias.Checked Then
        '    sql2 &= ""
        'Else
        '    sql2 &= "where id_relaciones=" & cogerIdAlojamientos()
        'End If
        MsgBox(sql2)
        '----------------------------------------------------------------------------------------------------------------------ç
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

    Private Sub cmb_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedIndexChanged
        If cont > 1 Then
            '  MsgBox(cmb_provincia.SelectedItem)

        End If
        cont += 1

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        MsgBox(Me.cmb_tipo.SelectedItem)
    End Sub

End Class