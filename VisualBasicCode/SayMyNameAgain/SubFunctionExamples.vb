Option Explicit On
Option Strict On
'class notess
Module SubFunctionExamples

    Sub Main()
        'Console.WriteLine("I'm in sub main.")
        'MyOtherSub()

        'DoMath(3, 1)
        'DoMath(8, 0)
        'Console.WriteLine(firstFunction())
        'Console.WriteLine(MyCoolFunc("String"))

        Console.ReadKey(False)

    End Sub

    Sub MyOtherSub()

        Console.WriteLine("I'm in my other sub.")

    End Sub

    'pass data to a sub/function with arguments
    Sub DoMath(someNumber As Integer, secondNumber As Integer)
        someNumber *= 2
        Console.WriteLine(someNumber + secondNumber)
    End Sub

    Function firstFunction() As String
        'mycoolfool <- Tim's function


        'Return "henlo"
        Return 0.ToString()
    End Function

    Function MyCoolFunc(noteToSelf As String) As String
        Dim temp As String
        temp = ($"hello, {noteToSelf}")
        Return temp
    End Function










End Module
