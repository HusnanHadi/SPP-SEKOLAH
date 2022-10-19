Imports MySql.Data.MySqlClient
Public Class Form_kelas
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim ds As DataSet
    Dim myDB As String
    Sub koneksi()
        myDB = "Database=project;Server=localhost;uid=root;password="
        con = New MySqlConnection(myDB)
        If con.State = ConnectionState.Closed Then
            con.Open()
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

        Call koneksi()
        ModuleSPP.OpenConnection()
        da = New MySqlDataAdapter("select * from tbkelas", con)
        ds = New DataSet
        da.Fill(ds)
        dgvKelas.DataSource = ds.Tables(0)
        ModuleSPP.CloseConnection()
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
                Call koneksi()

                Dim inputdata As String = "insert into tbkelas values('" & tb_kodeKelas.Text & "','" & tb_namaKelas.Text & "')"
                cmd = New MySqlCommand(inputdata, con)
                cmd.ExecuteNonQuery()

                MsgBox("Input data berhasil")

                Call kondisiawal()
            End If
        End If
    End Sub

    Private Sub tb_kodeKelas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_kodeKelas.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            cmd = New MySqlCommand("select * from tbkelas where kode_kelas ='" & tb_kodeKelas.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tb_namaKelas.Text = dr.Item("nama_kelas")
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
                Call koneksi()
                Dim editdata As String = "Update tbkelas set nama_kelas ='" & tb_namaKelas.Text & "' Where kode_kelas = '" & tb_kodeKelas.Text & "'"
                cmd = New MySqlCommand(editdata, con)
                cmd.ExecuteNonQuery()


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
                Call koneksi()
                Dim hapusdata As String = "Delete from tbkelas where kode_kelas = '" & tb_kodeKelas.Text & "'"
                cmd = New MySqlCommand(hapusdata, con)
                cmd.ExecuteNonQuery()

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
            btn_hapus.PerformClick()
            btn_edit.PerformClick()
        End If
        Call kondisiawal()
    End Sub

    Private Sub Tb_namaKelas_TextChanged(sender As Object, e As EventArgs) Handles tb_namaKelas.TextChanged

    End Sub
End Class