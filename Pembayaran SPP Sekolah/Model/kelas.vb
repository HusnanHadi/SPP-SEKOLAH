Imports MySql.Data.MySqlClient
Public Class kelas
    Public Kode_Kelas As Integer
    Public Nama_Kelas As String

    Sub Simpan()
        Call OpenConnection()
        Dim inputdata As String = "insert into tbkelas values('" & Kode_Kelas & "','" & Nama_Kelas & "')"
        cmd = New MySqlCommand(inputdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Edit()
        Call OpenConnection()
        Dim editdata As String = "Update tbkelas set Nama_Kelas = '" & Nama_Kelas & "'where Kode_Kelas = '" & Kode_Kelas & "'"
        cmd = New MySqlCommand(editdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Hapus()
        Call OpenConnection()
        Dim hapusdata As String = "Delete from tbkelas where Kode_Kelas = '" & Kode_Kelas & "'"
        cmd = New MySqlCommand(hapusdata, CONN)
        cmd.ExecuteNonQuery()
    End Sub

End Class
