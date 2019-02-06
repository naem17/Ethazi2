Imports MySql.Data.MySqlClient
Public Class Site1
    Inherits System.Web.UI.MasterPage
    'Connection String localhost = User Id=root;Host=localhost;Database=labetxe
    'Connection String remota = User Id=gp2;Password=NuG7FqwibR1ZAuKy;Host=kasserver.synology.me;Port=3307;Database=reto_gp2;Persist Security Info=True
    Public Shared cnstring As String = "User Id=gp2;Password=NuG7FqwibR1ZAuKy;Host=kasserver.synology.me;Port=3307;Database=reto_gp2;Persist Security Info=True"
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