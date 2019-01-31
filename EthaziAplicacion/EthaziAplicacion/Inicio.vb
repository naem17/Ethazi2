Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Security.Cryptography

Public Class Inicio
    Dim sql As String
    Dim PasConMD5 As String
    Dim result As Integer
    Dim ojito As Boolean = True

    Private Sub Button2_Click(sendeingr As Object, e As EventArgs) Handles Button2.Click
        conectar()
        MD5EncryptPass(Me.txt_password.Text)
        '   sql = "SELECT nombre_usuario,contrasenia from usuarios where perfil='A' or perfil='P'"
        sql = "SELECT nombre_usuario,contrasenia,perfil from USUARIOS where nombre_usuario=@nombre AND contrasenia=@pass"
        Dim cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader = Nothing
        Dim respuesta As String = Nothing
        cmd1.Parameters.AddWithValue("@nombre", Me.txt_usuario.Text)
        cmd1.Parameters.AddWithValue("@pass", PasConMD5)
        Try
            dr = cmd1.ExecuteReader()
            While dr.Read
                If Me.txt_usuario.Text = dr.Item(0) And PasConMD5 = dr.Item(1) Then
                    If Not IsDBNull(dr.Item(2)) Or dr.Item(2).Equals("") Then
                        result = 1
                    End If

                End If
            End While
            If result = 1 Then
                dr.Close()
                Me.Hide()
                Administrador.ShowDialog()
            Else
                MsgBox("Usuario NO ACEPTADO")
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.txt_password.Text = ""
            Me.txt_usuario.Text = ""
            Me.txt_usuario.Focus()
            PictureBox2.Image = My.Resources.ocultar
            Me.txt_password.PasswordChar = "*"
        End Try

        desconectar()

    End Sub

    Private Sub lnk_registrar_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Registro.ShowDialog()
    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        form_center(Me)
        conectar()
    End Sub
    Public Sub form_center(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not parent Is Nothing Then
            r = parent.ClientRectangle
            x = r.Width - frm.Width + parent.Left
            y = r.Height - frm.Height + parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - frm.Width
            y = r.Height - frm.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(x, y)
    End Sub
    Private Sub MD5EncryptPass(ByVal StrPass As String)

        PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ojito Then
            PictureBox2.Image = My.Resources.ver
            Me.txt_password.PasswordChar = ""
            ojito = False
        Else
            PictureBox2.Image = My.Resources.ocultar
            Me.txt_password.PasswordChar = "*"
            ojito = True
        End If
    End Sub
End Class