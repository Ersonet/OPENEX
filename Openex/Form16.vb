Public Class FrmOpenex16
    Private Sub Pbox2_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Pbox3_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Pbox1_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        FrmOpenex18.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
        FrmOpenex18.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        FrmOpenex18.Show()
        Me.Hide()
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

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub FrmOpenex16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoScroll = False
        HorizontalScroll.Enabled = False
        AutoScroll = True
    End Sub

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
End Class