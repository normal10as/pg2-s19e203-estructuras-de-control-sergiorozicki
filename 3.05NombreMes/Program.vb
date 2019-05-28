Imports System

Module NombreMes
    Enum Meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiebre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main(args As String())

        Dim mes As Byte

        Console.Write("Ingrese numero de un mes (del 1 al 12): ")
        mes = Console.ReadLine()
        Select Case mes
            Case Meses.Enero
                Console.WriteLine("El mes ingresado es Enero")
            Case Meses.Febrero
                Console.WriteLine("El mes ingresado es Febrero")
            Case Meses.Marzo
                Console.WriteLine("El mes ingresado es Marzo")
            Case Meses.Abril
                Console.WriteLine("El mes ingresado es Abril")
            Case Meses.Mayo
                Console.WriteLine("El mes ingresado es Mayo")
            Case Meses.Junio
                Console.WriteLine("El mes ingresado es Junio")
            Case Meses.Julio
                Console.WriteLine("El mes ingresado es Julio")
            Case Meses.Agosto
                Console.WriteLine("El mes ingresado es Agosto")
            Case Meses.Septiebre
                Console.WriteLine("El mes ingresado es Septiebre")
            Case Meses.Octubre
                Console.WriteLine("El mes ingresado es Octubre")
            Case Meses.Noviembre
                Console.WriteLine("El mes ingresado es Noviembre")
            Case Meses.Diciembre
                Console.WriteLine("El mes ingresado es Diciembre")
            Case Else
                Console.WriteLine("El mes ingresado es incorrecto")
        End Select

    End Sub
End Module
