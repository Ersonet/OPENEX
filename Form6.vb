Public Class FrmOpenex6
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex4.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub TxtAllText_TextChanged(sender As Object, e As EventArgs) Handles TxtAllText.TextChanged

    End Sub
End Class