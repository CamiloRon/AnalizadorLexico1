Imports Proyecto1_201709112.Token
Public Class AnalizadorLexico
    Private lista As List(Of Token)
    Private errores As List(Of Token)
    Private estado As Integer
    Private auxLex As String
    Private entrada As String
    Private i, fila, columna As Integer
    Private c As Char
    Private lineas() As String

    Public Function escanear(ByVal entrada As String()) As List(Of Token)
        Me.lineas = entrada
        Console.WriteLine(lineas.Length)
        lista = New List(Of Token)
        For Each texto As String In lineas
            fila += 1
            For i = 0 To texto.Length - 1
                c = texto.Chars(i)
                Select Case estado
                    Case 0
                        estado0(c)
                    Case 1
                        estado1(c)
                End Select
            Next
            auxLex = ""
        Next
        Return lista
    End Function

    Private Sub estado0(ByVal c As Char)
        columna = i
        If (Char.IsLetterOrDigit(c)) Then
            estado = 1
            auxLex += c
        ElseIf (c = "#" Or c = "[" Or c = "]" Or c = "{" Or c = "}" Or c = ";" Or c = "+" Or c = "-" Or c = ":" Or c = "=") Then
            estado2(c)
        ElseIf (c <> " ") Then
            auxLex += c
            tokenError(Token.Tipo.TIPO_ERROR)
        End If
    End Sub

    Private Sub estado1(ByVal c As Char)
        If (Char.IsLetterOrDigit(c)) Then
            auxLex += c
        Else
            addToken(Token.Tipo.PALABRA)
            i -= 1
        End If
    End Sub

    Private Sub estado2(ByVal c As Char)

        Select Case c
            Case "#"
                addToken(Tipo.SIGNO_NUMERAL)
        End Select

    End Sub

    Private Sub tokenError(ByVal tipo As Tipo)
        errores.Add(New Token(tipo, auxLex, fila, i + 1))
    End Sub

    Private Sub addToken(ByVal tipo As Tipo)
        lista.Add(New Token(tipo, auxLex, fila, columna + 1))
        auxLex = ""
        estado = 0
    End Sub
    Public Sub imprimirLista(ByVal l As List(Of Token))
        For Each t As Token In l
            Console.WriteLine(t.getTipoEnString() & "<-->" & t.getValor())
        Next
    End Sub


End Class
