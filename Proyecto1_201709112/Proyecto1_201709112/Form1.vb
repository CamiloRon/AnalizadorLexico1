﻿Imports Proyecto1_201709112.Token
Public Class Form1
    Dim rutaguardado As String
    Dim estado As Boolean = False
    Dim tokens As List(Of Token)
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



    End Sub

    Private Sub ImprimirErrores()

    End Sub

    Private Sub ImprimirTokens()

    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Dim entrada As String = Me.RichTextBox1.Text
        Dim lex As AnalizadorLexico = New AnalizadorLexico()
        Dim lTokens As List(Of Token) = lex.escanear(Me.RichTextBox1.Lines)
        If (lTokens.First.getTipo() = Token.Tipo.TIPO_ERROR) Then
            ImprimirErrores()
        Else
            ImprimirTokens()
            Dim analizador As AnalizadorBloques = New AnalizadorBloques(lTokens)
        End If



        FolderBrowserDialog1.ShowDialog()
        System.IO.Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath + "\\Reportes\\CSS")
        Dim archivo As New IO.StreamWriter(FolderBrowserDialog1.SelectedPath + "\\Reportes\\CSS\\style.css")
        archivo.Write("@import url(https://fonts.googleapis.com/css?family=Roboto:400,500,700,300,100); body { background-color: #3e94ec; font-family: 'Roboto', helvetica, arial, sans-serif; font-size: 16px; font-weight: 400; text-rendering: optimizeLegibility; } div.table-title { display: block; margin: auto; max-width: 600px; padding:5px; width: 100%; } .table-title h3 { color: #fafafa; font-size: 30px; font-weight: 400; font-style:normal; font-family: 'Roboto', helvetica, arial, sans-serif; text-shadow: -1px -1px 1px rgba(0, 0, 0, 0.1); text-transform:uppercase; } /*** Table Styles **/ .table-fill { background: white; border-radius:3px; border-collapse: collapse; height: 320px; margin: auto; max-width: 600px; padding:5px; width: 100%; box-shadow: 0 5px 10px rgba(0, 0, 0, 0.1); animation: float 5s infinite; } th { color:#D5DDE5;; background:#1b1e24; border-bottom:4px solid #9ea7af; border-right: 1px solid #343a45; font-size:23px; font-weight: 100; padding:24px; text-align:left; text-shadow: 0 1px 1px rgba(0, 0, 0, 0.1); vertical-align:middle; } th:first-child { border-top-left-radius:3px; } th:last-child { border-top-right-radius:3px; border-right:none; } tr { border-top: 1px solid #C1C3D1; border-bottom-: 1px solid #C1C3D1; color:#666B85; font-size:16px; font-weight:normal; text-shadow: 0 1px 1px rgba(256, 256, 256, 0.1); } tr:hover td { background:#4E5066; color:#FFFFFF; border-top: 1px solid #22262e; } tr:first-child { border-top:none; } tr:last-child { border-bottom:none; } tr:nth-child(odd) td { background:#EBEBEB; } tr:nth-child(odd):hover td { background:#4E5066; } tr:last-child td:first-child { border-bottom-left-radius:3px; } tr:last-child td:last-child { border-bottom-right-radius:3px; } td { background:#FFFFFF; padding:20px; text-align:left; vertical-align:middle; font-weight:300; font-size:18px; text-shadow: -1px -1px 1px rgba(0, 0, 0, 0.1); border-right: 1px solid #C1C3D1; } td:last-child { border-right: 0px; } th.text-left { text-align: left; } th.text-center { text-align: center; } th.text-right { text-align: right; } td.text-left { text-align: left; } td.text-center { text-align: center; } td.text-right { text-align: right; }")
        archivo.Flush()
        archivo.Close()
        Dim lex As New AnalizadorLexico
        tokens = AnalizadorLexico.(RichTextBox1.Text);
            If (Tokens.First().getTipo().Equals("Elemento léxico desconocido")) Then {
                Using (System.IO.StreamWriter archivo = New System.IO.StreamWriter(folderBrowserDialog1.SelectedPath + "\\Reportes\\Errores.html")) {
                    archivo.Write("<!DOCTYPE html> <html lang='en' > <head> <meta charset='UTF - 8'> <title>Errores</title> <link rel='stylesheet' href='css/style.css'> </head> <body> <meta name='viewport' content='initial - scale = 1.0; maximum - scale = 1.0; width = device - width; '>  <div class='table - title'> <h3 align = 'Center'>Errores lexicos</h3> </div> <table class='table - fill' align = 'Center'> <thead> <tr> <th class='text - left'>No.</th> <th class='text - left'>Error</th> <th class='text - left'>Descripción</th> <th class='text - left'>Fila</th> <th class='text - left'>Columna</th> </tr> </thead> <tbody class='table - hover'>");
                    foreach(Token token In tokens) {
                        Error error = (Error)token;
                        archivo.Write("<tr> <td class='text - left'>" + error.getIDError() + "</td> <td class='text - left'> " + Error.getValor() + "</td> <td class='text - left'> " + Error.getTipo() + "</td> <td class='text - left'> " + Error.getFila() + "</td> <td class='text - left'> " + Error.getColumna() + "</td> </tr>");
                    }
                    archivo.Write("</tbody> </table> </body></html>");
                    archivo.Flush();
                    archivo.Close();
                }
            } else {
                escribirColor();
                crearBloques();
                Using (System.IO.StreamWriter archivo = New System.IO.StreamWriter(folderBrowserDialog1.SelectedPath + "\\Reportes\\Tokens.html")) {
                    archivo.Write("<!DOCTYPE html> <html lang='en' > <head> <meta charset='UTF - 8'> <link rel='stylesheet' href='css/style.css'> </head> <body> <meta name='viewport' content='initial - scale = 1.0; maximum - scale = 1.0; width = device - width; '>  <div class='table - title'> <h3 align = 'Center'>Tokens</h3> </div> <table class='table - fill' align = 'Center'> <thead> <tr> <th class='text - left'>No.</th> <th class='text - left'>Token</th> <th class='text - left'>Tipo</th> <th class='text - left'>Fila</th> <th class='text - left'>Columna</th> </tr> </thead> <tbody class='table - hover'>");
                    foreach(Token token In tokens) {
                        archivo.Write("<tr> <td class='text - left'>" + Token.getID() + "</td> <td class='text - left'> " + Token.getValor() + "</td> <td class='text - left'> " + Token.getTipo() + "</td> <td class='text - left'> " + Token.getFila() + "</td> <td class='text - left'> " + Token.getColumna() + "</td> </tr>");
                    }
                    archivo.Write("</tbody> </table> </body></html>");
                    archivo.Flush();
                    archivo.Close();
                }
                If (organigramas.Count > 0) Then{
                    Using (System.IO.StreamWriter archivo = New System.IO.StreamWriter(folderBrowserDialog1.SelectedPath + "\\Reportes\\Organigramas.html")) {
                        archivo.Write("<!DOCTYPE html> <html lang='en' > <head> <meta charset='UTF - 8'> <title>Organigramas</title> <link rel='stylesheet' href='css/style.css'> </head> <body><CENTER>");
                        foreach(organigrama organigrama In organigramas) {
                            archivo.Write("<h1>" + organigrama.nombre + "</h1><img src='" + FolderBrowserDialog1.SelectedPath + "\\Reportes\\" + organigrama.nombre + ".jpg'>");
                        }
                        archivo.Write("</CENTER></body></html>");
                    }
                }
                
            }
    End Sub
End Class
