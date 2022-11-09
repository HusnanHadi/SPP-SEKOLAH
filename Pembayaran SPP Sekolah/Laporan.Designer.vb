<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.rb_bulan = New System.Windows.Forms.RadioButton()
        Me.rb_tahun = New System.Windows.Forms.RadioButton()
        Me.cb_bulan = New System.Windows.Forms.ComboBox()
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.dtp_bulan_tahun = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rb_bulan
        '
        Me.rb_bulan.AutoSize = True
        Me.rb_bulan.Location = New System.Drawing.Point(26, 37)
        Me.rb_bulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_bulan.Name = "rb_bulan"
        Me.rb_bulan.Size = New System.Drawing.Size(58, 20)
        Me.rb_bulan.TabIndex = 0
        Me.rb_bulan.TabStop = True
        Me.rb_bulan.Text = "Bulan"
        Me.rb_bulan.UseVisualStyleBackColor = True
        '
        'rb_tahun
        '
        Me.rb_tahun.AutoSize = True
        Me.rb_tahun.Location = New System.Drawing.Point(26, 78)
        Me.rb_tahun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_tahun.Name = "rb_tahun"
        Me.rb_tahun.Size = New System.Drawing.Size(61, 20)
        Me.rb_tahun.TabIndex = 1
        Me.rb_tahun.TabStop = True
        Me.rb_tahun.Text = "Tahun"
        Me.rb_tahun.UseVisualStyleBackColor = True
        '
        'cb_bulan
        '
        Me.cb_bulan.FormattingEnabled = True
        Me.cb_bulan.Location = New System.Drawing.Point(93, 37)
        Me.cb_bulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cb_bulan.Name = "cb_bulan"
        Me.cb_bulan.Size = New System.Drawing.Size(140, 24)
        Me.cb_bulan.TabIndex = 2
        '
        'dtp_tahun
        '
        Me.dtp_tahun.CustomFormat = "yyyy"
        Me.dtp_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tahun.Location = New System.Drawing.Point(93, 78)
        Me.dtp_tahun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.ShowUpDown = True
        Me.dtp_tahun.Size = New System.Drawing.Size(139, 23)
        Me.dtp_tahun.TabIndex = 3
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(93, 145)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(87, 28)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(220, 145)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(87, 28)
        Me.btn_keluar.TabIndex = 4
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'dtp_bulan_tahun
        '
        Me.dtp_bulan_tahun.CustomFormat = "yyyy"
        Me.dtp_bulan_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_bulan_tahun.Location = New System.Drawing.Point(321, 38)
        Me.dtp_bulan_tahun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_bulan_tahun.Name = "dtp_bulan_tahun"
        Me.dtp_bulan_tahun.ShowUpDown = True
        Me.dtp_bulan_tahun.Size = New System.Drawing.Size(139, 23)
        Me.dtp_bulan_tahun.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tahun"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 237)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.dtp_bulan_tahun)
        Me.Controls.Add(Me.dtp_tahun)
        Me.Controls.Add(Me.cb_bulan)
        Me.Controls.Add(Me.rb_tahun)
        Me.Controls.Add(Me.rb_bulan)
        Me.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_bulan As RadioButton
    Friend WithEvents rb_tahun As RadioButton
    Friend WithEvents cb_bulan As ComboBox
    Friend WithEvents dtp_tahun As DateTimePicker
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents dtp_bulan_tahun As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
