Imports MySql.Data.MySqlClient
Public Class Form_siswa
    Dim CONN As MySqlConnection
    Dim CMD As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As DataSet
    Dim myDB As String
    Sub OpenConnection()
        myDB = "Database=project;Server=localhost;uid=root;password="
        CONN = New MySqlConnection(myDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub kondisiawal()
        tb_nis.Text = ""
        tb_nama.Text = ""
        cb_jkelamin.Refresh()
        dtp1.ResetText()
        tb_alamat.Text = ""
        tb_telpon.Text = ""
        cb_agama.Refresh()
        cb_thMasuk.Refresh()
        tb_kodeKelas.Text = ""
        tb_namaKelas.Text = ""
        tb_nis.Enabled = False
        tb_nama.Enabled = False
        cb_jkelamin.Enabled = False
        dtp1.Enabled = False
        tb_telpon.Enabled = False
        tb_alamat.Enabled = False
        cb_agama.Enabled = False
        cb_thMasuk.Enabled = False
        tb_kodeKelas.Enabled = False
        tb_namaKelas.Enabled = False
        btn_simpan.Text = "Input"
        btn_edit.Text = "Edit"
        btn_hapus.Text = "Hapus"
        btn_keluar.Text = "Keluar"

        btn_simpan.Enabled = True
        btn_edit.Enabled = True
        btn_hapus.Enabled = True
        btn_keluar.Enabled = True

        Call OpenConnection()
        ModuleSPP.OpenConnection()
        da = New MySqlDataAdapter("select * from tbsiswa", CONN)
        ds = New DataSet
        da.Fill(ds)
        dgvSiswa.DataSource = ds.Tables(0)
    End Sub
    Private Sub FormSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call NoOtomatis()
        Call kondisiawal()

    End Sub
    Sub fieldaktif()
        tb_nis.Enabled = True
        tb_nama.Enabled = True
        cb_jkelamin.Enabled = True
        dtp1.Enabled = True
        tb_alamat.Enabled = True
        tb_telpon.Enabled = True
        cb_agama.Enabled = True
        cb_thMasuk.Enabled = True
        tb_kodeKelas.Enabled = True
        tb_namaKelas.Enabled = True
        tb_nis.Focus()
    End Sub
    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Input" Then
            btn_simpan.Text = "Simpan"

            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call OpenConnection()

                Dim Siswa = New siswa With {
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text,
                    .Jenis_Kelamin = cb_jkelamin.Text,
                    .Tanggal_Lahir = dtp1.Value,
                    .Alamat = tb_alamat.Text,
                    .Telpon = tb_telpon.Text,
                    .Agama = cb_agama.Text,
                    .Tahun_Masuk = cb_thMasuk.Text,
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Siswa.Simpan()

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
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi penuh")
            Else
                Dim Siswa = New siswa With {
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text,
                    .Jenis_Kelamin = cb_jkelamin.Text,
                    .Tanggal_Lahir = dtp1.Value,
                    .Alamat = tb_alamat.Text,
                    .Telpon = tb_telpon.Text,
                    .Agama = cb_agama.Text,
                    .Tahun_Masuk = cb_thMasuk.Text,
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Siswa.Edit()

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
            If tb_nis.Text = "" Or tb_nama.Text = "" Or cb_jkelamin.Text = "" Or tb_alamat.Text = "" Or tb_telpon.Text = "" Or cb_agama.Text = "" Or cb_thMasuk.Text = "" Or tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastika data yang akan dihapus terisi")
            Else
                Dim Siswa = New siswa With {
                    .NIS = tb_nis.Text,
                    .Nama_Siswa = tb_nama.Text,
                    .Jenis_Kelamin = cb_jkelamin.Text,
                    .Tanggal_Lahir = dtp1.Value,
                    .Alamat = tb_alamat.Text,
                    .Telpon = tb_telpon.Text,
                    .Agama = cb_agama.Text,
                    .Tahun_Masuk = cb_thMasuk.Text,
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Siswa.Hapus()

                MsgBox("Hapus data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub
    Private Sub dgvSiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiswa.CellClick
        tb_nis.Text = dgvSiswa.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = dgvSiswa.Rows(e.RowIndex).Cells(1).Value
        cb_jkelamin.Text = dgvSiswa.Rows(e.RowIndex).Cells(2).Value
        dtp1.Value = dgvSiswa.Rows(e.RowIndex).Cells(3).Value
        tb_alamat.Text = dgvSiswa.Rows(e.RowIndex).Cells(4).Value
        tb_telpon.Text = dgvSiswa.Rows(e.RowIndex).Cells(5).Value
        cb_agama.Text = dgvSiswa.Rows(e.RowIndex).Cells(6).Value
        cb_thMasuk.Text = dgvSiswa.Rows(e.RowIndex).Cells(7).Value
        tb_kodeKelas.Text = dgvSiswa.Rows(e.RowIndex).Cells(8).Value
        tb_namaKelas.Text = dgvSiswa.Rows(e.RowIndex).Cells(9).Value
    End Sub
    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub
    Private Sub tb_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cari.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim hasil = siswa.Cari(tb_cari.Text)
            If IsNothing(hasil) Then
                MsgBox("Data tidak ada")
            Else
                tb_nis.Text = hasil.NIS
                tb_nama.Text = hasil.Nama_Siswa
                cb_jkelamin.Text = hasil.Jenis_Kelamin
                dtp1.Value = hasil.Tanggal_Lahir
                tb_alamat.Text = hasil.Alamat
                tb_telpon.Text = hasil.Telpon
                cb_agama.Text = hasil.Agama
                cb_thMasuk.Text = hasil.Tahun_Masuk
                tb_kodeKelas.Text = hasil.Kode_Kelas
                tb_namaKelas.Text = hasil.Nama_Kelas
            End If
        End If
    End Sub
    Private Sub tb_kodeKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kodeKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()

            CMD = New MySqlCommand("select * from tbkelas where kode_kelas ='" & tb_kodeKelas.Text & "'", CONN)
            dr = CMD.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_kodeKelas.Text = dr.Item("Kode_Kelas")
                tb_namaKelas.Text = dr.Item("Nama_Kelas")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
    Private Sub tb_namaKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_namaKelas.KeyPress
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
        CMD = New MySqlCommand("select NIS from tbsiswa order by NIS desc", CONN)
        dr = CMD.ExecuteReader
        dr.Read()
        If Not dr.HasRows = True Then
            tb_nis.Text = "20030600" + "01"
        Else
            If Microsoft.VisualBasic.Mid(dr.Item("NIS"), 2, 8) = 20030600 Then
                tb_nis.Text = "20030600" + Format(Microsoft.VisualBasic.Right(dr.Item("NIS"), 8) + 1, "00")
            Else
                tb_nis.Text = "20030600" + "01"
            End If
        End If
    End Sub
    Private Sub Tb_cari_TextChanged(sender As Object, e As EventArgs) Handles tb_cari.TextChanged
        Call OpenConnection()
        da = New MySqlDataAdapter("select * from tbsiswa where Nama_Siswa like '%" & tb_cari.Text & "%'", CONN)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbsiswa")
        dgvSiswa.DataSource = ds.Tables("tbsiswa")
        dgvSiswa.AllowUserToAddRows = False
        dgvSiswa.ReadOnly = True
    End Sub

    Private Sub Form_siswa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cb_agama.Text = ""
        cb_jkelamin.Text = ""
        cb_thMasuk.Text = ""

    End Sub

    Private Sub tb_nis_TextChanged(sender As Object, e As EventArgs) Handles tb_nis.TextChanged

    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged

    End Sub
End Class