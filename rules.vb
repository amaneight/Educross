Public Class rules

    Public Sub rules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")

        If frmval.Text = "About" Then
            crd.Hide()
            Label1.Hide()
            ruletext.Hide()
            abouttext.Show()
            header1.Show()
            header2.Show()
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()


        ElseIf frmval.Text = "Credits" Then
            PictureBox1.Show()
            PictureBox2.Show()
            PictureBox3.Show()
            ruletext.Hide()
            abouttext.Hide()
            header1.Hide()
            header2.Hide()
            crd.Show()
            

        ElseIf frmval.Text = "Rules" Then
            Label1.Show()
            Label1.Text = "Rules"
            ruletext.Show()
            abouttext.Hide()
            header1.Hide()
            header2.Hide()
            crd.Hide()
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
        End If
        frmval.Hide()

    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        If frmval.Text = "Rules" Then
            frmval.Text = ""
            stuhp.Show()
        ElseIf frmval.Text = "About" Or frmval.Text = "Credits" Then
            frmval.Text = ""
            Login.Show()
        End If
    End Sub

End Class