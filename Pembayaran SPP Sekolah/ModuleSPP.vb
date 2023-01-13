Imports MySql.Data.MySqlClient
Module ModuleSPP
    Public CONN As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public myDB As String
    Public Sub OpenConnection()
        myDB = ("server=localhost;port=3306;user id=root;password=;database=project")
        CONN = New MySqlConnection(myDB)
        If CONN.State = ConnectionState.Closed Then CONN.Open()
    End Sub
End Module
