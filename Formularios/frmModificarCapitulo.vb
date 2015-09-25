
Imports System.IO

Public Class frmModificarCapitulo

    Private Sub btnModificarCapitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCapitulo.Click

        Dim lineas(miCapitulo.CargarEpisodiosLista(serieElegida).Count - 1) As String
        lineas = miCapitulo.CargarEpisodiosLista(serieElegida)
        miCapitulo.CargarEpisodiosLista(serieElegida)


        ficW = New StreamWriter(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
        For j = 0 To lineas.Count - 1
            Dim datos() As String = lineas(j).Split("*")
            If datos(0).ToLower = txtTituloCapitulo.Text.ToLower Or datos(1) = txtNumeroCapitulo.Text Then
                ficW.WriteLine(txtTituloCapitulo.Text & "*" & txtNumeroCapitulo.Text & "*" & datos(2) & "*" & txtEnlaceCapitulo.Text & "*" & txtDescargaCapitulo.Text)
            Else
                ficW.WriteLine(lineas(j))
            End If

        Next
        ficW.Close()
        MessageBox.Show("Capítulo modificado correctamente")
        txtDescargaCapitulo.Clear()
        txtEnlaceCapitulo.Clear()
        txtNumeroCapitulo.Clear()
        txtTituloCapitulo.Clear()

    End Sub

    ' CARGA EN EL COMBO BOX LA LISTA DE EPISODIOS

    Private Sub frmModificarCapitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Start()
        'lblSharingan.BringToFront()
        'Timer1.Interval = 1000
        'ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
        Dim linea As String
        Dim lineas(miCapitulo.CargarEpisodiosLista(serieElegida).Count) As String
        lineas = miCapitulo.CargarEpisodiosLista(serieElegida)

        'Dim int As Integer = miCapitulo.CargarEpisodiosLista().Count
        Dim datos() As String
        'Do Until ficR.EndOfStream
        '    linea = ficR.ReadLine
        '    datos = linea.Split("*")
        '    cboListaCapitulos.Items.Add(datos(0))
        'Loop
        For i = 0 To lineas.Count - 1
            linea = lineas(i)
            datos = linea.Split("*")
            cboListaCapitulos.Items.Add(datos(0))
        Next

    End Sub

    Private Sub cboListaCapitulos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboListaCapitulos.SelectedIndexChanged

        Dim lineas(miCapitulo.CargarEpisodiosLista(serieElegida).Count - 1) As String
        lineas = miCapitulo.CargarEpisodiosLista(serieElegida)
        Dim cont As Integer = miCapitulo.CargarEpisodiosLista(serieElegida).Count - 1
        ficR.Close()
        Dim num As Integer = cboListaCapitulos.SelectedIndex
        Dim datos() As String = lineas(num).Split("*")
        txtTituloCapitulo.Text = datos(0)
        txtNumeroCapitulo.Text = datos(1)
        txtEnlaceCapitulo.Text = datos(3)
        txtDescargaCapitulo.Text = datos(4)

    End Sub


    ' MANGEKYO SHARINGAN!! (Si no ves Naruto no lo vas a pillar, ya tienes una excusa para usar esta aplicación)

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    lblSharingan.Visible = False
    '    Timer1.Stop()
    'End Sub
End Class