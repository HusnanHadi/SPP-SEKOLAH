<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.login = New System.Windows.Forms.ToolStripMenuItem()
        Me.logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.masterData = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SISWAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'login
        '
        Me.login.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Login_37128
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(180, 22)
        Me.login.Text = "LOGIN"
        '
        'logout
        '
        Me.logout.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Logout_37127
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(180, 22)
        Me.logout.Text = "LOGOUT"
        '
        'masterData
        '
        Me.masterData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KELASToolStripMenuItem, Me.SISWAToolStripMenuItem})
        Me.masterData.Name = "masterData"
        Me.masterData.Size = New System.Drawing.Size(66, 20)
        Me.masterData.Text = "MASTER"
        '
        'KELASToolStripMenuItem
        '
        Me.KELASToolStripMenuItem.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.folder_blue_16863
        Me.KELASToolStripMenuItem.Name = "KELASToolStripMenuItem"
        Me.KELASToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KELASToolStripMenuItem.Text = "KELAS"
        '
        'SISWAToolStripMenuItem
        '
        Me.SISWAToolStripMenuItem.Image = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.users_clients_group_16774
        Me.SISWAToolStripMenuItem.Name = "SISWAToolStripMenuItem"
        Me.SISWAToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SISWAToolStripMenuItem.Text = "SISWA"
        '
        'transaksi
        '
        Me.transaksi.Name = "transaksi"
        Me.transaksi.Size = New System.Drawing.Size(84, 20)
        Me.transaksi.Text = "TRANSAKSI"
        '
        'laporan
        '
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(75, 20)
        Me.laporan.Text = "LAPORAN"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Pembayaran_SPP_Sekolah.My.Resources.Resources.Building__Anime_Background_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
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
    Friend WithEvents KELASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SISWAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents transaksi As ToolStripMenuItem
    Friend WithEvents laporan As ToolStripMenuItem
End Class
