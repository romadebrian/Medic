Imports MySql.Data.MySqlClient
Public Class Transaksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader


    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MedicalDataSet.rekam_medis' table. You can move, or remove it, as needed.
        'Me.Rekam_medisTableAdapter.Fill(Me.MedicalDataSet.rekam_medis)
        Call FormMati()
        btnsimpan.Enabled = False
        btncetak.Enabled = False
        btntotal.Enabled = False
        btntotal.Enabled = False
        txtkodeuser.ReadOnly = True
    End Sub

    Sub FormKosong()
        txtnorekam.Text = ""
        txtno.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtkodedokter.Text = ""
        txtnamadokter.Text = ""
        txttelpdokter.Text = ""
        txtkeluhan.Text = ""
        txtdiagnosa.Text = ""
        txtketerangan.Text = ""
        txtkodeobat.Text = ""
        txtnamaobat.Text = ""
        txthargaobat.Text = ""
        txtjumlahobat.Text = ""
        txtbiayadokter.Text = ""
        txtbiayaobat.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
        txtnorekam.Focus()
    End Sub

    Sub FormHidup()
        dttgl.Enabled = True
        txtnorekam.Enabled = True
        txtno.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txtkodedokter.Enabled = True
        txtnamadokter.Enabled = True
        txttelpdokter.Enabled = True
        txtkeluhan.Enabled = True
        txtdiagnosa.Enabled = True
        txtketerangan.Enabled = True
        txtkodeobat.Enabled = True
        txtnamaobat.Enabled = True
        txthargaobat.Enabled = True
        txtjumlahobat.Enabled = True
        txtbiayadokter.Enabled = True
        txtbiayaobat.Enabled = True
        txttotal.Enabled = True
        txtbayar.Enabled = True
        txtkembali.Enabled = True
    End Sub

    Sub FormMati()
        dttgl.Enabled = False
        txtnorekam.ReadOnly = True
        txtno.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txtkodedokter.Enabled = False
        txtnamadokter.Enabled = False
        txttelpdokter.Enabled = False
        txtkeluhan.Enabled = False
        txtdiagnosa.Enabled = False
        txtketerangan.Enabled = False
        txtkodeobat.Enabled = False
        txtnamaobat.Enabled = False
        txthargaobat.Enabled = False
        txtjumlahobat.Enabled = False
        txtbiayadokter.Enabled = False
        txtbiayaobat.Enabled = False
        txttotal.Enabled = False
        txtbayar.Enabled = False
        txtkembali.Enabled = False
    End Sub

    Sub FormRedOnly()
        dttgl.Enabled = True
        txtnorekam.ReadOnly = True
        txtno.ReadOnly = True
        txtnama.ReadOnly = True
        txtalamat.ReadOnly = True
        txtkodedokter.ReadOnly = True
        txtnamadokter.ReadOnly = True
        txttelpdokter.ReadOnly = True
        txtkeluhan.ReadOnly = True
        txtdiagnosa.ReadOnly = True
        txtketerangan.ReadOnly = True
        txtkodeobat.ReadOnly = True
        txtnamaobat.ReadOnly = True
        txthargaobat.ReadOnly = True
        txtjumlahobat.ReadOnly = True
        txtbiayadokter.ReadOnly = True
        txtbiayaobat.ReadOnly = True
        txttotal.ReadOnly = True
        txtbayar.ReadOnly = True
        txtkembali.ReadOnly = True
        txtkeluhan.ReadOnly = True

    End Sub

    Sub FormRedOnlyMati()
        dttgl.Enabled = False
        txtnorekam.ReadOnly = False
        txtno.ReadOnly = False
        txtnama.ReadOnly = False
        txtalamat.ReadOnly = False
        txtkodedokter.ReadOnly = False
        txtnamadokter.ReadOnly = False
        txttelpdokter.ReadOnly = False
        txtkeluhan.ReadOnly = False
        txtdiagnosa.ReadOnly = False
        txtketerangan.ReadOnly = False
        txtkodeobat.ReadOnly = False
        txtnamaobat.ReadOnly = False
        txthargaobat.ReadOnly = False
        txtjumlahobat.ReadOnly = False
        txtbiayadokter.ReadOnly = False
        txtbiayaobat.ReadOnly = False
        txttotal.ReadOnly = False
        txtbayar.ReadOnly = False
        txtkembali.ReadOnly = False
    End Sub

    Sub FormNormal()
        Call FormKosong()
        btntambah.Enabled = True
        btntotal.Enabled = True
        btnsimpan.Enabled = False
        btnkeluar.Text = "Keluar"
    End Sub

    Sub Kode_Otomatis()
        Dim Urutan As String
        Dim Hitung, Cari As Long
        CMD = New MySqlCommand("Select * From rekam_medis where no_rekam in(select max(no_rekam) from rekam_medis) ", Koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            'Urutan = "RKM/" & Date.Now.Year & "/" & "000001"
            Urutan = "RKM/" & Date.Now.Year & "/" & "00000" + "1"
        Else
            Cari = Microsoft.VisualBasic.Right(RD.GetString(0), 6)
            'If Microsoft.VisualBasic.Left(RD.GetString(0), 9) <> "RKMI" & Date.Now.Year & "/" & Cari Then
            If Not RD.HasRows Then
                Urutan = "RKM/" & Date.Now.Year & "/" & "000001"
                'Urutan = "RKM/" & Date.Now.Year & "/" & Val(Microsoft.VisualBasic.Right(RD.GetString(0), 6)) + 1
            Else
                Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 6) + 1
                Urutan = "RKM/" & Date.Now.Year & "/" & Microsoft.VisualBasic.Right("000000" & Hitung, 6)
            End If
        End If
        RD.Close()
        txtnorekam.Text = Urutan
    End Sub

    Private Sub btntambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call FormHidup()
        Call FormKosong()
        Call FormRedOnly()
        Kode_Otomatis()
        'txtnorekam.Enabled = False
        txtno.Focus()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        dgtampil.Enabled = False
        btnkeluar.Text = "&Normal"
        txtno.ReadOnly = False
        txtkodedokter.ReadOnly = False
        txtkodeobat.ReadOnly = False
        txtjumlahobat.ReadOnly = False
        txtbayar.ReadOnly = False
        txtdiagnosa.ReadOnly = False
        txtkeluhan.ReadOnly = False
        txtketerangan.ReadOnly = False
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from pasien where no_pasien = '" & txtno.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnama.Text = myreader.Item(1)
                txtalamat.Text = myreader.Item(4)
                txtkodedokter.Focus()
                txtnama.ReadOnly = True
                txtalamat.ReadOnly = True
            Else
                MessageBox.Show("Kode pasien tidak terdaftar ....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtno.Text = ""
                txtno.Focus()
            End If
        End If
    End Sub

    Private Sub txtkodedokter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodedokter.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from dokter where kd_dokter = '" & txtkodedokter.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnamadokter.Text = myreader.Item(1)
                txttelpdokter.Text = myreader.Item(4)
                txtkeluhan.Focus()
                txtnamadokter.ReadOnly = True
                txttelpdokter.ReadOnly = True
            Else
                MessageBox.Show("Kode Dokter tidak terdaftar ....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtkodedokter.Text = ""
                txtkodedokter.Focus()
            End If
        End If
    End Sub

    Private Sub txtkodeobat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeobat.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from obat where kd_obat = '" & txtkodeobat.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnamaobat.Text = myreader.Item(1)
                txthargaobat.Text = myreader.Item(4)
                txtjumlahobat.Focus()
                txtnamaobat.ReadOnly = True
                txthargaobat.ReadOnly = True
            Else
                MessageBox.Show("Kode obat tidak terdaftar ....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtkodeobat.Text = ""
                txtkodeobat.Focus()
            End If
        End If

        If e.KeyChar = Chr(Keys.Space) Then
            btntotal.Focus()
        End If
    End Sub

    Private Sub txtjumlahobat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlahobat.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            If txtkodeobat.Text = "" Then
                MsgBox("data masih kosong bro")
            Else
                If txtjumlahobat.Text = "" Then
                    MsgBox("data masih kosong")
                    txtjumlahobat.Focus()
                Else
                    Dim curen, harb, jumo As Double
                    harb = txthargaobat.Text
                    jumo = txtjumlahobat.Text
                    dgtampil.RowCount = dgtampil.RowCount + 1
                    txtcount.Text = Val(txtcount.Text) + 1
                    dgtampil(0, dgtampil.RowCount - 2).Value = txtkodeobat.Text
                    dgtampil(1, dgtampil.RowCount - 2).Value = txtnamaobat.Text
                    dgtampil(2, dgtampil.RowCount - 2).Value = txthargaobat.Text
                    dgtampil(3, dgtampil.RowCount - 2).Value = txtjumlahobat.Text
                    curen = harb * jumo
                    dgtampil(4, dgtampil.RowCount - 2).Value = Format(Val(curen), "#,###") 'menjadikan format corrency
                    txtkodeobat.Clear()
                    txtnamaobat.Clear()
                    txthargaobat.Clear()
                    txtjumlahobat.Clear()
                    txtkodeobat.Focus()
                    btntotal.Enabled = True
                End If

            End If

        End If
    End Sub

    Private Sub btntotal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntotal.Click
        Dim total_biaya_obat As Double
        Dim f, G As Double
        For i As Integer = 0 To dgtampil.RowCount - 1
            total_biaya_obat += dgtampil.Item(4, i).Value
        Next
        'Dim i As Integer
        'i = dgtampil.CurrentRow.Index
        'txtbiayaobat.Text = dgtampil.Item(4, i).Value
        'R = Format(Val(total.ToString), "#,###") 'menjadikan format corrency
        txtbiayaobat.Text = total_biaya_obat
        txtbiayaobat.Text = Format(Val(txtbiayaobat.Text), "#,###") 'menjadikan format corrency
        txtbiayadokter.Text = "20,000"
        f = txtbiayadokter.Text
        'G = txtbiayaobat.Text
        txttotal.Text = f + total_biaya_obat
        txttotal.Text = Format(Val(txttotal.Text), "#,###") 'menjadikan format corrency
        txtbiayaobat.ReadOnly = True
        txtbiayadokter.ReadOnly = True
        txttotal.ReadOnly = True
        txtbayar.Focus()
    End Sub

    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) Then
            If txtbayar.Text = "" Then
            ElseIf txttotal.Text = "" Then
            Else
                Dim j, l As Double
                'txtkembali.Text = txtbayar.Text - txttotal.Text
                j = txtbayar.Text
                l = txttotal.Text
                txtkembali.Text = j - l
                txtkembali.Text = Format(Val(txtkembali.Text), "#,###") 'menjadikan format corrency
                Call FormRedOnly()
                btnsimpan.Focus()
                'btntotal.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtkeluhan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkeluhan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtdiagnosa.Focus()
        End If
    End Sub

    Private Sub txtdiagnosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiagnosa.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtketerangan.Focus()
        End If
    End Sub

    Private Sub txtketerangan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtketerangan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtkodeobat.Focus()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        'Dim kode_obat As Integer
        Dim jumlah_obat As Integer
        For i As Integer = 0 To dgtampil.RowCount - 1
            jumlah_obat += dgtampil.Item(3, i).Value
        Next
        'txtkodeobat.Text = kode_obat.ToString
        'txtjumlahobat.Text = jumlah_obat.ToString

        If txtno.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtno.Focus()

        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Anda harus menekan ENTER di Nomor Pasien", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtno.Focus()
        ElseIf txtkodedokter.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtkodedokter.Focus()
        ElseIf txtnamadokter.Text = "" Then
            MessageBox.Show("Anda harus menekan ENTER di Kode Dokter", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtkodedokter.Focus()
        ElseIf txtkeluhan.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtkeluhan.Focus()
        ElseIf txtdiagnosa.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtdiagnosa.Focus()
        ElseIf txtketerangan.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtketerangan.Focus()
        ElseIf txtbiayadokter.Text = "" And btntotal.Enabled = True Then
            MessageBox.Show("Anda Belum Menekan Tombol Total", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            btntotal.Focus()
        ElseIf txttotal.Text = "" Then
            MessageBox.Show("Anda Belum input Obat", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtkodeobat.Focus()
        
        ElseIf txtketerangan.Text = "" Then
            MessageBox.Show("Data yang di input tidak lengkap", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtketerangan.Focus()
        ElseIf txtbayar.Text = "" Then
            MessageBox.Show("Blom Bayar", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtbayar.Focus()
        ElseIf txtkembali.Text = "" Then
            MessageBox.Show("Anda Belum Menekan ENTER di bayar", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call FormHidup()
            txtbayar.Focus()

        Else

            Sql = "INSERT INTO rekam_medis(no_rekam, tgl, keluhan, diagnosa, keterangan, jumlah_obat, biaya_dokter, biaya_obat, total,kd_dokter,no_pasien,kd_user)" & " VALUES ('" & txtnorekam.Text & "','" & Format(dttgl.Value, "yyyy-MM-dd") & "','" & txtkeluhan.Text & "','" & txtdiagnosa.Text & "', '" & txtketerangan.Text & "', '" & jumlah_obat.ToString & "','" & txtbiayadokter.Text & "', '" & txtbiayaobat.Text & "', '" & txttotal.Text & "','" & txtkodedokter.Text & "', '" & txtno.Text & "','" & txtkodeuser.Text & "')"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtnorekam.Text & " Sudah disimpan", "Simpan data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnorekam.Focus()
            btnsimpan.Enabled = False
            btntambah.Enabled = False
            btncetak.Enabled = True
            'btnkeluar.Text = "Keluar"
            'Call FormKosong()
            btntotal.Enabled = False
            btncetak.Focus()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        If btnkeluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call FormRedOnlyMati()
            Call FormNormal()
            Call FormMati()
            Call FormKosong()
            btntotal.Enabled = False
            btntambah.Enabled = True
            btncetak.Enabled = False
            dgtampil.RowCount = dgtampil.RowCount - Val(txtcount.Text)
            txtcount.Text = "0"
            btntambah.Focus()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Nomor Rekam : ", Font, Brushes.Black, 50, 50)
        e.Graphics.DrawString(txtnorekam.Text, txtnorekam.Font, Brushes.Black, 150, 50)
        e.Graphics.DrawString("Tanggal : ", Font, Brushes.Black, 320, 50)
        e.Graphics.DrawString(dttgl.Text, dttgl.Font, Brushes.Black, 400, 50)
        e.Graphics.DrawString("Nama Pasien ", Font, Brushes.Black, 50, 70)
        e.Graphics.DrawString(txtnama.Text, txtnama.Font, Brushes.Black, 150, 70)
        e.Graphics.DrawString("Nama Dokter ", Font, Brushes.Black, 50, 90)
        e.Graphics.DrawString(txtnamadokter.Text, txtnamadokter.Font,Brushes.Black, 150, 90)
        e.Graphics.DrawString("Keluhan ", Font, Brushes.Black, 50, 110)
        e.Graphics.DrawString(txtkeluhan.Text, txtkeluhan.Font, Brushes.Black,150, 110)
        e.Graphics.DrawString("Diagnosa ", Font, Brushes.Black, 50, 130)
        e.Graphics.DrawString(txtdiagnosa.Text, txtdiagnosa.Font, Brushes.Black,150, 130)
        e.Graphics.DrawString("Biaya Dokter ", Font, Brushes.Black, 50, 150)
        e.Graphics.DrawString(txtbiayadokter.Text, txtbiayadokter.Font,Brushes.Black, 150, 150)
        e.Graphics.DrawString("Biaya obat ", Font, Brushes.Black, 320, 150)
        e.Graphics.DrawString(txtbiayaobat.Text, txtbiayaobat.Font, Brushes.Black,400, 150)
        e.Graphics.DrawString("Total ", Font, Brushes.Black, 50, 170)
        e.Graphics.DrawString(txttotal.Text, txttotal.Font, Brushes.Black, 150,170)
        e.Graphics.DrawString("Bayar ", Font, Brushes.Black, 320, 170)
        e.Graphics.DrawString(txtbayar.Text, txtbayar.Font, Brushes.Black, 400,170)
        e.Graphics.DrawString("Kembali ", Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString(txtkembali.Text, txtkembali.Font, Brushes.Black, 400, 190)
        e.Graphics.DrawString(" Terima kasih atas kujungan anda, semoga Lekas sembuh ", Font, Brushes.Black, 200, 250)
    End Sub

    Private Sub btncetak_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncetak.Click
        With PrintDocument1
            .PrinterSettings.DefaultPageSettings.Landscape = False
            .Print()
            btnkeluar.Focus()
        End With
    End Sub

    Private Sub txtkodeuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodeuser.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

    Private Sub txtbayar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbayar.TextChanged
        Dim P As Double
        If txtbayar.Text = "" Or Not IsNumeric(txtbayar.Text) Then
            Exit Sub
        End If
        P = txtbayar.Text
        txtbayar.Text = Format(P, "#,###") 'menjadikan format corrency
        txtbayar.SelectionStart = Len(txtbayar.Text)
    End Sub
End Class










