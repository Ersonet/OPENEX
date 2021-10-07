Public Class FrmOpenex15
    Private Sub LblForo_Click(sender As Object, e As EventArgs) Handles LblForo.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub FrmOpenex15_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmOpenex3.Show()
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
End Class