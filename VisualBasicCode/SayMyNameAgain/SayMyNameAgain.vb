Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/AftaAnfi/SayMyNameAgain.git

Module SayMyNameAgain

    Dim readInputString As String

    Sub Main()
        Console.WriteLine("What is your name?")

        readInputString = Console.ReadLine()

        Select Case readInputString
            Case "Joe"
                Console.WriteLine($"Hello {readInputString}!")
            Case "Emily"
                Console.WriteLine($"Hello {readInputString}!")
            Case "Aftanom"
                Console.WriteLine($"Awh yes, the programmer {readInputString} has arrived.")
            Case Else
                Console.WriteLine("Hello!")
                Console.WriteLine("Have a good day!")
        End Select

        Console.WriteLine("Press any key to continue...")
        Console.ReadKey(False)


    End Sub

End Module