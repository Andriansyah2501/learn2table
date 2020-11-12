Imports MySql.Data.MySqlClient
Module Module1
    Public strkon As String = "server=localhost;uid=root;database=pratikum7"
    Public koneksi As New MySqlConnection(strkon)
    Public ds As New DataSet
    Public cek As MySqlDataReader
    Public perintah As New MySqlCommand
    Public mda As New MySqlDataAdapter

End Module
