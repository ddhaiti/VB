Public Class Room
    Private Shared ourOneFormInstance As Room

    Public Shared ReadOnly Property Instance() As Room
        Get
            If ourOneFormInstance Is Nothing Then
                ourOneFormInstance = New Room
            End If
            Return ourOneFormInstance
        End Get

    End Property
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Room_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ourOneFormInstance = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ourOneFormInstance.Close()
    End Sub
End Class