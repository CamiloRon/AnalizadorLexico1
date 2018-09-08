Public Class Clase
    Private Nombre As String
    Private Atributos As List(Of Atributo)
    Private Metodos As List(Of Metodo)

    Public Sub New(ByVal Nombre As String, ByRef Atributos As List(Of Atributo), ByRef Metodos As List(Of Metodo))
        Me.Nombre = Nombre
        Me.Atributos = Atributos
        Me.Metodos = Metodos
    End Sub

    Public Sub New(ByVal Nombre As String, ByRef Metodos As List(Of Metodo))
        Me.Nombre = Nombre
        Me.Metodos = Metodos
    End Sub
End Class
