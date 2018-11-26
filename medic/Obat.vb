Imports MySql.Data.MySqlClient
Public Class Obat
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader

    Private Sub Obat1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call FormMati()
    End Sub

    Private Sub Obat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MedicalDataSet.obat' table. You can move, or remove it, as needed.
        Me.ObatTableAdapter.Fill(Me.MedicalDataSet.obat)
        PanggilData()
        btnsimpan.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False

        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("id-ID")
    End Sub

    Sub FormKosong()
        txtkode.Text = ""
        txtnama.Text = ""
        txtstok.Text = ""
        txtukuran.Text = ""
        txtharga.Text = ""
        txtkode.Focus()
    End Sub

    Sub FormHidup()
        'txtkode.Enabled = True
        txtnama.Enabled = True
        txtstok.Enabled = True
        txtukuran.Enabled = True
        txtharga.Enabled = True
    End Sub

    Sub FormMati()
        txtkode.ReadOnly = True
        'txtkode.Enabled = False
        txtnama.Enabled = False
        txtstok.Enabled = False
        txtukuran.Enabled = False
        txtharga.Enabled = False
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
        With Me.dgobat
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub PanggilData()
        Dim Adapter As New MySqlDataAdapter("select * from obat", Module1.Koneksi)
        Dim dt As New DataTable("obat")
        Adapter.Fill(dt)
        dgobat.DataSource = dt
        Call GridBerwarna()
        dgobat.Columns(4).DefaultCellStyle.Format = "c"
        dgobat.Refresh()

    End Sub

    Sub Kode_Otomatis()
        CMD = New MySqlCommand("Select * From obat where kd_obat in(select max(kd_obat) from obat) ", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            txtkode.Text = "OBT001"
            RD.Close()
        End If
        If Not RD.HasRows Then
            txtkode.Text = "OBT" + "001"
            RD.Close()
        Else
            txtkode.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("kd_obat").ToString, 4, 3)) + 1
            If Len(txtkode.Text) = 1 Then
                txtkode.Text = "OBT00" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 2 Then
                txtkode.Text = "OBT0" & txtkode.Text & ""
            ElseIf Len(txtkode.Text) = 3 Then
                txtkode.Text = "OBT" & txtkode.Text & ""
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FormHidup()
        Call FormKosong()
        Call PanggilData()
        Call Kode_Otomatis()
        txtnama.Focus()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnhapus.Enabled = False
        btnupdate.Enabled = False
        btnkeluar.Text = "&Normal"

    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call FormNormal()
            Call FormMati()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim sql As String = String.Empty
        If txtkode.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkode.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
        ElseIf txtstok.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtstok.Focus()
        ElseIf txtukuran.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtukuran.Focus()
        ElseIf txtharga.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtharga.Focus()

        Else
            sql = "INSERT INTO obat (kd_obat,nama_obat,stok,ukuran,harga)" & " VALUES ('" & txtkode.Text & "', '" & txtnama.Text & "', '" & txtstok.Text & "', '" & txtukuran.Text & "', '" & txtharga.Text & "')"
            Dim command As New MySqlCommand(sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah disimpan", "Simpan data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormNormal()
            Call FormKosong()
            Call PanggilData()
        End If
        
    End Sub

    Private Sub dgobat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgobat.Click
        Dim i As Integer
        i = dgobat.CurrentRow.Index()
        txtkode.Text = dgobat.Item(0, i).Value
        txtnama.Text = dgobat.Item(1, i).Value
        txtstok.Text = dgobat.Item(2, i).Value
        txtukuran.Text = dgobat.Item(3, i).Value
        txtharga.Text = dgobat.Item(4, i).Value
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
            If dgobat.CurrentRow.Index > -1 Then
                Dim Sql As String = String.Empty
                Sql = "Delete from obat where kd_obat = '" & txtkode.Text & "'"
                Dim command As New MySqlCommand(Sql, Module1.Koneksi)
                command.ExecuteNonQuery()
                Module1.Koneksi.Close()
                MessageBox.Show("Data dengan kode " & txtkode.Text & "Sudah di hapus", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call FormKosong()
                Call PanggilData()
                Call FormNormal()
                btnhapus.Enabled = False
                btnupdate.Enabled = False
            Else
                MessageBox.Show("Pilih dulu data yang akan dihapus", "Tidak ada data yang akan dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            txtkode.ReadOnly = True

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtnama.Focus()
            txtkode.ReadOnly = True
        ElseIf txtstok.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtstok.Focus()
            txtkode.ReadOnly = True
        ElseIf txtukuran.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtukuran.Focus()
            txtkode.ReadOnly = True
        ElseIf txtharga.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtharga.Focus()
            txtkode.ReadOnly = True

        Else
            Sql = "UPDATE obat SET kd_obat = '" & txtkode.Text & "', nama_obat = '" & txtnama.Text & "', stok = '" & txtstok.Text & "', ukuran = '" & txtukuran.Text & "', harga = '" & txtharga.Text & "' WHERE kd_obat = '" & txtkode.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & " Sudah diupdate", "Update data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            txtstok.Focus()
        End If
    End Sub

    Private Sub txtstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            txtukuran.Focus()
        End If
    End Sub

    Private Sub txtukuran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtukuran.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtharga.Focus()
        End If
    End Sub

    Private Sub txtharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

    'Private Sub txtharga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtharga.TextChanged
    '   If txtharga.Text.Length <= 2 Then ' jika panjang karakter pada textbox1 <= 2
    '      txtharga.Text = FormatCurrency(0) ' menampilkan Rp0
    ' Else ' jika tidak
    '    txtharga.Text = FormatCurrency(txtharga.Text) ' mengubah format pada textbox1 menjadi currency
    '   txtharga.SelectionStart = txtharga.Text.Length '  menetapkan titik awal dari teks yang dipilih pada textbox
    ' End If
    'End Sub


    Private Sub txtharga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtharga.TextChanged
        If txtharga.Text = "" Or Not IsNumeric(txtharga.Text) Then
            Exit Sub
        End If
        Dim s As Double
        s = txtharga.Text
        txtharga.Text = Format(s, "#,###") 'menjadikan format corrency
        txtharga.SelectionStart = Len(txtharga.Text)
    End Sub
End Class