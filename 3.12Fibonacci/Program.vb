Imports System

Module Fibonacci
    Sub Main(args As String())
        Dim a = 1, b = 0, suma As UShort
        For y = 1 To 20
            Console.WriteLine(suma)
            suma = a + b
            b = a
            a = suma
        Next
    End Sub
End Module
