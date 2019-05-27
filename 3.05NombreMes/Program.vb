Imports System

Module NombreMes
    Enum Meses
        Enero = 1
        Febrero = 2
        Marzo = 3
        Abril = 4
        Mayo = 5
        Junio = 6
        Julio = 7
        Agosto = 8
        Septiebre = 9
        Octubre = 10
        Noviembre = 11
        Diciembre = 12
    End Enum
    Sub Main(args As String())

        Dim mes As Meses

        Console.Write("Ingrese numero de un mes (del 1 al 12): ")
        mes = Console.ReadLine()
        Select Case mes
            Case 1
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 2
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 3
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 4
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 5
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 6
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 7
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 8
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 9
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 10
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 11
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case 12
                Console.WriteLine("El mes ingresado es: " & mes.ToString)
            Case Else
                Console.WriteLine("El mes ingresado es incorrecto")
        End Select

    End Sub
End Module
