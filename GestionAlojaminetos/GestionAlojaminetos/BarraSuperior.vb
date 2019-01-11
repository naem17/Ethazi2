Imports MySql.Data.MySqlClient
Public Class BarraSuperior
    Dim cnn1 = Site1.cnn1
    Public Sub CargarBarra()
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

            While (das1.HasRows)
                Dim ButtonChange = New Button()

                ButtonChange.Text = das1.GetString(0)
                ButtonChange.ID = "change_" + das1.ToString()

            End While
        Catch ex As MySqlException
            MsgBox("Error1: " & ex.Message)
        Finally
            cnn1.Close()
        End Try
    End Sub
End Class
