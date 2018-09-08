Public Class Token
    Enum Tipo
        PALABRA
        NUMERO_ENTERO
        SIGNO_IGUAL
        SIGNO_MAS
        SIGNO_MENOS
        SIGNO_DOSPUNTOS
        SIGNO_PUNTOYCOMA
        SIGNO_NUMERAL
        CORCHETE_IZQ
        CORCHETE_DER
        LLAVE_IZQ
        LLAVE_DER
        PALABRA_RESERVADA
        TIPO_ERROR
    End Enum
    Private tipoToken As Tipo
    Private valor As String
    Public fila, columna As Integer
    Public Sub New(ByVal tipo As Tipo, ByVal auxLex As String, ByVal filas As Integer, ByVal columnas As Integer)
        Me.tipoToken = tipo
        Me.valor = auxLex
        Me.fila = filas
        Me.columna = columnas
    End Sub
    Public Function getTipo() As Tipo
        Return tipoToken
    End Function
    Public Function getValor() As String
        Return valor
    End Function
    Public Function getTipoEnString() As String
        Select Case tipoToken
            Case Tipo.NUMERO_ENTERO
                Return "NumeroEntero "
            Case Tipo.PALABRA
                Return "Palabra"
            Case Tipo.SIGNO_IGUAL
                Return "Signoigual"
            Case Tipo.SIGNO_MAS
                Return "Mas"
            Case Tipo.SIGNO_MENOS
                Return "Menos"
            Case Tipo.SIGNO_DOSPUNTOS
                Return "DosPuntos"
            Case Tipo.SIGNO_PUNTOYCOMA
                Return "PuntoYcoma"
            Case Tipo.CORCHETE_IZQ
                Return "CorcheteIzq"
            Case Tipo.CORCHETE_DER
                Return "CorcheteDer"
            Case Tipo.LLAVE_IZQ
                Return "LlaveIzq"
            Case Tipo.LLAVE_DER
                Return "LlaveDer"
            Case Tipo.PALABRA_RESERVADA
                Return "PalabraReservada"
            Case Tipo.SIGNO_NUMERAL
                Return "Numeral"
            Case Else
                Return "Desconocido  "
        End Select
    End Function

End Class
