Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class Administrador
    Dim sql As String
    Dim das1 As New DataSet 'copia de los datos 
    Dim adap1

   

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MenuStrip1.ForeColor = Drawing.Color.Blue
        'sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS',A.TELEFONO, A.DIRECCION,"
        'sql &= "M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL,A.COORDENADAS, A.CALIDAD_ASEGURADA AS 'CALIDAD', A.CLUB, A.TIENDA, A.CAPACIDAD,"
        'sql &= "A.GASTRONOMICO, A.SURFING,  A.RESTAURANTE, A.AUTOCARAVANA "
        'sql &= "FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C "
        'sql &= "WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE "
        'sql &= "AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        cargar(sql)
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarToolStripMenuItem.Click
        PrimeraPageInsert.Show()
        Me.Hide()
    End Sub
    Private Sub ActulizarBBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActulizarBBDDToolStripMenuItem.Click
        'sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS',A.TELEFONO, A.DIRECCION,"
        'sql &= "M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL,A.COORDENADAS, A.CALIDAD_ASEGURADA AS 'CALIDAD', A.CLUB, A.TIENDA, A.CAPACIDAD,"
        'sql &= "A.GASTRONOMICO, A.SURFING,  A.RESTAURANTE, A.AUTOCARAVANA "
        'sql &= "FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M, PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C "
        'sql &= "WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE "
        'sql &= "AND A.CODIGO_TIPOS= T.CODIGO AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M,"
        sql &= " PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO "
        sql &= "AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        cargar(sql)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        eliminar()
    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
        cargarProvinciaIdVISTA()
        cargarMunicipioIDVISTA()
        cargarCodPostalIDVISTA()
        Dim misdatos(17) As String
        Dim mifila As Integer
        Dim firma As String
        mifila = DataGridView1.CurrentRow.Index

        'Recorremos todas las columnas de la fila seleccionada en busca de un valor nulo
        firma = DataGridView1.Item(0, mifila).Value
        Vista.datosACargar(firma)
        Me.Close()
        Vista.Show()

    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
        exEnXML()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Me.Hide()
        Buscar.Show()

    End Sub

    Private Sub MAPAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAPAToolStripMenuItem.Click
        Me.Hide()
        Dim mifila As Integer
        Dim firma As String
        mifila = DataGridView1.CurrentRow.Index
        'Recorremos todas las columnas de la fila seleccionada en busca de un valor nulo
        firma = DataGridView1.Item(0, mifila).Value
        Mapa.mostrarAlojamiento(firma)
        Mapa.Show()

    End Sub

    Public Sub filtrar()

    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Informe.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        ConexionBBDD.desconectar()
        Inicio.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class