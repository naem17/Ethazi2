Imports MySql.Data.MySqlClient
Public Class Indice
    Inherits System.Web.UI.Page

    Dim cnstring As String = "Data Source=localhost;Database=labetxe;Uid=root;Pwd=;"
    Dim cnn1 As New MySqlConnection(cnstring)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar con la BBDD")
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
            cmd1.Parameters.AddWithValue("@pass", Me.Login1.Password)
            Dim das1 As MySqlDataReader
            das1 = cmd1.ExecuteReader()
            If das1.HasRows() Then
                Response.Redirect("Bienvenida.aspx")
                Dim x As LoginName
                x = Master.FindControl("NombreDeUsuario")
                x. = "IBON"
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception
            If cnn1.State = ConnectionState.Open Then
                cnn1.Close()
            End If
        End Try
    End Sub
End Class