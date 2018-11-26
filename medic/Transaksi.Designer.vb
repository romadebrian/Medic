<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txttelpdokter = New System.Windows.Forms.TextBox()
        Me.txtkodedokter = New System.Windows.Forms.TextBox()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.dgtampil = New System.Windows.Forms.DataGridView()
        Me.kode_bat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Obat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekammedisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicalDataSet = New medic.medicalDataSet()
        Me.Rekam_medisTableAdapter = New medic.medicalDataSetTableAdapters.rekam_medisTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtjumlahobat = New System.Windows.Forms.TextBox()
        Me.txthargaobat = New System.Windows.Forms.TextBox()
        Me.txtnamaobat = New System.Windows.Forms.TextBox()
        Me.txtkodeobat = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtbiayaobat = New System.Windows.Forms.TextBox()
        Me.txtbiayadokter = New System.Windows.Forms.TextBox()
        Me.txtnorekam = New System.Windows.Forms.TextBox()
        Me.txtdiagnosa = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.dttgl = New System.Windows.Forms.DateTimePicker()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.txtkeluhan = New System.Windows.Forms.RichTextBox()
        Me.txtkodeuser = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtcount = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RekammedisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Rekam Medis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Diagnosa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keluhan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kode Obat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nama Obat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Harga Obat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Jumlah Obat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(451, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tanggal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Kode Dokter"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Nama Dokter"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Nomor Telepon"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Biaya Dokter"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Biaya Obat"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Total Biaya"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Bayar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Kembali"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(451, 360)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Keterangan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 144)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(112, 84)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(267, 54)
        Me.txtalamat.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(112, 55)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(267, 20)
        Me.txtnama.TabIndex = 5
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(112, 29)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(179, 20)
        Me.txtno.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttelpdokter)
        Me.GroupBox2.Controls.Add(Me.txtkodedokter)
        Me.GroupBox2.Controls.Add(Me.txtnamadokter)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(454, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 144)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Dokter"
        '
        'txttelpdokter
        '
        Me.txttelpdokter.Location = New System.Drawing.Point(111, 81)
        Me.txttelpdokter.Name = "txttelpdokter"
        Me.txttelpdokter.Size = New System.Drawing.Size(189, 20)
        Me.txttelpdokter.TabIndex = 15
        '
        'txtkodedokter
        '
        Me.txtkodedokter.Location = New System.Drawing.Point(111, 29)
        Me.txtkodedokter.Name = "txtkodedokter"
        Me.txtkodedokter.Size = New System.Drawing.Size(100, 20)
        Me.txtkodedokter.TabIndex = 29
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Location = New System.Drawing.Point(111, 55)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(252, 20)
        Me.txtnamadokter.TabIndex = 14
        '
        'dgtampil
        '
        Me.dgtampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtampil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_bat, Me.nama_obat, Me.harga_obat, Me.Jumlah_Obat, Me.Total_Obat})
        Me.dgtampil.Location = New System.Drawing.Point(15, 423)
        Me.dgtampil.Name = "dgtampil"
        Me.dgtampil.Size = New System.Drawing.Size(957, 229)
        Me.dgtampil.TabIndex = 22
        '
        'kode_bat
        '
        Me.kode_bat.HeaderText = "Kode_bat"
        Me.kode_bat.Name = "kode_bat"
        '
        'nama_obat
        '
        Me.nama_obat.HeaderText = "nama_obat"
        Me.nama_obat.Name = "nama_obat"
        '
        'harga_obat
        '
        Me.harga_obat.HeaderText = "Harga_Obat"
        Me.harga_obat.Name = "harga_obat"
        '
        'Jumlah_Obat
        '
        Me.Jumlah_Obat.HeaderText = "Jumlah_Obat"
        Me.Jumlah_Obat.Name = "Jumlah_Obat"
        '
        'Total_Obat
        '
        Me.Total_Obat.HeaderText = "Total_Obat"
        Me.Total_Obat.Name = "Total_Obat"
        '
        'RekammedisBindingSource
        '
        Me.RekammedisBindingSource.DataMember = "rekam_medis"
        Me.RekammedisBindingSource.DataSource = Me.MedicalDataSet
        '
        'MedicalDataSet
        '
        Me.MedicalDataSet.DataSetName = "medicalDataSet"
        Me.MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rekam_medisTableAdapter
        '
        Me.Rekam_medisTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtjumlahobat)
        Me.GroupBox3.Controls.Add(Me.txthargaobat)
        Me.GroupBox3.Controls.Add(Me.txtnamaobat)
        Me.GroupBox3.Controls.Add(Me.txtkodeobat)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 139)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Obat"
        '
        'txtjumlahobat
        '
        Me.txtjumlahobat.Location = New System.Drawing.Point(112, 107)
        Me.txtjumlahobat.Name = "txtjumlahobat"
        Me.txtjumlahobat.Size = New System.Drawing.Size(94, 20)
        Me.txtjumlahobat.TabIndex = 13
        '
        'txthargaobat
        '
        Me.txthargaobat.Location = New System.Drawing.Point(112, 81)
        Me.txthargaobat.Name = "txthargaobat"
        Me.txthargaobat.Size = New System.Drawing.Size(179, 20)
        Me.txthargaobat.TabIndex = 12
        '
        'txtnamaobat
        '
        Me.txtnamaobat.Location = New System.Drawing.Point(112, 55)
        Me.txtnamaobat.Name = "txtnamaobat"
        Me.txtnamaobat.Size = New System.Drawing.Size(179, 20)
        Me.txtnamaobat.TabIndex = 11
        '
        'txtkodeobat
        '
        Me.txtkodeobat.Location = New System.Drawing.Point(112, 29)
        Me.txtkodeobat.Name = "txtkodeobat"
        Me.txtkodeobat.Size = New System.Drawing.Size(179, 20)
        Me.txtkodeobat.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtkembali)
        Me.GroupBox4.Controls.Add(Me.txtbayar)
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Controls.Add(Me.txtbiayaobat)
        Me.GroupBox4.Controls.Add(Me.txtbiayadokter)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(454, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(410, 166)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Biaya - Biaya"
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(111, 131)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(189, 20)
        Me.txtkembali.TabIndex = 30
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(111, 107)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(189, 20)
        Me.txtbayar.TabIndex = 22
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(111, 81)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(189, 20)
        Me.txttotal.TabIndex = 21
        '
        'txtbiayaobat
        '
        Me.txtbiayaobat.Location = New System.Drawing.Point(111, 55)
        Me.txtbiayaobat.Name = "txtbiayaobat"
        Me.txtbiayaobat.Size = New System.Drawing.Size(189, 20)
        Me.txtbiayaobat.TabIndex = 20
        '
        'txtbiayadokter
        '
        Me.txtbiayadokter.Location = New System.Drawing.Point(111, 29)
        Me.txtbiayadokter.Name = "txtbiayadokter"
        Me.txtbiayadokter.Size = New System.Drawing.Size(189, 20)
        Me.txtbiayadokter.TabIndex = 19
        '
        'txtnorekam
        '
        Me.txtnorekam.Location = New System.Drawing.Point(127, 6)
        Me.txtnorekam.Name = "txtnorekam"
        Me.txtnorekam.Size = New System.Drawing.Size(179, 20)
        Me.txtnorekam.TabIndex = 25
        '
        'txtdiagnosa
        '
        Me.txtdiagnosa.Location = New System.Drawing.Point(234, 376)
        Me.txtdiagnosa.Name = "txtdiagnosa"
        Me.txtdiagnosa.Size = New System.Drawing.Size(190, 20)
        Me.txtdiagnosa.TabIndex = 27
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(454, 376)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(133, 20)
        Me.txtketerangan.TabIndex = 28
        '
        'dttgl
        '
        Me.dttgl.Location = New System.Drawing.Point(519, 9)
        Me.dttgl.Name = "dttgl"
        Me.dttgl.Size = New System.Drawing.Size(203, 20)
        Me.dttgl.TabIndex = 29
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(897, 41)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(897, 89)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(897, 142)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 2
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(897, 191)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 3
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btntotal
        '
        Me.btntotal.Location = New System.Drawing.Point(642, 374)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(112, 23)
        Me.btntotal.TabIndex = 11
        Me.btntotal.Text = "Total"
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'txtkeluhan
        '
        Me.txtkeluhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkeluhan.Location = New System.Drawing.Point(24, 376)
        Me.txtkeluhan.Multiline = False
        Me.txtkeluhan.Name = "txtkeluhan"
        Me.txtkeluhan.Size = New System.Drawing.Size(197, 41)
        Me.txtkeluhan.TabIndex = 14
        Me.txtkeluhan.Text = ""
        '
        'txtkodeuser
        '
        Me.txtkodeuser.Location = New System.Drawing.Point(862, 397)
        Me.txtkodeuser.Name = "txtkodeuser"
        Me.txtkodeuser.Size = New System.Drawing.Size(110, 20)
        Me.txtkodeuser.TabIndex = 35
        '
        'PrintDocument1
        '
        '
        'txtcount
        '
        Me.txtcount.Location = New System.Drawing.Point(789, 376)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(28, 20)
        Me.txtcount.TabIndex = 36
        Me.txtcount.Text = "0"
        Me.txtcount.Visible = False
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1053, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtcount)
        Me.Controls.Add(Me.txtkodeuser)
        Me.Controls.Add(Me.txtkeluhan)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dttgl)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.txtdiagnosa)
        Me.Controls.Add(Me.txtnorekam)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgtampil)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RekammedisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgtampil As System.Windows.Forms.DataGridView
    Friend WithEvents MedicalDataSet As medic.medicalDataSet
    Friend WithEvents RekammedisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rekam_medisTableAdapter As medic.medicalDataSetTableAdapters.rekam_medisTableAdapter
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents txttelpdokter As System.Windows.Forms.TextBox
    Friend WithEvents txtkodedokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnamadokter As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlahobat As System.Windows.Forms.TextBox
    Friend WithEvents txthargaobat As System.Windows.Forms.TextBox
    Friend WithEvents txtnamaobat As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeobat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtbiayaobat As System.Windows.Forms.TextBox
    Friend WithEvents txtbiayadokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnorekam As System.Windows.Forms.TextBox
    Friend WithEvents txtdiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents txtkembali As System.Windows.Forms.TextBox
    Friend WithEvents dttgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btntotal As System.Windows.Forms.Button
    Friend WithEvents txtkeluhan As System.Windows.Forms.RichTextBox
    Friend WithEvents txtkodeuser As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents kode_bat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah_Obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
End Class
