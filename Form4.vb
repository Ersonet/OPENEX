Public Class FrmOpenex4
    Private Sub FrmOpenex4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LblMate.Parent = PtrAsig1 codigo para  cambiar color del label
        'LblMate.BackColor = Color.Transparent color del fondo
    End Sub

    Private Sub LblMate_Click(sender As Object, e As EventArgs) Handles LblMate.Click
        FrmOpenex5.Show()
        Me.Hide()
    End Sub

    Private Sub LblContab_Click(sender As Object, e As EventArgs) Handles LblContab.Click
        FrmOpenex6.Show()
        Me.Hide()
    End Sub

    Private Sub LblFinanzas_Click(sender As Object, e As EventArgs) Handles LblFinanzas.Click
        FrmOpenex7.Show()
        Me.Hide()
    End Sub

    Private Sub PtrAsig1_Click(sender As Object, e As EventArgs) Handles PtrAsig1.Click
        FrmOpenex5.Show()
        Me.Hide()
    End Sub

    Private Sub PtrAsig2_Click(sender As Object, e As EventArgs) Handles PtrAsig2.Click
        FrmOpenex6.Show()
        Me.Hide()
    End Sub

    Private Sub PtrAsig3_Click(sender As Object, e As EventArgs) Handles PtrAsig3.Click
        FrmOpenex7.Show()
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

    Private Sub PtrAsig4_Click(sender As Object, e As EventArgs) Handles PtrAsig4.Click
        FrmOpenex8.Show()
        Me.Hide()
    End Sub

    Private Sub LblCienE_Click(sender As Object, e As EventArgs) Handles LblCienE.Click
        FrmOpenex8.Show()
        Me.Hide()
    End Sub
End Class