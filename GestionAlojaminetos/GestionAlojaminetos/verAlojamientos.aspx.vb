Imports MySql.Data.MySqlClient
Public Class verAlojamientos
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If cnn1.State = ConnectionState.Closed Then
                cnn1.Open()
            End If
            cargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message.ToString & ex.ToString)
        End Try
    End Sub

    Private Sub cargarDatos()
        Dim cmd1 = cnn1.CreateCommand
        If Session("select") = Nothing Then
            cmd1.CommandText = "SELECT A.`FIRMA`, A.`NOMBRE`, A.`DIRECCION`, A.`TELEFONO`, A.`EMAIL`, A.`WEB`, P.`PROVINCUA` AS `PROVINCIA`, M.`MUNICIPIO`, R.`CODIGO_POSTAL` AS `CODIGO POSTAL`, CONCAT(SUBSTRING(A.`DESCRIPCION`, 1, 50),'...') AS `DESCRIPCION`, CONCAT(SUBSTRING(A.`DESCRIPCION_EUSKERA`, 1, 50),'...') AS `DESCRIPCION EUSKERA`, A.`CAPACIDAD`, T.`TIPO`, Y.`TIPO_EUSKERA` AS `TIPO EUSKERA`, K.`CATEGORIA`, A.`COORDENADAS`, A.`CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`, A.`TIENDA`, A.`GASTRONOMICO`, A.`CLUB`, A.`RESTAURANTE`, A.`AUTOCARAVANA`, A.`SURFING` FROM `ALOJAMIENTOS` A, `RELACION_CP_MUNICIPIOS_PROVINCIAS` R, `MUNICIPIOS` M, `PROVINCIAS` P, `CATEGORIAS` K, `TIPOS` T, `TIPOS_EUSKERA` Y  WHERE A.`CODIGO_TIPOS` = T.`CODIGO` AND A.`CODIGO_TIPOS_EUSKERA` = Y.`CODIGO` AND A.`CODIGO_CATEGORIAS` = K.`CODIGO` AND A.`ID_RELACIONES` = R.`ID` AND R.`CODIGO_PROVINCIA` = P.`CODIGO` AND R.`INDICE_MUNICIPIO` = M.`INDICE` ORDER BY A.`NOMBRE`"
        Else
            cmd1.CommandText = Session("select")
        End If
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim ds As New DataSet
        ds.Clear()
        da1.Fill(ds, "alojamientos")
        lbl_Num.Text = ds.Tables("alojamientos").Rows.Count & " alojamientos encontrados"
        Me.GridView1.DataSource = ds.Tables("alojamientos")
        Me.GridView1.DataBind()
        Me.GridView1.AllowSorting = True
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("firma") = Me.GridView1.SelectedRow.Cells(1).Text
        Response.Redirect("VerSeleccion.aspx")
    End Sub

    Private Sub GridView1_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        Dim param As String = Me.GridView1.Rows(e.RowIndex).Cells(1).Text
        Dim alojamiento As String = Me.GridView1.Rows(e.RowIndex).Cells(2).Text
        If MsgBox("Quieres eliminar el alojamiento " & alojamiento & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cmd1 As MySqlCommand = cnn1.CreateCommand
            cmd1.CommandText = "DELETE FROM `ALOJAMIENTOS` WHERE `ALOJAMIENTOS`.`FIRMA` = @param"
            cmd1.Parameters.AddWithValue("@param", param)
            Dim dar1 As MySqlDataReader
            dar1 = cmd1.ExecuteReader()
            While dar1.Read
                MsgBox("Alojamiento " & alojamiento & " eliminado.")
            End While
            dar1.Close()
        End If
    End Sub
    Private Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs) Handles GridView1.RowEditing
        Response.Redirect("EditarPagina.aspx?" & Me.GridView1.Rows(e.NewEditIndex).Cells(1).Text)
    End Sub

    Protected Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Response.Redirect("insertarAlojamientos.aspx")
    End Sub

    Private Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        Dim newPageNumber As Integer = e.NewPageIndex + 1
        GridView1.PageIndex = e.NewPageIndex
        cargarDatos()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Session("sino") Then
            Me.GridView1.AllowPaging = False
            Me.Button1.Text = "Contraer"
            Session("sino") = False
        ElseIf Session("sino") = False Then
            Me.GridView1.AllowPaging = True
            Me.Button1.Text = "Ver Todos"
            Session("sino") = True
        End If

        cargarDatos()
    End Sub

    Protected Sub btn_Excel_Click(sender As Object, e As EventArgs) Handles btn_Excel.Click
        descargarInforme(Session("select"))
    End Sub

    Sub descargarInforme(ByVal sql As String)
        Dim htw As Html32TextWriter
        Me.GridView1.RenderControl(htw)
    End Sub

    Private Sub GenerateXLSXFile(tbl As DataTable)

        Dim excelPackage = New ExcelPackage

        Dim excelWorksheet = excelPackage.Workbook.Worksheets.Add("DemoPage")

        excelWorksheet.Cells("A1").LoadFromDataTable(tbl, True)

        Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        Response.AddHeader("content-disposition", "attachment;  filename=ExcelDemo.xlsx")
        Dim stream As New MemoryStream(excelPackage.GetAsByteArray())

        Response.OutputStream.Write(stream.ToArray(), 0, stream.ToArray().Length)

        Response.Flush()

        Response.Close()

    End Sub

    Private Function CreateDataTable() As DataTable

        Dim dataTable As New DataTable("DT")

        Dim cmd As New MySqlCommand(Session("select"), cnn1)

        Dim adaptor As New MySqlDataAdapter

        adaptor.SelectCommand = cmd
        adaptor.Fill(dataTable)

        Return dataTable
    End Function
End Class