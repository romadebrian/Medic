Imports MySql.Data.MySqlClient
Public Class Dokter
    Dim koneksi = Module1.Koneksi

    Private Sub Dokter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'MedicalDataSet.dokter' table. You can move, or remove it, as needed.
        Me.DokterTableAdapter.Fill(Me.MedicalDataSet.dokter)
        PanggilData()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btntambah.Enabled = True
    End Sub

    Private Sub Dokter_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call FromMati()
    End Sub

    Sub FormKosong()
        txtkode.Text = ""
        txtnama.Text = ""
        txtsip.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
        txtkode.Focus()
    End Sub

    Sub FromHidup()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtsip.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
    End Sub

    Sub FromMati()
        txtkode.ReadOnly = True
        txtnama.Enabled = False
        txtsip.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
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
        With Me.dgdokter
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from dokter", Module1.Koneksi)
        Dim dt As New DataTable("dokter")
        Adapter.Fill(dt)
        dgdokter.DataSource = dt
        Call GridBerwarna()
    End Sub

    'Private Sub btntambah_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Sub btntambah_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FromHidup()
        Call FormKosong()
        Call PanggilData()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"
        txtkode.Focus()
        txtkode.ReadOnly = False
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call FormNormal()
            Call FromMati()
            Call PanggilData()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        If txtkode.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            'Call FormKosong()
            'Call PanggilData()
            txtkode.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            'Call FormKosong()
            'Call PanggilData()
            txtnama.Focus()
        ElseIf txtsip.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtsip.Focus()
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtalamat.Focus()
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txttelp.Focus()

        Else
            Sql = "INSERT INTO dokter (kd_dokter,nama_dokter,sip,alamat,telp)" & "VALUES ('" & txtkode.Text & "','" & txtnama.Text & "','" & txtsip.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "') "
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah Disimpan", " Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormKosong()
            Call FromMati()
            Call FormNormal()
            Call PanggilData()
            btntambah.Focus()
        End If
        'Call FormKosong()
        'Call PanggilData()
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Focus()
        End If
        Dim Adapter As New MySqlDataAdapter("Select * from dokter where kd_dokter = '" & txtkode.Text & "'", Module1.Koneksi)
        Dim dt As New DataTable("dokter")
        Adapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah ada, inputkan data lain", " Ditemukan data yang sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkode.Text = " "
            btnsimpan.Enabled = False
            btnkeluar.Focus()
        End If
        dgdokter.DataSource = dt
    End Sub

    Private Sub dgdokter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdokter.Click
        Dim i As Integer
        i = dgdokter.CurrentRow.Index
        txtkode.Text = dgdokter.Item(0, i).Value
        txtnama.Text = dgdokter.Item(1, i).Value
        txtsip.Text = dgdokter.Item(2, i).Value
        txtalamat.Text = dgdokter.Item(3, i).Value
        txttelp.Text = dgdokter.Item(4, i).Value
        Call FromHidup()
        txtkode.ReadOnly = True
        btnhapus.Enabled = True
        btnupdate.Enabled = True
        btntambah.Enabled = False
        btnkeluar.Text = "&Normal"
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim peringatan As MessageBoxOptions
        peringatan = MessageBox.Show("Apakah anda ingin menghapus data ?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If peringatan = vbYes Then
            If dgdokter.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "DELETE from dokter WHERE kd_dokter = '" & txtkode.Text & "'"
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
        If txtkode.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtkode.ReadOnly = True
            'Call FormKosong()
            'Call PanggilData()
            txtkode.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtkode.ReadOnly = True
            'Call FormKosong()
            'Call PanggilData()
            txtnama.Focus()
        ElseIf txtsip.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtkode.ReadOnly = True
            txtsip.Focus()
        ElseIf txtalamat.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtkode.ReadOnly = True
            txtalamat.Focus()
        ElseIf txttelp.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FromHidup()
            txtkode.ReadOnly = True
            txttelp.Focus()

        Else
            Dim Sql As String = String.Empty
            Sql = "UPDATE dokter set kd_dokter = '" & txtkode.Text & "', nama_dokter = '" & txtnama.Text & "', sip = '" & txtsip.Text & "', alamat = '" & txtalamat.Text & "', telp = '" & txttelp.Text & "' where	kd_dokter = '" & txtkode.Text & "'"
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
            txtsip.Focus()
        End If
    End Sub

    Private Sub txtsip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsip.KeyPress
        If e.KeyChar = Chr(13) Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(13) Then
            txttelp.Focus()
        End If
    End Sub

    Private Sub txttelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            btnsimpan.Focus()
        End If
    End Sub



End Class