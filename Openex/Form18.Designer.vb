<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOpenex18
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btncontenido As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents LblOpenex2 As Label
    Friend WithEvents LblBienvidos As Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex18))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btncontenido = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.LblOpenex2 = New System.Windows.Forms.Label()
        Me.LblBienvidos = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Btncontenido
        '
        Me.Btncontenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btncontenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Btncontenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btncontenido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncontenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncontenido.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Btncontenido.ForeColor = System.Drawing.Color.White
        Me.Btncontenido.Location = New System.Drawing.Point(79, 566)
        Me.Btncontenido.Name = "Btncontenido"
        Me.Btncontenido.Size = New System.Drawing.Size(161, 34)
        Me.Btncontenido.TabIndex = 125
        Me.Btncontenido.Text = "Descubrir Openex"
        Me.Btncontenido.UseVisualStyleBackColor = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(-19, 107)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(357, 337)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 126
        Me.PictureBox9.TabStop = False
        '
        'LblOpenex2
        '
        Me.LblOpenex2.AutoSize = True
        Me.LblOpenex2.Font = New System.Drawing.Font("Century Gothic", 40.0!)
        Me.LblOpenex2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblOpenex2.Location = New System.Drawing.Point(40, 358)
        Me.LblOpenex2.Name = "LblOpenex2"
        Me.LblOpenex2.Size = New System.Drawing.Size(238, 65)
        Me.LblOpenex2.TabIndex = 127
        Me.LblOpenex2.Text = "OPENEX"
        '
        'LblBienvidos
        '
        Me.LblBienvidos.AutoSize = True
        Me.LblBienvidos.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LblBienvidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblBienvidos.Location = New System.Drawing.Point(14, 423)
        Me.LblBienvidos.Name = "LblBienvidos"
        Me.LblBienvidos.Size = New System.Drawing.Size(290, 19)
        Me.LblBienvidos.TabIndex = 128
        Me.LblBienvidos.Text = "Aprender Excel, nunca fue tan divertido!"
        '
        'FrmOpenex18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 640)
        Me.Controls.Add(Me.LblBienvidos)
        Me.Controls.Add(Me.LblOpenex2)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Btncontenido)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpenex18"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        End
    End Sub

    Private Sub Btncontenido_Click(sender As Object, e As EventArgs) Handles Btncontenido.Click
        FrmOpenex23.Show()
        Me.Hide()
    End Sub
End Class
