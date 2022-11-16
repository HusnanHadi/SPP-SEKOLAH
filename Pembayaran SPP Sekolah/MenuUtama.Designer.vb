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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.login = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.masterData = New System.Windows.Forms.ToolStripMenuItem()
        Me.kelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.siswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.masterData, Me.transaksi, Me.laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(-12, -6)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(397, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.login, Me.logout})
        Me.FILEToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(53, 23)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'login
        '
        Me.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Login_37128
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(145, 24)
        Me.login.Text = "LOGIN"
        '
        'logout
        '
        Me.logout.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Logout_37127
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(145, 24)
        Me.logout.Text = "LOGOUT"
        '
        'masterData
        '
        Me.masterData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.kelas, Me.siswa})
        Me.masterData.Name = "masterData"
        Me.masterData.Size = New System.Drawing.Size(131, 23)
        Me.masterData.Text = "MASTER DATA"
        '
        'kelas
        '
        Me.kelas.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.folder_blue_16863
        Me.kelas.Name = "kelas"
        Me.kelas.Size = New System.Drawing.Size(128, 24)
        Me.kelas.Text = "KELAS"
        '
        'siswa
        '
        Me.siswa.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.users_clients_group_16774
        Me.siswa.Name = "siswa"
        Me.siswa.Size = New System.Drawing.Size(128, 24)
        Me.siswa.Text = "SISWA"
        '
        'transaksi
        '
        Me.transaksi.Name = "transaksi"
        Me.transaksi.Size = New System.Drawing.Size(107, 23)
        Me.transaksi.Text = "TRANSAKSI"
        '
        'laporan
        '
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(95, 23)
        Me.laporan.Text = "LAPORAN"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Building__Anime_Background_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 615)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
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
