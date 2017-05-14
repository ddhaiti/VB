'Dupuytren Derbey D'Haiti Polls
Public Class Form1

    Dim sourceString As String = New System.Net.WebClient().DownloadString("http://www.realclearpolitics.com/epolls/latest_polls/president/")
    Dim poll() As String
    Dim candidate() As String
    Dim winner As String


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Sanders Radio button
        poll = Split(sourceString, "Sanders +")
        candidate = Split(poll(1), "<")
        winner = "Sanders +" & candidate(0)
        Label2.Text = winner
        Me.BackgroundImage = My.Resources.DemocraticLogo

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Trump radio button
        poll = Split(sourceString, "Trump +")
        candidate = Split(poll(1), "<")
        winner = "Trump +" & candidate(0)
        Label2.Text = winner
        Me.BackgroundImage = My.Resources.RepublicanLogo
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'Cruz radio button
        poll = Split(sourceString, "Cruz +")
        candidate = Split(poll(1), "<")
        winner = "Cruz +" & candidate(0)
        Label2.Text = winner
        Me.BackgroundImage = My.Resources.RepublicanLogo
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'Clinton radio button
        poll = Split(sourceString, "Clinton +")
        candidate = Split(poll(1), "<")
        winner = "Clinton +" & candidate(0)
        Label2.Text = winner
        Me.BackgroundImage = My.Resources.DemocraticLogo
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'Rubio radio button
        poll = Split(sourceString, "Rubio +")
        candidate = Split(poll(1), "<")
        winner = "Rubio +" & candidate(0)
        Label2.Text = winner
        Me.BackgroundImage = My.Resources.RepublicanLogo
    End Sub


End Class
