Public Class AnalizadorBloques

    Private contador As Integer = 0
    Private lista() As Token
    Private clases As List(Of Clase)

    Public Sub New(ByRef Tokens As List(Of Token))
        Dim lista() As Token = Tokens.ToArray()

        AnalizarBloqueClase(lista)

    End Sub

    Private Sub AnalizarBloqueClase(ByRef lista As Token())
        Console.WriteLine(lista.Length)
        Console.WriteLine(lista(contador).getValor())
        If (lista(contador).getValor().Equals("[")) Then
            If (lista(contador + 1).getValor().ToLower().Equals("clase")) Then
                If (lista(contador + 2).getValor().Equals("]")) Then
                    Dim Bloqueatributo = False
                    If (lista(contador + 3).getValor().Equals("{")) Then
                        If (lista(contador + 4).getValor().Equals("[")) Then
                            Dim atributos As List(Of Atributo)
                            Dim metodos As List(Of Metodo)
                            Dim nombre As String
                            If (lista(contador + 5).getValor().ToLower().Equals("atributo")) Then
                                contador += 5
                                atributos = AnalizarBloqueAtributo()
                                Bloqueatributo = True
                            ElseIf (lista(contador + 5).getValor().ToLower().Equals("metodo")) Then
                                contador += 5
                                metodos = AnalizarBloqueMetodo()
                            ElseIf (lista(contador + 5).getValor().ToLower().Equals("nombre")) Then
                                If (lista(contador + 6).getValor().ToLower()) Then
                                End If
                                If (lista(contador + 1).getValor().Equals("}")) Then

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function AnalizarBloqueAtributo() As List(Of Atributo)

    End Function

    Private Function AnalizarBloqueMetodo() As List(Of Metodo)

    End Function
End Class
