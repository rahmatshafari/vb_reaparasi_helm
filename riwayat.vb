Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class riwayat
    Dim mycoon As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable


    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub

    Sub showtbl()
        Dim adapter As New MySqlDataAdapter("SELECT pegawai.kode_pegawai, pegawai.nama_pegawai, service.nama, service.alamat, service.Merk_helm, service.Jenis_helm FROM pegawai,service WHERE pegawai.kode_pegawai=service.kode_pegawai", mycoon)
        Dim tba As New DataTable
        adapter.Fill(tba)
        DataGridView1.DataSource = tba
    End Sub

    Sub tbl()
        Dim adapter As New MySqlDataAdapter("SELECT COUNT(id), kode_pegawai, nama_pegawai FROM service GROUP BY kode_pegawai", mycoon)
        Dim tbs As New DataTable
        adapter.Fill(tbs)
        DataGridView2.DataSource = tbs
    End Sub

    Sub pgw()
        Dim adapter As New MySqlDataAdapter("SELECT * from pegawai", mycoon)
        Dim tbz As New DataTable
        adapter.Fill(tbz)
        DataGridView3.DataSource = tbz
    End Sub

    Private Sub riwayat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        showtbl()
        tbl()
        pgw()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adapter As New MySqlDataAdapter("SELECT kode_pegawai, nama_pegawai,nama,alamat,no_hp,Merk_helm,Warna,Jenis_helm,Ukuran,ganti_baut,ganti_busa,ganti_tali,ganti_kaca,dicuci,total_biaya,bayar,kembali from service where Tanggal_service BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'", mycoon)
        Dim tbf As New DataTable
        adapter.Fill(tbf)
        DataGridView4.DataSource = tbf

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        home.Show()
        Me.Hide()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        DataGridView1.DataSource = cari_nama(TextBox1.Text)
        DataGridView4.DataSource = cari_nama(TextBox1.Text)
    End Sub
End Class