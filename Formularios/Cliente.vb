Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class Cliente

    Private miStream As Stream
    Dim clienteTCP As TcpClient
    Dim servidorThread As Thread

    Private Sub ButtonCONECTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Try
            CheckForIllegalCrossThreadCalls = False
            clienteTCP = New TcpClient
            clienteTCP.Connect(TextBoxIP.Text, TextBoxPUERTO.Text)
            miStream = clienteTCP.GetStream
            servidorThread = New Thread(AddressOf LEER)
            servidorThread.Start()
            rchClientes.AppendText("Conectado")
            btnConectar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LEER()
        Dim miBuffer() As Byte
        While True
            Try
                miBuffer = New Byte(100) {}
                miStream.Read(miBuffer, 0, miBuffer.Length)
                Dim mensaje As String = Encoding.UTF7.GetString(miBuffer)
                If mensaje.Contains("AAAAAAAAAAAAAAAAA") Then 'PARA EVITAR UN EXTRAÑO ¿ECO?
                    'ES ESE ¿ECO?
                Else
                    rchClientes.AppendText(vbCrLf & mensaje)
                    rchClientes.ScrollToCaret()
                    If mensaje.StartsWith("Conexion:") Then
                        Dim miSplit As New ArrayList(mensaje.Split(":"))
                        ListBox1.Items.Add(miSplit(1))
                    ElseIf mensaje.StartsWith("Desconexion:") Then
                        Dim miSplit As New ArrayList(mensaje.Split(":"))
                        ListBox1.Items.Remove(miSplit(1))
                    End If
                End If
            Catch ex As Exception
                Exit While
            End Try
        End While
    End Sub


    Private Sub TextBoxMENSAJE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMensaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtMensaje.Text <> Nothing Then
                Enviar(txtNombre.Text & ":" & txtMensaje.Text)
            End If
        End If
    End Sub

    Public Sub Enviar(ByVal MENSAJE As String)
        Try
            Dim miBuffer() As Byte
            ' If MENSAJE = ";)" Then MENSAJE = Image.FromFile("C:\Users\unairf\Documents\probar.jpg").ToString
            miBuffer = Encoding.UTF7.GetBytes(MENSAJE)
            miStream.Write(miBuffer, 0, miBuffer.Length)
            txtMensaje.Clear()
            txtMensaje.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            clienteTCP.Close()
            servidorThread.Abort()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rchClientes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rchClientes.TextChanged
        '\\this will replace :-)
        Dim matches = Regex.Matches(Me.rchClientes.Text, ":-\)")

        For Each m As Match In matches

            If m.Success Then

                Me.rchClientes.SelectionStart = m.Index
                Me.rchClientes.SelectionLength = m.Length

                Me.PasteSmiley()

            End If

        Next

        matches = Nothing
    End Sub
    Public Sub PasteSmiley()

        ' Using i = Image.FromFile("C:\Users\richt\Pictures\Saved Pictures\shannaro3.GIF")
        Using i = Image.FromFile("C:\Users\richt\Pictures\Saved Pictures\jeje.png")

            Clipboard.SetImage(i)

            Me.rchClientes.Paste()

        End Using

    End Sub
End Class