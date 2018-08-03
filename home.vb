Public Class home

    
    Private Sub TRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        transaksi.Show()
        Me.Hide()
    End Sub


    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        about.Show()
        Me.Hide()
    End Sub

    
    Private Sub DATAPELANGGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        data.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        about.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        transaksi.Show()
        Me.Close()
    End Sub

    
    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        selesai.Show()
       

    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        riwayat.Show()




    End Sub
End Class