Imports System

Module Comparar
    Sub Main(args As String())

        Dim valor1, valor2 As Integer

        Console.Write("Ingrese el 1er valor numerico: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese el 2do valor numerico: ")
        valor2 = Console.ReadLine()
        If valor1 > valor2 Then
            Console.WriteLine("El 1er valor es mayor que el 2do")
        ElseIf valor1 = valor2 Then
            Console.WriteLine("El 1er valor es igual al 2do")
        Else
            Console.WriteLine("El 2do valor es mayor que el 1ro")
        End If
    End Sub
End Module
