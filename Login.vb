Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        stulog.slog_user.Text = ""
        stulog.slog_pass.Text = ""
        Me.Hide()

        stulog.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        faclog.flog_user.Text = ""
        faclog.flog_pass.Text = ""
        Me.Hide()
        faclog.Show()

    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        rules.frmval.Text = "About"
        rules.rules_Load(sender, e)
        rules.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        rules.frmval.Text = "Credits"
        rules.rules_Load(sender, e)
        rules.Show()
    End Sub

End Class


