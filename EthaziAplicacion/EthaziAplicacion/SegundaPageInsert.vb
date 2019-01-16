Imports MySql.Data.MySqlClient
Public Class SegundaPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        TerceraPageInsert.Show()
        MsgBox(Me.cmb_Provincia.SelectedValue.ToString)
        MsgBox(Me.cmb_Municipio.SelectedValue.ToString)
        MsgBox(Me.cmb_CodPostal.SelectedValue.ToString)
        Me.Hide()


    End Sub
    Dim cont As Integer
    Dim kk As Boolean = False
    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged

        'Dim sql As String
        'Dim das1 As New DataSet 'copia de los datos 
        'Dim adap1
        'Dim tabla As New DataTable
        'Dim valor As Integer = Val(cmb_Provincia.SelectedValue.ToString())

        'sql = "Select municipio from municipio where codigo="
        'Dim cmd1 As New MySqlCommand
        'cmd1 = New MySqlCommand(sql, conexion)
        'adap1 = New MySqlDataAdapter(cmd1)
        'das1.Clear()

        'adap1.Fill(tabla)
        'Me.cmb_Provincia.DataSource = tabla
        'Me.cmb_Provincia.DisplayMember = "provincua"
        If cont > 2 Then
            cargarCmbMunicipio()
        End If
        If Not kk Then
            cmb_Provincia.Items.RemoveAt(0)
        End If
        MsgBox(cmb_Provincia.SelectedItem)
        kk = True
        cont += 1
    End Sub

    Private Sub SegundaPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        cargarCmbProvincia()

        'cargarCmbMunicipio()
        cargarCmbCodpostal()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PrimeraPageInsert.ShowDialog()
    End Sub
End Class