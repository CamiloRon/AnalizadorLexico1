Public Class Token
    Enum Tipo
        IDENTIFICADOR
        NUMERO_ENTERO
        SIGNO_IGUAL
        SIGNO_MAYORQ
        SIGNO_MENORQ
        SIGNO_DOSPUNTOS
        SIGNO_PUNTOYCOMA
        SIGNO_NUMERAL
        CORCHETE_IZQ
        CORCHETE_DER
        LLAVE_IZQ
        LLAVE_DER
        PALABRA_RESERVADA
    End Enum
    Private tipoToken As Tipo
    Private valor As String
    Public Sub New(ByVal tipo As Tipo, ByVal auxLex As String)
        Me.tipoToken = tipo
        Me.valor = auxLex
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
            Case Tipo.IDENTIFICADOR
                Return "Identificador"
            Case Tipo.SIGNO_IGUAL
                Return "Signoigual"
            Case Tipo.SIGNO_MAYORQ
                Return "MayorQ"
            Case Tipo.SIGNO_MENORQ
                Return "MenorQ"
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
            Case Else
                Return "Desconocido  "
        End Select
    End Function

End Class
