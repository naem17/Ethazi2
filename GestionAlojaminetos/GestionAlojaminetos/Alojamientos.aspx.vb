Public Class Alojamientos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Response.Redirect("VerSeleccion.aspx?" & Me.GridView1.SelectedRow.Cells(1).Text & "-Alojamientos")
    End Sub
End Class