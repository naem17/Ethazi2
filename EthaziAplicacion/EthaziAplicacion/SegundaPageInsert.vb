Imports MySql.Data.MySqlClient
Public Class SegundaPageInsert

    Private Sub btn_Siguiente_Click(sender As Object, e As EventArgs) Handles btn_Siguiente.Click
        Dim provincia, municipio, codpostal As Boolean
     
        If cmb_Municipio.Text = "" Then
            PictureBox3.Visible = True
            municipio = False
        Else
            municipio = True
            PictureBox3.Visible = False
        End If
        MsgBox(cmb_CodPostal.Text)
        If cmb_CodPostal.Text = "" Then
            codpostal = False
            PictureBox4.Visible = True
        Else
            codpostal = True
            PictureBox4.Visible = False
        End If
        If municipio And codpostal Then
            TerceraPageInsert.Show()
            Me.Hide()
        End If




    End Sub
    Dim cont As Integer
    Private Sub cmb_Provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Provincia.SelectedIndexChanged
        If cont > 1 Then
            cargarCmbMunicipio()
        End If
        cont += 1
    End Sub

    Private Sub SegundaPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.form_center(Me)
        conectar()
        cmb_CodPostal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmb_Municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cargarCmbProvincia()
        cargarCmbMunicipio()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PrimeraPageInsert.ShowDialog()
    End Sub

    Private Sub cmb_Municipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Municipio.SelectedIndexChanged

        If cont > 1 Then

            MsgBox(Me.cmb_Municipio.SelectedItem)

            cargarCmbCodpostal()
        End If
        cont += 1

    End Sub

    Private Sub cmb_CodPostal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CodPostal.SelectedIndexChanged

    End Sub
End Class