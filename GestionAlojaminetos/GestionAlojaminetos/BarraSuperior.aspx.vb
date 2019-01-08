Imports MySql.Data.MySqlClient
Public Class BarraSuperior
    Inherits System.Web.UI.Page
    Dim cnn1 = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim cmd1 = New MySqlCommand
            Dim tablas = New DataTable
            Dim adp = New MySqlDataAdapter

            If (cnn1.State = ConnectionState.Closed) Then
                cnn1.Open()
            End If

            cmd1.Connection = cnn1
            cmd1.CommandText = "SELECT DISTINCT TABLE_NAME " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_SCHEMA ='labetxe'"

            adp.SelectCommand = cmd1
            Dim reader = cmd1.ExecuteReader

            'adapter.Fill(dt)
            tablas.Load(reader)

        Catch ex As MySqlException
            MsgBox("Error1: " & ex.Message)
        Finally
            cnn1.Close()
        End Try
    End Sub

    'SELECT DISTINCT TABLE_NAME 
    'FROM INFORMATION_SCHEMA.COLUMNS
    'WHERE TABLE_SCHEMA ='labetxe';

End Class