Imports System

Module Menor
    Sub Main(args As String())

        Dim valor1, valor2, valor3 As Integer

        Console.Write("Ingrese el 1er valor numerico: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese el 2do valor numerico: ")
        valor2 = Console.ReadLine()
        Console.Write("Ingrese el 3er valor numerico: ")
        valor3 = Console.ReadLine()
        If valor1 < valor2 And valor1 < valor3 Then
            Console.WriteLine("El menor valor es el " & valor1)
        ElseIf valor2 < valor1 And valor2 < valor3 Then
            Console.WriteLine("El menor valor es el " & valor2)
        ElseIf valor3 < valor1 And valor3 < valor2 Then
            Console.WriteLine("El menor valor es el " & valor3)
        Else
            Console.WriteLine("Los valores ingresados son iguales")
        End If
    End Sub
End Module
