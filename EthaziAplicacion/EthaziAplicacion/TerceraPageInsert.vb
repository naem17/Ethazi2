Public Class TerceraPageInsert

    Dim euskera As Boolean

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        MsgBox(Me.cmb_Tipo.SelectedItem)
        MsgBox(cmb_Tipo.Text)
        CuartaPageInsert.Show()
        Me.Hide()
    End Sub

    Private Sub TerceraPageInsert_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()
        Administrador.Show()
    End Sub

    Private Sub TerceraPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Inicio.form_center(Me)
        Me.txt_descripcionAbreEus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        conectar()
        cargarCmbTipo()
        cargarCmbCategorias()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        SegundaPageInsert.Show()
    End Sub
    Private Sub txt_Capacidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Capacidad.KeyPress
        If (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 90) Or (Asc(e.KeyChar) > 97 And Asc(e.KeyChar) < 122) Then
            e.Handled = True
            MsgBox("Este campo es solo numerico")
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub btn_Euskera_Click(sender As Object, e As EventArgs) Handles btn_Euskera.Click
        If Not euskera Then
            btn_Euskera.Text = "*Español"
            Me.lbl_DescripcionAbre.Text = "Deskribapen laburtuta"
            Me.lbl_DescripcionNOABRE.Text = "Deskribapen luzea"
            Me.lbl_Tipo.Text = "Mota:"
            Me.lbl_Capacidad.Text = "Edukiera:"
            Me.lbl_Categoria.Text = "Kategoriak:"
            Me.txt_descripcionAbreEus.Visible = False
            Me.txt_descripcionNoAbreEus.Visible = False
            euskera = True
        ElseIf euskera Then
            btn_Euskera.Text = "*Euskera"
            Me.lbl_DescripcionAbre.Text = "Descripcion abreviada"
            Me.lbl_DescripcionNOABRE.Text = "Descripcion extensa"
            Me.lbl_Capacidad.Text = "Capacidad:"
            Me.lbl_Tipo.Text = "Tipo:"
            Me.lbl_Categoria.Text = "Categoria:"
            Me.txt_descripcionAbreEus.Visible = True
            Me.txt_descripcionNoAbreEus.Visible = True
            euskera = False
        End If
    End Sub
End Class