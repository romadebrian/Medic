Imports MySql.Data.MySqlClient
Public Class Login
    Dim koneksi = Module1.Koneksi

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtuser.Focus()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnlogin.Focus()
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim aksi As String = String.Empty
        aksi = "select * from user where nama = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "'"
        Dim Sqlku As New MySqlCommand(aksi, Module1.Koneksi)
        Dim Myreder As MySqlDataReader
        Myreder = Sqlku.ExecuteReader
        If Myreder.HasRows = 0 Then
            MsgBox("Username atau Password ada yang salah !", MsgBoxStyle.Exclamation, "Error Login")
            txtuser.Clear()
            txtpass.Clear()
            txtuser.Focus()
        Else
            MsgBox("Login Berhasil, Selamat Datang " & txtuser.Text & "!", MsgBoxStyle.Information, "Successful Login")
            MenuUtama.Show()
            Me.Hide()
            Transaksi.txtkodeuser.Text = txtuser.Text
        End If
    End Sub
End Class