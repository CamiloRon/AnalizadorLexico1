Public Class Atributo
    Private Nombre As String
    Private Visibilidad As Char
    Private Tipo As String

    Public Sub New(ByVal Nombre As String, ByVal Visibilidad As Char)
        Me.Nombre = Nombre
        Me.Visibilidad = Visibilidad
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Visibilidad As Char, ByVal Tipo As String)
        Me.Nombre = Nombre
        Me.Visibilidad = Visibilidad
        Me.Tipo = Tipo
    End Sub
End Class
