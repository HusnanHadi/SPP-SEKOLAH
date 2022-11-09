Imports MySql.Data.MySqlClient
Public Class siswa
    Public NIS As Integer
    Public Nama_Siswa As String
    Public Jenis_Kelamin As String
    Public Tanggal_Lahir As Date
    Public Alamat As String
    Public Telpon As String
    Public Agama As String
    Public Tahun_Masuk As String
    Public Kode_Kelas As Integer
    Public Nama_Kelas As String

    Public Shared Function Cari(keyword As String)
        Call OpenConnection()
        cmd = New MySqlCommand("Select * from tbsiswa where Nama_Siswa ='" & keyword & "'", CONN)
        dr = cmd.ExecuteReader()
        dr.Read()
        If Not dr.HasRows Then
            Return Nothing
        Else
            Dim Siswa = New siswa With {
                .NIS = dr.Item("NIS"),
                .Nama_Siswa = dr.Item("Nama_Siswa"),
                .Jenis_Kelamin = dr.Item("Jenis_Kelamin"),
                .Tanggal_Lahir = dr.Item("Tanggal_Lahir"),
                .Alamat = dr.Item("Alamat"),
                .Telpon = dr.Item("Telpon"),
                .Agama = dr.Item("Agama"),
                .Tahun_Masuk = dr.Item("Tahun_Masuk"),
                .Kode_Kelas = dr.Item("Kode_Kelas"),
                .Nama_Kelas = dr.Item("Nama_Kelas")
            }
            Return Siswa
        End If
    End Function
    Sub Simpan()
        Call OpenConnection()
        Dim inputdata As String = "insert into tbsiswa values('" & NIS & "','" & Nama_Siswa & "','" & Jenis_Kelamin & "','" & Format(Tanggal_Lahir, "yyyy-MM-dd") & "','" & Alamat & "','" & Telpon & "','" & Agama & "','" & Tahun_Masuk & "','" & Kode_Kelas & "','" & Nama_Kelas & "')"
        cmd = New MySqlCommand(inputdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call OpenConnection()
        Dim editdata As String = "Update tbsiswa set Nama_Siswa ='" & Nama_Siswa & "', Jenis_Kelamin ='" & Jenis_Kelamin & "', Tanggal_Lahir ='" & Format(Tanggal_Lahir, ("yyyy-MM-dd")) & "', Alamat ='" & Alamat & "', Telpon ='" & Telpon & "', Agama ='" & Agama & "', Tahun_Masuk ='" & Tahun_Masuk & "', Kode_Kelas ='" & Kode_Kelas & "', Nama_Kelas = '" & Nama_Kelas & "' where NIS ='" & NIS & "'"
        cmd = New MySqlCommand(editdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Hapus()
        Call OpenConnection()
        Dim hapusdata As String = "Delete from tbsiswa where NIS = '" & NIS & "'"
        cmd = New MySqlCommand(hapusdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
End Class
