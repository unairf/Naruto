<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.rchClientes = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.TextBoxPUERTO = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.TextBoxIP = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rchClientes
        '
        Me.rchClientes.BackColor = System.Drawing.Color.White
        Me.rchClientes.ForeColor = System.Drawing.Color.Black
        Me.rchClientes.Location = New System.Drawing.Point(21, 38)
        Me.rchClientes.Name = "rchClientes"
        Me.rchClientes.Size = New System.Drawing.Size(488, 381)
        Me.rchClientes.TabIndex = 14
        Me.rchClientes.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(515, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 381)
        Me.ListBox1.TabIndex = 18
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.ForeColor = System.Drawing.Color.Black
        Me.txtMensaje.Location = New System.Drawing.Point(20, 425)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(489, 20)
        Me.txtMensaje.TabIndex = 17
        '
        'TextBoxPUERTO
        '
        Me.TextBoxPUERTO.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBoxPUERTO.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBoxPUERTO.Location = New System.Drawing.Point(130, 12)
        Me.TextBoxPUERTO.Name = "TextBoxPUERTO"
        Me.TextBoxPUERTO.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxPUERTO.TabIndex = 16
        Me.TextBoxPUERTO.Text = "8050"
        Me.TextBoxPUERTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnConectar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnConectar.Location = New System.Drawing.Point(514, 425)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(210, 20)
        Me.btnConectar.TabIndex = 15
        Me.btnConectar.Text = "CONECTAR"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'TextBoxIP
        '
        Me.TextBoxIP.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TextBoxIP.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.TextBoxIP.Location = New System.Drawing.Point(514, 12)
        Me.TextBoxIP.Name = "TextBoxIP"
        Me.TextBoxIP.Size = New System.Drawing.Size(210, 20)
        Me.TextBoxIP.TabIndex = 13
        Me.TextBoxIP.Text = "192.168.1.15"
        Me.TextBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(330, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 19
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(745, 456)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.rchClientes)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.TextBoxPUERTO)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.TextBoxIP)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rchClientes As System.Windows.Forms.RichTextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPUERTO As System.Windows.Forms.TextBox
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents TextBoxIP As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
End Class
