<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpenex23
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nombre_CompletoLabel As System.Windows.Forms.Label
        Dim Correo_ElectronicoLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Confirmar_ContraseñaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex23))
        Me.OpenexdatabaseDataSet = New Openex.OpenexdatabaseDataSet()
        Me.OpenexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenexTableAdapter = New Openex.OpenexdatabaseDataSetTableAdapters.OpenexTableAdapter()
        Me.TableAdapterManager = New Openex.OpenexdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.OpenexBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenexBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_CompletoTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.Confirmar_ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNewUser = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        IdLabel = New System.Windows.Forms.Label()
        Nombre_CompletoLabel = New System.Windows.Forms.Label()
        Correo_ElectronicoLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Confirmar_ContraseñaLabel = New System.Windows.Forms.Label()
        CType(Me.OpenexdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenexBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OpenexBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(46, 355)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 21)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'Nombre_CompletoLabel
        '
        Nombre_CompletoLabel.AutoSize = True
        Nombre_CompletoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_CompletoLabel.Location = New System.Drawing.Point(46, 79)
        Nombre_CompletoLabel.Name = "Nombre_CompletoLabel"
        Nombre_CompletoLabel.Size = New System.Drawing.Size(160, 21)
        Nombre_CompletoLabel.TabIndex = 3
        Nombre_CompletoLabel.Text = "Nombre Completo:"
        '
        'Correo_ElectronicoLabel
        '
        Correo_ElectronicoLabel.AutoSize = True
        Correo_ElectronicoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_ElectronicoLabel.Location = New System.Drawing.Point(46, 133)
        Correo_ElectronicoLabel.Name = "Correo_ElectronicoLabel"
        Correo_ElectronicoLabel.Size = New System.Drawing.Size(158, 21)
        Correo_ElectronicoLabel.TabIndex = 5
        Correo_ElectronicoLabel.Text = "Correo Electronico:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(46, 187)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(70, 21)
        UsuarioLabel.TabIndex = 7
        UsuarioLabel.Text = "Usuario:"
        AddHandler UsuarioLabel.Click, AddressOf Me.UsuarioLabel_Click
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(46, 241)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(107, 21)
        ContraseñaLabel.TabIndex = 9
        ContraseñaLabel.Text = "Contraseña:"
        AddHandler ContraseñaLabel.Click, AddressOf Me.ContraseñaLabel_Click
        '
        'Confirmar_ContraseñaLabel
        '
        Confirmar_ContraseñaLabel.AutoSize = True
        Confirmar_ContraseñaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Confirmar_ContraseñaLabel.Location = New System.Drawing.Point(46, 295)
        Confirmar_ContraseñaLabel.Name = "Confirmar_ContraseñaLabel"
        Confirmar_ContraseñaLabel.Size = New System.Drawing.Size(188, 21)
        Confirmar_ContraseñaLabel.TabIndex = 11
        Confirmar_ContraseñaLabel.Text = "Confirmar Contraseña:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.OpenexTableAdapter = Me.OpenexTableAdapter
        Me.TableAdapterManager.UpdateOrder = Openex.OpenexdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenexBindingNavigator
        '
        Me.OpenexBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OpenexBindingNavigator.BindingSource = Me.OpenexBindingSource
        Me.OpenexBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OpenexBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OpenexBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OpenexBindingNavigatorSaveItem})
        Me.OpenexBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OpenexBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OpenexBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OpenexBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OpenexBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OpenexBindingNavigator.Name = "OpenexBindingNavigator"
        Me.OpenexBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OpenexBindingNavigator.Size = New System.Drawing.Size(320, 25)
        Me.OpenexBindingNavigator.TabIndex = 0
        Me.OpenexBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OpenexBindingNavigatorSaveItem
        '
        Me.OpenexBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenexBindingNavigatorSaveItem.Image = CType(resources.GetObject("OpenexBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OpenexBindingNavigatorSaveItem.Name = "OpenexBindingNavigatorSaveItem"
        Me.OpenexBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OpenexBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(90, 352)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 27)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'Nombre_CompletoTextBox
        '
        Me.Nombre_CompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Nombre Completo", True))
        Me.Nombre_CompletoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_CompletoTextBox.Location = New System.Drawing.Point(46, 103)
        Me.Nombre_CompletoTextBox.Name = "Nombre_CompletoTextBox"
        Me.Nombre_CompletoTextBox.Size = New System.Drawing.Size(228, 27)
        Me.Nombre_CompletoTextBox.TabIndex = 4
        '
        'Correo_ElectronicoTextBox
        '
        Me.Correo_ElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Correo Electronico", True))
        Me.Correo_ElectronicoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo_ElectronicoTextBox.Location = New System.Drawing.Point(46, 157)
        Me.Correo_ElectronicoTextBox.Name = "Correo_ElectronicoTextBox"
        Me.Correo_ElectronicoTextBox.Size = New System.Drawing.Size(228, 27)
        Me.Correo_ElectronicoTextBox.TabIndex = 6
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(46, 211)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(229, 27)
        Me.UsuarioTextBox.TabIndex = 8
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(46, 265)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(228, 27)
        Me.ContraseñaTextBox.TabIndex = 10
        '
        'Confirmar_ContraseñaTextBox
        '
        Me.Confirmar_ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OpenexBindingSource, "Confirmar Contraseña", True))
        Me.Confirmar_ContraseñaTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirmar_ContraseñaTextBox.Location = New System.Drawing.Point(46, 319)
        Me.Confirmar_ContraseñaTextBox.Name = "Confirmar_ContraseñaTextBox"
        Me.Confirmar_ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Confirmar_ContraseñaTextBox.Size = New System.Drawing.Size(229, 27)
        Me.Confirmar_ContraseñaTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 6.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 24)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Querido Usuario, Quédese tranquilo. Nosotros no compartiremos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "su información con" &
    " terceras personas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(46, 438)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(228, 40)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Registrarse"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(30, 563)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 35)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Ingresar con Google"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(30, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 35)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Ingresar con Facebook"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Registro de Usuario"
        '
        'BtnNewUser
        '
        Me.BtnNewUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BtnNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNewUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewUser.ForeColor = System.Drawing.Color.White
        Me.BtnNewUser.Location = New System.Drawing.Point(46, 378)
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(228, 40)
        Me.BtnNewUser.TabIndex = 47
        Me.BtnNewUser.Text = "Nuevo Usuario"
        Me.BtnNewUser.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 50)
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'FrmOpenex23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 640)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnNewUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Nombre_CompletoLabel)
        Me.Controls.Add(Me.Nombre_CompletoTextBox)
        Me.Controls.Add(Correo_ElectronicoLabel)
        Me.Controls.Add(Me.Correo_ElectronicoTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Confirmar_ContraseñaLabel)
        Me.Controls.Add(Me.Confirmar_ContraseñaTextBox)
        Me.Controls.Add(Me.OpenexBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpenex23"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form23"
        CType(Me.OpenexdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenexBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OpenexBindingNavigator.ResumeLayout(False)
        Me.OpenexBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenexdatabaseDataSet As OpenexdatabaseDataSet
    Friend WithEvents OpenexBindingSource As BindingSource
    Friend WithEvents OpenexTableAdapter As OpenexdatabaseDataSetTableAdapters.OpenexTableAdapter
    Friend WithEvents TableAdapterManager As OpenexdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenexBindingNavigator As BindingNavigator
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
    Friend WithEvents OpenexBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Nombre_CompletoTextBox As TextBox
    Friend WithEvents Correo_ElectronicoTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents Confirmar_ContraseñaTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNewUser As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
