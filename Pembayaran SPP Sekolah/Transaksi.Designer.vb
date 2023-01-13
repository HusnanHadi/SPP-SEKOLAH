<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_transaksi))
        Me.cb_sppBulan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_jmlhBayar = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.tb_noPembayaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_cari = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvPembayaran = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_sppBulan
        '
        Me.cb_sppBulan.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sppBulan.FormattingEnabled = True
        Me.cb_sppBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "November", "Desember"})
        Me.cb_sppBulan.Location = New System.Drawing.Point(138, 148)
        Me.cb_sppBulan.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_sppBulan.Name = "cb_sppBulan"
        Me.cb_sppBulan.Size = New System.Drawing.Size(143, 30)
        Me.cb_sppBulan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No Pembayaran"
        '
        'tb_jmlhBayar
        '
        Me.tb_jmlhBayar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_jmlhBayar.Location = New System.Drawing.Point(138, 177)
        Me.tb_jmlhBayar.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_jmlhBayar.Name = "tb_jmlhBayar"
        Me.tb_jmlhBayar.Size = New System.Drawing.Size(143, 30)
        Me.tb_jmlhBayar.TabIndex = 6
        '
        'tb_nama
        '
        Me.tb_nama.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama.Location = New System.Drawing.Point(138, 119)
        Me.tb_nama.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(143, 30)
        Me.tb_nama.TabIndex = 4
        '
        'tb_nis
        '
        Me.tb_nis.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nis.Location = New System.Drawing.Point(138, 90)
        Me.tb_nis.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(143, 30)
        Me.tb_nis.TabIndex = 3
        '
        'tb_noPembayaran
        '
        Me.tb_noPembayaran.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_noPembayaran.Location = New System.Drawing.Point(138, 33)
        Me.tb_noPembayaran.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_noPembayaran.Name = "tb_noPembayaran"
        Me.tb_noPembayaran.Size = New System.Drawing.Size(143, 30)
        Me.tb_noPembayaran.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal Bayar"
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_hapus.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(213, 255)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(80, 37)
        Me.btn_hapus.TabIndex = 9
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(117, 255)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(80, 37)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(323, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 22)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Cari Data"
        '
        'tb_cari
        '
        Me.tb_cari.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cari.Location = New System.Drawing.Point(426, 23)
        Me.tb_cari.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_cari.Name = "tb_cari"
        Me.tb_cari.Size = New System.Drawing.Size(192, 30)
        Me.tb_cari.TabIndex = 115
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(21, 255)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(80, 37)
        Me.btn_simpan.TabIndex = 7
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama"
        '
        'dgvPembayaran
        '
        Me.dgvPembayaran.AllowUserToAddRows = False
        Me.dgvPembayaran.AllowUserToDeleteRows = False
        Me.dgvPembayaran.AllowUserToResizeColumns = False
        Me.dgvPembayaran.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPembayaran.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPembayaran.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgvPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembayaran.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvPembayaran.Location = New System.Drawing.Point(327, 54)
        Me.dgvPembayaran.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPembayaran.MultiSelect = False
        Me.dgvPembayaran.Name = "dgvPembayaran"
        Me.dgvPembayaran.ReadOnly = True
        Me.dgvPembayaran.RowHeadersVisible = False
        Me.dgvPembayaran.RowHeadersWidth = 62
        Me.dgvPembayaran.RowTemplate.Height = 28
        Me.dgvPembayaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPembayaran.Size = New System.Drawing.Size(588, 279)
        Me.dgvPembayaran.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 180)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 22)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Jumlah Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 150)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 22)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "SPP Bulan"
        '
        'btn_keluar
        '
        Me.btn_keluar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(117, 297)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(80, 37)
        Me.btn_keluar.TabIndex = 10
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = False
        '
        'dtp2
        '
        Me.dtp2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp2.Location = New System.Drawing.Point(138, 62)
        Me.dtp2.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(143, 30)
        Me.dtp2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp2)
        Me.GroupBox1.Controls.Add(Me.cb_sppBulan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_jmlhBayar)
        Me.GroupBox1.Controls.Add(Me.tb_nama)
        Me.GroupBox1.Controls.Add(Me.tb_nis)
        Me.GroupBox1.Controls.Add(Me.tb_noPembayaran)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(297, 225)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'Form_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(923, 350)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tb_cari)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.dgvPembayaran)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSAKSI"
        CType(Me.dgvPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_sppBulan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_jmlhBayar As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents tb_noPembayaran As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_cari As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvPembayaran As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_keluar As Button
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
End Class
