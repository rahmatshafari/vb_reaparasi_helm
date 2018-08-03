Public Class about

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        home.Show()
    End Sub

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label13.Text = "Aplikasi ini berguna untuk jasa reparasi helm." & vbNewLine &
                        "mohon maaf aplikasi ini dalam tahap perkembangan   " & vbNewLine &
                        " masih banyak bugdan error di bagian tertentu.  " & vbNewLine &
                        "Semoga kedepan aplikasi ini dapat berkembang dan  " & vbNewLine &
                        "bermanfaat terima kasih"
    End Sub
End Class