﻿Public Class FrmOpenex21
    Private Sub FrmOpenex21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoScroll = False
        HorizontalScroll.Enabled = False
        AutoScroll = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        FrmOpenex2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex4.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmOpenex15.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub LblInicio_Click(sender As Object, e As EventArgs) Handles LblInicio.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub LblForo_Click(sender As Object, e As EventArgs) Handles LblForo.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub
End Class