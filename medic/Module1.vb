Imports MySql.Data.MySqlClient
Module Module1
    Public Function Koneksi() As MySqlConnection
        Dim Conn As New MySqlConnection
        Conn = New MySqlConnection("server=localhost; database=medical; user=root; password=;")
        Conn.Open()
        Return Conn
    End Function
End Module
