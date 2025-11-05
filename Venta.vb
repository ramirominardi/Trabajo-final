Public Class Venta
    Public Property IdVenta As Integer
    Public Property Cliente As Cliente
    Public Property Fecha As Date
    Public Property Total As Decimal
    Public Property Detalles As List(Of DetalleVenta)

    Public Sub New()
        Detalles = New List(Of DetalleVenta)
    End Sub

    Public Sub AgregarDetalle(producto As Producto, cantidad As Integer)
        Dim detalle As New DetalleVenta With {
            .producto = producto,
            .cantidad = cantidad,
            .Subtotal = producto.Precio * cantidad
        }
        Detalles.Add(detalle)
        CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Total = Detalles.Sum(Function(d) d.Subtotal)
    End Sub
End Class
