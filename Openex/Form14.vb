Public Class FrmOpenex14
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

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

    End Sub

    Private Sub FrmOpenex14_Load(sender As Object, e As EventArgs)
        AutoScroll = False
        HorizontalScroll.Enabled = False
        AutoScroll = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FrmOpenex24.Show()
        Me.Hide()
    End Sub

    Private Sub FrmOpenex14_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoScroll = False
        HorizontalScroll.Enabled = False
        AutoScroll = True
    End Sub
End Class