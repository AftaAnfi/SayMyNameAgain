Option Strict On
Option Explicit On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/AftaAnfi/SayMyNameAgain.git

Module SayMyNameAgain

    Sub Main()
        Dim readInputString As String

        'prompt user and gather user input 
        Console.WriteLine("What is your name?")
        readInputString = Console.ReadLine()

        'select case based on the name given from user
        Select Case readInputString
            Case "Joe"
                Console.WriteLine($"Hello {readInputString}!")
            Case "Emily"
                Console.WriteLine($"Hello {readInputString}!")
            Case "Aftanom"
                Console.WriteLine($"Awh yes, the programmer {readInputString} has arrived.")
            Case Else
                'if not Joe Emily or Aftanom, display a simple hello
                Console.WriteLine("Hello!")
                Console.WriteLine("Have a good day!")
        End Select

        'Prompt user on exitting the program
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey(False)

    End Sub

End Module