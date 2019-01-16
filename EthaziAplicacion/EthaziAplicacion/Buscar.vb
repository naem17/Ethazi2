Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim sql As String
    Dim sql2 As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Dim cont As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim nombre As String = Me.txt_Nombre.Text
        Dim capacidad As String = Me.txt_capacidad.Text
        If nombre <> "" Then
            sql2 = "Select * from alojamientos where capacidad = " & capacidad & " and id_relaciones=" & cogerIdAlojamientos() & " and codigo_tipos=" & cogerTipo()
        Else
            sql2 = "Select * from alojamientos where nombre like '" & nombre & "%' and capacidad = " & capacidad & " and codigo_tipos=" & cogerTipo()
        End If
        If capacidad <> "" Then
            sql2 = "Select * from alojamientos where nombre like '" & nombre & "%' and codigo_tipos=" & cogerTipo() & " and id_relaciones=" & cogerIdAlojamientos()
        Else
            sql2 = "Select * from alojamientos where nombre like '" & nombre & "%' and capacidad = " & capacidad & " and codigo_tipos=" & cogerTipo() & " and id_relaciones=" & cogerIdAlojamientos()
        End If
        If ckb_tipos.Checked Then
            sql2 = "Select * from alojamientos where nombre like '" & nombre & "%' and capacidad = " & capacidad & " and id_relaciones=" & cogerIdAlojamientos()
        Else
            sql2 = "Select * from alojamientos where codigo_tipos=" & cogerTipo()
        End If
        If ckb_provincias.Checked Then
            sql2 = "Select * from alojamientos where nombre like '" & nombre & "%' and capacidad = " & capacidad & " and codigo_tipos=" & cogerTipo()
        Else
            sql2 = "Select * from alojamientos where id_relaciones=" & cogerIdAlojamientos()
        End If

        cargar(sql2)
    End Sub

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarCmbProvincia2()
        cargarCmbTipo2()
        sql = "select * from alojamientos"
        cargar(sql)


    End Sub

    Private Sub cmb_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedIndexChanged
        If cont > 1 Then
            MsgBox(cmb_provincia.SelectedValue.ToString)

        End If
        cont += 1

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_provincias.CheckedChanged
        If Not ckb_provincias.Checked Then
            Me.cmb_provincia.Visible = True
            
        Else
            Me.cmb_provincia.Visible = False

        End If
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        MsgBox(Me.cmb_tipo.SelectedItem)
    End Sub

  
    Private Sub ckb_tipos_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_tipos.CheckedChanged
        If Not ckb_tipos.Checked Then
            Me.cmb_tipo.Visible = True

        Else
            Me.cmb_tipo.Visible = False

        End If
    End Sub
End Class