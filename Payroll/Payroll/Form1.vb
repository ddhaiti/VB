'Dupuytren Derbey D'Haiti 

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a Payroll object to connect to the business tier.
        Dim HoursDecimal As Decimal
        Dim RateDecimal As Decimal

        ' Check for valid input data.
        ErrorProvider1.Clear()
        Decimal.TryParse(TextBox2.Text, HoursDecimal)
        If HoursDecimal > 0 Then
            Decimal.TryParse(TextBox3.Text, RateDecimal)
            If RateDecimal > 0 Then

                ' Both values converted successfully.
                Try
                    Dim APayroll As New Payroll(HoursDecimal, RateDecimal)
                    TextBox4.Text = APayroll.Pay.ToString("C")
                    Dim x As New summary()
                    x.Show()
                Catch Err As ApplicationException
                    ' Catch exceptions from the Payroll class.
                    Select Case Err.Source
                        Case "Hours"
                            ErrorProvider1.SetError(TextBox2,
                              Err.Message)
                            With TextBox2
                                .SelectAll()
                                .Focus()
                            End With
                        Case "Rate"
                            ErrorProvider1.SetError(TextBox3,
                              Err.Message)
                            With TextBox3
                                .SelectAll()
                                .Focus()
                            End With
                    End Select
                End Try
            Else
                ' Rate did not pass validation.
                ErrorProvider1.SetError(TextBox3,
                  "The rate must be numeric and positive.")
            End If
        Else
            ' Hours did not pass validation.
            ErrorProvider1.SetError(TextBox2,
              "The hours must be numeric and positive.")
        End If


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
