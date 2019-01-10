Imports MySql.Data.MySqlClient
Public Class BarraSuperior
    Inherits System.Web.UI.Page
    Dim cnn1 = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim cmd1 = New MySqlCommand
            Dim tablas = New DataTable

            If (cnn1.State = ConnectionState.Closed) Then
                cnn1.Open()
            End If

            cmd1.Connection = cnn1
            cmd1.CommandText = "SELECT DISTINCT TABLE_NAME " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_SCHEMA ='labetxe'"
            Dim das1 As MySqlDataReader
            das1 = cmd1.ExecuteReader()

        Catch ex As MySqlException
            MsgBox("Error1: " & ex.Message)
        Finally
            cnn1.Close()
        End Try
    End Sub

    Protected Sub Update_btn_CheckedChanged(sender As Object, e As EventArgs) Handles Update_Rbtn.CheckedChanged

    End Sub

    'SELECT DISTINCT TABLE_NAME 
    'FROM INFORMATION_SCHEMA.COLUMNS
    'WHERE TABLE_SCHEMA ='labetxe';

    'SELECT COUNT(*) AS ColumnCount FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'alojamientos'
End Class