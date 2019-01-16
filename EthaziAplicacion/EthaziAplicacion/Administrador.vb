Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Administrador
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MenuStrip1.ForeColor = Drawing.Color.Blue
        sql = "Select * from Alojamientos"
        cargar(sql)
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        PrimeraPageInsert.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
      
    End Sub


    Private Sub ActulizarBBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActulizarBBDDToolStripMenuItem.Click
        sql = "Select * from Alojamientos"
        cargar(sql)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        eliminar()

    End Sub

    
    Private Sub DataGridView1_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
        Dim misdatos(17) As String
        Dim mifila As Integer
        Dim firma As String
        mifila = DataGridView1.CurrentRow.Index
        'Recorremos todas las columnas de la fila seleccionada en busca de un valor nulo

        firma = DataGridView1.Item(0, mifila).Value



        Vista.datosACargar(firma)
        Vista.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        exEnXML()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Me.Hide()
        Buscar.Show()

    End Sub
End Class