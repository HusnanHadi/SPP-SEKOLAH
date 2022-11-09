Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class FormLaporan
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim myDB As String
    Sub rbRefresh()
        rb_bulan.Checked = False
        rb_tahun.Checked = False
    End Sub

    Private Sub Btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Call OpenConnection()
        dr.Read()
        If rb_bulan.Checked = True Then
            myDB = "Select * from tbspp where month (Tanggal_Bayar) = '" & cb_bulan.SelectedIndex & "' and year (Tanggal_Bayar) = '" & Format(dtp_bulan_tahun.Value, "yyyy/MM/dd") & "')"
        ElseIf rb_tahun.Checked = True Then
            myDB = "Select * from tbspp where year (Tanggal_Bayar) = '" & Format(dtp_bulan_tahun.Value, "yyyy") & "')"
        End If
        Try
            Preview.DataSetLaporan.Clear()
            Call OpenConnection()
            cmd = New MySqlCommand(myDB, CONN)
            da.SelectCommand = cmd
            da.Fill(Preview.DataSetLaporan.TRANSAKSI)
            cmd.Dispose()
            da.Dispose()
            CONN.Close()
        Catch ex As Exception
            CONN.Close()
            MessageBox.Show(ex.Message)
        End Try
        Preview.RV_preview.SetDisplayMode(DisplayMode.PrintLayout)
        Preview.RV_preview.ZoomMode = ZoomMode.Percent
        Preview.RV_preview.ZoomPercent = 100
        Preview.RV_preview.RefreshReport()
        Preview.ShowDialog()
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call rbRefresh()
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub
End Class