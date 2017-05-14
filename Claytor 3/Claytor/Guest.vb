Public Class Guest
    Private xmlDatabaseData As String = My.Application.Info.DirectoryPath & “\xmlData1.xml"
    Private xmlDatabaseData2 As String = My.Application.Info.DirectoryPath & “\xmlData2.xml"
    Private Sub Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(xmlDatabaseData) = True Then
            _DataSet1.ReadXml(xmlDatabaseData)
        End If
        If My.Computer.FileSystem.FileExists(xmlDatabaseData2) = True Then
            _DataSet1.ReadXml(xmlDatabaseData2)
        End If
    End Sub

    Private Sub GuestBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GuestBindingNavigatorSaveItem.Click
        Me.Validate()
        _DataSet1.WriteXml(xmlDatabaseData)
    End Sub
    Private Shared ourOneFormInstance As Guest

    Public Shared ReadOnly Property Instance() As Guest
        Get
            If ourOneFormInstance Is Nothing Then
                ourOneFormInstance = New Guest
            End If
            Return ourOneFormInstance
        End Get

    End Property


    Private Sub Guest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ourOneFormInstance = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ourOneFormInstance.Close()
    End Sub


End Class