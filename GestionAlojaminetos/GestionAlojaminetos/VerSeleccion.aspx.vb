﻿Imports MySql.Data.MySqlClient
Public Class VerSeleccion
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim datos() As String = Split(Request.QueryString().ToString(), "+")

        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        Dim cmd1 = cnn1.CreateCommand()
        datos(1) = datos(1).ToLower
        Dim sql As String
        sql = "SELECT * FROM " & datos(1).ToString
        Select Case datos(1)
            Case "alojamientos"
                cmd1.CommandText = sql & " WHERE FIRMA = @param"
            Case "categorias"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "codigos_postales"
                cmd1.CommandText = sql & " WHERE ID = @param"
            Case "municipios"
                cmd1.CommandText = sql & " WHERE INDICE = @param"
            Case "provincias"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "tipos"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case "tipos_euskera"
                cmd1.CommandText = sql & " WHERE CODIGO = @param"
            Case Else
                MsgBox("No se a creado select")
        End Select
        cmd1.Parameters.AddWithValue("@param", datos(0))
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
        Me.GridView1.DataSource = dt
        Me.GridView1.DataBind()
    End Sub
End Class