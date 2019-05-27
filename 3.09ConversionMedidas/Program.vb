Imports System

Module ConversioMedias
    Sub Main(args As String())
        Dim opcion As Byte
        Dim pies, pulgadas, yardas, centimetros, metros As Decimal
        Console.Write("Seleccione unidad de medida a introducir: 1(pies), 2(pulgadas), 3(yardas), 4(centimetros), 5(metros): ")
        opcion = Console.ReadLine()
        Select Case opcion
            Case 1
                Console.Write("Ingrese la cantidad de pies: ")
                pies = Console.ReadLine()
                pulgadas = (pies * 30.48) / (2.54)
                yardas = (pies * 30.48) / (91.44)
                centimetros = pies * 30.48
                metros = (pies * 30.48) / (100)
                Console.WriteLine("La convercion de pies a pulgadas es: " & pulgadas)
                Console.WriteLine("La convercion de pies a yardas es: " & yardas)
                Console.WriteLine("La convercion de pies a centimetros es: " & centimetros)
                Console.WriteLine("La convercion de pies a metros es: " & metros)
            Case 2
                Console.Write("Ingrese la cantidad de pulgadas: ")
                pulgadas = Console.ReadLine()
                pies = (pulgadas * 2.54) / (30.48)
                yardas = (pulgadas * 2.54) / (91.44)
                centimetros = pulgadas * 2.54
                metros = (pulgadas * 2.54) / (100)
                Console.WriteLine("La convercion de pulgadas a pies es: " & pies)
                Console.WriteLine("La convercion de pulgadas a yardas es: " & yardas)
                Console.WriteLine("La convercion de pulgadas a centimetros es: " & centimetros)
                Console.WriteLine("La convercion de pulgadas a metros es: " & metros)
            Case 3
                Console.Write("Ingrese la cantidad de yardas: ")
                yardas = Console.ReadLine()
                pies = (yardas * 91.44) / (30.48)
                pulgadas = (yardas * 91.44) / (2.54)
                centimetros = yardas * 91.44
                metros = (yardas * 91.44) / (100)
                Console.WriteLine("La convercion de yardas a pies es: " & pies)
                Console.WriteLine("La convercion de yardas a pulgadas es: " & pulgadas)
                Console.WriteLine("La convercion de yardas a centimetros es: " & centimetros)
                Console.WriteLine("La convercion de yardas a metros es: " & metros)
            Case 4
                Console.Write("Ingrese la cantidad de centimetros: ")
                centimetros = Console.ReadLine()
                pies = centimetros / 30.48
                pulgadas = centimetros / 2.54
                yardas = centimetros / 91.44
                metros = centimetros / 100
                Console.WriteLine("La convercion de centimetros a pies es: " & pies)
                Console.WriteLine("La convercion de centimetros a pulgadas es: " & pulgadas)
                Console.WriteLine("La convercion de centimetros a yardas es: " & yardas)
                Console.WriteLine("La convercion de centimetros a metros es: " & metros)
            Case 5
                Console.Write("Ingrese la cantidad de metros: ")
                metros = Console.ReadLine()
                pies = (metros * 100) / (30.48)
                pulgadas = (metros * 100) / (2.54)
                yardas = (metros * 100) / (91.44)
                centimetros = metros * 100
                Console.WriteLine("La convercion de metros a pies es: " & pies)
                Console.WriteLine("La convercion de metros a pulgadas es: " & pulgadas)
                Console.WriteLine("La convercion de metros a yardas es: " & yardas)
                Console.WriteLine("La convercion de metros a centimetros es: " & centimetros)
            Case Else
                Console.WriteLine("Inudad de medida introducida incorreta")
        End Select
    End Sub
End Module
