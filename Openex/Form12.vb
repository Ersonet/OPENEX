Public Class FrmOpenex12
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmOpenex9.TxtPregunta1.Text = Me.TxtRtaForUser.Text
        FrmOpenex9.TxtPregunta2.Text = Me.TxtRtaForUser.Text

        FrmOpenex11.Show()
        Me.Hide()
        TxtRtaForUser.Clear()

        'TxtRtaForUser.Text = ""
        'TxtRtaForUser.TabIndex = 1
        'TxtRtaForUser.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub LblInicio_Click(sender As Object, e As EventArgs) Handles LblInicio.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub TxtRtaForUser_TextChanged(sender As Object, e As EventArgs) Handles TxtRtaForUser.TextChanged

    End Sub
End Class