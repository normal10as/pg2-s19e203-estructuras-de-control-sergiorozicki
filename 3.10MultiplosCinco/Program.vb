Imports System

Module MultiploCinco
    Sub Main(args As String())

        Dim valor1, valor2, resto, paso_valor As Integer

        Console.Write("Ingrese un valor numerico: ")
        valor1 = Console.ReadLine()
        Console.Write("Ingrese un valor numerico mayor q el anterior: ")
        valor2 = Console.ReadLine()
        Dim contador_valores As Integer = 0
        Console.WriteLine("Valores multiplos de 5 DO WHILE LOOP")

        Console.WriteLine("Do While...Loop")
        paso_valor = valor1
        Do While paso_valor <= valor2
            resto = (paso_valor Mod 5)
            If resto = 0 Then
                contador_valores += 1
                Console.WriteLine(paso_valor)
            End If
            paso_valor += 1
        Loop

        Console.WriteLine("Do Until...Loop")
        paso_valor = valor1
        Do Until paso_valor = valor2
            resto = (paso_valor Mod 5)
            If resto = 0 Then
                Console.WriteLine(paso_valor)
            End If
            paso_valor += 1
        Loop

        Console.WriteLine("Do...While Loop")
        paso_valor = valor1
        Do
            resto = (paso_valor Mod 5)
            If resto = 0 Then
                Console.WriteLine(paso_valor)
            End If
            paso_valor += 1
        Loop While paso_valor <= valor2

        Console.WriteLine("Do...Until Loop")
        paso_valor = valor1
        Do
            resto = (paso_valor Mod 5)
            If resto = 0 Then
                Console.WriteLine(paso_valor)
            End If
            paso_valor += 1
        Loop Until paso_valor = valor2

        Console.WriteLine("For...Next")
        paso_valor = valor1
        For y = paso_valor To valor2
            resto = (y Mod 5)
            If resto = 0 Then
                Console.WriteLine(y)
            End If
        Next
        Console.WriteLine("La cantidad de valores multiples de 5 son: " & contador_valores)
    End Sub
End Module
