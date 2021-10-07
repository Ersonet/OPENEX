Public Class FrmOpenex10
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnResponder_Click(sender As Object, e As EventArgs) Handles BtnResponder.Click
        FrmOpenex13.Show()
        Me.Hide()

        TxtRtaForUser.Text = ""
        TxtRtaForUser.TabIndex = 1
        TxtRtaForUser.Focus()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmOpenex15.Show()
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub
End Class