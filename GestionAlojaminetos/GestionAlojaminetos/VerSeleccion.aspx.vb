Imports MySql.Data.MySqlClient
Public Class VerSeleccion
    Inherits System.Web.UI.Page
    Dim cnn1 As MySqlConnection = Site1.cnn1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim firma As String = Request.QueryString().ToString()
        If cnn1.State = ConnectionState.Closed Then
            cnn1.Open()
        End If
        Dim cmd1 = cnn1.CreateCommand()
        cmd1.CommandText = "SELECT * FROM alojamientos WHERE FIRMA = @firma"
        cmd1.Parameters.AddWithValue("@firma", firma)
        Dim da1 As New MySqlDataAdapter
        da1.SelectCommand = cmd1
        Dim dt As New DataTable
        da1.Fill(dt)
        Me.GridView1.DataSource = dt
        Me.GridView1.DataBind()
        Label1.Text = firma
    End Sub
End Class