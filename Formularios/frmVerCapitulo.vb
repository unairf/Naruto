Public Class frmVerCapitulo

    Private Sub frmVerCapitulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.AllowNavigation = False
        WebBrowser1.AllowWebBrowserDrop = False
    End Sub
    Private Sub WebBrowser1_NewWindow(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = True
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    'Private Sub frmVerCapitulo_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged
    '    btnVolver.Visible = False
    '    Button1.Visible = False
    'End Sub

    'Private Sub frmVerCapitulo_MaximumSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximumSizeChanged
    '    btnVolver.Visible = False
    '    Button1.Visible = False
    'End Sub

    Private Sub frmVerCapitulo_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        btnVolver.Visible = False
        Button1.Visible = False
    End Sub
End Class