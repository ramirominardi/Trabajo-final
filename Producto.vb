Public Class Producto
    Private _idProducto As Integer
    Private _nombre As String
    Private _precio As Decimal
    Private _stock As Integer

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _precio = value
            Else
                MsgBox("El precio no puede ser negativo")
            End If
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _stock = value
            Else
                MsgBox("Stock inválido")
            End If
        End Set
    End Property
End Class
