<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dokter
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
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtsip = New System.Windows.Forms.TextBox()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.RichTextBox()
        Me.dgdokter = New System.Windows.Forms.DataGridView()
        Me.KddokterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamadokterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicalDataSet = New medic.medicalDataSet()
        Me.DokterTableAdapter = New medic.medicalDataSetTableAdapters.dokterTableAdapter()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        CType(Me.dgdokter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surat Izin Praktek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telepon"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(109, 29)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(131, 20)
        Me.txtkode.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(109, 54)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(212, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtsip
        '
        Me.txtsip.Location = New System.Drawing.Point(109, 81)
        Me.txtsip.Name = "txtsip"
        Me.txtsip.Size = New System.Drawing.Size(131, 20)
        Me.txtsip.TabIndex = 9
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(380, 85)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(156, 20)
        Me.txttelp.TabIndex = 11
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(380, 29)
        Me.txtalamat.Multiline = False
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(228, 49)
        Me.txtalamat.TabIndex = 12
        Me.txtalamat.Text = ""
        '
        'dgdokter
        '
        Me.dgdokter.AutoGenerateColumns = False
        Me.dgdokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdokter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KddokterDataGridViewTextBoxColumn, Me.NamadokterDataGridViewTextBoxColumn, Me.SipDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TelpDataGridViewTextBoxColumn})
        Me.dgdokter.DataSource = Me.DokterBindingSource
        Me.dgdokter.Location = New System.Drawing.Point(15, 125)
        Me.dgdokter.Name = "dgdokter"
        Me.dgdokter.Size = New System.Drawing.Size(593, 274)
        Me.dgdokter.TabIndex = 13
        '
        'KddokterDataGridViewTextBoxColumn
        '
        Me.KddokterDataGridViewTextBoxColumn.DataPropertyName = "kd_dokter"
        Me.KddokterDataGridViewTextBoxColumn.HeaderText = "kd_dokter"
        Me.KddokterDataGridViewTextBoxColumn.Name = "KddokterDataGridViewTextBoxColumn"
        '
        'NamadokterDataGridViewTextBoxColumn
        '
        Me.NamadokterDataGridViewTextBoxColumn.DataPropertyName = "nama_dokter"
        Me.NamadokterDataGridViewTextBoxColumn.HeaderText = "nama_dokter"
        Me.NamadokterDataGridViewTextBoxColumn.Name = "NamadokterDataGridViewTextBoxColumn"
        '
        'SipDataGridViewTextBoxColumn
        '
        Me.SipDataGridViewTextBoxColumn.DataPropertyName = "sip"
        Me.SipDataGridViewTextBoxColumn.HeaderText = "sip"
        Me.SipDataGridViewTextBoxColumn.Name = "SipDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'TelpDataGridViewTextBoxColumn
        '
        Me.TelpDataGridViewTextBoxColumn.DataPropertyName = "telp"
        Me.TelpDataGridViewTextBoxColumn.HeaderText = "telp"
        Me.TelpDataGridViewTextBoxColumn.Name = "TelpDataGridViewTextBoxColumn"
        '
        'DokterBindingSource
        '
        Me.DokterBindingSource.DataMember = "dokter"
        Me.DokterBindingSource.DataSource = Me.MedicalDataSet
        '
        'MedicalDataSet
        '
        Me.MedicalDataSet.DataSetName = "medicalDataSet"
        Me.MedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DokterTableAdapter
        '
        Me.DokterTableAdapter.ClearBeforeFill = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(158, 416)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 15
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(278, 416)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 16
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(390, 416)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(512, 416)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 18
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(28, 416)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 0
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'Dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(622, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.dgdokter)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.txtsip)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Dokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokter"
        CType(Me.dgdokter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtsip As System.Windows.Forms.TextBox
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.RichTextBox
    Friend WithEvents dgdokter As System.Windows.Forms.DataGridView
    Friend WithEvents MedicalDataSet As medic.medicalDataSet
    Friend WithEvents DokterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DokterTableAdapter As medic.medicalDataSetTableAdapters.dokterTableAdapter
    Friend WithEvents KddokterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamadokterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
End Class
