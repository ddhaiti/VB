'Dupuytren Derbey D'Haiti
'Reservation for Claytor's 2
Public Class Reservation

    Private xmlDatabaseData As String = My.Application.Info.DirectoryPath & “\xmlData1.xml"
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xmlDatabaseData) = True Then
            _DataSet1.ReadXml(xmlDatabaseData)
        End If
    End Sub

    Private Shared ourOneFormInstance As Reservation

    Public Shared ReadOnly Property Instance() As Reservation
        Get
            If ourOneFormInstance Is Nothing Then
                ourOneFormInstance = New Reservation
            End If
            Return ourOneFormInstance
        End Get

    End Property

    Private Sub Reservation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ourOneFormInstance = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ourOneFormInstance.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rate As Decimal
        Dim nights As Integer
        ' Dim total As Decimal

        If CheckBox1.Checked = True Then
            If RadioButton1.Checked = True Then
                rate = Label4.Text
            ElseIf RadioButton2.Checked = True Then
                rate = Label5.Text
            ElseIf RadioButton3.Checked = True Then
                rate = Label6.Text
            End If
        ElseIf CheckBox2.Checked = True Then
            If RadioButton1.Checked = True Then
                rate = Label7.Text
            ElseIf RadioButton2.Checked = True Then
                rate = Label8.Text
            ElseIf RadioButton3.Checked = True Then
                rate = Label9.Text
            End If
        End If

        If CustomerNameTextBox.Text = "" Then
            MsgBox("Customer name required")

        ElseIf CreditCardNumberTextBox.Text = "" Then
            MsgBox("Credit card number required")
        Else
            nights = NumberOfNightsNumericUpDown.Value
            Dim reservation As New res(rate, nights)

            If CheckBox3.Checked = True Or CheckBox4.Checked = True Then
                Label10.Text = reservation.getTotal2().ToString("C")
            Else
                Label10.Text = reservation.getTotal().ToString("C")

            End If


            Me.Validate()
            ReservationBindingSource.EndEdit()
            DataSet1.WriteXml(xmlDatabaseData)
        End If





    End Sub

    Private Sub ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReservationBindingNavigatorSaveItem.Click
        Me.Validate()
        _DataSet1.WriteXml(xmlDatabaseData)
    End Sub
End Class