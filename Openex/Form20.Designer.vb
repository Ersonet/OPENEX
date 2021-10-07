<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpenex20
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex20))
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblBienvidos = New System.Windows.Forms.Label()
        Me.LblOpenex2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(5, 161)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(310, 300)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 118
        Me.PictureBox8.TabStop = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.Location = New System.Drawing.Point(80, 520)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(164, 37)
        Me.BtnIngresar.TabIndex = 135
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'LblBienvidos
        '
        Me.LblBienvidos.AutoSize = True
        Me.LblBienvidos.BackColor = System.Drawing.Color.White
        Me.LblBienvidos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblBienvidos.Location = New System.Drawing.Point(52, 62)
        Me.LblBienvidos.Name = "LblBienvidos"
        Me.LblBienvidos.Size = New System.Drawing.Size(221, 23)
        Me.LblBienvidos.TabIndex = 136
        Me.LblBienvidos.Text = "¡Bienvenido a Openex!"
        '
        'LblOpenex2
        '
        Me.LblOpenex2.AutoSize = True
        Me.LblOpenex2.BackColor = System.Drawing.Color.White
        Me.LblOpenex2.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.LblOpenex2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblOpenex2.Location = New System.Drawing.Point(64, 95)
        Me.LblOpenex2.Name = "LblOpenex2"
        Me.LblOpenex2.Size = New System.Drawing.Size(198, 20)
        Me.LblOpenex2.TabIndex = 137
        Me.LblOpenex2.Text = "Inicia para conocer Excel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 570)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 16)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "¿ Tienes una cuenta ?   Iniciar Sesión"
        '
        'FrmOpenex20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 640)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblBienvidos)
        Me.Controls.Add(Me.LblOpenex2)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpenex20"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblBienvidos As Label
    Friend WithEvents LblOpenex2 As Label
    Friend WithEvents Label1 As Label
End Class
