Public Class Guest
    Private Shared ourOneFormInstance As Guest

    Public Shared ReadOnly Property Instance() As Guest
        Get
            If ourOneFormInstance Is Nothing Then
                ourOneFormInstance = New Guest
            End If
            Return ourOneFormInstance
        End Get

    End Property
    Private Sub Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ourOneFormInstance = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ourOneFormInstance.Close()
    End Sub
End Class