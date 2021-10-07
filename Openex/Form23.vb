Public Class FrmOpenex23
    Private Sub OpenexBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OpenexBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OpenexBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OpenexdatabaseDataSet)

    End Sub

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OpenexdatabaseDataSet.Openex' Puede moverla o quitarla según sea necesario.
        Me.OpenexTableAdapter.Fill(Me.OpenexdatabaseDataSet.Openex)
        Nombre_CompletoTextBox.Text = ""
        Correo_ElectronicoTextBox.Text = ""
        UsuarioTextBox.Text = ""
        ContraseñaTextBox.Text = ""
        Confirmar_ContraseñaTextBox.Text = ""
    End Sub

    Private Sub UsuarioLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenexBindingSource.EndEdit()
        OpenexTableAdapter.Update(OpenexdatabaseDataSet.Openex)
        MsgBox(" Se ha registrado correctamente ", vbInformation, " Iniciar Sesión ")
        FrmOpenex25.Show()
        Me.Hide()
    End Sub

    Private Sub ContraseñaLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
        OpenexBindingSource.AddNew()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class