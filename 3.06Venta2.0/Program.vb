Imports System

Module Venta20
    Sub Main(args As String())

        Dim cantidad As Integer
        Dim precio_unitario, descuento, sub_total As Decimal

        Console.Write("Ingrese la catidad del producto a comprar: ")
        cantidad = Console.ReadLine()
        Console.Write("Ingrese el precio del producto: ")
        precio_unitario = Console.ReadLine()
        sub_total = precio_unitario * cantidad
        Select Case cantidad
            Case 10 To 50
                descuento = (5 * sub_total) / (100)
                Console.WriteLine("El descuento es del 5%")
            Case 51 To 250
                descuento = (10 * sub_total) / (100)
                Console.WriteLine("El descuento es del 10%")
            Case Is > 251
                descuento = (20 * sub_total) / (100)
                Console.WriteLine("El descuento es del 20%")
        End Select
        Console.WriteLine("El subtotal es: $" & sub_total)
        Console.WriteLine("El monto descontado es: $" & descuento)
        Console.WriteLine("Total: $" & sub_total - descuento)
    End Sub
End Module
