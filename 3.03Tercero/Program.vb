Imports System

Module Tercero
    Sub Main(args As String())

        Dim valor1, valor2, valor3, valor4, valor5 As Integer

        Console.Write("Ingrese el 1er valor numerico: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese el 2do valor numerico: ")
        valor2 = Console.ReadLine()
        Console.Write("Ingrese el 3er valor numerico: ")
        valor3 = Console.ReadLine()
        Console.Write("Ingrese el 4to valor numerico: ")
        valor4 = Console.ReadLine()
        Console.Write("Ingrese el 5to valor numerico: ")
        valor5 = Console.ReadLine()
        If valor1 = valor2 And valor1 = valor3 And valor1 = valor4 And valor1 = valor5 Then
            Console.WriteLine("Los valores ingresados son iguales")
        ElseIf valor1 >= valor2 And valor1 >= valor3 And valor1 >= valor4 And valor1 >= valor5 Then
            Console.WriteLine("El mayor valor es el 1ro")
        ElseIf valor2 >= valor1 And valor2 >= valor3 And valor2 >= valor4 And valor5 >= valor5 Then
            Console.WriteLine("El mayor valor es el 2do")
        ElseIf valor3 >= valor1 And valor3 >= valor2 And valor3 >= valor4 And valor3 >= valor5 Then
            Console.WriteLine("El mayor valor es el 3ro")
        ElseIf valor4 >= valor1 And valor4 >= valor2 And valor4 >= valor3 And valor4 >= valor5 Then
            Console.WriteLine("El mayor valor es el 4to")
        ElseIf valor5 >= valor1 And valor5 >= valor2 And valor5 >= valor3 And valor5 >= valor4 Then
            Console.WriteLine("El mayor valor es el 5to")
        End If
    End Sub
End Module
