Public Class TerceraPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        CuartaPageInsert.Show()
        Me.Hide()

    End Sub



    Private Sub TerceraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.form_center(Me)
        conectar()
        cargarCmbTipo()
        cargarCmbCategorias()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SegundaPageInsert.Show()
    End Sub


    Private Sub txt_Capacidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Capacidad.KeyPress
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")
        Else
            e.Handled = False
        End If
    End Sub
End Class