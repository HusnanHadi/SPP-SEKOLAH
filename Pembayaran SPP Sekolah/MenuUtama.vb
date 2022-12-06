Public Class FormMenuUtama
    Sub terunci()
        login.Enabled = True
        logout.Enabled = False
        masterData.Enabled = False
        transaksi.Enabled = False
        laporan.Enabled = False
    End Sub
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Form_login.ShowDialog()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Call terunci()
    End Sub

    Private Sub KELASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELASToolStripMenuItem.Click
        Form_kelas.ShowDialog()
    End Sub

    Private Sub SISWAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SISWAToolStripMenuItem.Click
        Form_siswa.ShowDialog()
    End Sub

    Private Sub transaksi_Click(sender As Object, e As EventArgs) Handles transaksi.Click
        Form_transaksi.ShowDialog()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Form_Laporan.ShowDialog()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terunci()
    End Sub
End Class