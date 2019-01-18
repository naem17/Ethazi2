Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Administrador
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MenuStrip1.ForeColor = Drawing.Color.Blue
        sql = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DESCRIPCION_ABREVIADA` AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, A.`DESCRIPCION_ABREVIADA_EUSKERA` AS `DESCRIPCION ABREVIADA EUSKERA`, A.`DESCRIPCION` AS `DESCRIPCION`, A.`DESCRIPCION_EUSKERA` AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
        cargar(sql)
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        PrimeraPageInsert.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
      
    End Sub


    Private Sub ActulizarBBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActulizarBBDDToolStripMenuItem.Click
        sql = "SELECT A.`FIRMA`, A.`NOMBRE`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA`, A.`TIENDA`, A.`CAPACIDAD`, A.`GASTRONOMICO`, A.`SURFING`, A.`COORDENADAS`, A.`CODIGO_TIPOS` AS `CODIGO TIPOS`, A.`CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, A.`CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`, CONCAT(SUBSTRING(A.`DESCRIPCION_ABREVIADA_EUSKERA`, 1, 50),'...') AS `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`TELEFONO`, A.`DIRECCION`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`EMAIL`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, M.`MUNICIPIO`, P.`PROVINCUA` AS `PROVINCIA`, R.`CODIGO_POSTAL` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P WHERE A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
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