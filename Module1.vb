Imports MySql.Data.MySqlClient
Imports System.Data
Module Module1
    Public mycoon As New MySqlConnection
    Private mycommand As New MySqlCommand
    Private myadapter As New MySqlDataAdapter
    Private mydata As New DataTable
    Private reader As MySqlDataReader
    Private sql As String



    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub

    'Public Function cari_nim(ByVal nm As String) As DataTable
    '    koneksi()
    '    Dim cari = New DataTable
    '    sql = "select * from service where nama_pegawai like '%" & nm & "%'"
    '    myadapter = New MySqlDataAdapter(sql, mycoon)
    '    myadapter.fill(cari)
    '    Return cari
    'End Function

    Public Function cari_nama(ByVal nm As String) As DataTable
        koneksi()
        Dim cari = New DataTable
        sql = "select * from service where nama_pegawai like '%" & nm & "%'"
        myadapter = New MySqlDataAdapter(sql, mycoon)
        myadapter.Fill(cari)
        Return cari
    End Function

End Module