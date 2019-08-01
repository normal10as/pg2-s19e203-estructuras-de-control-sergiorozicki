Imports System

Module Deposito

    Private capital, saldo_acumulado, tasa_mensual, interes, saldo, total_interes As Decimal
    Private cantidad_meses As UShort
    Const interes_anual As Byte = 36
    Sub Main(args As String())
        CapitalInicial("Ingrese el capital inicial: ")
        CantidadMeses("Ingrese la cantidad de mese: ")
        EscribirTitulo("MES | CAPITAL | INTERES | SALDO")
        tasa_mensual = interes_anual / 12
        For Nmes = 1 To cantidad_meses
            interes = capital * tasa_mensual
            saldo = capital + tasa_mensual
            Console.WriteLine(Nmes & "       " & capital & "       " & interes & "        " & saldo)
            total_interes += interes
            capital = saldo
        Next
        Console.WriteLine("Total interes ganado: " & total_interes)
    End Sub
    Private Sub EscribirTitulo(mensaje3)
        Console.WriteLine(mensaje3)
    End Sub
    Private Sub CapitalInicial(mensaje1)
        Console.Write(mensaje1)
        capital = Console.ReadLine()
    End Sub
    Private Sub CantidadMeses(mensaje2)
        Console.Write(mensaje2)
        cantidad_meses = Console.ReadLine()
    End Sub
End Module
