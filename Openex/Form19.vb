Public Class FrmOpenex19
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmOpenex20.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea desvincular su cuenta de nuestra app?", vbExclamation) Then
            FrmOpenex18.Show()
            Me.Hide()
        End If
    End Sub
End Class