Imports MySql.Data.MySqlClient
Public Class Site1
    Inherits System.Web.UI.MasterPage
    Public Shared cnstring As String = "Data Source=localhost;Database=labetxe;Uid=root;Pwd=;"
    Public Shared cnn1 As New MySqlConnection(cnstring)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not (Session("User") = Nothing) Then
                lbl_User.Text = Session("User")
            End If
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

    Protected Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Session("User") = Nothing
        Response.Redirect("Loggin.aspx")
    End Sub
End Class