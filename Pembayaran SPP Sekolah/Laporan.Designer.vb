<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Laporan))
        Me.rb_bulan = New System.Windows.Forms.RadioButton()
        Me.rb_tahun = New System.Windows.Forms.RadioButton()
        Me.dtp_tahun = New System.Windows.Forms.DateTimePicker()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'rb_bulan
        '
        Me.rb_bulan.AutoSize = True
        Me.rb_bulan.Location = New System.Drawing.Point(12, 13)
        Me.rb_bulan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_bulan.Name = "rb_bulan"
        Me.rb_bulan.Size = New System.Drawing.Size(110, 20)
        Me.rb_bulan.TabIndex = 0
        Me.rb_bulan.TabStop = True
        Me.rb_bulan.Text = "Tanggal & Bulan"
        Me.rb_bulan.UseVisualStyleBackColor = True
        '
        'rb_tahun
        '
        Me.rb_tahun.AutoSize = True
        Me.rb_tahun.Location = New System.Drawing.Point(12, 44)
        Me.rb_tahun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rb_tahun.Name = "rb_tahun"
        Me.rb_tahun.Size = New System.Drawing.Size(60, 20)
        Me.rb_tahun.TabIndex = 1
        Me.rb_tahun.TabStop = True
        Me.rb_tahun.Text = "Tahun"
        Me.rb_tahun.UseVisualStyleBackColor = True
        '
        'dtp_tahun
        '
        Me.dtp_tahun.CustomFormat = "yyyy"
        Me.dtp_tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_tahun.Location = New System.Drawing.Point(128, 44)
        Me.dtp_tahun.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp_tahun.Name = "dtp_tahun"
        Me.dtp_tahun.ShowUpDown = True
        Me.dtp_tahun.Size = New System.Drawing.Size(105, 23)
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
        Me.btn_print.Location = New System.Drawing.Point(128, 75)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(101, 28)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(128, 111)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(101, 28)
        Me.btn_keluar.TabIndex = 4
        Me.btn_keluar.Text = "KELUAR"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "S / D"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd/MM/yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(128, 13)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(105, 23)
        Me.dtp1.TabIndex = 6
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "dd/MM/yyyy"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(280, 13)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(105, 23)
        Me.dtp2.TabIndex = 6
        '
        'Form_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(402, 150)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.dtp_tahun)
        Me.Controls.Add(Me.rb_tahun)
        Me.Controls.Add(Me.rb_bulan)
        Me.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAPORAN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_bulan As RadioButton
    Friend WithEvents rb_tahun As RadioButton
    Friend WithEvents dtp_tahun As DateTimePicker
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dtp2 As DateTimePicker
End Class
