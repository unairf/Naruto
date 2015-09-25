<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBuscarActualizaciones = New System.Windows.Forms.Label()
        Me.chkBuscarActualizaciones = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBuscarActualizaciones
        '
        Me.lblBuscarActualizaciones.AutoSize = True
        Me.lblBuscarActualizaciones.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblBuscarActualizaciones.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.lblBuscarActualizaciones.Location = New System.Drawing.Point(379, 169)
        Me.lblBuscarActualizaciones.Name = "lblBuscarActualizaciones"
        Me.lblBuscarActualizaciones.Size = New System.Drawing.Size(200, 13)
        Me.lblBuscarActualizaciones.TabIndex = 0
        Me.lblBuscarActualizaciones.Text = "Buscar actualizaciones automáticamente"
        '
        'chkBuscarActualizaciones
        '
        Me.chkBuscarActualizaciones.AutoSize = True
        Me.chkBuscarActualizaciones.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.chkBuscarActualizaciones.Location = New System.Drawing.Point(618, 168)
        Me.chkBuscarActualizaciones.Name = "chkBuscarActualizaciones"
        Me.chkBuscarActualizaciones.Size = New System.Drawing.Size(15, 14)
        Me.chkBuscarActualizaciones.TabIndex = 1
        Me.chkBuscarActualizaciones.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(322, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descargar lista de episodios automáticamente"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(379, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nota: eliminará cualquier capítulo que hayas modificado"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.CheckBox1.Location = New System.Drawing.Point(618, 221)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(322, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mostrar tutorial en el menú desplegable"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.CheckBox2.Location = New System.Drawing.Point(618, 332)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(494, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Formularios.My.Resources.Resources.blanch1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1094, 595)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkBuscarActualizaciones)
        Me.Controls.Add(Me.lblBuscarActualizaciones)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjustes"
        Me.Text = "frmAjustes"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscarActualizaciones As Label
    Friend WithEvents chkBuscarActualizaciones As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button1 As Button
End Class
