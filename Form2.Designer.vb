<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpenex2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex2))
        Me.LblBienvidos = New System.Windows.Forms.Label()
        Me.LblOpenex2 = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblText1 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LblTemario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBienvidos
        '
        Me.LblBienvidos.AutoSize = True
        Me.LblBienvidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblBienvidos.Location = New System.Drawing.Point(29, 91)
        Me.LblBienvidos.Name = "LblBienvidos"
        Me.LblBienvidos.Size = New System.Drawing.Size(261, 39)
        Me.LblBienvidos.TabIndex = 0
        Me.LblBienvidos.Text = "BIENVENIDO A"
        '
        'LblOpenex2
        '
        Me.LblOpenex2.AutoSize = True
        Me.LblOpenex2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.LblOpenex2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblOpenex2.Location = New System.Drawing.Point(40, 133)
        Me.LblOpenex2.Name = "LblOpenex2"
        Me.LblOpenex2.Size = New System.Drawing.Size(252, 63)
        Me.LblOpenex2.TabIndex = 2
        Me.LblOpenex2.Text = "OPENEX"
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
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(69, 402)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(176, 43)
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'LblText1
        '
        Me.LblText1.AutoSize = True
        Me.LblText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LblText1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblText1.Location = New System.Drawing.Point(98, 457)
        Me.LblText1.Name = "LblText1"
        Me.LblText1.Size = New System.Drawing.Size(133, 17)
        Me.LblText1.TabIndex = 4
        Me.LblText1.Text = "REGISTRATE AQUÌ"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(47, 258)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(232, 26)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(47, 348)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(232, 26)
        Me.TxtContraseña.TabIndex = 2
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblUsuario.Location = New System.Drawing.Point(43, 220)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(74, 24)
        Me.LblUsuario.TabIndex = 7
        Me.LblUsuario.Text = "Usuario"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblContraseña.Location = New System.Drawing.Point(43, 304)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(106, 24)
        Me.LblContraseña.TabIndex = 8
        Me.LblContraseña.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(296, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "REGISTRATE CON FACEBOOK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(12, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(296, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "REGISTRATE CON GOOGLE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(45, 600)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No compartiremos ninguna informaciòn."
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(22, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'LblTemario
        '
        Me.LblTemario.AutoSize = True
        Me.LblTemario.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblTemario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblTemario.ForeColor = System.Drawing.Color.White
        Me.LblTemario.Location = New System.Drawing.Point(58, 14)
        Me.LblTemario.Name = "LblTemario"
        Me.LblTemario.Size = New System.Drawing.Size(118, 20)
        Me.LblTemario.TabIndex = 33
        Me.LblTemario.Text = "Inicio de sesiòn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 50)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(111, 620)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 9)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Versiòn Instalada 1.1.2"
        '
        'FrmOpenex2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LblTemario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblText1)
        Me.Controls.Add(Me.LblBienvidos)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.LblOpenex2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmOpenex2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBienvidos As Label
    Friend WithEvents LblOpenex2 As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblText1 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblTemario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
