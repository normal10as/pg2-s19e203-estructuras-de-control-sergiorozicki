Imports System

Module ParesImpares

    Dim valor, resto, pares, impares As Integer

    Sub Main(args As String())
        Do
            Console.Write("Ingrese un valor numerico entero (0 para salir): ")
            valor = Console.ReadLine()
            resto = (valor Mod 2)
            If resto = 0 And valor <> 0 Then
                pares += 1
            ElseIf resto = 1 And valor <> 0 Then
                impares += 1
            End If
        Loop Until valor = 0
        If pares = 0 And impares > 0 Then
            Console.WriteLine("Todos lo numero ingresados son impares")
        ElseIf impares = 0 And pares > 0 Then
            Console.WriteLine("Todos lo numero ingresados son pares")
        ElseIf pares > 0 And impares > 0 Then
            Console.WriteLine("La cantidad de numeros pares son: " & pares)
            Console.WriteLine("La cantidad de numeros impares son: " & impares)
        ElseIf pares = 0 And impares = 0 Then
            Console.WriteLine("No se ingresaron numeros impares ni pares")
        End If
    End Sub
End Module
