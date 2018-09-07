Public Class Form1
    Dim rutaguardado As String
    Dim estado As Boolean = False
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "txt|*.txt"
        Dim ResultadoOFD As String
        OFD.ShowDialog()
        ResultadoOFD = OFD.FileName
        rutaguardado = ResultadoOFD
        estado = True

        Dim SR As New IO.StreamReader(rutaguardado)
        Me.RichTextBox1.Text = SR.ReadToEnd
        SR.Close()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "txt|*.txt"
        Dim ResultadoSFD As String
        SFD.ShowDialog()
        ResultadoSFD = SFD.FileName
        rutaguardado = ResultadoSFD
        estado = True

        Dim SW As New IO.StreamWriter(ResultadoSFD)
        SW.Write(Me.RichTextBox1.Text)
        SW.Flush()
        SW.Close()
    End Sub

    Private Sub GuardarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem1.Click
        If estado = True Then
            Dim SW As New IO.StreamWriter(rutaguardado)
            SW.Write(Me.RichTextBox1.Text)
            SW.Flush()
            SW.Close()
            Console.WriteLine("Guardado en:" + rutaguardado)

        Else
            Dim SFD As New SaveFileDialog
            SFD.Filter = "txt|*.txt"
            Dim ResultadoSFD As String
            SFD.ShowDialog()
            ResultadoSFD = SFD.FileName
            rutaguardado = ResultadoSFD

            Dim SW As New IO.StreamWriter(ResultadoSFD)
            SW.Write(Me.RichTextBox1.Text)
            SW.Flush()
            SW.Close()
            estado = True

        End If

    End Sub

    Private Sub AnalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnalizarToolStripMenuItem.Click
        Dim entrada As String = Me.RichTextBox1.Text


        Dim lex As AnalizadorLexico = New AnalizadorLexico()
        Dim lTokens As List(Of Token) = lex.escanear(entrada)
        lex.imprimirLista(lTokens)
    End Sub
End Class
