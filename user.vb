Imports MySql.Data.MySqlClient
Imports System.Data

Public Class user

    Dim mycoon As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim myadapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim reader As MySqlDataReader

    Sub koneksi()
        mycoon = New MySqlConnection("server='localhost'; user id='root'; password=''; database='db_safari'")
        mycoon.Open()
    End Sub


    Sub showSfr()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM tb_user", mycoon)
        Dim tb As New DataTable
        adapter.Fill(tb)
        DataGridView1.DataSource = tb
    End Sub

    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        login.Show()
        Me.Hide()
    End Sub

   

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        showSfr()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
        mycommand = New MySqlCommand("insert into tb_user (id,username,password) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "')", mycoon)
        mycommand.ExecuteNonQuery()
        showSfr()
        MsgBox("Insert data sukses", MsgBoxStyle.OkOnly, "info")
    End Sub
End Class