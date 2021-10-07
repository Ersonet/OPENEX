<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpenex25
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenex25))
        Me.GroupTerminosycondiciones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.GroupTerminosycondiciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupTerminosycondiciones
        '
        Me.GroupTerminosycondiciones.BackColor = System.Drawing.Color.White
        Me.GroupTerminosycondiciones.Controls.Add(Me.Button1)
        Me.GroupTerminosycondiciones.Controls.Add(Me.TextBox2)
        Me.GroupTerminosycondiciones.Controls.Add(Me.TextBox1)
        Me.GroupTerminosycondiciones.Controls.Add(Me.BtnAceptar)
        Me.GroupTerminosycondiciones.Location = New System.Drawing.Point(12, 12)
        Me.GroupTerminosycondiciones.Name = "GroupTerminosycondiciones"
        Me.GroupTerminosycondiciones.Size = New System.Drawing.Size(280, 577)
        Me.GroupTerminosycondiciones.TabIndex = 0
        Me.GroupTerminosycondiciones.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(6, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "No Acepto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.TextBox2.Location = New System.Drawing.Point(6, 27)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(268, 505)
        Me.TextBox2.TabIndex = 48
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(0, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 17)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Text = "   Términos de uso"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(144, 538)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(130, 33)
        Me.BtnAceptar.TabIndex = 46
        Me.BtnAceptar.Text = "Acepto"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'FrmOpenex25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(304, 601)
        Me.Controls.Add(Me.GroupTerminosycondiciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpenex25"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupTerminosycondiciones.ResumeLayout(False)
        Me.GroupTerminosycondiciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupTerminosycondiciones As GroupBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
