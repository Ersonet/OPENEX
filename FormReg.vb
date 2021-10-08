Imports System.Data.SqlClient

Public Class FrmReg
    Dim TextN As String
    Dim TextA As String

    Private Sub TxtNombres_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNombres.Validating
        If TxtNombres.Text.Length = 0 Then
            ErrorProvider1.SetError(TxtNombres, "Ingresa Tu Nombre")
        Else
            ErrorProvider1.SetError(TxtNombres, "")
        End If
    End Sub

    Private Sub TxtApellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtApellidos.Validating
        If TxtApellidos.Text.Length = 0 Then
            ErrorProvider1.SetError(TxtApellidos, "Ingresa Tus Apellidos")
        Else
            ErrorProvider1.SetError(TxtApellidos, "")
        End If
    End Sub

    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles BtnComenzar.Click
        Dim Conexion As String
        Conexion = "Data Source=D4B1D14Z-PC;Initial Catalog=Openex;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = Conexion

        Dim adaptador As New SqlCommand("insert into Usuarios values('" & EMail.Text & "','" & TxtNombres.Text & "','" & TxtApellidos.Text & "','" & Sexo.Text & "','" & Fecha_Nacim.Text & "','" & CContraseña.Text & "','" & N_Usuario.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
    End Sub

    Private Sub TxtNombres_Leave(sender As Object, e As EventArgs) Handles TxtNombres.Leave
        TextN = TxtNombres.Text
        TxtNombres.Text = ""
        TxtNombres.Text = TextN
    End Sub

    Private Sub TxtApellidos_Leave(sender As Object, e As EventArgs) Handles TxtApellidos.Leave
        TextA = TxtApellidos.Text
        TxtApellidos.Text = ""
        TxtApellidos.Text = TextA
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Hide()
        PictureBox5.Show()
        Contraseña.PasswordChar = "*"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox5.Hide()
        PictureBox2.Show()
        Contraseña.PasswordChar = New Char()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Hide()
        PictureBox6.Show()
        CContraseña.PasswordChar = "*"
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Hide()
        PictureBox7.Show()
        CContraseña.PasswordChar = New Char()
    End Sub
    

    Private Sub FrmReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class