<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_siswa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_siswa))
        Me.dgvSiswa = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.tb_kodeKelas = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.tb_namaKelas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_telpon = New System.Windows.Forms.TextBox()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.cb_thMasuk = New System.Windows.Forms.ComboBox()
        Me.cb_agama = New System.Windows.Forms.ComboBox()
        Me.cb_jkelamin = New System.Windows.Forms.ComboBox()
        Me.tb_cari = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSiswa
        '
        Me.dgvSiswa.AllowUserToAddRows = False
        Me.dgvSiswa.AllowUserToDeleteRows = False
        Me.dgvSiswa.AllowUserToResizeColumns = False
        Me.dgvSiswa.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSiswa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSiswa.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSiswa.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvSiswa.Location = New System.Drawing.Point(274, 43)
        Me.dgvSiswa.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSiswa.MultiSelect = False
        Me.dgvSiswa.Name = "dgvSiswa"
        Me.dgvSiswa.ReadOnly = True
        Me.dgvSiswa.RowHeadersVisible = False
        Me.dgvSiswa.RowTemplate.Height = 28
        Me.dgvSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSiswa.Size = New System.Drawing.Size(554, 260)
        Me.dgvSiswa.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 228)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tahun Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kode Kelas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 284)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nama Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 170)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Telpon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(538, 308)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(85, 38)
        Me.btn_keluar.TabIndex = 22
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_hapus.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(448, 308)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(85, 38)
        Me.btn_hapus.TabIndex = 21
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(358, 308)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(85, 38)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'dtp1
        '
        Me.dtp1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Location = New System.Drawing.Point(104, 110)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(143, 23)
        Me.dtp1.TabIndex = 4
        '
        'tb_kodeKelas
        '
        Me.tb_kodeKelas.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kodeKelas.Location = New System.Drawing.Point(104, 254)
        Me.tb_kodeKelas.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_kodeKelas.Name = "tb_kodeKelas"
        Me.tb_kodeKelas.Size = New System.Drawing.Size(143, 23)
        Me.tb_kodeKelas.TabIndex = 9
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(268, 308)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(85, 38)
        Me.btn_simpan.TabIndex = 19
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'tb_namaKelas
        '
        Me.tb_namaKelas.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_namaKelas.Location = New System.Drawing.Point(104, 282)
        Me.tb_namaKelas.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_namaKelas.Name = "tb_namaKelas"
        Me.tb_namaKelas.Size = New System.Drawing.Size(143, 23)
        Me.tb_namaKelas.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(271, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cari Data"
        '
        'tb_telpon
        '
        Me.tb_telpon.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telpon.Location = New System.Drawing.Point(104, 167)
        Me.tb_telpon.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_telpon.Name = "tb_telpon"
        Me.tb_telpon.Size = New System.Drawing.Size(143, 23)
        Me.tb_telpon.TabIndex = 6
        '
        'tb_alamat
        '
        Me.tb_alamat.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_alamat.Location = New System.Drawing.Point(104, 138)
        Me.tb_alamat.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(143, 23)
        Me.tb_alamat.TabIndex = 5
        '
        'tb_nama
        '
        Me.tb_nama.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama.Location = New System.Drawing.Point(104, 52)
        Me.tb_nama.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(143, 23)
        Me.tb_nama.TabIndex = 2
        '
        'cb_thMasuk
        '
        Me.cb_thMasuk.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_thMasuk.FormattingEnabled = True
        Me.cb_thMasuk.Items.AddRange(New Object() {"2020", "2021", "2022", "2023", "2024", "2025"})
        Me.cb_thMasuk.Location = New System.Drawing.Point(104, 225)
        Me.cb_thMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_thMasuk.Name = "cb_thMasuk"
        Me.cb_thMasuk.Size = New System.Drawing.Size(143, 23)
        Me.cb_thMasuk.TabIndex = 8
        '
        'cb_agama
        '
        Me.cb_agama.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_agama.FormattingEnabled = True
        Me.cb_agama.Items.AddRange(New Object() {"Islam", "Kristen", "Hindu", "Budha", "Kong Wu Chu"})
        Me.cb_agama.Location = New System.Drawing.Point(104, 196)
        Me.cb_agama.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_agama.Name = "cb_agama"
        Me.cb_agama.Size = New System.Drawing.Size(143, 23)
        Me.cb_agama.TabIndex = 7
        '
        'cb_jkelamin
        '
        Me.cb_jkelamin.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jkelamin.FormattingEnabled = True
        Me.cb_jkelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cb_jkelamin.Location = New System.Drawing.Point(104, 81)
        Me.cb_jkelamin.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_jkelamin.Name = "cb_jkelamin"
        Me.cb_jkelamin.Size = New System.Drawing.Size(143, 23)
        Me.cb_jkelamin.TabIndex = 3
        '
        'tb_cari
        '
        Me.tb_cari.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cari.Location = New System.Drawing.Point(346, 10)
        Me.tb_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_cari.Name = "tb_cari"
        Me.tb_cari.Size = New System.Drawing.Size(131, 23)
        Me.tb_cari.TabIndex = 24
        '
        'tb_nis
        '
        Me.tb_nis.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nis.Location = New System.Drawing.Point(104, 23)
        Me.tb_nis.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(143, 23)
        Me.tb_nis.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.tb_kodeKelas)
        Me.GroupBox1.Controls.Add(Me.tb_namaKelas)
        Me.GroupBox1.Controls.Add(Me.tb_telpon)
        Me.GroupBox1.Controls.Add(Me.tb_alamat)
        Me.GroupBox1.Controls.Add(Me.tb_nama)
        Me.GroupBox1.Controls.Add(Me.cb_thMasuk)
        Me.GroupBox1.Controls.Add(Me.cb_agama)
        Me.GroupBox1.Controls.Add(Me.cb_jkelamin)
        Me.GroupBox1.Controls.Add(Me.tb_nis)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(251, 332)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Form_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(846, 364)
        Me.Controls.Add(Me.dgvSiswa)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tb_cari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_siswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISWA"
        CType(Me.dgvSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSiswa As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents tb_kodeKelas As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents tb_namaKelas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tb_telpon As TextBox
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents cb_thMasuk As ComboBox
    Friend WithEvents cb_agama As ComboBox
    Friend WithEvents cb_jkelamin As ComboBox
    Friend WithEvents tb_cari As TextBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
