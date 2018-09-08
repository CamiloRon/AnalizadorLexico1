Public Class Metodo
    Private Nombre As String
    Private Visibilidad As Char
    Private Retorno As String

    Public Sub New(ByVal Nombre As String, ByVal Visibilidad As Char)
        Me.Nombre = Nombre
        Me.Visibilidad = Visibilidad
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Visibilidad As Char, ByVal Retorno As String)
        Me.Nombre = Nombre
        Me.Visibilidad = Visibilidad
        Me.Retorno = Retorno
    End Sub
End Class
