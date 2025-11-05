Public Class Cliente
    Inherits Persona  ' Herencia

    Private _codigoCliente As String
    Private _categoria As String

    Public Property CodigoCliente As String
        Get
            Return _codigoCliente
        End Get
        Set(value As String)
            _codigoCliente = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    ' Método sobreescrito
    Public Overrides Sub MostrarDatos()
        MyBase.MostrarDatos()
        Console.WriteLine("Código: " & CodigoCliente & " - Categoría: " & Categoria)
    End Sub

    ' Método para generar código (basado en nombre + doc)
    Public Function GenerarCodigo() As String
        Return "C" & Nombre.Substring(0, 2).ToUpper() & Documento.Substring(0, 3)
    End Function
End Class

