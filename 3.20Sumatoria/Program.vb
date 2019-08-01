Imports System.Math

Module Program
    Private valor, suma, total, suma2 As Decimal
    Sub Main(args As String())

        Dim respuesta = 1
        Do While respuesta
            Console.Write("Ingrese solo numeros enteros positivos: ")
            valor = Console.ReadLine()
            If (valor > 0) And ((valor Mod 2) = 1 Or (valor Mod 2) = 0) Then
                respuesta = 0
            Else
                respuesta = 1
            End If
        Loop
        For x = 1 To valor
            suma2 = Sumatoria(suma)
            suma = (Pow(x, 2))
        Next
        Console.WriteLine("La sumatoria de los numeros es " & suma2)
    End Sub
    Function Sumatoria(ByRef suma)
        total += suma
        Return total
    End Function
End Module
