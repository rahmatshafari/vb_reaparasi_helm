Imports MySql.Data.MySqlClient
Imports System.Data.Odbc

Public Class login
    Dim koneksi As MySqlConnection
    Dim MC As MySqlCommand
    Dim str, username, password As String

    Sub clear()
        Dim ctl As Control
        For Each ctl In Me.Controls

            If TypeOf ctl Is TextBox Then
                ctl.Text = ""

            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        str = "Server=localhost; user id=root; password=; database=db_safari"
        koneksi = New MySqlConnection(str)
        koneksi.Open()

        username = TextBox1.Text
        password = TextBox2.Text
        MC = New MySqlCommand("select * from tb_user where username='" + username + "' AND password='" + password + "'", koneksi)
        Dim mydata As MySqlDataReader
        mydata = MC.ExecuteReader
        mydata.Read()

        If mydata.HasRows Then
            home.Show()
            Me.Hide()
        Else
            MsgBox("username dan password yang anda salah")
        End If
        Call clear()



    End Sub

  
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        Me.Close()
    End Sub
End Class