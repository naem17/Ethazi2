Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class Indice
    Inherits System.Web.UI.Page

    Dim cnstring As String = "Data Source=localhost;Database=labetxe;Uid=root;Pwd=;"
    Dim cnn1 As New MySqlConnection(cnstring)
    Dim PasConMd5 As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar con la BBDD" & "     " & ex.Message)
            If cnn1.State = ConnectionState.Open Then
                cnn1.Close()
            End If
        End Try
    End Sub

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        Try
            Dim cmd1 = cnn1.CreateCommand()
            cmd1.CommandText = "SELECT NOMBRE_USUARIO, CONTRASENIA FROM USUARIOS 
            WHERE NOMBRE_USUARIO = @user AND CONTRASENIA = @pass"
            cmd1.Parameters.AddWithValue("@user", Me.Login1.UserName)
            Call MD5EncryptPass(Me.Login1.Password)
            cmd1.Parameters.AddWithValue("@pass", PasConMd5)
            Dim das1 As MySqlDataReader
            das1 = cmd1.ExecuteReader()
            If das1.HasRows() Then
                Response.Redirect("Bienvenida.aspx")
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception
            If cnn1.State = ConnectionState.Open Then
                cnn1.Close()
            End If
        End Try
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

        PasConMd5 = PasConMd5.ToLower()
    End Sub
End Class