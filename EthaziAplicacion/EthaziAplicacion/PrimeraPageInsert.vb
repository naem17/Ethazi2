Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PrimeraPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click

        Dim sMail As String
        Dim mailCorrecto, firmaCorrecta As Boolean
        sMail = Me.txt_Email.Text
        If Not validar_Mail(sMail) Or txt_Email.Text = "" Then
            PictureBox2.Visible = True
            mailCorrecto = False
        Else
            mailCorrecto = True
            PictureBox2.Visible = False
        End If

        '--------------------------------------------

        If Me.txt_Firma.Text = "" Then
            firmaCorrecta = False
            PictureBox1.Visible = True
        Else
            firmaCorrecta = True
            PictureBox1.Visible = False
        End If
        If mailCorrecto And firmaCorrecta Then
            Me.Hide()
            SegundaPageInsert.ShowDialog()

        End If

    End Sub

    Private Sub PrimeraPageInsert_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub PrimeraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.form_center(Me)
        conectar()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Administrador.Show()
    End Sub

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class