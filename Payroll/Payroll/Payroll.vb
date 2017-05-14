
'Dupuytren Derbey D'Haiti
Public Class Payroll

    'shared variables
    Private Shared NumberEmployeesInteger As Integer
    Private Shared TotalPayDecimal As Decimal
    Private Shared TotalOvertimeHoursDecimal As Decimal


    'Private Class variables.
    Private HoursDecimal As Decimal     ' Hold the Hours property.
    Private RateDecimal As Decimal      ' Hold the Rate property.
    Private PayDecimal As Decimal       ' Hold the Pay property.



    ' Constants.
    Private Const MINIMUM_WAGE_Decimal As Decimal = 7.5D
    Private Const MAXIMUM_WAGE_Decimal As Decimal = 50D
    Private Const MINIMUM_HOURS_Decimal As Decimal = 0D
    Private Const MAXIMUM_HOURS_Decimal As Decimal = 60D
    Private Const REGULAR_HOURS_Decimal As Decimal = 40D
    Private Const OVERTIME_RATE_Decimal As Decimal = 1.5D

    ' Constructor.
    Sub New(ByVal HoursInDecimal As Decimal, ByVal RateInDecimal As Decimal)

        Hours = HoursInDecimal
        Rate = RateInDecimal
        FindPay()
        NumberEmployeesInteger = NumberEmployeesInteger + 1
        ' Assign properties (Hours, Rate) and calculate the pay with FindPay
    End Sub

    Private Sub FindPay()
        ' Calculate the pay.
        Dim OvertimeHoursDecimal As Decimal
        OvertimeHoursDecimal = HoursDecimal - REGULAR_HOURS_Decimal
        If OvertimeHoursDecimal < 0 Then
            OvertimeHoursDecimal = 0
        End If
        PayDecimal = ((Hours - OvertimeHoursDecimal) * Rate) + (OvertimeHoursDecimal * OVERTIME_RATE_Decimal * Rate)
        TotalPayDecimal = TotalPayDecimal + PayDecimal
        TotalOvertimeHoursDecimal = TotalOvertimeHoursDecimal + OvertimeHoursDecimal

    End Sub

    ' Property procedures.
    Public Property Hours() As Decimal
        Get
            Return HoursDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= MINIMUM_HOURS_Decimal And
                    Value <= MAXIMUM_HOURS_Decimal Then
                HoursDecimal = Value
            Else
                Dim Ex As New ApplicationException(
                      "Hours are outside of the acceptable range.")
                Ex.Source = "Hours"
                Throw Ex
            End If
        End Set
    End Property

    Public Property Rate() As Decimal
        Get
            Return RateDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= MINIMUM_WAGE_Decimal And
                 Value <= MAXIMUM_WAGE_Decimal Then
                RateDecimal = Value
            Else
                Dim Ex As New ApplicationException(
                      "Pay rate is outside of the acceptable range.")
                Ex.Source = "Rate"
                Throw Ex
            End If
        End Set
    End Property

    Public ReadOnly Property Pay() As Decimal
        Get
            Return PayDecimal
        End Get
    End Property
    Public Shared ReadOnly Property NumberProcessed() As Integer
        Get
            Return NumberEmployeesInteger
        End Get

    End Property
    Public Shared ReadOnly Property TotalPay() As Decimal
        Get
            Return TotalPayDecimal
        End Get

    End Property
    Public Shared ReadOnly Property TotalOvertimeHours() As Integer
        Get
            Return TotalOvertimeHoursDecimal
        End Get

    End Property

End Class


