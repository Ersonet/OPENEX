Public Class FrmOpenex1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblopenex.Click

    End Sub
    Private Sub FrmOpenex1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value = 1 Then
            FrmOpenex2.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub
End Class
