Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Application.Info.Title
        Label2.Text = My.Application.Info.Description
        Label3.Text = My.Application.Info.CompanyName
        Label4.Text = My.Application.Info.Copyright

    End Sub


End Class