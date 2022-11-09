Imports MySql.Data.MySqlClient
Public Class Form_kelas
    Sub OpenConnection()
        myDB = "Database=project;Server=localhost;uid=root;password="
        CONN = New MySqlConnection(myDB)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub kondisiawal()
        tb_kodeKelas.Text = ""
        tb_namaKelas.Text = ""
        tb_kodeKelas.Enabled = False
        tb_namaKelas.Enabled = False
        tb_kodeKelas.MaxLength = 5

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
        da = New MySqlDataAdapter("select * from tbkelas", CONN)
        ds = New DataSet
        da.Fill(ds)
        dgvKelas.DataSource = ds.Tables(0)
    End Sub
    Private Sub Kelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
    Sub fieldaktif()
        tb_kodeKelas.Enabled = True
        tb_namaKelas.Enabled = True
        tb_kodeKelas.Focus()
    End Sub

    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If btn_simpan.Text = "Input" Then
            btn_simpan.Text = "Simpan"

            btn_edit.Enabled = False
            btn_hapus.Enabled = False
            btn_keluar.Text = "Batal"

            Call fieldaktif()
        Else
            If tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi")
            Else
                Call OpenConnection()
                Dim Kelas = New kelas With {
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Kelas.Simpan()

                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub tb_kodeKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kodeKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConnection()

            cmd = New MySqlCommand("select * from tbkelas where Kode_Kelas ='" & tb_kodeKelas.Text & "'", CONN)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_namaKelas.Text = dr.Item("Nama_Kelas")
            Else
                MsgBox("Data tidak ada")
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
            If tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastikan semua kolom terisi penuh")
            Else
                Dim Kelas = New kelas With {
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Kelas.Edit()

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
            If tb_kodeKelas.Text = "" Or tb_namaKelas.Text = "" Then
                MsgBox("Pastika data yang akan dihapus terisi")
            Else
                Dim Kelas = New kelas With {
                    .Kode_Kelas = tb_kodeKelas.Text,
                    .Nama_Kelas = tb_namaKelas.Text}
                Kelas.Hapus()

                MsgBox("Hapus data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub Btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        If btn_keluar.Text = "Keluar" Then
            Me.Close()
        Else
            Call kondisiawal()
        End If
    End Sub

    Private Sub dgvKelas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKelas.CellClick
        tb_kodeKelas.Text = dgvKelas.Rows(e.RowIndex).Cells(0).Value
        tb_namaKelas.Text = dgvKelas.Rows(e.RowIndex).Cells(1).Value
    End Sub
    Private Sub tb_namaKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_namaKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_simpan.PerformClick()
        ElseIf e.KeyChar = Chr(13) Then
            btn_edit.PerformClick()
        ElseIf e.KeyChar = Chr(13) Then
            btn_hapus.PerformClick()
        End If
    End Sub
End Class