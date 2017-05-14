'Dupuytren Derbey D'Haiti
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student1 As Student = New Student(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        student1.calculateClassStanding()
        Label5.Text = student1.standing
    End Sub
End Class
