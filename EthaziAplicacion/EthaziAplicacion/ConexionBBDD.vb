Imports MySql.Data.MySqlClient

Module ConexionBBDD
    Public cadenaconexion As String = "server=kasserver.synology.me;database=reto_gp2;user id=gp2;port=3307; password=NuG7FqwibR1ZAuKy;"
    ' Public cadenaconexion As String = "server=localhost;database=reto_gp2;user id=root; password=;"
    Friend conexion As New MySqlConnection(cadenaconexion)
    Public Sub conectar()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub desconectar()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
