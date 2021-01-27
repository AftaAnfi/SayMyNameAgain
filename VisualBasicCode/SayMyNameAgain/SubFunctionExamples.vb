Option Explicit On
Option Strict On
'class notess
Module SubFunctionExamples

    Sub Main()
        Console.WriteLine("I'm in sub main.")
        MyOtherSub()
        DoMath()
        Console.ReadKey(False)

    End Sub

    Sub MyOtherSub()

        Console.WriteLine("I'm in my other sub.")

    End Sub

    Sub DoMath()
        Console.WriteLine(2 + 2)
    End Sub

End Module
