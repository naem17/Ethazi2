Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim sql As String
    Dim sql2 As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim nombre As String = Me.txt_Nombre.Text
        Dim provincia As Integer = Me.cmb_provincia.SelectedValue
        Dim capacidad As String = Me.txt_capacidad.Text
        Dim tipo As String = Me.txt_tipo.Text
    
        sql2 = "Select * from alojamientos where codigo_provincia=" & provincia & " or nombre='%" & nombre & "'"
        cargar(sql2)
    End Sub

    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarCmbProvincia2()
    End Sub

    Private Sub cmb_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_provincias.CheckedChanged
        If Not ckb_provincias.Checked = True Then
            Me.cmb_provincia.Visible = True
            Me.cmb_provincia.SelectedIndex = -1
        Else
            Me.cmb_provincia.Visible = False

        End If
    End Sub
End Class