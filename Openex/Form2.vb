Public Class FrmOpenex2
    Private Sub FrmOpenex2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BASEDEDATOSOPENEXDataSet.Base_de_Datos' Puede moverla o quitarla según sea necesario.
        Me.OpenexTableAdapter.Fill(Me.OpenexdatabaseDataSet.Openex)
        Me.UsuarioTextBox1.Text = ""
        Me.ContraseñaTextBox1.Text = ""
    End Sub

    Private Sub OpenexBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OpenexBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OpenexBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.OpenexdatabaseDataSet)

    End Sub

    Private Sub BtnIngresar2_Click(sender As Object, e As EventArgs) Handles BtnIngresar2.Click
        If Me.OpenexTableAdapter.OpenexBD(Me.OpenexdatabaseDataSet.Openex, UsuarioTextBox1.Text, ContraseñaTextBox1.Text) Then
            MsgBox(" Inicio de Sesión correcto ", vbInformation, " Inicio de Sesión ")
            FrmOpenex3.Show()
            Me.Hide()
        Else
            MsgBox(" Datos Incorrectos ", vbCritical, " Error al iniciar Sesión ")
        End If
    End Sub
    Private Sub UsuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ContraseñaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenexBindingSource.AddNew()
        FrmOpenex23.Show()
        Me.Hide()
    End Sub
End Class