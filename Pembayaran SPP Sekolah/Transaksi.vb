Imports MySql.Data.MySqlClient
Public Class Form_transaksi
    Dim CONN As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As DataSet
    Dim myDB As String
    Sub OpenConection()
        myDB = "Database=project;Server=localhost;uid=root;password="
        CONN = New MySqlConnection(myDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub kondisiawal()

        dtp2.ResetText()
        tb_nis.Text = ""
        tb_nama.Text = ""
        cb_sppBulan.Text = ""
        cb_sppBulan.ResetText()
        tb_jmlhBayar.Text = ""
        tb_noPembayaran.Enabled = False
        dtp2.Enabled = False
        tb_nis.Enabled = False
        tb_nama.Enabled = False
        cb_sppBulan.Enabled = False
        tb_jmlhBayar.Enabled = False

        btn_simpan.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_keluar.Text = "Keluar"

        btn_simpan.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_keluar.Enabled = True

        Call OpenConection()
        ModuleSPP.OpenConnection()
        da = New MySqlDataAdapter("select * from tbspp", CONN)
        ds = New DataSet
        da.Fill(ds)
        dgvPembayaran.DataSource = ds.Tables(0)
    End Sub
    Sub fieldaktif()
        tb_noPembayaran.Enabled = True
        dtp2.Enabled = True
        tb_nis.Enabled = True
        tb_nama.Enabled = True
        cb_sppBulan.Enabled = True
        tb_jmlhBayar.Enabled = True
        tb_noPembayaran.Focus()
    End Sub
    Private Sub FormSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_sppBulan.Text = ""
        Call kondisiawal()
    End Sub
    'Private Sub tb_noPembayaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_noPembayaran.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        Call OpenConection()

    '        cmd = New MySqlCommand("select * from tbspp where No_Pembayaran ='" & tb_noPembayaran.Text & "'", CONN)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows Then
    '            tb_noPembayaran.Text = dr.Item("No_Pembayaran")
    '            tb_nis.Text = dr.Item("nis")
    '            tb_nama.Text = dr.Item("nama_siswa")
    '            dtp2.Value = dr.Item("tanggal_bayar")
    '            cb_sppBulan.Text = dr.Item("spp_bulan")
    '            tb_jmlhBayar.Text = dr.Item("jumlah")
    '        Else
    '            MsgBox("Data tidak ada")
    '        End If
    '    End If
    'End Sub

    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Input" Then
            btn_simpan.Text = "Simpan"

            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or tb_nama.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call OpenConection()

                Dim Transaksi = New transaksi With {
                    .No_Pembayaran = tb_noPembayaran.Text,
                    .SPP_Bulan = cb_sppBulan.Text,
                    .Tanggal_Bayar = dtp2.Value,
                    .Jumlah = tb_jmlhBayar.Text,
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text}
                Transaksi.Simpan()
                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Update"

            btn_simpan.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or tb_nama.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastikan semua kolom terisi penuh")
            Else
                Dim Transaksi = New transaksi With {
                    .No_Pembayaran = tb_noPembayaran.Text,
                    .SPP_Bulan = cb_sppBulan.Text,
                    .Tanggal_Bayar = dtp2.Value,
                    .Jumlah = tb_jmlhBayar.Text,
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text}
                Transaksi.Edit()

                MsgBox("Edit data berhasil")
                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If btn_hapus.Text = "Hapus" Then
            btn_hapus.Text = "Delete"
            btn_simpan.Enabled = False
            btn_edit.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_noPembayaran.Text = "" Or tb_nis.Text = "" Or tb_nama.Text = "" Or cb_sppBulan.Text = "" Or tb_jmlhBayar.Text = "" Then
                MsgBox("Pastika data yang akan dihapus terisi")
            Else
                Dim Transaksi = New transaksi With {
                    .No_Pembayaran = tb_noPembayaran.Text,
                    .SPP_Bulan = cb_sppBulan.Text,
                    .Tanggal_Bayar = dtp2.Value,
                    .Jumlah = tb_jmlhBayar.Text,
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text}
                Transaksi.Hapus()

                MsgBox("Hapus data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs)
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub

    Private Sub dgvSPP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembayaran.CellClick
        tb_noPembayaran.Text = dgvPembayaran.Rows(e.RowIndex).Cells(0).Value
        cb_sppBulan.Text = dgvPembayaran.Rows(e.RowIndex).Cells(1).Value
        dtp2.Value = dgvPembayaran.Rows(e.RowIndex).Cells(2).Value
        tb_jmlhBayar.Text = dgvPembayaran.Rows(e.RowIndex).Cells(3).Value
        tb_nis.Text = dgvPembayaran.Rows(e.RowIndex).Cells(4).Value
        tb_nama.Text = dgvPembayaran.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Btn_keluar_Click_1(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub

    Private Sub Btn_preview_Click(sender As Object, e As EventArgs)
        FormLaporan.ShowDialog()
    End Sub
    Private Sub tb_jmlhBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_jmlhBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_simpan.PerformClick()
        End If
        If e.KeyChar = Chr(13) Then
            btn_edit.PerformClick()
        End If
        If e.KeyChar = Chr(13) Then
            btn_hapus.PerformClick()
        End If
    End Sub
    Sub NoOtomatis()
        Call OpenConnection()
        cmd = New MySqlCommand("select No_Pembayaran from tbspp order by No_Pembayaran desc", CONN)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows = True Then
            tb_noPembayaran.Text = "20" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(dr.Item("No_Pembayaran"), 3, 6) = Format(Today, "yyMMdd") Then
                tb_noPembayaran.Text = "20" + Format(Microsoft.VisualBasic.Right(dr.Item("No_Pembayaran"), 8) + 1, "00")
            Else
                tb_noPembayaran.Text = "20" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub

    Private Sub Form_transaksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call NoOtomatis()
    End Sub

    Private Sub tb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = transaksi.Cari(tb_cari.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada")
            Else
                tb_noPembayaran.Text = hasil.No_Pembayaran
                dtp2.Value = hasil.Tanggal_Bayar
                tb_nis.Text = hasil.NIS
                tb_nama.Text = hasil.Nama_Siswa
                cb_sppBulan.Text = hasil.SPP_Bulan
                tb_jmlhBayar.Text = hasil.Jumlah
            End If
        End If
    End Sub

    Private Sub tb_nis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_nis.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConection()
            cmd = New MySqlCommand("select * from tbsiswa where NIS ='" & tb_nis.Text & "'", CONN)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                'tb_noPembayaran.Text = dr.Item("No_Pembayaran")
                tb_nis.Text = dr.Item("nis")
                tb_nama.Text = dr.Item("nama_siswa")
                'dtp2.Value = dr.Item("tanggal_bayar")
                'cb_sppBulan.Text = dr.Item("spp_bulan")
                'tb_jmlhBayar.Text = dr.Item("jumlah")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
End Class