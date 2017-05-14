Public Class summary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Payroll.NumberProcessed
        TextBox2.Text = Payroll.TotalOvertimeHours
        TextBox3.Text = Payroll.TotalPay.ToString("C")

    End Sub
End Class