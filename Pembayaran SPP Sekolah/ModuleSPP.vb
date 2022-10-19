Imports MySql.Data.MySqlClient
Module ModuleSPP
    Public CONN As MySqlConnection = New MySqlConnection()

    Sub OpenConnection()
        CONN.ConnectionString = "server=localhost;user id=root;password=;database=project"
        CONN.Open()
    End Sub

    Sub CloseConnection()
        CONN.Close()
    End Sub
End Module
