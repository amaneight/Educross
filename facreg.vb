Imports System.Data.SqlClient
Public Class facreg
    Dim myconn, myconn1 As New SqlConnection
    Dim cmd, cmd1, cmd2 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1 As SqlDataReader
    Dim adp As SqlDataAdapter
    Dim keyascii As Integer
    Dim ra As Integer
    Dim in_str As String
    Dim str As String
    Dim fid As String
    Dim fname As String
    Dim mname As String
    Dim lname As String
    Dim dept As String
    Dim contact As String
    Dim password As String
    Dim cnfpass As String
    Dim age As String
    Dim gender As String
    Dim aage As Integer = 0


    Public Sub facreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()
        str = "select *from facultyreg"
        adp = New SqlDataAdapter(str, myconn)
        user.Hide()
        fr_id.Show()


        If fc_hp.edittp.Text = "Edit" Then

            cmd = New SqlCommand("Select * from facultyreg where facid='" + faclog.flog_user.Text + "' ", myconn)
            dr = cmd.ExecuteReader()
            If dr.HasRows() = True Then
                While dr.Read()
                    user.Show()
                    fr_id.Hide()
                    user.Text = dr("facid").ToString
                    fr_id.Text = user.Text
                    fr_fname.Text = dr("fname").ToString
                    fr_mname.Text = dr("mname").ToString
                    fr_lname.Text = dr("lname").ToString
                    fr_dept.Text = dr("dept").ToString
                    fr_age.Text = dr("age").ToString
                    fr_contact.Text = dr("contact").ToString
                    If dr("gender").Equals("Male") Then
                        fr_male.Checked = True
                    Else
                        fr_female.Checked = True
                    End If
                End While

            End If
            dr.Close()
        End If


    End Sub

    Sub fillthegrid()
        ds = New DataSet()
        adp.Fill(ds, "facultyreg")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconn.Close()
        myconn.Open()

        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()
        fid = fr_id.Text
        fname = fr_fname.Text
        mname = fr_mname.Text
        lname = fr_lname.Text
        password = fr_pass.Text
        contact = fr_contact.Text
        dept = fr_dept.Text
        cnfpass = fr_cpass.Text
        If fr_age.Text <> "" Then
            aage = fr_age.Text
        End If

        age = fr_age.Text
        fr_male.Checked = True

        If fr_male.Checked Then
            gender = fr_male.Text.ToString

        ElseIf fr_female.Checked Then
            gender = fr_female.Text.ToString
        End If

        cmd2 = New SqlCommand("select * from facultyreg where facid='" + fr_id.Text + "' ", myconn)
        dr1 = cmd2.ExecuteReader()

        If dr1.HasRows() = True And fc_hp.edittp.Text = "" Then
            MsgBox("Username already in use.", MsgBoxStyle.Critical)
            fr_id.Text = ""
            dr1.Close()

        ElseIf fr_id.Text = "" Or fr_fname.Text = "" Or fr_lname.Text = "" Or fr_contact.Text = "" Or fr_pass.Text = "" Or fr_cpass.Text = "" Or fr_age.Text = "" Then
            dr1.Close()
            MsgBox("Fill in all details.", MsgBoxStyle.Critical, "EDU.CROSS")
        ElseIf fc_hp.edittp.Text = "" And fr_id.Text.Length < 4 Then
            dr1.Close()
            MsgBox("Username is too short (Min 4 characters)", MsgBoxStyle.Information, "EDU.CROSS")
            fr_id.Text = ""
        ElseIf fr_pass.Text <> fr_cpass.Text Then
            dr1.Close()
            MsgBox("Passwords don't match", MsgBoxStyle.Exclamation, "EDU.CROSS")
            fr_pass.Text = ""
            fr_cpass.Text = ""

        ElseIf fr_pass.Text.Length < 4 Then
            dr1.Close()
            MsgBox("Password is too weak (Min 4 characters) ", MsgBoxStyle.Information, "EDU.CROSS")
            fr_pass.Text = ""
        ElseIf aage > 70 Or aage < 22 Then
            dr1.Close()
            MsgBox("Age should be between 22 to 70 Years", MsgBoxStyle.Information, "EDU.CROSS")
            fr_age.Text = ""
        ElseIf fr_contact.Text.Length <> 10 Then
            dr1.Close()
            MsgBox("Invalid Phone Number", MsgBoxStyle.Information, "EDU.CROSS")
            fr_contact.Text = ""

        ElseIf fc_hp.edittp.Text = "Edit" Then
            in_str = "update facultyreg set fname='" + fr_fname.Text + "',mname='" + fr_mname.Text + "',lname='" + fr_lname.Text + "',dept='" + fr_dept.Text + "',contact='" + fr_contact.Text + "',password='" + fr_pass.Text + "',age='" + fr_age.Text + "',gender='" + gender + "' where facid = '" + faclog.flog_user.Text + "'"
            cmd1 = New SqlCommand(in_str, myconn1)
            cmd1.ExecuteNonQuery()
            ' fillthegrid()
            myconn.Close()
            MsgBox("Account Updated Successfully.", MsgBoxStyle.Information, "EDU.CROSS")
            fc_hp.edittp.Text = ""
            myconn1.Close()

            Me.Hide()
            faclog.flog_user.Text = ""
            faclog.flog_pass.Text = ""
            faclog.Show()
        ElseIf fc_hp.edittp.Text = "" Then
            in_str = "insert into facultyreg(facid,fname,mname,lname,dept,contact,password,age,gender) values ('" + fid + "','" + fname + "','" + mname + "','" + lname + "','" + dept + "','" + contact + "','" + password + "','" + age + "','" + gender + "');"
            cmd1 = New SqlCommand(in_str, myconn1)
            cmd1.ExecuteNonQuery()
            myconn.Close()
            MsgBox("Account Created Successfully.", MsgBoxStyle.Information, "EDU.CROSS")
            fc_hp.edittp.Text = ""
            myconn1.Close()
            Me.Hide()
            faclog.flog_user.Text = ""
            faclog.flog_pass.Text = ""
            faclog.Show()
        End If


    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fr_id.Text = ""
        fr_fname.Text = ""
        fr_mname.Text = ""
        fr_lname.Text = ""
        fr_pass.Text = ""
        fr_contact.Text = ""
        fr_dept.Text = ""
        fr_cpass.Text = ""
        fr_age.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        If fc_hp.edittp.Text = "Edit" Then
            fc_hp.edittp.Text = ""
            fc_hp.Show()
        Else
            faclog.flog_user.Text = ""
            faclog.flog_pass.Text = ""
            faclog.Show()
        End If

    End Sub

    Private Sub fr_mname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_mname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Critical, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub fr_fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_fname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Critical, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub fr_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_lname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Critical, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub fr_age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_age.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers  Only ", MsgBoxStyle.Critical, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub fr_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_id.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            MsgBox("Please enter Alphanumeric characters Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub fr_contact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_contact.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers  Only ", MsgBoxStyle.Critical, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub fr_dept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fr_dept.KeyPress
        keyascii = Asc(e.KeyChar)
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

End Class
