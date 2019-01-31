Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class PrimeraPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click

        Dim sMail As String
        Dim mailCorrecto, firmaCorrecta, telCorrecto As Boolean
        sMail = Me.txt_Email.Text
        If Not validar_Mail(sMail) Or txt_Email.Text = "" Then
            PictureBox2.Visible = True
            mailCorrecto = False
        Else
            mailCorrecto = True
            PictureBox2.Visible = False
        End If
        '-------------------------------------------------------
        Dim sWeb As String
        Dim webCorrecto As Boolean
        sWeb = Me.txt_Web.Text
        If Not validar_Web(sWeb) Then
            PictureBox5.Visible = True
            webCorrecto = False
        Else
            PictureBox5.Visible = False
            webCorrecto = True
        End If
        '--------------------------------------------
        If txt_Telefono.Text.Length >= 9 Then
            PictureBox4.Visible = True
            telCorrecto = True
        Else
            PictureBox4.Visible = False
            telCorrecto = False
        End If
        '------------------------------------------------------
        If Me.txt_Firma.Text = "" Then
            firmaCorrecta = False
            PictureBox1.Visible = True
        Else
            firmaCorrecta = True
            PictureBox1.Visible = False
        End If
        If mailCorrecto And firmaCorrecta And telCorrecto Then
            Me.Hide()
            SegundaPageInsert.Show()

        End If

    End Sub

    Private Sub PrimeraPageInsert_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()
        Administrador.Show()

    End Sub

    Private Sub PrimeraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_Firma.MaxLength = 8
        Inicio.form_center(Me)
        conectar()
        Me.txt_Telefono.MaxLength = 9

        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Administrador.Show()
    End Sub

    Private Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Private Function validar_Web(ByVal sWeb As String) As Boolean
        Dim valido As Boolean
        ' retorna true o false   
        Dim web() As String
        If txt_Web.Text.Length Then
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

  
    Private Sub txt_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Telefono.KeyPress
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")

        Else

            e.Handled = False
        End If
    End Sub
  
End Class