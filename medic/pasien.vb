Imports MySql.Data.MySqlClient
Public Class pasien
    Dim gender As String
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Sub GridBerwarna()
        With Me.dgpasien
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub FromHidup()
        txtno.ReadOnly = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
        cbagama.Enabled = True
        rblaki.Enabled = True
        rbperempuan.Enabled = True
        dtlahir.Enabled = True
        'dgpasien.Enabled = True
    End Sub

    Sub FromMati()
        txtno.ReadOnly = True
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
        cbagama.Enabled = False
        rblaki.Enabled = False
        rbperempuan.Enabled = False
        dtlahir.Enabled = False
        'dgpasien.Enabled = False
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from pasien", Module1.Koneksi)
        Dim dt As New DataTable("pasien")
        Adapter.Fill(dt)
        dgpasien.DataSource = dt
        Call GridBerwarna()
    End Sub

    Sub FormKosong()
        txtno.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
        rblaki.Checked = True
        rbperempuan.Checked = False
        cbagama.Text = ""
        dtlahir.Text = ""
        txtno.Focus()
    End Sub

    Sub FormNormal()
        Call FormKosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnupdate.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "Keluar"
        btntambah.Focus()
    End Sub

    Sub Kode_Otomatis()
        CMD = New MySqlCommand("Select * From pasien where no_pasien in(select max(no_pasien) from pasien) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            txtno.Text = "1"
            RD.Close()
        End If
        If Not RD.HasRows Then
            txtno.Text = "1"
            RD.Close()
        Else
            txtno.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("no_pasien").ToString, 1, 1)) + 1
            RD.Close()
        End If
    End Sub

    Private Sub pasien_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call FromMati()
    End Sub

    Private Sub pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MedicalDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.MedicalDataSet.pasien)
        PanggilData()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        'btnsimpan.Enabled = Fals
        btnupdate.Enabled = False
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FromHidup()
        Call FormKosong()
        Call PanggilData()
        Call Kode_Otomatis()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"
        txtnama.Focus()
        txtno.ReadOnly = True
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call FormNormal()
            Call FromMati()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        If rblaki.Checked = True Then
            gender = rblaki.Text
        Else
            gender = rbperempuan.Text
        End If

        If txtno.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtno.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtnama.Focus()
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            cbagama.Focus()
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtalamat.Focus()
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txttelp.Focus()
            'ElseIf txttelp.Text <> IsNumeric(txttelp) Then
            'MessageBox.Show("Nomor Telepon Harus Numeric", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Call FromHidup()
            'txttelp.Focus()
            

        Else
            Sql = "INSERT INTO pasien (no_pasien,nama_pasien,jenkel,agama,alamat,tgl_lahir,telp)" & "VALUES ('" & txtno.Text & "','" & txtnama.Text & "','" & gender & "','" & cbagama.Text & "','" & txtalamat.Text & "','" & Format(dtlahir.Value, "yyy-MM-dd") & "','" & txttelp.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtno.Text & " Sudah Disimpan", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FromMati()
            Call FormNormal()
            Call PanggilData()
            btntambah.Focus()

        End If
        'Call FormKosong()
        'Call PanggilData()
    End Sub

    Private Sub dgpasien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpasien.Click
        Dim i As Integer
        i = dgpasien.CurrentRow.Index
        txtno.Text = dgpasien.Item(0, i).Value
        txtnama.Text = dgpasien.Item(1, i).Value
        If dgpasien.Item(2, i).Value = "Laki -Laki" Then
            rblaki.Checked = True
        Else
            rbperempuan.Checked = True
        End If
        cbagama.Text = dgpasien.Item(3, i).Value
        txtalamat.Text = dgpasien.Item(4, i).Value
        dtlahir.Text = dgpasien.Item(5, i).Value
        txttelp.Text = dgpasien.Item(6, i).Value
        Call FromHidup()
        'txtno.Enabled = False
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
        btnsimpan.Enabled = False

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dgpasien.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from pasien WHERE no_pasien = '" & txtno.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("data dengan kode " & txtno.Text & " Sudah di hapus", " Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call FormKosong()
                Call PanggilData()
                Call FormNormal()
                'btnhapus.Enabled = False
                'btnupdate.Enabled = False
                'btntambah.Enabled = True
            Else
                MessageBox.Show("Pilih dulu data yang akan di hapus", "Tidak ada data yang akan di hapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Call FormNormal()
            Call FormKosong()
            btntambah.Focus()
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Dim Sql As String = String.Empty
        If rblaki.Checked = True Then
            gender = rblaki.Text
        Else : rbperempuan.Checked = True
            gender = rbperempuan.Text
        End If

        If txtno.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtno.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtnama.Focus()
        ElseIf cbagama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            cbagama.Focus()
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtalamat.Focus()
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txttelp.Focus()


        Else
            Sql = "UPDATE pasien set no_pasien = '" & txtno.Text & "', nama_pasien = '" & txtnama.Text & "', jenkel = '" & gender & "', agama = '" & cbagama.Text & "', alamat = '" & txtalamat.Text & "', tgl_lahir = '" & Format(dtlahir.Value, "yyyy-MM-dd") & "', telp = '" & txtno.Text & "' where	no_pasien = '" & txtno.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan no pasien " & txtno.Text & " Sudah di Update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call PanggilData()
            Call FormNormal()
            btntambah.Focus()
            btnhapus.Enabled = False
            btnupdate.Enabled = False
        End If
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtnama.Focus()
        End If
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            rblaki.Focus()
        End If
    End Sub

    Private Sub rblaki_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rblaki.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbagama.Focus()
        End If
    End Sub

    Private Sub rbperempuan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbperempuan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cbagama.Focus()
        End If
    End Sub

    Private Sub cbagama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbagama.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(13) Then
            dtlahir.Focus()
        End If
    End Sub

    Private Sub dtlahir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtlahir.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txttelp.Focus()
        End If
    End Sub

    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub
End Class

