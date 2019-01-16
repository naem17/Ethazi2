Public Class Registro

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inicio.Show()
        Me.Hide()
        'Inicio.lbl_Inicio.Text = "¡BIENVENIDO!"
        'Inicio.lbl_Inicio.ForeColor = Drawing.Color.DarkRed

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.txt_Nickname.Text = " "
        Me.txt_Nombre.Text = " "
        Me.txt_Apellidos.Text = " "
        Me.txt_Contrasenya.Text = " "
        Me.txt_RepeContrasenya.Text = " "
        Me.txt_Email.Text = " "
        Me.txt_Telefono.Text = " "
    End Sub
End Class