Public Class FormMenuUtama
    Sub terkonci()
        login.Enabled = True
        logout.Enabled = False
        masterData.Enabled = False
        transaksi.Enabled = False
        laporan.Enabled = False

    End Sub
    Private Sub Form_MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call terkonci()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles login.Click
        Form_login.ShowDialog()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Call terkonci()
    End Sub

    Private Sub Kelas_Click(sender As Object, e As EventArgs) Handles kelas.Click
        Form_kelas.ShowDialog()
    End Sub

    Private Sub Siswa_Click(sender As Object, e As EventArgs) Handles siswa.Click
        Form_siswa.ShowDialog()
    End Sub

    Private Sub Transaksi_Click(sender As Object, e As EventArgs) Handles transaksi.Click
        Form_transaksi.ShowDialog()
    End Sub

    Private Sub Laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        FormLaporan.ShowDialog()

    End Sub
End Class
