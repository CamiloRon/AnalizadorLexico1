Public Class AnalizadorBloques

    Private contador As Integer
    Private lista() As Token

    Public Sub New(ByRef Tokens As List(Of Token))
        Dim lista() As Token = Tokens.ToArray()

        AnalizarBloqueClase(lista)

    End Sub

    Private Sub AnalizarBloqueClase(ByRef lista As Token())
        Console.WriteLine(lista.Length)
        Console.WriteLine(lista(0).getValor())
        If (lista(0).getValor().Equals("[")) Then
            Console.WriteLine("dfd")
            If (lista(1).getValor().ToLower().Equals("clase")) Then
                If (lista(2).getValor().Equals("]")) Then
                    If (lista(3).getValor().Equals("{")) Then
                        If (lista(4).getValor().Equals("[")) Then
                            If (lista(5).getValor().ToLower().Equals("atributo")) Then
                                AnalizarBloqueAtributo()
                            ElseIf (lista(5).getValor().ToLower().Equals("metodo")) Then
                                AnalizarBloqueMetodo()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub AnalizarBloqueAtributo()
        Console.WriteLine(lista.Count)
    End Sub

    Private Sub AnalizarBloqueMetodo()
        Console.WriteLine(lista.Count)
    End Sub
End Class
