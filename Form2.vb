Public Class FrmOpenex2
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TxtUsuario.Text = "" And TxtContraseña.Text = "" Then
            FrmOpenex3.Show()
            Me.Hide()
        Else
            MsgBox("Ingresar Datos", vbCritical, "Inicio de sesiòn invalido")
            TxtUsuario.Text = ""
            TxtContraseña.Text = ""
            TxtUsuario.TabIndex = 1
            TxtUsuario.Focus()
        End If
    End Sub

    Private Sub LblText1_Click(sender As Object, e As EventArgs) Handles LblText1.Click
        FrmReg.Show()
        Me.Hide()

    End Sub

    Private Sub FrmOpenex2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class