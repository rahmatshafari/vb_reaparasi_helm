Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class transaksi

    Dim total, diskon, total1, bayar, kembali, service, service1, service2, service3, service4 As Integer

    Dim mycoon As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable

    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        home.Show()
        Me.Close()

    End Sub
    Sub clear()
        Dim ctl, cm As Control
        For Each ctl In Me.Controls

            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If

        Next
       
        Label20.Text = ""
        Label23.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
    End Sub

    Sub showtbl()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM service", mycoon)
        Dim tb As New DataTable
        adapter.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub
 

    Private Sub transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        showtbl()
        Call com()
    End Sub

   
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Label15.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        DateTimePicker2.Value = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        Label20.Text = DataGridView1.Rows(e.RowIndex).Cells(17).Value
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value
        Label23.Text = DataGridView1.Rows(e.RowIndex).Cells(19).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Helm Catok" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()


                Else
                    service = 0

                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Half Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()
                    Call koneksi()
                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()
                    
                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()
                    Call koneksi()
                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "3/4 Modular" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()
                    Call koneksi()
                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Full Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'baut'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service = 0
                End If
                If CheckBox2.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_busa'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service1 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service1 = 0
                End If
                If CheckBox3.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_tali'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service2 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service2 = 0
                End If
                If CheckBox4.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'ganti_kaca'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service3 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service3 = 0
                End If
                If CheckBox5.Checked Then
                    Call koneksi()
                    Dim cv As New MySqlCommand("select harga from list_harga where servicee = 'dicuci'", mycoon)
                    Dim myd As MySqlDataReader
                    myd = cv.ExecuteReader
                    myd.Read()
                    If myd.HasRows Then
                        service4 = myd.Item("harga")
                    End If
                    mycoon.Close()

                Else
                    service4 = 0
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        Else
            MsgBox("Silahkan isi Terlebih Dahulu")
        End If

        Label20.Text = total
        total = service + service1 + service2 + service3 + service4


    End Sub

   

   



  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        mycommand = New MySqlCommand("update service set   kode_pegawai='" & ComboBox2.Text & "', nama_pegawai='" & Label15.Text & "', nama='" & TextBox5.Text & "', alamat='" & TextBox6.Text & "', no_hp='" & TextBox7.Text & "', Merk_helm='" & TextBox1.Text & "', Warna='" & TextBox2.Text & "', Jenis_helm='" & ComboBox1.Text & "', Ukuran = '" & ComboBox3.Text & "', Tanggal_service='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', Tanggal_ambil='" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "', total_biaya='" & Label20.Text & "',bayar='" & TextBox4.Text & "',kembali='" & Label23.Text & "' where id='" & TextBox3.Text & "'", mycoon)
        mycommand.ExecuteNonQuery()
        If ComboBox1.Text = "Helm Catok" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If

            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Half Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "3/4 Modular" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Full Face" Then
            If CheckBox1.Checked Then
                mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            Else
                mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            End If
            If CheckBox2.Checked Then
                mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            Else
                mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            End If
            If CheckBox3.Checked Then
                mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            Else
                mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            End If
            If CheckBox4.Checked Then
                mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            Else
                mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            End If
            If CheckBox5.Checked Then
                mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            Else
                mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                mycommand.ExecuteNonQuery()
            End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
        End If




        showtbl()
        clear()
        MsgBox("Data Berhasil Diubah", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call koneksi()
        mycommand = New MySqlCommand("insert into service (id,kode_pegawai,nama_pegawai, nama, alamat, no_hp, Merk_helm, Warna, Jenis_helm, Ukuran, Tanggal_service, Tanggal_ambil, ganti_baut, ganti_busa, ganti_tali, ganti_kaca, dicuci, total_biaya, bayar, kembali) VALUES ( '" & TextBox3.Text & "','" & ComboBox2.Text & "' ,'" & Label15.Text & "', '" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & ComboBox3.Text & "', '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "', '', '', '', '', '','" & Label20.Text & "','" & TextBox4.Text & "','" & Label23.Text & "')", mycoon)
        mycommand.ExecuteNonQuery()
        If ComboBox1.Text = "Helm Catok" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If

            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Half Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "3/4 Modular" Then
            If ComboBox3.Text = "M" Then
                 If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Full Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        Else

        End If
        showtbl()
        Call clear()
        MsgBox("Data Berhasil diinput", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        koneksi()
        mycommand = New MySqlCommand("delete from service where id='" & TextBox3.Text & "'", mycoon)
        mycommand.ExecuteNonQuery()
        If ComboBox1.Text = "Helm Catok" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If

            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Half Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update _service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "3/4 Modular" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update tb_service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        ElseIf ComboBox1.Text = "Full Face" Then
            If ComboBox3.Text = "M" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "L" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            ElseIf ComboBox3.Text = "XL" Then
                If CheckBox1.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_baut ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_baut ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox2.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_busa ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_busa ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox3.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_tali ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_tali ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox4.Checked Then
                    mycommand = New MySqlCommand("update service set ganti_kaca ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set ganti_kaca ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
                If CheckBox5.Checked Then
                    mycommand = New MySqlCommand("update service set dicuci ='YA' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                Else
                    mycommand = New MySqlCommand("update service set dicuci ='TIDAK' where id='" & TextBox3.Text & "'", mycoon)
                    mycommand.ExecuteNonQuery()
                End If
            Else
                MsgBox("Silahkan Pilih Ukuran Terlebih Dahulu")
            End If
        Else

        End If
        showtbl()
        Call clear()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        pengambilan.Show()
        pengambilan.Label23.Text = Label15.Text
        pengambilan.Label14.Text = TextBox5.Text
        pengambilan.Label15.Text = TextBox6.Text
        pengambilan.Label16.Text = TextBox7.Text
        pengambilan.Label17.Text = TextBox1.Text
        pengambilan.Label18.Text = TextBox2.Text
        pengambilan.Label19.Text = ComboBox1.Text
        pengambilan.Label20.Text = ComboBox3.Text
        pengambilan.Label21.Text = DateTimePicker1.Value
        pengambilan.Label22.Text = DateTimePicker2.Value
        pengambilan.Label31.Text = service
        pengambilan.Label32.Text = service1
        pengambilan.Label33.Text = service2
        pengambilan.Label34.Text = service3
        pengambilan.Label35.Text = service4
        pengambilan.Label54.Text = Label20.Text
        pengambilan.Label24.Text = TextBox4.Text
        pengambilan.Label25.Text = Label23.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        bayar = TextBox4.Text
        kembali = bayar - total
        Label23.Text = kembali
    End Sub

   
   

    Sub com()
        Call koneksi()
        Dim cm As New MySqlDataAdapter("select kode_pegawai from pegawai", mycoon)
        Dim sd As New DataSet
        sd.Clear()
        cm.Fill(sd, "pegawai")
        ComboBox2.DataSource = (sd.Tables("pegawai"))
        Me.ComboBox2.ValueMember = "kode_pegawai"
        mycoon.Close()
    End Sub
   
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call koneksi()
        Dim nma As New MySqlCommand("select* from pegawai where kode_pegawai='" & ComboBox2.Text & "'", mycoon)
        Dim myaa As MySqlDataReader
        myaa = nma.ExecuteReader
        myaa.Read()
        If myaa.HasRows Then
            Label15.Text = myaa.Item("nama_pegawai")
        End If
        mycoon.Close()
    End Sub

   
End Class