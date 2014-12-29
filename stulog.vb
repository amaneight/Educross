Imports System.Data.SqlClient


Public Class stulog
    Dim myconn As New SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim ds As DataSet
    Dim adp As SqlDataAdapter
    Dim adp1 As SqlDataAdapter
    Dim ds1 As DataSet
    Dim ra As Integer
    Dim str2 As String
    Dim str1 As String
    Dim str As String
    Dim keyascii As String
    Dim flag As Integer = 0
    

    Public Sub from1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")

        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()
        str = "select * from studentreg"
        adp = New SqlDataAdapter(str, myconn)
        fillthegrid()
        fl.Hide()
        fl1.Hide()

    End Sub
    Sub fillthegrid()
        ds = New DataSet()
        adp.Fill(ds, "studentreg")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        stureg.sr_prn.Text = ""
        stureg.sr_fname.Text = ""
        stureg.sr_mname.Text = ""
        stureg.sr_lname.Text = ""
        stureg.sr_roll.Text = ""
        stureg.sr_year.Text = "S.E"
        stureg.sr_div.Text = "Div.1"
        stureg.sr_contact.Text = ""
        stureg.sr_pass.Text = ""
        stureg.sr_cpass.Text = ""
        stureg.sr_age.Text = ""
        stureg.user.Hide()
        stureg.sr_prn.Show()
        stureg.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myconn.Close()
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub slog_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles slog_user.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsSymbol(e.KeyChar) Then
            MsgBox("Please enter Alphanumeric Characters", MsgBoxStyle.Critical, "Validation error")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If

    End Sub

    Private Sub slog_pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles slog_pass.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            MsgBox("Please enter Alphanumeric Characters", MsgBoxStyle.Critical, "Validation error")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconn.Close()
        myconn.Open()

        If slog_user.Text = "" Then
            MsgBox("Please enter the Username", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If slog_pass.Text = "" Then
            MsgBox("Please enter the password", MsgBoxStyle.Critical)
            Exit Sub
        End If

        cmd = New SqlCommand("select * from studentreg where prnno='" + slog_user.Text + "' and password='" + slog_pass.Text + "' ", myconn)
        dr1 = cmd.ExecuteReader()

        If dr1.HasRows() = False Then
            ' MsgBox("Login Successful")
            Me.Hide()
            If flag = 0 Then
                stuhp.Show()
                flag = flag + 1
            ElseIf flag > 0 Then
                stuhp.Level_Load(sender, e)
                stuhp.Show()
            End If

        Else
            MsgBox("The entered username or password is incorrect", MsgBoxStyle.Critical)
            slog_user.Text = ""
            slog_pass.Text = ""
            dr1.Close()
        End If

        'slog_user.Text = ""
        'slog_pass.Text = ""

        dr1.Close()

    End Sub
End Class
