Imports MySql.Data.MySqlClient
Public Class transaksi
    Public No_Pembayaran As Integer
    Public SPP_Bulan As String
    Public Tanggal_Bayar As Date
    Public Jumlah As Integer
    Public NIS As Integer
    Public Nama_Siswa As String

    Public Shared Function Cari(keyword As String)
        Call OpenConnection()
        cmd = New MySqlCommand("Select * from tbspp where Nama_Siswa ='" & keyword & "'", CONN)
        dr = cmd.ExecuteReader()
        dr.Read()
        If Not dr.HasRows Then
            Return Nothing
        Else
            Dim Transaksi = New transaksi With {
                .No_Pembayaran = dr.Item("No_Pembayaran"),
                .Tanggal_Bayar = dr.Item("Tanggal_Bayar"),
                .NIS = dr.Item("NIS"),
                .Nama_Siswa = dr.Item("Nama_Siswa"),
                .SPP_Bulan = dr.Item("SPP_Bulan"),
                .Jumlah = dr.Item("Jumlah")
            }
            Return Transaksi
        End If
    End Function
    Sub Simpan()
        Call OpenConnection()
        Dim inputdata As String = "insert into tbspp values('" & No_Pembayaran & "','" & SPP_Bulan & "','" & Format(Tanggal_Bayar, "yyyy-MM-dd") & "','" & Jumlah & "','" & NIS & "','" & Nama_Siswa & "')"
        cmd = New MySqlCommand(inputdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call OpenConnection()
        Dim editdata As String = "Update tbspp set spp_bulan ='" & SPP_Bulan & "', Tanggal_Bayar ='" & Format(Tanggal_Bayar, ("yyyy-MM-dd")) & "', Jumlah ='" & Jumlah & "', Nama_Siswa ='" & Nama_Siswa & "', NIS ='" & NIS & "' Where No_Pembayaran ='" & No_Pembayaran & "'"
        cmd = New MySqlCommand(editdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Hapus()
        Call OpenConnection()
        Dim hapusdata As String = "Delete from tbspp where No_Pembayaran = '" & No_Pembayaran & "'"
        cmd = New MySqlCommand(hapusdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
End Class
