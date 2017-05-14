'Dupuytren Derbey D'Haiti
Public Class Student

    Private studentName As String
    Public Property Name() As String
        Get
            Return studentName
        End Get
        Set(ByVal value As String)
            studentName = value
        End Set
    End Property

    Private studentAge As Integer
    Public Property Age() As Integer
        Get
            Return studentAge
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                studentAge = value
            Else
                MsgBox("no negativews for age")
            End If
        End Set
    End Property

    Private studentYear As Integer
    Public Property Year() As Integer
        Get
            Return studentYear
        End Get
        Set(ByVal value As Integer)
            If value >= 1 And value <= 4 Then
                studentYear = value
            End If
        End Set
    End Property
    Private classStanding As String
    Public Property standing() As String
        Get
            Return classStanding
        End Get
        Set(ByVal value As String)
            classStanding = value
        End Set
    End Property

    Sub New(ByVal _name As String, ByVal _age As Integer, ByVal _year As Integer)
        Name = _name
        Age = _age
        Year = _year
    End Sub
    Sub calculateClassStanding()
        If studentYear = 1 Then
            classStanding = "Freshman"
        ElseIf studentYear = 2 Then
            classStanding = "Sophomore"
        ElseIf studentYear = 3 Then
            classStanding = "Junior"
        ElseIf studentYear = 4 Then
            classStanding = "Senior"
        Else
            MsgBox("Invalid year")
        End If
    End Sub

End Class
