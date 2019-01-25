Public Class PrimeraPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        If Me.txt_Firma.Text = "" Or Me.txt_Email.Text = "" Then
            PictureBox1.Visible = True
            PictureBox2.Visible = True
        Else
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            Me.Hide()
            SegundaPageInsert.ShowDialog()
            Me.Hide()

        End If
    End Sub

    Private Sub PrimeraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Administrador.Show()
    End Sub
End Class