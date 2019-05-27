Imports System.Math

Module Program
    Sub Main(args As String())

        Dim año, mes_elegido, resto1, resto2, resto3 As Integer

        Console.Write("Ingrese año : ")
        año = Console.ReadLine()
        Console.Write("Ingrese mes: ")
        mes_elegido = Console.ReadLine()
        Console.WriteLine(mes_elegido)
        resto1 = (año Mod 4)
        resto2 = (año Mod 100)
        resto3 = (año Mod 400)
        Select Case resto3
            Case 0
                Select Case mes_elegido
                    Case 1, 3, 5, 7, 8, 10, 12
                        Console.WriteLine("El mes ingresado tiene 31 dias")
                    Case 2
                        Console.WriteLine("El mes ingresado tiene 29 dias")
                    Case 4, 6, 9, 11
                        Console.WriteLine("El mes ingresado tiene 30 dias")
                End Select
            Case <> 0
                Select Case resto1
                    Case 0
                        Select Case resto2
                            Case <> 0
                                Select Case mes_elegido
                                    Case 1, 3, 5, 7, 8, 10, 12
                                        Console.WriteLine("El mes ingresado tiene 31 dias")
                                    Case 2
                                        Console.WriteLine("El mes ingresado tiene 29 dias")
                                    Case 4, 6, 9, 11
                                        Console.WriteLine("El mes ingresado tiene 30 dias")
                                End Select
                            Case 0
                                Select Case mes_elegido
                                    Case 1, 3, 5, 7, 8, 10, 12
                                        Console.WriteLine("El mes ingresado tiene 31 dias")
                                    Case 2
                                        Console.WriteLine("El mes ingresado tiene 28 dias")
                                    Case 4, 6, 9, 11
                                        Console.WriteLine("El mes ingresado tiene 30 dias")
                                End Select
                        End Select
                    Case <> 0
                        Select Case mes_elegido
                            Case 1, 3, 5, 7, 8, 10, 12
                                Console.WriteLine("El mes ingresado tiene 31 dias")
                            Case 2
                                Console.WriteLine("El mes ingresado tiene 28 dias")
                            Case 4, 6, 9, 11
                                Console.WriteLine("El mes ingresado tiene 30 dias")
                        End Select
                End Select
        End Select
    End Sub
End Module