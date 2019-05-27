Imports System

Module Venta
    Sub Main(args As String())

        Dim cantidad As Integer
        Dim precio_unitario, descuento, sub_total As Decimal

        Console.Write("Ingrese la catidad del producto a comprar: ")
        cantidad = Console.ReadLine()
        Console.Write("Ingrese el precio del producto: ")
        precio_unitario = Console.ReadLine()
        sub_total = precio_unitario * cantidad
        If cantidad >= 10 And cantidad <= 50 Then
            descuento = (5 * sub_total) / (100)
            Console.WriteLine("El descuento es del 5%")
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            descuento = (10 * sub_total) / (100)
            Console.WriteLine("El descuento es del 10%")
        ElseIf cantidad >= 251 Then
            descuento = (20 * sub_total) / (100)
            Console.WriteLine("El descuento es del 20%")
        End If
        Console.WriteLine("El subtotal es: $" & sub_total)
        Console.WriteLine("El monto descontado es: $" & descuento)
        Console.WriteLine("Total: $" & sub_total - descuento)
    End Sub
End Module
