Public Class Level
    Dim currdate As Date

    Dim i As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = 0
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog

        '  Me.WindowState = System.Windows.Forms.FormWindowState.Maximized



        currdate = TimeOfDay
        'MsgBox(currdate)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        stuhp.Hide()
        selevel.Text = "Easy"

        If i > 0 Then
            stucross.Form1_Load(sender, e)
            stucross.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        End If
        i = i + 1
        stucross.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        stuhp.Hide()
        selevel.Text = "Medium"

        If i > 0 Then
            stucross.Form1_Load(sender, e)
            stucross.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        End If
        i = i + 1

        stucross.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        stuhp.Hide()
        selevel.Text = "Hard"

        If i > 0 Then
            stucross.Form1_Load(sender, e)
            stucross.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        End If
        i = i + 1
        stucross.Show()
    End Sub
End Class