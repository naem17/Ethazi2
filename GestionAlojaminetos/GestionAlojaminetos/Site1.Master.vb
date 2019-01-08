Imports MySql.Data.MySqlClient
Public Class Site1
    Inherits System.Web.UI.MasterPage
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

End Class