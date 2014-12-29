Imports System.Data.SqlClient

Public Class faclog
    Dim myconn As New SqlConnection
    Dim myconn1 As SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1, cmd2 As SqlCommand
    Dim dr, dr1 As SqlDataReader
    Dim ds As DataSet
    Dim adp As SqlDataAdapter
    Dim adp1 As SqlDataAdapter
    Dim ds1 As DataSet
    Dim ra As Integer
    Dim str1, str2, str3 As String
    Dim str As String
    Dim fn, mn, ln As String
    Dim fname As String
    Dim flag As Integer = 0

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        facreg.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconn.Close()
        myconn.Open()

        If flog_user.Text = "" Then
            MsgBox("Please enter the Username", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If flog_pass.Text = "" Then
            MsgBox("Please enter the password", MsgBoxStyle.Critical)
            Exit Sub
        End If

        cmd = New SqlCommand("select * from facultyreg where facid='" + flog_user.Text + "' and password='" + flog_pass.Text + "' ", myconn)
        dr = cmd.ExecuteReader()

        If dr.HasRows() = True Then
          

            '    While dr.Read()
            '        fn = dr("fname").ToString
            '        mn = dr("mname").ToString
            '        ln = dr("lname").ToString
            '        fname = "Prof." & fn & " " & mn & " " & ln
            '    End While

            '    MessageBox.Show("Username : " & fname, "Login Successful")


            myconn.Close()
            Me.Hide()
            If flag = 0 Then
                flag = flag + 1
            ElseIf flag > 0 Then
                fc_hp.fc_hp_Load(sender, e)
            End If
            Me.Hide()
            fc_hp.Show()

        Else
            MsgBox("The entered username or password is incorrect", MsgBoxStyle.Critical)
            flog_user.Text = ""
            flog_pass.Text = ""

        End If
        dr.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        facreg.user.Text = ""
        facreg.fr_id.Text = ""
        facreg.fr_fname.Text = ""
        facreg.fr_mname.Text = ""
        facreg.fr_lname.Text = ""
        facreg.fr_dept.Text = ""
        facreg.fr_age.Text = ""
        facreg.fr_contact.Text = ""
        facreg.fr_pass.Text = ""
        facreg.fr_cpass.Text = ""
        facreg.fr_male.Checked = True
        facreg.user.Hide()
        facreg.fr_id.Show()
        facreg.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub faclog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()
        str = "select * from facultyreg"
        adp = New SqlDataAdapter(str, myconn)
        fillthegrid()
        fl.Hide()
        fl2.Hide()
        fl3.Hide()
        fl4.Hide()

    End Sub
    Sub fillthegrid()
        ds = New DataSet()
        adp.Fill(ds, "facultyreg")
    End Sub

   
    Sub fillthegrid2()
        ds = New DataSet()
        adp.Fill(ds, "studentreg")
    End Sub


    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myconn.Close()
        Me.Hide()
        Login.Show()
    End Sub
End Class