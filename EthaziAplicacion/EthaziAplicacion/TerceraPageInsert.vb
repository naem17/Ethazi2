Public Class TerceraPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        CuartaPageInsert.Show()
        Me.Hide()

    End Sub

    Private Sub cmb_Tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Tipo.SelectedIndexChanged

    End Sub

    Private Sub TerceraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

        cargarCmbTipo()
        cargarCmbCategorias()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        SegundaPageInsert.Show()
    End Sub
End Class