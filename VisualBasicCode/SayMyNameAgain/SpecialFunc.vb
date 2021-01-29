Option Strict On
Option Explicit On
Module SpecialFunc

    Sub Main()

        promptUser("Hetlo")

        For i = 0 To 5
            storeMessages("hello")
        Next

        promptUser(storeMessages(""))

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


End Module
