Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class Form_Laporan
    Sub rbRefresh()
        rb_bulan.Checked = False
        rb_tahun.Checked = False
    End Sub
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rbRefresh()
    End Sub
    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Preview.ShowDialog()
        Call rbRefresh()
    End Sub
End Class