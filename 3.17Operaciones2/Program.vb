Imports System

Module Operaciones2
    Enum Operaciones As Integer
        suma = 1
        resta
        multiplicacion
        division
    End Enum
    Sub Main(args As String())
        Resultado(Operaciones.suma, 5, 8)
        Resultado(Operaciones.suma, 5, 8, 3)
        Resultado(Operaciones.suma, 5, 8, 3, 2)
        Resultado(Operaciones.resta, 5, 8)
        Resultado(Operaciones.resta, 5, 8, 3)
        Resultado(Operaciones.resta, 5, 8, 3, 2)
        Resultado(Operaciones.multiplicacion, 5, 8)
        Resultado(Operaciones.multiplicacion, 5, 8, 3)
        Resultado(Operaciones.multiplicacion, 5, 8, 3, 2)
        Resultado(Operaciones.division, 5, 8)
        Resultado(Operaciones.division, 5, 8, 3)
        Resultado(Operaciones.division, 5, 8, 3, 2)
    End Sub
    Sub Resultado(opcion As Operaciones, numero1 As Integer, numero2 As Integer)
        Select Case opcion
            Case Operaciones.suma
                Console.WriteLine(numero1 & "+" & numero2 & "=" & Calcular(Operaciones.suma, numero1, numero2))
            Case Operaciones.resta
                Console.WriteLine(numero1 & "-" & numero2 & "=" & Calcular(Operaciones.resta, numero1, numero2))
            Case Operaciones.multiplicacion
                Console.WriteLine(numero1 & "*" & numero2 & "=" & Calcular(Operaciones.multiplicacion, numero1, numero2))
            Case Operaciones.division
                Console.WriteLine(numero1 & "/" & numero2 & "=" & Calcular(Operaciones.division, numero1, numero2))
        End Select
    End Sub
    Sub Resultado(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer)
        Select Case opcion
            Case Operaciones.suma
                Console.WriteLine(numero1 & "+" & numero2 & "+" & numero3 & "=" & Calcular(Operaciones.suma, numero1, numero2, numero3))
            Case Operaciones.resta
                Console.WriteLine(numero1 & "-" & numero2 & "-" & numero3 & "=" & Calcular(Operaciones.resta, numero1, numero2, numero3))
            Case Operaciones.multiplicacion
                Console.WriteLine(numero1 & "*" & numero2 & "*" & numero3 & "=" & Calcular(Operaciones.multiplicacion, numero1, numero2, numero3))
            Case Operaciones.division
                Console.WriteLine(numero1 & "/" & numero2 & "/" & numero3 & "=" & Calcular(Operaciones.division, numero1, numero2, numero3))
        End Select
    End Sub
    Sub Resultado(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer, numero4 As Integer)
        Select Case opcion
            Case Operaciones.suma
                Console.WriteLine(numero1 & "+" & numero2 & "+" & numero3 & "+" & numero4 & "=" & Calcular(Operaciones.suma, numero1, numero2, numero3, numero4))
            Case Operaciones.resta
                Console.WriteLine(numero1 & "-" & numero2 & "-" & numero3 & "-" & numero4 & "=" & Calcular(Operaciones.resta, numero1, numero2, numero3, numero4))
            Case Operaciones.multiplicacion
                Console.WriteLine(numero1 & "*" & numero2 & "*" & numero3 & "*" & numero4 & "=" & Calcular(Operaciones.multiplicacion, numero1, numero2, numero3, numero4))
            Case Operaciones.division
                Console.WriteLine(numero1 & "/" & numero2 & "/" & numero3 & "/" & numero4 & "=" & Calcular(Operaciones.division, numero1, numero2, numero3, numero4))
        End Select
    End Sub

    Function Calcular(opcion As Operaciones, numero1 As Decimal, numero2 As Integer) As Decimal
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
    Function Calcular(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer) As Decimal
        Return (Calcular(opcion, Calcular(opcion, numero1, numero2), numero3))
    End Function
    Function Calcular(opcion As Operaciones, numero1 As Integer, numero2 As Integer, numero3 As Integer, numero4 As Integer) As Decimal
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
