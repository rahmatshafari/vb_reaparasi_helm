Imports MySql.Data.MySqlClient
Imports System.Data.Odbc
Public Class data
    Dim mycoon As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader

    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub


    Sub showtbl()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM data", mycoon)
        Dim tb As New DataTable
        adapter.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Sub clear()
        Dim ctl As Control
        For Each ctl In Me.Controls

            If TypeOf ctl Is TextBox Then
                ctl.Text = ""

            End If
        Next
    End Sub


    Private Sub data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        showtbl()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        mycommand = New MySqlCommand("insert into data (id,Nama,Alamat,No_Hp) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')", mycoon)
        mycommand.ExecuteNonQuery()
        showtbl()
        Call clear()
        MsgBox("Data Berhasil diinput", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        koneksi()
        mycommand = New MySqlCommand("update data set Nama='" & TextBox2.Text & "', Alamat='" & TextBox3.Text & "', No_Hp='" & TextBox4.Text & "'where id = '" & TextBox1.Text & "'", mycoon)
        mycommand.ExecuteNonQuery()
        showtbl()
        clear()
        MsgBox("Data Berhasil Diubah", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        koneksi()
        mycommand = New MySqlCommand("delete from data where No='" & TextBox1.Text & "'", mycoon)
        mycommand.ExecuteNonQuery()
        showtbl()
        clear()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.OkOnly, "info")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        home.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount > 0 Then
            Dim pgl As Integer
            With DataGridView1
                pgl = .CurrentRow.Index()
                TextBox1.Text = .Item(0, pgl).Value
                TextBox2.Text = .Item(1, pgl).Value
                TextBox3.Text = .Item(2, pgl).Value
                TextBox4.Text = .Item(3, pgl).Value
                TextBox2.Enabled = True
                TextBox2.Focus()
            End With
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        transaksi.Show()
    End Sub

   
End Class
