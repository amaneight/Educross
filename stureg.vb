Imports System.Data.SqlClient

Public Class stureg
    Dim myconn, myconn1, myconn2 As New SqlConnection
    Dim cmd, cmd1, cmd2 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1 As SqlDataReader
    Dim adp As SqlDataAdapter
    Dim keyascii As Integer
    Dim ra As Integer
    Dim in_str As String
    Dim str As String
    Dim prn As String
    Dim fname As String
    Dim mname As String
    Dim lname As String
    Dim rollno As String
    Dim year As String
    Dim div As String
    Dim contact As String
    Dim dept As String
    Dim password As String
    Dim cnfpass As String
    Dim age As String
    Dim gender As String
    Dim regdate As String
    Dim modate As String
    Dim aage As Integer = 0

    Public Sub stureg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        user.Hide()
        sr_prn.Show()

        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()
        str = "select *from studentreg"
        adp = New SqlDataAdapter(str, myconn)
        sr_prn.Text = ""
        sr_fname.Text = ""
        sr_mname.Text = ""
        sr_lname.Text = ""
        sr_roll.Text = ""
        sr_year.Text = "S.E"
        sr_div.Text = "Div.1"
        sr_contact.Text = ""
        sr_pass.Text = ""
        sr_cpass.Text = ""
        sr_age.Text = ""
        sr_male.Checked = True


        fillthegrid()
        regdate = DateString.ToString
        modate = "NA"
        If stuhp.ipcrno.Text = "Edit" Then

            cmd = New SqlCommand("Select * from studentreg where prnno='" + stulog.slog_user.Text + "' ", myconn)
            dr = cmd.ExecuteReader()
            If dr.HasRows() = True Then
                While dr.Read()
                    modate = DateString.ToString
                    user.Show()
                    sr_prn.Hide()
                    user.Text = dr("prnno").ToString
                    sr_prn.Text = user.Text
                    sr_fname.Text = dr("fname").ToString
                    sr_mname.Text = dr("mname").ToString
                    sr_lname.Text = dr("lname").ToString
                    sr_roll.Text = dr("rollno").ToString
                    sr_year.Text = dr("year").ToString
                    sr_div.Text = dr("div").ToString
                    sr_contact.Text = dr("contact").ToString
                    sr_age.Text = dr("age").ToString
                    sr_dept.Text = dr("dept").ToString
                    regdate = dr("regdate").ToString
                    gender = dr("gender").ToString
                    If gender.Equals("Male") Then
                        sr_male.Checked = True
                    Else
                        sr_female.Checked = True
                    End If
                End While
            End If
            dr.Close()
        End If



    End Sub

    Sub fillthegrid()
        ds = New DataSet()
        adp.Fill(ds, "studentreg")
    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmbut.Click
        


        myconn.Close()
        myconn.Open()
        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()
        myconn2 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn2.Open()

       
        If sr_male.Checked Then
            gender = sr_male.Text.ToString

        ElseIf sr_female.Checked Then
            gender = sr_female.Text.ToString
        End If

        'If stuhp.ipcrno.Text = "Edit" Then
        '    cmd = New SqlCommand("delete from studentreg where prnno='" + stulog.slog_user.Text + "' and password='" + stulog.slog_pass.Text + "' ", myconn)
        '    dr = cmd.ExecuteReader()
        '    dr.Close()
        '    stuhp.ipcrno.Text = ""

        'End If
        prn = sr_prn.Text
        fname = sr_fname.Text
        mname = sr_mname.Text
        lname = sr_lname.Text
        rollno = sr_roll.Text
        year = sr_year.Text
        div = sr_div.Text
        contact = sr_contact.Text
        password = sr_pass.Text
        cnfpass = sr_cpass.Text
        If sr_age.Text <> "" Then
            aage = sr_age.Text
        End If

        age = sr_age.Text
        dept = sr_dept.Text


        cmd = New SqlCommand("select * from studentreg where prnno='" + sr_prn.Text + "' ", myconn)
        dr = cmd.ExecuteReader()

        cmd2 = New SqlCommand("select * from studentreg where rollno='" + sr_roll.Text + "' and year='" + sr_year.Text + "' and div='" + sr_div.Text + "' and dept='" + sr_dept.Text + "' ", myconn2)
        dr1 = cmd2.ExecuteReader()

        If dr.HasRows() = True And stuhp.ipcrno.Text = "" Then
            MsgBox("Username already in use.", MsgBoxStyle.Exclamation, "EDU.CROSS")
            sr_prn.Text = ""
            dr.Close()
        ElseIf dr1.HasRows() = True And stuhp.ipcrno.Text = "E" Then
            MsgBox("Roll no. already in use.", MsgBoxStyle.Exclamation, "EDU.CROSS")
            sr_roll.Text = ""
            dr1.Close()

        ElseIf sr_prn.Text = "" Or sr_fname.Text = "" Or sr_lname.Text = "" Or sr_roll.Text = "" Or sr_contact.Text = "" Or sr_pass.Text = "" Or sr_cpass.Text = "" Or sr_age.Text = "" Then
            dr.Close()
            MsgBox("Fill in all details.", MsgBoxStyle.Exclamation, "EDU.CROSS")
        ElseIf sr_prn.Text.Length < 4 And stuhp.ipcrno.Text = "" Then
            dr.Close()
            MsgBox("Username is too short (Min 4 characters) ", MsgBoxStyle.Information, "EDU.CROSS")
            sr_prn.Text = ""
        ElseIf aage > 30 Or aage < 16 Then
            dr.Close()
            MsgBox("Age should be between 16 to 30 Years", MsgBoxStyle.Information, "EDU.CROSS")
        ElseIf sr_contact.Text.Length <> 10 Then
            dr.Close()
            MsgBox("Invalid Phone Number", MsgBoxStyle.Information, "EDU.CROSS")
        ElseIf sr_pass.Text.Length < 4 Then
            dr.Close()
            MsgBox("Password is too weak (Min 4 characters) ", MsgBoxStyle.Information, "EDU.CROSS")
            sr_pass.Text = ""
        ElseIf sr_pass.Text <> sr_cpass.Text Then
            dr.Close()
            sr_pass.Text = ""
            sr_cpass.Text = ""
            MsgBox("Passwords don't match", MsgBoxStyle.Exclamation, "EDU.CROSS")
        ElseIf stuhp.ipcrno.Text = "Edit" Then
            in_str = "update studentreg set fname='" + sr_fname.Text + "',mname='" + sr_mname.Text + "',lname='" + sr_lname.Text + "',rollno='" + sr_roll.Text + "',year='" + sr_year.Text + "',div='" + sr_div.Text + "',dept='" + sr_dept.Text + "',contact='" + sr_contact.Text + "',password='" + sr_pass.Text + "',age='" + sr_age.Text + "',gender='" + gender + "' where prnno = '" + stulog.slog_user.Text + "'"
            cmd1 = New SqlCommand(in_str, myconn1)
            cmd1.ExecuteNonQuery()
            ' fillthegrid()
            myconn.Close()
            MsgBox("Account Updated Successfully.", MsgBoxStyle.Information, "EDU.CROSS")
            myconn1.Close()
            stuhp.ipcrno.Text = ""
            Me.Hide()
            stulog.slog_user.Text = ""
            stulog.slog_pass.Text = ""
            stulog.Show()
        ElseIf stuhp.ipcrno.Text = "" Then
            in_str = "insert into studentreg(prnno,fname,mname,lname,rollno,year,div,dept,contact,password,age,gender,regdate,modate) values ('" + prn + "','" + fname + "','" + mname + "','" + lname + "','" + rollno + "','" + year + "','" + div + "','" + dept + "','" + contact + "','" + password + "','" + age + "','" + gender + "','" & regdate & "','" + modate + "');"
            cmd1 = New SqlCommand(in_str, myconn1)
            cmd1.ExecuteNonQuery()
            ' fillthegrid1()
            myconn.Close()
            MsgBox("Account Created Successfully.", MsgBoxStyle.Information, "EDU.CROSS")
            myconn1.Close()
            Me.Hide()
            stulog.Show()
        End If

    End Sub
    


    Private Sub resetbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbut.Click
        sr_prn.Text = ""
        sr_fname.Text = ""
        sr_mname.Text = ""
        sr_lname.Text = ""
        sr_roll.Text = ""
        sr_year.Text = "S.E"
        sr_div.Text = "Div.1"
        sr_dept.text = "IT"
        sr_contact.Text = ""
        sr_pass.Text = ""
        sr_cpass.Text = ""
        sr_age.Text = ""

    End Sub

    Private Sub sr_prn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_prn.KeyPress
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
    Private Sub sr_fname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_fname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub sr_mname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_mname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub sr_lname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_lname.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            MsgBox("Please enter Alphabets Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub sr_roll_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_roll.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub sr_age_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_age.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers  Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub sr_contact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_contact.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers Only ", MsgBoxStyle.Exclamation, "EDU.CROSS")
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        If stuhp.ipcrno.Text = "Edit" Then
            stuhp.ipcrno.Text = ""
            stuhp.Show()
        Else
            stulog.Show()
        End If

    End Sub
    Private Sub sr_div_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_div.KeyPress
        keyascii = Asc(e.KeyChar)
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub sr_dept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_dept.KeyPress
        keyascii = Asc(e.KeyChar)
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub sr_year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sr_year.KeyPress
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