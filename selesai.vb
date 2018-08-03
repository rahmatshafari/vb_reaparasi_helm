Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class selesai
    Dim mycoon As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable

    Dim total, diskon, bayar, kembali As Integer

    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub

    Private Sub selesai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Dim cm As New MySqlDataAdapter("select nama from service", mycoon)
        Dim sd As New DataSet
        sd.Clear()
        cm.Fill(sd, "service")
        ComboBox1.DataSource = (sd.Tables("service"))
        Me.ComboBox1.ValueMember = "nama"
        mycoon.Close()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        Dim diskon As Integer
        Dim nm As New MySqlCommand("select* from service where nama='" & ComboBox1.Text & "'", mycoon)
        Dim mya As MySqlDataReader
        mya = nm.ExecuteReader
        mya.Read()
        If mya.HasRows Then
            Label15.Text = mya.Item("alamat")
            Label16.Text = mya.Item("no_hp")
            Label17.Text = mya.Item("Merk_helm")
            Label18.Text = mya.Item("Warna")
            Label19.Text = mya.Item("Jenis_helm")
            Label20.Text = mya.Item("Ukuran")
            Label21.Text = mya.Item("Tanggal_service")
            Label22.Text = mya.Item("Tanggal_ambil")
            Label54.Text = mya.Item("total_biaya")
            Label24.Text = mya.Item("bayar")
            Label255.Text = mya.Item("kembali")
            Label31.Text = mya.Item("ganti_baut")
            Label32.Text = mya.Item("ganti_busa")
            Label33.Text = mya.Item("ganti_tali")
            Label34.Text = mya.Item("ganti_kaca")
            Label35.Text = mya.Item("dicuci")
            Label68.Text = mya.Item("nama_pegawai")

        End If
        mycoon.Close()

    End Sub




    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        Dim diskon As Integer
        Dim nms As New MySqlCommand("select* from service where nama='" & ComboBox1.Text & "'", mycoon)
        Dim myar As MySqlDataReader
        myar = nms.ExecuteReader
        myar.Read()
        If myar.HasRows Then
            Label14.Text = myar.Item("total_biaya")
            Label23.Text = myar.Item("bayar")
            Label25.Text = myar.Item("kembali")
        End If
        If RadioButton1.Checked Then
            MsgBox("Karena Adanya kerusakan pada helm anda maka kami memberi kompensasi diskon sebesar 50%")
            diskon = Label14.Text * 0.5
            Label14.Text = diskon

            kembali = Label23.Text - Label14.Text
            Label25.Text = kembali
            Label62.Text = "50%"
            Label64.Text = "MOHON MAAF ATAS KESALAHAN DARI PIHAK KAMI"


        End If
        If RadioButton2.Checked Then
            MsgBox("Terima kasih telah service di tempat kami, semoga anda nyaman terhadap pelayanan")
            Label62.Text = "0%"
            Label64.Text = " JANGAN LUPA MEMAKAI HELM SAAT BERKENDARA, TERIMA KASIH  "

        End If

        mycoon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Barang telah diambil")
        home.Show()
        Me.Close()
    End Sub
End Class