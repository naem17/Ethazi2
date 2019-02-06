Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Conexion

    Public Shared cadenaconexion As String = "Data Source=localhost;Database=labetxe;Uid=root;Pwd=;"

    Public Shared conection As New MySqlConnection(cadenaconexion)

    Public Shared Sub conectar()
        Try
            If conection.State = ConnectionState.Closed Then
                conection.Open()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If conection.State = ConnectionState.Open Then
                conection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
