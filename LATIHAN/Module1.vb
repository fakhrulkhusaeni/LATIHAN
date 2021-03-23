Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet
    Public MyDB As String
    Public Sub koneksi()
        MyDB = "Data Source=DESKTOP-U0L3NF7\SQLEXPRESS;Initial Catalog=penjualan_barang;Integrated Security=True"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
