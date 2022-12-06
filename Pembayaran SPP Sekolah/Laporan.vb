Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class Form_Laporan
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim myDB As String
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
End Class