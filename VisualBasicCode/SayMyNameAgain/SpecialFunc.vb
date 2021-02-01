Option Strict On
Option Explicit On
Module SpecialFunc

    Sub Main()

        'class notes

        'Console.WriteLine("enter the first number")
        'While problem = True And userInput <> "Q"
        '    Try
        '        userInput = Console.ReadLine()
        '        firstNumber = CInt(userinput)
        '        problem = False
        '    Catch ex As Exception
        '        Console.WriteLine($"I need a number, you entered {userInput}")
        '        problem = True
        '    End Try
        'End While
        'problem = True

        'If problem = True Then
        '    Console.Clear()
        '    Console.WriteLine("")
        'End If






        'promptUser("Hetlo")

        For i = 0 To 10
            'storeMessages("hello")
            RandomNumberInRange(4)
        Next

        'promptUser(storeMessages(""))

        Console.Read()

    End Sub

    Sub promptUser(message As String)
        Console.WriteLine(message)
    End Sub


    Function storeMessages(message As String) As String
        'static doesn't change scope but lifetime is foreverrrrrrrrrrrrrr (as long as program is open)
        Static storedMessages As String
        storedMessages &= message
        Return storedMessages
    End Function

    Function RandomNumberInRange(maxNumber As Integer) As Single

        Randomize(DateTime.Now.Millisecond)

        'Dim value As Integer = CInt(Int((maxNumber * Rnd()) + 1))

        Return CInt(Rnd())

        Dim temp As Single
        temp = Rnd()
        Console.WriteLine($"Rnd:{temp} {CInt(temp)} {Int(temp)}")
        Return temp


    End Function




End Module
