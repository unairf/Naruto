<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCapitulo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTituloEpisodio = New System.Windows.Forms.Label()
        Me.lblNumeroCapitulo = New System.Windows.Forms.Label()
        Me.lblEnlaceVisualizacion = New System.Windows.Forms.Label()
        Me.lblEnlaceDescarga = New System.Windows.Forms.Label()
        Me.txtTituloCapitulo = New System.Windows.Forms.TextBox()
        Me.txtDescargaCapitulo = New System.Windows.Forms.TextBox()
        Me.txtEnlaceCapitulo = New System.Windows.Forms.TextBox()
        Me.cboListaCapitulos = New System.Windows.Forms.ComboBox()
        Me.txtNumeroCapitulo = New System.Windows.Forms.TextBox()
        Me.btnModificarCapitulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTituloEpisodio
        '
        Me.lblTituloEpisodio.AutoSize = True
        Me.lblTituloEpisodio.Location = New System.Drawing.Point(27, 87)
        Me.lblTituloEpisodio.Name = "lblTituloEpisodio"
        Me.lblTituloEpisodio.Size = New System.Drawing.Size(97, 13)
        Me.lblTituloEpisodio.TabIndex = 20
        Me.lblTituloEpisodio.Text = "Título del episodio:"
        '
        'lblNumeroCapitulo
        '
        Me.lblNumeroCapitulo.AutoSize = True
        Me.lblNumeroCapitulo.Location = New System.Drawing.Point(27, 113)
        Me.lblNumeroCapitulo.Name = "lblNumeroCapitulo"
        Me.lblNumeroCapitulo.Size = New System.Drawing.Size(104, 13)
        Me.lblNumeroCapitulo.TabIndex = 19
        Me.lblNumeroCapitulo.Text = "Número de episodio:"
        '
        'lblEnlaceVisualizacion
        '
        Me.lblEnlaceVisualizacion.AutoSize = True
        Me.lblEnlaceVisualizacion.Location = New System.Drawing.Point(27, 139)
        Me.lblEnlaceVisualizacion.Name = "lblEnlaceVisualizacion"
        Me.lblEnlaceVisualizacion.Size = New System.Drawing.Size(121, 13)
        Me.lblEnlaceVisualizacion.TabIndex = 18
        Me.lblEnlaceVisualizacion.Text = "Enlace de visualización:"
        '
        'lblEnlaceDescarga
        '
        Me.lblEnlaceDescarga.AutoSize = True
        Me.lblEnlaceDescarga.Location = New System.Drawing.Point(27, 166)
        Me.lblEnlaceDescarga.Name = "lblEnlaceDescarga"
        Me.lblEnlaceDescarga.Size = New System.Drawing.Size(105, 13)
        Me.lblEnlaceDescarga.TabIndex = 17
        Me.lblEnlaceDescarga.Text = "Enlace de descarga:"
        '
        'txtTituloCapitulo
        '
        Me.txtTituloCapitulo.Location = New System.Drawing.Point(163, 87)
        Me.txtTituloCapitulo.Name = "txtTituloCapitulo"
        Me.txtTituloCapitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTituloCapitulo.TabIndex = 16
        '
        'txtDescargaCapitulo
        '
        Me.txtDescargaCapitulo.Location = New System.Drawing.Point(163, 166)
        Me.txtDescargaCapitulo.Name = "txtDescargaCapitulo"
        Me.txtDescargaCapitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtDescargaCapitulo.TabIndex = 15
        '
        'txtEnlaceCapitulo
        '
        Me.txtEnlaceCapitulo.Location = New System.Drawing.Point(163, 139)
        Me.txtEnlaceCapitulo.Name = "txtEnlaceCapitulo"
        Me.txtEnlaceCapitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtEnlaceCapitulo.TabIndex = 14
        '
        'cboListaCapitulos
        '
        Me.cboListaCapitulos.FormattingEnabled = True
        Me.cboListaCapitulos.Location = New System.Drawing.Point(10, 40)
        Me.cboListaCapitulos.Name = "cboListaCapitulos"
        Me.cboListaCapitulos.Size = New System.Drawing.Size(264, 21)
        Me.cboListaCapitulos.TabIndex = 13
        '
        'txtNumeroCapitulo
        '
        Me.txtNumeroCapitulo.Enabled = False
        Me.txtNumeroCapitulo.Location = New System.Drawing.Point(163, 113)
        Me.txtNumeroCapitulo.Name = "txtNumeroCapitulo"
        Me.txtNumeroCapitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroCapitulo.TabIndex = 12
        '
        'btnModificarCapitulo
        '
        Me.btnModificarCapitulo.Location = New System.Drawing.Point(30, 198)
        Me.btnModificarCapitulo.Name = "btnModificarCapitulo"
        Me.btnModificarCapitulo.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarCapitulo.TabIndex = 11
        Me.btnModificarCapitulo.Text = "Modificar"
        Me.btnModificarCapitulo.UseVisualStyleBackColor = True
        '
        'frmModificarCapitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblTituloEpisodio)
        Me.Controls.Add(Me.lblNumeroCapitulo)
        Me.Controls.Add(Me.lblEnlaceVisualizacion)
        Me.Controls.Add(Me.lblEnlaceDescarga)
        Me.Controls.Add(Me.txtTituloCapitulo)
        Me.Controls.Add(Me.txtDescargaCapitulo)
        Me.Controls.Add(Me.txtEnlaceCapitulo)
        Me.Controls.Add(Me.cboListaCapitulos)
        Me.Controls.Add(Me.txtNumeroCapitulo)
        Me.Controls.Add(Me.btnModificarCapitulo)
        Me.Name = "frmModificarCapitulo"
        Me.Text = "frmModificarCapitulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloEpisodio As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCapitulo As System.Windows.Forms.Label
    Friend WithEvents lblEnlaceVisualizacion As System.Windows.Forms.Label
    Friend WithEvents lblEnlaceDescarga As System.Windows.Forms.Label
    Friend WithEvents txtTituloCapitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescargaCapitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtEnlaceCapitulo As System.Windows.Forms.TextBox
    Friend WithEvents cboListaCapitulos As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroCapitulo As System.Windows.Forms.TextBox
    Friend WithEvents btnModificarCapitulo As System.Windows.Forms.Button
End Class
