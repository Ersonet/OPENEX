<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOpenex2
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex2))
        Me.OpenexdatabaseDataSet = New Openex.OpenexdatabaseDataSet()
        Me.OpenexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenexTableAdapter = New Openex.OpenexdatabaseDataSetTableAdapters.OpenexTableAdapter()
        Me.TableAdapterManager1 = New Openex.OpenexdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.OpenexBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenexBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsuarioTextBox1 = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnIngresar2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblText3 = New System.Windows.Forms.Label()
        Me.BtnFB = New System.Windows.Forms.Button()
        Me.BtnGmail = New System.Windows.Forms.Button()
        Me.LblSesion = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.OpenexdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenexBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpenexBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(57, 268)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(70, 21)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Usuario:"
        AddHandler UsuarioLabel.Click, AddressOf Me.UsuarioLabel_Click
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(57, 333)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(107, 21)
        ContraseñaLabel.TabIndex = 3
        ContraseñaLabel.Text = "Contraseña:"
        AddHandler ContraseñaLabel.Click, AddressOf Me.ContraseñaLabel_Click
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(103, 70)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(115, 21)
        Label3.TabIndex = 84
        Label3.Text = "Bienvenido a "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Label4.Location = New System.Drawing.Point(101, 211)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(118, 33)
        Label4.TabIndex = 85
        Label4.Text = "OPENEX"
        '
        'OpenexdatabaseDataSet
        '
        Me.OpenexdatabaseDataSet.DataSetName = "OpenexdatabaseDataSet"
        Me.OpenexdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenexBindingSource
        '
        Me.OpenexBindingSource.DataMember = "Openex"
        Me.OpenexBindingSource.DataSource = Me.OpenexdatabaseDataSet
        '
        'OpenexTableAdapter
        '
        Me.OpenexTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.OpenexTableAdapter = Me.OpenexTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Openex.OpenexdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenexBindingNavigator
        '
        Me.OpenexBindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.OpenexBindingNavigator.BindingSource = Me.OpenexBindingSource
        Me.OpenexBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.OpenexBindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.OpenexBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.OpenexBindingNavigatorSaveItem})
        Me.OpenexBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OpenexBindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.OpenexBindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.OpenexBindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.OpenexBindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.OpenexBindingNavigator.Name = "OpenexBindingNavigator"
        Me.OpenexBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.OpenexBindingNavigator.Size = New System.Drawing.Size(320, 25)
        Me.OpenexBindingNavigator.TabIndex = 0
        Me.OpenexBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Agregar nuevo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'OpenexBindingNavigatorSaveItem
        '
        Me.OpenexBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenexBindingNavigatorSaveItem.Image = CType(resources.GetObject("OpenexBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OpenexBindingNavigatorSaveItem.Name = "OpenexBindingNavigatorSaveItem"
        Me.OpenexBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OpenexBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'UsuarioTextBox1
        '
        Me.UsuarioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Usuario", True))
        Me.UsuarioTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox1.Location = New System.Drawing.Point(57, 297)
        Me.UsuarioTextBox1.Name = "UsuarioTextBox1"
        Me.UsuarioTextBox1.Size = New System.Drawing.Size(207, 27)
        Me.UsuarioTextBox1.TabIndex = 2
        '
        'ContraseñaTextBox1
        '
        Me.ContraseñaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTextBox1.Location = New System.Drawing.Point(57, 364)
        Me.ContraseñaTextBox1.Name = "ContraseñaTextBox1"
        Me.ContraseñaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox1.Size = New System.Drawing.Size(207, 27)
        Me.ContraseñaTextBox1.TabIndex = 4
        '
        'BtnIngresar2
        '
        Me.BtnIngresar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BtnIngresar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnIngresar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar2.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar2.Location = New System.Drawing.Point(68, 407)
        Me.BtnIngresar2.Name = "BtnIngresar2"
        Me.BtnIngresar2.Size = New System.Drawing.Size(184, 40)
        Me.BtnIngresar2.TabIndex = 45
        Me.BtnIngresar2.Text = "Ingresar"
        Me.BtnIngresar2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 50)
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'LblText3
        '
        Me.LblText3.AutoSize = True
        Me.LblText3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblText3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.LblText3.Location = New System.Drawing.Point(30, 474)
        Me.LblText3.Name = "LblText3"
        Me.LblText3.Size = New System.Drawing.Size(132, 17)
        Me.LblText3.TabIndex = 79
        Me.LblText3.Text = "¿No esta registrado?"
        '
        'BtnFB
        '
        Me.BtnFB.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BtnFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnFB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFB.ForeColor = System.Drawing.Color.White
        Me.BtnFB.Location = New System.Drawing.Point(30, 517)
        Me.BtnFB.Name = "BtnFB"
        Me.BtnFB.Size = New System.Drawing.Size(260, 35)
        Me.BtnFB.TabIndex = 80
        Me.BtnFB.Text = "Ingresar con Facebook"
        Me.BtnFB.UseVisualStyleBackColor = False
        '
        'BtnGmail
        '
        Me.BtnGmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BtnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGmail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGmail.ForeColor = System.Drawing.Color.White
        Me.BtnGmail.Location = New System.Drawing.Point(30, 571)
        Me.BtnGmail.Name = "BtnGmail"
        Me.BtnGmail.Size = New System.Drawing.Size(260, 35)
        Me.BtnGmail.TabIndex = 81
        Me.BtnGmail.Text = "Ingresar con Google"
        Me.BtnGmail.UseVisualStyleBackColor = False
        '
        'LblSesion
        '
        Me.LblSesion.AutoSize = True
        Me.LblSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LblSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSesion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.LblSesion.ForeColor = System.Drawing.Color.White
        Me.LblSesion.Location = New System.Drawing.Point(30, 16)
        Me.LblSesion.Name = "LblSesion"
        Me.LblSesion.Size = New System.Drawing.Size(91, 19)
        Me.LblSesion.TabIndex = 82
        Me.LblSesion.Text = "Inicio Sesión"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(85, 97)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 83
        Me.PictureBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(171, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 33)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = " Registrese gratis"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmOpenex2
        '
        Me.AcceptButton = Me.BtnIngresar2
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 640)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LblSesion)
        Me.Controls.Add(Me.BtnGmail)
        Me.Controls.Add(Me.BtnFB)
        Me.Controls.Add(Me.LblText3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnIngresar2)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox1)
        Me.Controls.Add(Me.OpenexBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpenex2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.OpenexdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenexBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpenexBindingNavigator.ResumeLayout(False)
        Me.OpenexBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBienvidos As Label
    Friend WithEvents LblOpenex2 As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblText1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblTemario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Base_de_DatosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents OpenexdatabaseDataSet As OpenexdatabaseDataSet
    Friend WithEvents OpenexBindingSource As BindingSource
    Friend WithEvents OpenexTableAdapter As OpenexdatabaseDataSetTableAdapters.OpenexTableAdapter
    Friend WithEvents TableAdapterManager1 As OpenexdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenexBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents OpenexBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsuarioTextBox1 As TextBox
    Friend WithEvents ContraseñaTextBox1 As TextBox
    Friend WithEvents BtnIngresar2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblText3 As Label
    Friend WithEvents BtnFB As Button
    Friend WithEvents BtnGmail As Button
    Friend WithEvents LblSesion As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button3 As Button
End Class
