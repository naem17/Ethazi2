'Imports MySql.Data.MySqlClient
Public Class Alojamientos
    Inherits System.Web.UI.Page
    'Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If cnn1.State = ConnectionState.Closed Then
        '    cnn1.Open()
        'End If
        'Dim cmd1 = cnn1.CreateCommand()
        'cmd1.CommandText = "SELECT `FIRMA`, `NOMBRE`, CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA, 1, 50),'...')" +
        '    " AS `DESCRIPCION ABREVIADA`, `TIENDA`,`ID_RELACIONES` AS `ID RELACIONES`, `CAPACIDAD`, " +
        '    "`GASTRONOMICO`, `SURFING`, `COORDENADAS`, `CODIGO_TIPOS` AS `CODIGO TIPOS`," +
        '    " `CODIGO_TIPOS_EUSKERA` AS `CODIGOS TIPOS EUSKERA`, `CODIGO_CATEGORIAS` AS `CODIGO CATEGORIAS`," +
        '    " CONCAT(SUBSTRING(DESCRIPCION_ABREVIADA_EUSKERA, 1, 50),'...') AS" +
        '    " `DESCRIPCION ABREVIADA EUSKERA`, CONCAT(SUBSTRING(DESCRIPCION, 1, 50),'...')" +
        '    " AS `DESCRIPCION`, CONCAT(SUBSTRING(DESCRIPCION_EUSKERA, 1, 50),'...') AS" +
        '    " `DESCRIPCION EUSKERA`, `TELEFONO`, `DIRECCION`, `CALIDAD_ASEGURADA` AS `CALIDAD ASEGURADA`," +
        '    " `EMAIL`, `CLUB`, `RESTAURANTE`, `AUTOCARAVANA` FROM `alojamientos` ORDER BY `NOMBRE`"
        'MsgBox(cmd1.CommandText)
        'Dim da1 As New MySqlDataAdapter
        'da1.SelectCommand = cmd1
        'Dim dt As New DataTable
        'da1.Fill(dt)
        'Me.GridView1.DataSource = dt
        'Me.GridView1.DataBind()
        'Me.GridView1.AllowPaging = True
        'Me.GridView1.AllowSorting = True
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Response.Redirect("VerSeleccion.aspx?" & Me.GridView1.SelectedRow.Cells(1).Text)
    End Sub
End Class