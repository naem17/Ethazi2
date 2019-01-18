Imports System.Drawing

Public Class CuartaPageInsert

    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click
        insertar()
    End Sub

    Private Sub CuartaPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        TerceraPageInsert.Show()
    End Sub
End Class