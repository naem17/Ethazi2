﻿Imports MySql.Data.MySqlClient
Public Class SegundaPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        TerceraPageInsert.Show()
        Me.Hide()


    End Sub
    Dim cont As Integer
    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        If cont > 1 Then
            MsgBox(Me.cmb_Provincia.SelectedValue.ToString)
            cargarCmbMunicipio()
        End If
        cont += 1
    End Sub

    Private Sub SegundaPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        cargarCmbProvincia()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PrimeraPageInsert.ShowDialog()
    End Sub

    Private Sub cmb_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Municipio.SelectedIndexChanged
        'cont = 0
        If cont > 1 Then

            MsgBox(Me.cmb_Municipio.SelectedItem)

            cargarCmbCodpostal()
        End If
        cont += 1

    End Sub

    Private Sub cmb_CodPostal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CodPostal.SelectedIndexChanged

    End Sub
End Class