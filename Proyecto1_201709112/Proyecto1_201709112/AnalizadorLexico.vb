Imports Proyecto1_201709112.Token
Public Class AnalizadorLexico
    Private lista As List(Of Token)
    Private estado As Integer
    Private auxLex As String

    Public Function escanear(ByVal entrada As String) As List(Of Token)
        entrada = entrada + "~"
        lista = New List(Of Token)

        auxLex = ""
        Dim c As Char

        For i As Integer = 0 To entrada.Length - 1 Step 1
            c = entrada.Chars(i)

            If Char.IsLetter(c) Then
                auxLex += c
                addToken(Tipo.IDENTIFICADOR)



            ElseIf Char.IsDigit(c) Then
                auxLex += c
            ElseIf (c = "=") Then
                auxLex += c
                addToken(Tipo.SIGNO_IGUAL)
            ElseIf (c = ">") Then
                auxLex += c
                addToken(Tipo.SIGNO_MAYORQ)
            ElseIf (c = "<") Then
                auxLex += c
                addToken(Tipo.SIGNO_MENORQ)
            ElseIf (c = ":") Then
                auxLex += c
                addToken(Tipo.SIGNO_DOSPUNTOS)
            ElseIf (c = ";") Then
                auxLex += c
                addToken(Tipo.SIGNO_PUNTOYCOMA)
            ElseIf (c = "[") Then
                auxLex += c
                addToken(Tipo.CORCHETE_IZQ)
            ElseIf (c = "]") Then
                auxLex += c
                addToken(Tipo.CORCHETE_DER)
            ElseIf (c = "{") Then
                auxLex += c
                addToken(Tipo.LLAVE_IZQ)
            ElseIf (c = "}") Then
                auxLex += c
                addToken(Tipo.LLAVE_DER)
            ElseIf (c = "#") Then
                auxLex += c
                addToken(Tipo.SIGNO_NUMERAL)

            Else
                If (c = "~" And i = entrada.Length() - 1) Then
                    Console.WriteLine("Hemos concluido el análisis léxico satisfactoriamente")
                Else
                    Console.WriteLine("Error léxico con: " + c)

                End If
            End If



        Next
        Return lista
    End Function

    Private Sub addToken(ByVal tipo As Tipo)
        lista.Add(New Token(tipo, auxLex))
        auxLex = ""
        estado = 0
    End Sub
    Public Sub imprimirLista(ByVal l As List(Of Token))
        For Each t As Token In l
            Console.WriteLine(t.getTipoEnString() & "<-->" & t.getValor())
        Next
    End Sub


End Class
