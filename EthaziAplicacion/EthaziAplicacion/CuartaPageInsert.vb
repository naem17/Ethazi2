Imports System.Drawing

Public Class CuartaPageInsert
    Dim sql As String
    Private Sub btn_Finalizar_Click(sender As Object, e As EventArgs) Handles btn_Finalizar.Click
        insertar()
        Me.Hide()
        sql = "SELECT A.FIRMA, A.NOMBRE,A.EMAIL, T.TIPO AS 'TIPOS', TE.TIPO_EUSKERA AS 'TIPOS EUSKERA', C.CATEGORIA AS 'CATEGORIAS'"
        Sql &= ",A.TELEFONO, A.DIRECCION,M.MUNICIPIO, P.PROVINCUA AS 'PROVINCIA', R.CODIGO_POSTAL AS 'CODPOSTAL' FROM ALOJAMIENTOS A, RELACION_CP_MUNICIPIOS_PROVINCIAS R, MUNICIPIOS M,"
        Sql &= " PROVINCIAS P,TIPOS T,TIPOS_EUSKERA TE, CATEGORIAS C WHERE A.ID_RELACIONES = R.ID AND R.CODIGO_PROVINCIA = P.CODIGO AND R.INDICE_MUNICIPIO = M.INDICE AND A.CODIGO_TIPOS= T.CODIGO "
        Sql &= "AND A.CODIGO_TIPOS_EUSKERA=TE.CODIGO AND A.CODIGO_CATEGORIAS=C.CODIGO ORDER BY A.NOMBRE"
        cargar(Sql)
        Administrador.Show()
        PrimeraPageInsert.Close()
        SegundaPageInsert.Close()
        TerceraPageInsert.Close()
        Me.Close()
    End Sub

    Private Sub CuartaPageInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.form_center(Me)
        conectar()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        TerceraPageInsert.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ckb_Club_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Club.CheckedChanged

    End Sub

    Private Sub ckb_Restaurante_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Restaurante.CheckedChanged

    End Sub

    Private Sub ckb_Calidad_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Calidad.CheckedChanged

    End Sub

    Private Sub ckb_Tienda_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Tienda.CheckedChanged

    End Sub

    Private Sub ckb_Gastronomico_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Gastronomico.CheckedChanged

    End Sub

    Private Sub ckb_Autocaravana_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Autocaravana.CheckedChanged

    End Sub

    Private Sub ckb_Surfing_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_Surfing.CheckedChanged

    End Sub
End Class