Imports System.Math

Module VolumenCilindro
    Private radio, altura As Integer

    Sub Main(args As String())
        Dim respuesta = 1
        Do While respuesta
            Console.WriteLine("Ingrese solo numeros enteros")
            Console.Write("Ingrese el radio del cicilindro: ")
            radio = Console.ReadLine()
            Console.Write("Ingrese la altura del cilindro: ")
            altura = Console.ReadLine()
            If (radio > 0) And (altura > 0) Then
                respuesta = 0
            Else
                respuesta = 1
            End If
        Loop
        Console.WriteLine("El volumen del cilindro es: " & Volumen(radio, altura))
    End Sub
    Function Volumen(radio, altura)
        Return Sqrt((Math.PI) * Pow(radio, 2) * altura)
    End Function
End Module
