Module Module1

    Sub Main()

        Randomize()
        ' Generate random value between 1 and 6. 
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userGuess As Integer
        Dim answerIsCorrect As Boolean = True

        While answerIsCorrect
            firstNumber = CInt(Int((100 * Rnd()) + 1))
            secondNumber = CInt(Int((100 * Rnd()) + 1))
            Console.WriteLine("What is {0} + {1}", firstNumber, secondNumber)
            userGuess = Console.ReadLine()
            If (userGuess = (firstNumber + secondNumber)) Then
                Console.WriteLine("Correct!")
            Else
                Console.WriteLine("WRONG!")
                answerIsCorrect = False
            End If

        End While
        Console.ReadLine()
    End Sub

    Function Addition() As Integer

        Return 0
    End Function
End Module
