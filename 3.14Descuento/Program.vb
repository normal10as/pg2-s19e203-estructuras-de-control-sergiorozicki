Imports System

Module Descuento

    Private cantidad_productos, precio_unitario, descuento_producto, sub_total, pesos_descontados, total_cobrar As Decimal
    Private porcentaje_descontado As Byte

    Sub Main(args As String())
        Do
            IngresoCantidad("Ingrese la cantidad del producto a comprar (0 para finalizar): ")
            If cantidad_productos = 0 Then
                Exit Do
            End If
            IngresoPrecio("Ingrese el presio del producto: ")
            sub_total = SubTotal(cantidad_productos, precio_unitario)
            descuento_producto = Descuento(sub_total)
            porcentaje_descontado = PorcentajeDescontado(cantidad_productos)
            pesos_descontados += descuento_producto
            total_cobrar += (sub_total - descuento_producto)
            Console.WriteLine("Porcentaje descontado del producto: %" & porcentaje_descontado)
            Console.WriteLine("Subtotal del producto: " & sub_total)
            Console.WriteLine("Descuento del producto" & descuento_producto)
            Console.WriteLine("Total del producto: " & sub_total - descuento_producto)
        Loop Until cantidad_productos = 0
        Console.WriteLine("Total descuentos: " & pesos_descontados)
        Console.WriteLine("Total a cobrar: " & total_cobrar)
    End Sub
    Private Sub IngresoCantidad(cantidad)
        Console.Write(cantidad)
        cantidad_productos = Console.ReadLine()
    End Sub
    Private Sub IngresoPrecio(precio)
        Console.Write(precio)
        precio_unitario = Console.ReadLine()
    End Sub
    Private Function SubTotal(cantidad_productos As Decimal, precio_unitario As Decimal) As Decimal
        Return precio_unitario * cantidad_productos
    End Function
    Private Function Descuento(sub_total As Decimal) As Decimal
        If cantidad_productos < 10 Then
            descuento_producto = 0
        ElseIf cantidad_productos >= 10 And cantidad_productos <= 50 Then
            descuento_producto = (5 * sub_total) / (100)
        ElseIf cantidad_productos >= 51 And cantidad_productos <= 250 Then
            descuento_producto = (10 * sub_total) / (100)
        ElseIf cantidad_productos > 250 Then
            descuento_producto = (20 * sub_total) / (100)
        End If
        Return descuento_producto
    End Function
    Private Function PorcentajeDescontado(cantidad_productos As Decimal) As Byte
        If cantidad_productos < 10 Then
            porcentaje_descontado = 0
        ElseIf cantidad_productos >= 10 And cantidad_productos <= 50 Then
            porcentaje_descontado = 5
        ElseIf cantidad_productos >= 51 And cantidad_productos <= 250 Then
            porcentaje_descontado = 10
        ElseIf cantidad_productos > 250 Then
            porcentaje_descontado = 20
        End If
        Return porcentaje_descontado
    End Function
End Module
