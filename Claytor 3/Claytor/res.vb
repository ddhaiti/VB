'Dupuytren Derbey D'Haiti
'Reservation class for Claytor's 2

Public Class res
    Private totalDecimal As Decimal
    Private rateDecimal As Decimal
    Private nightsInt As Integer
    Private Const Discount As Decimal = 0.1
    Private Const Taxes As Decimal = 0.07

    Sub New(ByVal nightlyRates As Decimal, ByVal numberOfNights As Integer)
        rate = nightlyRates
        nights = numberOfNights
    End Sub

    Public Property rate() As Decimal
        Get
            Return rateDecimal
        End Get
        Set(ByVal value As Decimal)
            If value > 0 Then
                rateDecimal = value
            Else
                rateDecimal = 0
            End If
        End Set
    End Property


    Public Property nights() As Integer
        Get
            Return nightsInt
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                nightsInt = value
            Else
                nightsInt = 1
            End If
        End Set
    End Property

    Function getTotal() As Decimal
        totalDecimal = ((rate * nights) * Taxes) + (rate * nights)
        Return totalDecimal
    End Function
    Function getTotal2() As Decimal
        totalDecimal = (rate * nights) + ((rate * nights) * Taxes) - ((rate * nights) * Discount)
        Return totalDecimal
    End Function
End Class
