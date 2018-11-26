Imports MySql.Data.MySqlClient
Public Class User
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub User_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call FormMati()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MedicalDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.MedicalDataSet.user)
        PanggilData()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Sub FormKosong()
        txtkode.Text = ""
        txtnama.Text = ""
        txtpass.Text = ""
        txtkode.Focus()
    End Sub

    Sub FormHidup()
        'txtkode.Enabled = True
        txtnama.Enabled = True
        txtpass.Enabled = True
    End Sub

    Sub FormMati()
        txtkode.ReadOnly = True
        txtnama.Enabled = False
        txtpass.Enabled = False
    End Sub

    Sub FormNormal()
        Call FormKosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "Keluar"
        btntambah.Focus()
    End Sub

    Sub GridBerwarna()
        With Me.dguser
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from user", Module1.Koneksi)
        Dim dt As New DataTable("user")
        Adapter.Fill(dt)
        dguser.DataSource = dt
        Call GridBerwarna()
    End Sub

    Sub Kode_Otomatis()
        CMD = New MySqlCommand("Select * From user where kd_user in(select max(kd_user) from user) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            txtkode.Text = "1"
            RD.Close()
        End If
        If Not RD.HasRows Then
            txtkode.Text = "1"
            RD.Close()
        Else
            txtkode.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("kd_user").ToString, 1, 1)) + 1
            RD.Close()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FormHidup()
        Call FormKosong()
        Call PanggilData()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"
        txtnama.Focus()
        Call Kode_Otomatis()
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call FormNormal()
            Call FormMati()
            Call PanggilData()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        If txtkode.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtkode.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtpass.Focus()

        Else
            Sql = "INSERT INTO user (kd_user,nama,password)" & "VALUES ('" & txtkode.Text & "','" & txtnama.Text & "','" & txtpass.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah Disimpan", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FormMati()
            Call FormNormal()
            Call PanggilData()
            btntambah.Focus()
        End If
    End Sub


    Private Sub dguser_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dguser.CellFormatting
        If (e.ColumnIndex <> -1 AndAlso dguser.Columns(e.ColumnIndex).DataPropertyName = "password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Focus()
        End If
        Dim Adapter As New MySqlDataAdapter("SELECT * FROM user where kd_user = '" & txtkode.Text & "' ", Module1.Koneksi)
        Dim dt As New DataTable("user")
        Adapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            MessageBox.Show("Data ngan kode" & txtkode.Text & "Sudah ada, inputkan data lain", "Ditemukan data yang sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkode.Text = ""
        End If
        dguser.DataSource = dt
    End Sub

    Private Sub dguser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dguser.Click
        Dim i As Integer
        i = dguser.CurrentRow.Index
        txtkode.Text = dguser.Item(0, i).Value
        txtnama.Text = dguser.Item(1, i).Value
        txtpass.Text = dguser.Item(2, i).Value
        Call FormHidup()
        txtkode.ReadOnly = True
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
        btnsimpan.Enabled = False
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dguser.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from user WHERE kd_user = '" & txtkode.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("data dengan kode " & txtkode.Text & " Sudah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call FormKosong()
                Call PanggilData()
                Call FormNormal()
                btnhapus.Enabled = False
                btnupdate.Enabled = False
            Else
                MessageBox.Show("Pilih dulu data yang akan di hapus", "Tidak ada data yang akan di hapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Call FormNormal()
            Call FormKosong()
            btntambah.Focus()
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim Sql As String = String.Empty
        If txtkode.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()

            txtkode.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtpass.Focus()

        Else
            Sql = "UPDATE user set kd_user = '" & txtkode.Text & "', nama = '" & txtnama.Text & "', password = '" & txtpass.Text & "' where	kd_user = '" & txtkode.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call PanggilData()
            Call FormNormal()
            btntambah.Focus()
            btnhapus.Enabled = False
            btnupdate.Enabled = False
        End If

    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub
End Class