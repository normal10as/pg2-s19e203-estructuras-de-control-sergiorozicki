Imports System

Module Angulo
    Sub Main(args As String())

        Dim angulo As Short

        Console.Write("Ingrese tama�o del �ngulo: ")
        angulo = Console.ReadLine()
        Select Case angulo
            Case 0 To 90
                Console.WriteLine("El �ngulo es agudo")
            Case 90
                Console.WriteLine("El �ngulo es recto")
            Case 90 To 180
                Console.WriteLine("El �ngulo es obtuso")
            Case 180
                Console.WriteLine("El �ngulo es llano")
            Case 180 To 360
                Console.WriteLine("El �ngulo es c�ncavo")
            Case Is < 0
                Console.WriteLine("Error")
            Case Is > 360
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
