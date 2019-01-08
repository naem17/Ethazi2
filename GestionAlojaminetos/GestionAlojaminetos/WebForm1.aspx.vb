Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim x As Label
        x = Master.FindControl("etiqueta1")
        x.Text = "IBON"
    End Sub

End Class