Imports System

Module Operaciones
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Console.WriteLine("Suma")
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 3))
        Console.WriteLine(Calcular(Operaciones.suma, 5, 8, 3, 2))
        Console.WriteLine("Resta")
        Console.WriteLine(Calcular(Operaciones.resta, 5, 8))
        Console.WriteLine(Calcular(Operaciones.resta, 5, 8, 3))
        Console.WriteLine(Calcular(Operaciones.resta, 5, 8, 3, 2))
        Console.WriteLine("Multiplicacion")
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 5, 8))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 5, 8, 3))
        Console.WriteLine(Calcular(Operaciones.multiplicacion, 5, 8, 3, 2))
        Console.WriteLine("Division")
        Console.WriteLine(Calcular(Operaciones.division, 5, 8))
        Console.WriteLine(Calcular(Operaciones.division, 5, 8, 3))
        Console.WriteLine(Calcular(Operaciones.division, 5, 8, 3, 2))
        Console.WriteLine("Suma")
        Console.WriteLine(Calcular(5, 8))
        Console.WriteLine(Calcular(5, 8, 3))
        Console.WriteLine(Calcular(5, 8, 3, 2))
    End Sub

    Function Calcular(opcion As Operaciones, numero1 As Decimal, numero2 As Integer) As Operaciones
        Select Case opcion
            Case Operaciones.suma
                Return numero1 + numero2
            Case Operaciones.resta
                Return numero1 - numero2
            Case Operaciones.multiplicacion
                Return numero1 * numero2
            Case Operaciones.division
                Return numero1 / numero2
        End Select
        Return opcion
    End Function
    Function Calcular(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer) As Operaciones
        Return (Calcular(opcion, Calcular(opcion, numero1, numero2), numero3))
    End Function
    Function Calcular(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer, numero4 As Integer) As Operaciones
        Return Calcular(opcion, Calcular(opcion, numero1, numero2, numero3), numero4)
    End Function

    Function Calcular(numero1, numero2) As Integer
        Return numero1 + numero2
    End Function
    Function Calcular(numero1, numero2, numero3) As Integer
        Return Calcular(numero1, numero2) + numero3
    End Function
    Function Calcular(numero1, numero2, numero3, numero4) As Integer
        Return Calcular(numero1, numero2) + Calcular(numero3, numero4)
    End Function
End Module