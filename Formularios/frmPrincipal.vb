
Imports Clases
Imports System.IO
Imports System.Net

Public Class frmPrincipal
    'Dim whereToSave As String
    'Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    'Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)


    'fff




    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten mover el formulario una vez quitados los marcos

    Private Sub frmPrincipal_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub frmPrincipal_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub frmPrincipal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        serieElegida = "Shippuden"
        rdbShippuden.Checked = True
        'LblSoloRasengan.BringToFront()
        'lblRasengan.Tag = My.Resources.rasengan

        ' grpCapitulos.BackColor = Color.Transparent
        Button4.BackColor = Color.Transparent
        MenuStrip1.BackColor = Color.Transparent

        num = miCapitulo.CargarEpisodiosLista(serieElegida).Count - 1
        'Label1.Image = 
        'Form1.BackgroundImage = My.Resources.
        'ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")

        'Do Until ficR.EndOfStream
        '    ficR.ReadLine()
        '    num += 1
        'Loop
        'ProgressBar1.Value = 0
        'ProgressBar1.Maximum = num
        'ficR.Close()
        CargarCapitulos()

        Me.TransparencyKey = Color.Transparent ' ========================== AL PONER ESTA LÍNEA AL FINAL DESAPARECE EL BUG DE CARGA ============================================
    End Sub

    Sub CargarCapitulos() '============================== CARGA TANTOS CONTROLES EN FUNCIÓN DEL NÚMERO DE CAPÍTULOS Y LOS AÑADE AL PANEL Y UNA LISTA DE CONTROLES ====================
        Me.Visible = False
        misControles.Clear() ' Se eliminan antes de empezar para no crear controles duplicados
        'Dim pnl As New Panel ' ================== CON EL PANEL PODREMOS HACER SCROLL PARA VER TODOS LOS EPISODIOS ========================================
        pnl.Controls.Clear()

        pnl.AutoScroll = True
        pnl.Dock = DockStyle.Fill
        pnl.Top = 15
        pnl.Left = 2
        pnl.Width = grpCapitulos.Width - 50




        ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\" & serieElegida & ".txt") ' Se puede hacer usando la función CargarEpisodiosLista() de Capítulo pero me da pereza

        Dim x As Integer = -20
        Dim y As Integer = 10
        Dim datos() As String
        Dim linea As String

        Me.Visible = False
        Dim cont As Integer = 1

        Do Until ficR.EndOfStream


            'Declarar botones y su nombre

            Dim miCapitulo As New Capitulo
            linea = ficR.ReadLine
            lineaCompleta = linea
            datos = linea.Split("*")
            ' Dim grpCap As New GroupBox
            grpCap.Name = "grp" & cont

            Dim btnVerCapitulo As New Button
            btnVerCapitulo.Name = "btnVer" & cont

            Dim btnDescargarCapitulo As New Button
            btnDescargarCapitulo.Name = "btnDescargar" & cont
            grpCap.Name = "grpCap" & cont

            Dim chk As New CheckBox
            chk.Name = "chk" & cont

            'Habilitar botones

            grpCap.Enabled = True
            btnVerCapitulo.Enabled = True
            btnVerCapitulo.Visible = True
            btnDescargarCapitulo.Enabled = True
            chk.Enabled = True
            chk.FlatStyle = FlatStyle.Popup





            Me.Controls.Add(pnl)

            'grpCapitulos

            grpCapitulos.Controls.Add(pnl)
            grpCap.Size = New Size(grpCapitulos.Width - 50, 40)
            grpCap.Location = New Point(x, y + 15)

            chk.Location = New Point(x + 310, y)

            'btnVerCapitulo

            btnVerCapitulo.Location = New Point(x + 40, y)
            btnVerCapitulo.Size = New Size(longitudBotones, 25)
            btnVerCapitulo.Text = datos(0) & ": " & cont
            ' btnVerCapitulo.Font = New Font(btnVerCapitulo.Font.Name, btnVerCapitulo.Font.Size - 2, btnVerCapitulo.Font.Style)
            'btnDescargarCapitulo

            btnDescargarCapitulo.Size = New Size(65, 25)
            btnDescargarCapitulo.Location = New Point(x + 340, y)
            btnDescargarCapitulo.Text = "Descargar" & cont

            'miCapitulo

            miCapitulo.Nombre = datos(0)
            miCapitulo.Numero = datos(1)
            miCapitulo.Enlace = datos(3)
            miCapitulo.Descarga = datos(4)

            'grpCap.Controls.Add(btnVerCapitulo)
            'grpCap.Controls.Add(btnDescargarCapitulo)
            'grpCap.Controls.Add(chk)
            'grpCapitulos.Controls.Add(grpCap)

            'btnVisto
            Dim btnVisto As New Button
            btnVisto.Name = "btnVisto" & cont
            btnVisto.Size = New Size(45, 25)
            btnVisto.Location = New Point(x + 260, y)
            btnVisto.Enabled = True
            btnVisto.Visible = True
            If datos(2).ToLower = "true" Then
                miCapitulo.Visto = True
                btnVisto.BackColor = Color.Bisque
                btnVisto.Text = "Visto"
            ElseIf datos(2).ToLower = "false" Then
                miCapitulo.Visto = False
                btnVisto.Text = ""
            End If
            btnVisto.Tag = lineaCompleta


            'Agregar controles
            grpCapitulos.Controls.Add(btnVisto)
            pnl.Controls.Add(btnDescargarCapitulo)
            pnl.Controls.Add(btnVerCapitulo)
            pnl.Controls.Add(chk)
            pnl.Controls.Add(btnVisto)

            misControles.Add(grpCap)



            y = y + grpCap.Height + 3
            cont += 1
            'btnVerCapitulo.Tag = datos(3)
            btnDescargarCapitulo.Tag = datos(4)
            btnDescargarCapitulo.Name = datos(0)
            '================================================================================================================================================================================================
            AddHandler chk.CheckedChanged, AddressOf chk_Checked
            AddHandler chk.Click, AddressOf chk_Click
            AddHandler btnVerCapitulo.Click, AddressOf btnVerEpisodio_Click
            AddHandler btnDescargarCapitulo.Click, AddressOf btnDescargarCapitulo_Click
            AddHandler btnVisto.Click, AddressOf btnVisto_Click
            ' ================================================================================================================================================================================================

            enlace = datos(3)
            chk.Tag = enlace
            frmVer.Tag = enlace
            btnVerCapitulo.Tag = enlace
            'ProgressBar1.Value += 1 '==================================================AUMENTAR EN UNO EL PROGRESO DE LA BARRA (descartado) =============================================
            'Threading.Thread.Sleep(0) '================================================= TIEMPO DE ESPERA IGUAL QUE SLEEP EN LINUX =========================================
            btnVerCapitulo.BackColor = Color.BlanchedAlmond
            btnDescargarCapitulo.BackColor = Color.BlanchedAlmond
        Loop
        ficR.Close()
        'Threading.Thread.Sleep(1000
        Me.Visible = True
        ' pnl.Controls(10).Select()
        'pnl.Controls(10).Focus()
        ' pnl.AutoScrollPosition = New Point(10, focusCapituloY)

    End Sub


    Private Sub chk_Checked(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'If TryCast(sender, CheckBox).Checked = True Then MessageBox.Show("Hola!")
        If TryCast(sender, CheckBox).Checked = True Then '------------------------------------------------------------- SE PODRÍA HACER EN EL EVENTO CLICK YA QUE NO HAY UN EVENTO UNCHECKED-----------------------

            Dim frmVer As New frmVerCapitulo
            frmMdi.Show()  'frmMdi.IsMdiContainer = True
            frmVer.MdiParent = frmMdi
            frmVer.Tag = TryCast(sender, CheckBox).Tag
            If TryCast(sender, CheckBox).Tag <> "no" Then
                frmVer.WebBrowser1.Url = New Uri(TryCast(sender, CheckBox).Tag)
            Else
                MessageBox.Show("No disponible")
            End If
            frmVer.Show()
        End If
    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click ' ================ CERRAR EL FORMULARIO CORRESPONDIENTE AL HACER UNCHECK EN UN EPISODIO ===============
        If TryCast(sender, CheckBox).Checked = True Then
        Else
            For Each Form In frmMdi.MdiChildren
                If Form.Tag = TryCast(sender, CheckBox).Tag Then
                    Form.Close()
                End If
            Next
        End If
        'TryCast(sender, CheckBox).Tag
        'If TryCast(sender, CheckBox).Checked = True Then
        '    Dim frmVer As New frmVerCapitulo
        '    frmMdi.Show()  'frmMdi.IsMdiContainer = True
        '    frmVer.MdiParent = frmMdi

        '    frmVer.WebBrowser1.Url = New Uri(enlace)

        '    frmVer.Show()
        'End If
    End Sub

    Private Sub btnVerEpisodio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        focusCapituloY = TryCast(sender, Button).Location.Y
        enlace = TryCast(sender, Button).Tag
        If enlace <> "no" Then
            Dim frmVer As New frmVerCapitulo
            'frmMdi.Show()  'frmMdi.IsMdiContainer = True
            'frmVer.MdiParent = frmMdi

            frmVer.WebBrowser1.Url = New Uri(enlace)
            frmVer.Show()
        Else
            MessageBox.Show("Este capítulo está junto al anterior") ' =========================== HAY ALGUNOS EPISODIOS QUE ENGLOBAN 2, EN CASO DE QUERER VER UNO INCLUIDO EN OTRO SE LE INDICARÍA QUE TIENE QUE IR AL ANTERIOR ==================
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub



    ' EL FORMULARIO HACE MOVIMIENTOS EXTRAÑOS, PARECIDOS A LOS QUE HACÍA EN LA PANTALLA DE CARGA AL TENER LA PROPIEDAD     " Me.TransparencyKey = Color.Transparent "     AL PRINCIPIO 
    ' ===========================================================================================================================================================================================
    ' ===============================================================================================================================================================================================
    ' ===========================================================================================================================================================================================
    ' ===============================================================================================================================================================================================


    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click ' 
        'ProgressBar1.Value = 0
        'espera = 100
        CargarCapitulos()
    End Sub


    ' ===========================================================================================================================================================================================
    ' ===============================================================================================================================================================================================
    ' ===========================================================================================================================================================================================
    ' ===============================================================================================================================================================================================



    ' ABRE UN FORMULARIO MDI PARA PODER LLEVAR UN MAYOR CONTROL DE LOS FORMULARIOS ABIERTOS, NO PEGA EN ESTA APLICACIÓN PERO TENÍA QUE PARECER QUE SIGO LOS EJERCICIOS DE CLASE :P

    Private Sub VentanasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentanasToolStripMenuItem.Click
        'MenuStrip1.MdiWindowListItem
        'VentanasToolStripMenuItem.IsMdiWindowListEntry
        'TryCast(sender, ToolStrip).Items.Add(
        'Dim fruitToolStripMenuItem As New ToolStripMenuItem("Fruit", Nothing, Nothing, "Fruit")
        'MenuStrip1.Items.Add(fruitToolStripMenuItem)
        frmMdi.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    ' ============================== SI, ESTO ESTÁ MAL PLANTEADO Y TENGO QUE CORREGIRLO... PERO FUNCIONA!! ==================================================

    ' PERMITE MARCAR COMO VISTO O NO VISTO UN EPISODIO, AUNQUE EL FORMULARIO SE VUELVE LOCO YA QUE ACTUALIZA LOS CONTROLES (BUG)

    Private Sub btnVisto_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim lineaTag As String
        Dim datosTag() As String
        Dim lineas(0) As String
        Dim cont As Integer = 0
        lineaTag = TryCast(sender, Button).Tag
        datosTag = lineaTag.Split("*")
        If datosTag(2).ToLower = "true" Then
            ' Dim ficR2 As StreamReader

            ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\" & serieElegida & ".txt")

            Dim linea As String
            Dim datos() As String


            Do Until ficR.EndOfStream
                ReDim Preserve lineas(cont)
                linea = ficR.ReadLine

                datos = linea.Split("*")
                If linea = lineaTag Then

                    If datos(2).ToLower = "true" Then datosTag(2) = "false" Else datosTag(2) = "true"
                    linea = (datos(0) & "*" & datos(1) & "*" & datosTag(2) & "*" & datos(3) & "*" & datos(4))

                End If
                lineas(cont) = linea
                cont += 1
            Loop

            ficR.Close()
            'File.Delete(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
            'File.Create(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
            ficW = New StreamWriter(My.Application.Info.DirectoryPath & "\Capitulos\" & serieElegida & ".txt")
            For j = 0 To lineas.Count - 1
                ficW.WriteLine(lineas(j))
            Next
            ficW.Close()
        ElseIf datosTag(2).ToLower = "false" Then
            ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\" & serieElegida & ".txt")

            Dim linea As String
            Dim datos() As String


            Do Until ficR.EndOfStream
                ReDim Preserve lineas(cont)
                linea = ficR.ReadLine

                datos = linea.Split("*")
                If linea = lineaTag Then

                    If datos(2).ToLower = "false" Then datosTag(2) = "true" Else datosTag(2) = "false"
                    linea = (datos(0) & "*" & datos(1) & "*" & datosTag(2) & "*" & datos(3) & "*" & datos(4))

                End If
                lineas(cont) = linea
                cont += 1
            Loop

            ficR.Close()
            'File.Delete(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
            'File.Create(My.Application.Info.DirectoryPath & "\Capitulos\Naruto.txt")
            ficW = New StreamWriter(My.Application.Info.DirectoryPath & "\Capitulos\" & serieElegida & ".txt")
            For j = 0 To lineas.Count - 1
                ficW.WriteLine(lineas(j))
            Next
            ficW.Close()
        End If
        grpCapitulos.Controls.Clear()
        CargarCapitulos()
    End Sub

    Private Sub ModificarCapítuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCapítuloToolStripMenuItem.Click
        frmModificarCapitulo.Show()
    End Sub

    Private Sub rdbNaruto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbNaruto.Click
        rdbShippuden.Checked = False
        serieElegida = "Naruto"
        CargarCapitulos()
    End Sub

    Private Sub rdbShippuden_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbShippuden.Click
        rdbNaruto.Checked = False
        serieElegida = "Shippuden"
        CargarCapitulos()
    End Sub

    Private Sub btnDescargarCapitulo_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim enlace As String = TryCast(sender, Button).Tag
        Dim CLIENTE As New WebClient 'LO DECLARAMOS CON EVENTS PARA PODER UTILIZAR LOS PROCEDIMIENTOS PROGRESSCHANGED Y COMPLETED

        If enlace.Contains("dropbox.com") Then
            enlace.Replace("www.dropbox.com", "dl.dropboxusercontent.com")
            Dim linea As String()
            linea = enlace.Split("//")
            enlace = linea(0) & "dl.dropboxusercontent.com" & linea(1)
            linea(2) = "dl.dropboxusercontent.com"
            enlace = ""
            For i = 0 To linea.Count - 1
                enlace = enlace & linea(i) & "/"
            Next
            Dim myWebClient As New WebClient
            'myWebClient.DownloadFile(enlace, My.Application.Info.DirectoryPath)
            'My.Computer.Network.DownloadFile(enlace, My.Application.Info.DirectoryPath)
            CLIENTE.DownloadFileAsync(New Uri(enlace), "hola.mp4")
            'Me.whereToSave = enlace
            'Me.lblsloc.Text = whereToSave
            'Me.btDownload.Enabled = False
            'Me.btCancel.Enabled = True
            'Me.loc.Enabled = False
            'Me.brws.Enabled = False
            'Me.BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub



    Private Sub ChatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChatToolStripMenuItem.Click
        Cliente.Show()
    End Sub

End Class