Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class Informe
    Dim sql As String
    Dim das1 As New DataSet
    Dim adap1
    Public informeEspecifico As Boolean

    Private Sub Informe_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If informeEspecifico Then
            informeEspecifico = False
            Me.Close()

        Else
            Me.Close()
            Administrador.Show()
        End If
    End Sub
    Private Sub Informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar()
            sql = "Select nombre from alojamientos"
            Dim cmd1 As New MySqlCommand
            cmd1 = New MySqlCommand(sql, conexion)
            Dim dr As MySqlDataReader
            dr = cmd1.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr.Item(0))
            End While
            dr.Close()
            desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim oInforme As New CrystalReport2rpt

            ' establecer la fórmula de selección de registros
            oInforme.RecordSelectionFormula = "{ALOJAMIENTOS1.NOMBRE} = '" & Me.ComboBox1.Text & "'"
            Me.CrystalReportViewer1.ReportSource = oInforme
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        If informeEspecifico Then
            informeEspecifico = False
            Me.Close()

        Else
            Me.Close()
            Administrador.Show()
        End If
    End Sub
End Class