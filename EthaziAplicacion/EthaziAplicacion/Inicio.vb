Imports MySql.Data.MySqlClient
Public Class Inicio
    Dim sql As String
    Dim cmd1
    Dim result As Integer

    Private Sub Button2_Click(sendeingr As Object, e As EventArgs) Handles Button2.Click
        sql = "SELECT nombre_usuario,contrasenia from usuarios where perfil='A' or perfil='P'"
        cmd1 = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader = Nothing
        Dim respuesta As String = Nothing
        Try
            dr = cmd1.ExecuteReader()
            While dr.Read
                If Me.txt_usuario.Text = dr.Item(0).ToString And Me.txt_password.Text = dr.Item(1).ToString Then
                    result = 1
                End If
            End While
            If result = 1 Then
                dr.Close()
                MsgBox("Administrador ACEPTADO")
                Me.Hide()
                Administrador.ShowDialog()
            Else
                MsgBox("ERROR")
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try


    End Sub

    Private Sub lnk_registrar_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk_registrar.LinkClicked
        Me.Hide()
        Registro.ShowDialog()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        Me.txt_password.PasswordChar = "*"
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar()
    End Sub
End Class