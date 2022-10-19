<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.login = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.masterData = New System.Windows.Forms.ToolStripMenuItem()
        Me.kelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.masterData, Me.transaksi, Me.laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.login, Me.logout})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'login
        '
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(180, 22)
        Me.login.Text = "LOGIN"
        '
        'logout
        '
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(180, 22)
        Me.logout.Text = "LOGOUT"
        '
        'masterData
        '
        Me.masterData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kelas, Me.siswa})
        Me.masterData.Name = "masterData"
        Me.masterData.Size = New System.Drawing.Size(98, 20)
        Me.masterData.Text = "MASTER DATA"
        '
        'kelas
        '
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(180, 22)
        Me.kelas.Text = "KELAS"
        '
        'siswa
        '
        Me.siswa.Name = "siswa"
        Me.siswa.Size = New System.Drawing.Size(180, 22)
        Me.siswa.Text = "SISWA"
        '
        'transaksi
        '
        Me.transaksi.Name = "transaksi"
        Me.transaksi.Size = New System.Drawing.Size(80, 20)
        Me.transaksi.Text = "TRANSAKSI"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'laporan
        '
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(73, 20)
        Me.laporan.Text = "LAPORAN"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources._2018_05_22
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents login As ToolStripMenuItem
    Friend WithEvents logout As ToolStripMenuItem
    Friend WithEvents masterData As ToolStripMenuItem
    Friend WithEvents kelas As ToolStripMenuItem
    Friend WithEvents siswa As ToolStripMenuItem
    Friend WithEvents transaksi As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents laporan As ToolStripMenuItem
End Class
