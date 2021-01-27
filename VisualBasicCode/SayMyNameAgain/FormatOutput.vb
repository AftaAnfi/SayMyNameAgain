Option Explicit On
Option Strict On
Module FormatOutput
    Dim temp As String

    Sub main()
        'Class notes -----------------------------------------------------
        Console.WriteLine("-------------------------------------------------------------------------")
        For j = 0 To 10



            For i = 0 To 100

                'c for currency
                temp = CStr((i * j))
                '.ToString()
                'Console.WriteLine($"the string: {temp.PadLeft(7)} is {Len(temp)} char long")
                If i Mod 10 <> 0 Then
                    temp = ""
                Else
                    'Console.Write(temp.PadRight(2 + temp.Length) & "|  ")
                    Console.Write(temp.PadLeft(6))
                End If



            Next
            Console.WriteLine()
        Next
        Console.WriteLine("-------------------------------------------------------------------------")
        Console.Read()
        'end of class notes ---------------------------------------------
    End Sub
End Module
