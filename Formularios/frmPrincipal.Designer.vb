<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobarVersiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirCapítuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCapítuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpCapitulos = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlayMusic = New System.Windows.Forms.Button()
        Me.rdbShippuden = New System.Windows.Forms.RadioButton()
        Me.rdbNaruto = New System.Windows.Forms.RadioButton()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblShippuden = New System.Windows.Forms.Label()
        Me.lblNaruto = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentanasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(202, 217)
        Me.MenuStrip1.MdiWindowListItem = Me.ArchivoToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(140, 23)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobarVersiónToolStripMenuItem, Me.AñadirCapítuloToolStripMenuItem, Me.ModificarCapítuloToolStripMenuItem, Me.AjustesToolStripMenuItem, Me.ChatToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 19)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ComprobarVersiónToolStripMenuItem
        '
        Me.ComprobarVersiónToolStripMenuItem.Name = "ComprobarVersiónToolStripMenuItem"
        Me.ComprobarVersiónToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ComprobarVersiónToolStripMenuItem.Text = "Comprobar versión"
        '
        'AñadirCapítuloToolStripMenuItem
        '
        Me.AñadirCapítuloToolStripMenuItem.Name = "AñadirCapítuloToolStripMenuItem"
        Me.AñadirCapítuloToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AñadirCapítuloToolStripMenuItem.Text = "Añadir capítulo"
        '
        'ModificarCapítuloToolStripMenuItem
        '
        Me.ModificarCapítuloToolStripMenuItem.Name = "ModificarCapítuloToolStripMenuItem"
        Me.ModificarCapítuloToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ModificarCapítuloToolStripMenuItem.Text = "Modificar capítulo"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'ChatToolStripMenuItem
        '
        Me.ChatToolStripMenuItem.Name = "ChatToolStripMenuItem"
        Me.ChatToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ChatToolStripMenuItem.Text = "Chat"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'grpCapitulos
        '
        Me.grpCapitulos.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.grpCapitulos.Location = New System.Drawing.Point(205, 277)
        Me.grpCapitulos.Name = "grpCapitulos"
        Me.grpCapitulos.Size = New System.Drawing.Size(423, 202)
        Me.grpCapitulos.TabIndex = 4
        Me.grpCapitulos.TabStop = False
        Me.grpCapitulos.Text = "Capitulos"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(124, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(124, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(504, 514)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 8
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'btnPlayMusic
        '
        Me.btnPlayMusic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPlayMusic.Location = New System.Drawing.Point(235, 514)
        Me.btnPlayMusic.Name = "btnPlayMusic"
        Me.btnPlayMusic.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayMusic.TabIndex = 7
        Me.btnPlayMusic.Text = "Play"
        Me.btnPlayMusic.UseVisualStyleBackColor = True
        Me.btnPlayMusic.Visible = False
        '
        'rdbShippuden
        '
        Me.rdbShippuden.AutoSize = True
        Me.rdbShippuden.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.rdbShippuden.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbShippuden.Location = New System.Drawing.Point(499, 258)
        Me.rdbShippuden.Name = "rdbShippuden"
        Me.rdbShippuden.Size = New System.Drawing.Size(13, 12)
        Me.rdbShippuden.TabIndex = 23
        Me.rdbShippuden.TabStop = True
        Me.rdbShippuden.UseVisualStyleBackColor = False
        '
        'rdbNaruto
        '
        Me.rdbNaruto.AutoSize = True
        Me.rdbNaruto.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.rdbNaruto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdbNaruto.Location = New System.Drawing.Point(499, 227)
        Me.rdbNaruto.Name = "rdbNaruto"
        Me.rdbNaruto.Size = New System.Drawing.Size(13, 12)
        Me.rdbNaruto.TabIndex = 22
        Me.rdbNaruto.TabStop = True
        Me.rdbNaruto.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Red
        Me.btnCerrar.Location = New System.Drawing.Point(590, 222)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 23)
        Me.btnCerrar.TabIndex = 21
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(630, 440)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 25)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(662, 440)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 25)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'lblShippuden
        '
        Me.lblShippuden.AutoSize = True
        Me.lblShippuden.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblShippuden.Location = New System.Drawing.Point(519, 258)
        Me.lblShippuden.Name = "lblShippuden"
        Me.lblShippuden.Size = New System.Drawing.Size(58, 13)
        Me.lblShippuden.TabIndex = 24
        Me.lblShippuden.Text = "Shippuden"
        '
        'lblNaruto
        '
        Me.lblNaruto.AutoSize = True
        Me.lblNaruto.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblNaruto.Location = New System.Drawing.Point(519, 227)
        Me.lblNaruto.Name = "lblNaruto"
        Me.lblNaruto.Size = New System.Drawing.Size(39, 13)
        Me.lblNaruto.TabIndex = 25
        Me.lblNaruto.Text = "Naruto"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Formularios.My.Resources.Resources.marcoConNaruto
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 900)
        Me.Controls.Add(Me.lblNaruto)
        Me.Controls.Add(Me.lblShippuden)
        Me.Controls.Add(Me.rdbShippuden)
        Me.Controls.Add(Me.rdbNaruto)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPlayMusic)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpCapitulos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Naruto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirCapítuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCapítuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpCapitulos As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnPlayMusic As System.Windows.Forms.Button
    Friend WithEvents rdbShippuden As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNaruto As System.Windows.Forms.RadioButton
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblShippuden As System.Windows.Forms.Label
    Friend WithEvents lblNaruto As System.Windows.Forms.Label
    Friend WithEvents ComprobarVersiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
End Class
