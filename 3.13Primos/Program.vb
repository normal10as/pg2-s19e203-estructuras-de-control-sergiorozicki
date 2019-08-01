Imports System.Math

Module Primos
    Sub Main(args As String())
        Dim bandera As Byte
        For n = 2 To 1000
            bandera = 0
            For i = 2 To n / 2
                If (n Mod i) = 0 Then
                    bandera = 1
                    Exit For
                End If
            Next
            If bandera = 0 Then
                Console.WriteLine("El numero " & n & " es primo")
            End If
        Next
    End Sub
End Module
