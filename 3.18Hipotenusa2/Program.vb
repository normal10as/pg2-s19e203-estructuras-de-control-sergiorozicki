Imports System.Math

Module Hipotenusa2
    Private ladoA, ladoB, D As Decimal
    Sub Main(args As String())
        Dim respuesta = 1
        Do While respuesta
            Console.WriteLine("Ingrese solo numeros enteros positivos")
            Console.Write("Ingrese el lado A del triangulo: ")
            ladoA = Console.ReadLine()
            Console.Write("Ingrese el lado B del triangulo: ")
            ladoB = Console.ReadLine()
            If (ladoA > 0) And (ladoB > 0) And ((ladoB Mod 2) = 1 Or (ladoB Mod 2) = 0) And ((ladoA Mod 2) = 1 Or (ladoA Mod 2) = 0) Then
                respuesta = 0
            Else
                respuesta = 1
            End If
        Loop
        Console.WriteLine("El resultado de la hipotenusa es: " & CalculoC(ladoA, ladoB))
    End Sub

    Function CalculoC(ladoA As Integer, ladoB As Integer) As Integer
        Return Sqrt(Pow(ladoA, 2) + Pow(ladoB, 2))
    End Function
End Module