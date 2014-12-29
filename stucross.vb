Imports System.Data.SqlClient

Public Class stucross
    Dim myconn As New SqlConnection
    Dim myconn1 As New SqlConnection
    Dim cmd, cmd1, cmd2, cmd3 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1, dr2, dr3, dr4 As SqlDataReader
    Dim adp As SqlDataAdapter
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan
    Dim rid As New Random()
    Dim keyascii As Integer
    Dim ra As Integer
    Dim tm, a, d As Integer
    Dim in_str, in_str1 As String
    Dim str As String
    Dim crnum As String
    Dim i As Long = 1
    Dim ans As String
    Dim score As Integer = 0
    Dim val(65) As String
    Dim alp(65) As String
    Dim astr(10), dstr(10), acl(10), dcl(10) As String
    Dim ast(10), dst(10), flag As Integer
    Dim qlmt, n, crcount As Integer
    Dim stri, stri1, cltype, resid As String
    Dim qno1 As Integer = 1
    Dim tleft As Double
    Dim sovdate, fcid As String



    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducrossDataSet4.question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.Fill(Me.EducrossDataSet4.question)
        score = 0

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized


        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()

        flag = tm = a = d = 0

        crnum = stuhp.ipcrno.Text
        crlabel.Text = crnum
        Label5.Text = stuhp.ComboBox3.Text
        Label7.Text = stulog.slog_user.Text & " is playing !! "

        clue1.Hide()
        clue2.Hide()
        clue3.Hide()
        clue4.Hide()
        clue5.Hide()
        clue6.Hide()
        clue7.Hide()
        clue8.Hide()
        clue9.Hide()
        clue10.Hide()
        clue11.Hide()
        clue12.Hide()
        Label41.Hide()
        Label42.Hide()
        subpro.Hide()
        Proceed.Hide()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
        TextBox35.Text = ""
        TextBox36.Text = ""
        TextBox37.Text = ""
        TextBox38.Text = ""
        TextBox39.Text = ""
        TextBox40.Text = ""
        TextBox41.Text = ""
        TextBox42.Text = ""
        TextBox43.Text = ""
        TextBox44.Text = ""
        TextBox45.Text = ""
        TextBox46.Text = ""
        TextBox47.Text = ""
        TextBox48.Text = ""
        TextBox49.Text = ""
        TextBox50.Text = ""
        TextBox51.Text = ""
        TextBox52.Text = ""
        TextBox53.Text = ""
        TextBox54.Text = ""
        TextBox55.Text = ""
        TextBox56.Text = ""
        TextBox57.Text = ""
        TextBox58.Text = ""
        TextBox59.Text = ""
        TextBox60.Text = ""
        TextBox61.Text = ""
        TextBox62.Text = ""
        TextBox63.Text = ""
        TextBox64.Text = ""

        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        TextBox12.Visible = True
        TextBox13.Visible = True
        TextBox14.Visible = True
        TextBox15.Visible = True
        TextBox16.Visible = True
        TextBox17.Visible = True
        TextBox18.Visible = True
        TextBox19.Visible = True
        TextBox20.Visible = True
        TextBox21.Visible = True
        TextBox22.Visible = True
        TextBox23.Visible = True
        TextBox24.Visible = True
        TextBox25.Visible = True
        TextBox26.Visible = True
        TextBox27.Visible = True
        TextBox28.Visible = True
        TextBox29.Visible = True
        TextBox30.Visible = True
        TextBox31.Visible = True
        TextBox32.Visible = True
        TextBox33.Visible = True
        TextBox34.Visible = True
        TextBox35.Visible = True
        TextBox36.Visible = True
        TextBox37.Visible = True
        TextBox38.Visible = True
        TextBox39.Visible = True
        TextBox40.Visible = True
        TextBox41.Visible = True
        TextBox42.Visible = True
        TextBox43.Visible = True
        TextBox44.Visible = True
        TextBox45.Visible = True
        TextBox46.Visible = True
        TextBox47.Visible = True
        TextBox48.Visible = True
        TextBox49.Visible = True
        TextBox50.Visible = True
        TextBox51.Visible = True
        TextBox52.Visible = True
        TextBox53.Visible = True
        TextBox54.Visible = True
        TextBox55.Visible = True
        TextBox56.Visible = True
        TextBox57.Visible = True
        TextBox58.Visible = True
        TextBox59.Visible = True
        TextBox60.Visible = True
        TextBox61.Visible = True
        TextBox62.Visible = True
        TextBox63.Visible = True
        TextBox64.Visible = True
        Dim p As Integer

        For p = 0 To 10 Step 1
            acl(p) = ""
            dcl(p) = ""
        Next

        If Level.selevel.Text = "Easy" Then
            CountDownFrom = TimeSpan.FromMinutes(10)
        ElseIf Level.selevel.Text = "Medium" Then
            CountDownFrom = TimeSpan.FromMinutes(7)
        ElseIf Level.selevel.Text = "Hard" Then
            CountDownFrom = TimeSpan.FromMinutes(5)
        End If


        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")

        myconn1.Open()

        cmd = New SqlCommand("select * from crsol where crno='" + crlabel.Text + "' ", myconn1)
        dr = cmd.ExecuteReader()

        If dr.HasRows() = True Then

            While dr.Read()

                alp(0) = dr("a00").ToString
                If alp(0) = " " Then
                    TextBox1.Text = " "
                    TextBox1.Visible = False
                End If

                alp(1) = dr("a01").ToString
                If alp(1) = " " Then
                    TextBox2.Text = " "
                    TextBox2.Visible = False
                End If

                alp(2) = dr("a02").ToString
                If alp(2) = " " Then
                    TextBox3.Text = " "
                    TextBox3.Visible = False
                End If

                alp(3) = dr("a03").ToString
                If alp(3) = " " Then
                    TextBox4.Text = " "
                    TextBox4.Visible = False
                End If


                alp(4) = dr("a04").ToString
                If alp(4) = " " Then
                    TextBox5.Text = " "
                    TextBox5.Visible = False

                End If

                alp(5) = dr("a05").ToString
                If alp(5) = " " Then
                    TextBox6.Text = " "
                    TextBox6.Visible = False
                End If

                alp(6) = dr("a06").ToString
                If alp(6) = " " Then
                    TextBox7.Text = " "
                    TextBox7.Hide()
                End If

                alp(7) = dr("a07").ToString
                If alp(7) = " " Then
                    TextBox8.Text = " "
                    TextBox8.Hide()
                End If

                alp(8) = dr("a08").ToString
                If alp(8) = " " Then
                    TextBox9.Text = " "
                    TextBox9.Visible = False

                End If

                alp(9) = dr("a09").ToString
                If alp(9) = " " Then
                    TextBox10.Text = " "
                    TextBox10.Visible = False
                End If


                alp(10) = dr("a10").ToString
                If alp(10) = " " Then
                    TextBox11.Text = " "
                    TextBox11.Visible = False
                End If

                alp(11) = dr("a11").ToString
                If alp(11) = " " Then
                    TextBox12.Text = " "
                    TextBox12.Visible = False

                End If

                alp(12) = dr("a12").ToString
                If alp(12) = " " Then
                    TextBox13.Text = " "
                    TextBox13.Visible = False
                End If

                alp(13) = dr("a13").ToString
                If alp(13) = " " Then
                    TextBox14.Text = " "
                    TextBox14.Visible = False
                End If

                alp(14) = dr("a14").ToString
                If alp(14) = " " Then
                    TextBox15.Text = " "
                    TextBox15.Visible = False
                End If

                alp(15) = dr("a15").ToString
                If alp(15) = " " Then
                    TextBox16.Text = " "
                    TextBox16.Visible = False
                End If

                alp(16) = dr("a16").ToString
                If alp(16) = " " Then
                    TextBox17.Text = " "
                    TextBox17.Visible = False

                End If

                alp(17) = dr("a17").ToString
                If alp(17) = " " Then
                    TextBox18.Text = " "
                    TextBox18.Visible = False
                End If

                alp(18) = dr("a18").ToString
                If alp(18) = " " Then
                    TextBox19.Text = " "
                    TextBox19.Visible = False
                End If

                alp(19) = dr("a19").ToString
                If alp(19) = " " Then
                    TextBox20.Text = " "
                    TextBox20.Visible = False
                End If


                alp(20) = dr("a20").ToString
                If alp(20) = " " Then
                    TextBox21.Text = " "
                    TextBox21.Visible = False
                End If

                alp(21) = dr("a21").ToString
                If alp(21) = " " Then
                    TextBox22.Text = " "
                    TextBox21.Visible = False
                End If

                alp(22) = dr("a22").ToString
                If alp(22) = " " Then
                    TextBox23.Text = " "
                    TextBox23.Visible = False
                End If

                alp(23) = dr("a23").ToString
                If alp(23) = " " Then
                    TextBox24.Text = " "
                    TextBox24.Visible = False
                End If

                alp(24) = dr("a24").ToString
                If alp(24) = " " Then
                    TextBox25.Text = " "
                    TextBox25.Visible = False
                End If

                alp(25) = dr("a25").ToString
                If alp(25) = " " Then
                    TextBox26.Text = " "
                    TextBox26.Visible = False
                End If

                alp(26) = dr("a26").ToString
                If alp(26) = " " Then
                    TextBox27.Text = " "
                    TextBox27.Visible = False
                End If

                alp(27) = dr("a27").ToString
                If alp(27) = " " Then
                    TextBox28.Text = " "
                    TextBox28.Visible = False
                End If

                alp(28) = dr("a28").ToString
                If alp(28) = " " Then
                    TextBox29.Text = " "
                    TextBox29.Visible = False
                End If

                alp(29) = dr("a29").ToString
                If alp(29) = " " Then
                    TextBox30.Text = " "
                    TextBox30.Visible = False
                End If


                alp(30) = dr("a30").ToString
                If alp(30) = " " Then
                    TextBox31.Text = " "
                    TextBox31.Visible = False
                End If

                alp(31) = dr("a31").ToString
                If alp(31) = " " Then
                    TextBox32.Text = " "
                    TextBox32.Visible = False
                End If

                alp(32) = dr("a32").ToString
                If alp(32) = " " Then
                    TextBox33.Text = " "
                    TextBox33.Visible = False
                End If

                alp(33) = dr("a33").ToString
                If alp(33) = " " Then
                    TextBox34.Text = " "
                    TextBox34.Visible = False
                End If

                alp(34) = dr("a34").ToString
                If alp(34) = " " Then
                    TextBox35.Text = " "
                    TextBox35.Visible = False
                End If

                alp(35) = dr("a35").ToString
                If alp(35) = " " Then
                    TextBox36.Text = " "
                    TextBox36.Visible = False

                End If

                alp(36) = dr("a36").ToString
                If alp(36) = " " Then
                    TextBox37.Text = " "
                    TextBox37.Visible = False
                End If

                alp(37) = dr("a37").ToString
                If alp(37) = " " Then
                    TextBox38.Text = " "
                    TextBox38.Visible = False
                End If

                alp(38) = dr("a38").ToString
                If alp(38) = " " Then
                    TextBox39.Text = " "
                    TextBox39.Visible = False
                End If

                alp(39) = dr("a39").ToString
                If alp(39) = " " Then
                    TextBox40.Text = " "
                    TextBox40.Visible = False
                End If


                alp(40) = dr("a40").ToString
                If alp(40) = " " Then
                    TextBox41.Text = " "
                    TextBox41.Visible = False

                End If

                alp(41) = dr("a41").ToString
                If alp(41) = " " Then
                    TextBox42.Text = " "
                    TextBox42.Visible = False
                End If

                alp(42) = dr("a42").ToString
                If alp(42) = " " Then
                    TextBox43.Text = " "
                    TextBox43.Visible = False

                End If

                alp(43) = dr("a43").ToString
                If alp(43) = " " Then
                    TextBox44.Text = " "
                    TextBox44.Visible = False
                End If

                alp(44) = dr("a44").ToString
                If alp(44) = " " Then
                    TextBox45.Text = " "
                    TextBox45.Visible = False
                End If

                alp(45) = dr("a45").ToString
                If alp(45) = " " Then
                    TextBox46.Text = " "
                    TextBox46.Visible = False

                End If

                alp(46) = dr("a46").ToString
                If alp(46) = " " Then
                    TextBox47.Text = " "
                    TextBox47.Visible = False

                End If

                alp(47) = dr("a47").ToString
                If alp(47) = " " Then
                    TextBox48.Text = " "
                    TextBox48.Visible = False

                End If

                alp(48) = dr("a48").ToString
                If alp(48) = " " Then
                    TextBox49.Text = " "
                    TextBox49.Visible = False

                End If

                alp(49) = dr("a49").ToString
                If alp(49) = " " Then
                    TextBox50.Text = " "
                    TextBox50.Visible = False
                End If

                alp(50) = dr("a50").ToString
                If alp(50) = " " Then
                    TextBox51.Text = " "
                    TextBox51.Visible = False
                End If

                alp(51) = dr("a51").ToString
                If alp(51) = " " Then
                    TextBox52.Text = " "
                    TextBox52.Visible = False

                End If

                alp(52) = dr("a52").ToString
                If alp(52) = " " Then
                    TextBox53.Text = " "
                    TextBox53.Visible = False

                End If

                alp(53) = dr("a53").ToString
                If alp(53) = " " Then
                    TextBox54.Text = " "
                    TextBox54.Visible = False

                End If


                alp(54) = dr("a54").ToString
                If alp(54) = " " Then
                    TextBox55.Text = " "
                    TextBox55.Visible = False

                End If

                alp(55) = dr("a55").ToString
                If alp(55) = " " Then
                    TextBox56.Text = " "
                    TextBox56.Visible = False
                End If

                alp(56) = dr("a56").ToString
                If alp(56) = " " Then
                    TextBox57.Text = " "
                    TextBox57.Visible = False
                End If

                alp(57) = dr("a57").ToString
                If alp(57) = " " Then
                    TextBox58.Text = " "
                    TextBox58.Visible = False

                End If

                alp(58) = dr("a58").ToString
                If alp(58) = " " Then
                    TextBox59.Text = " "
                    TextBox59.Visible = False

                End If

                alp(59) = dr("a59").ToString
                If alp(59) = " " Then
                    TextBox60.Text = " "
                    TextBox60.Visible = False

                End If


                alp(60) = dr("a60").ToString
                If alp(60) = " " Then
                    TextBox61.Text = " "
                    TextBox61.Visible = False

                End If

                alp(61) = dr("a61").ToString
                If alp(61) = " " Then
                    TextBox62.Text = " "
                    TextBox62.Visible = False

                End If

                alp(62) = dr("a62").ToString
                If alp(62) = " " Then
                    TextBox63.Text = " "
                    TextBox63.Visible = False

                End If

                alp(63) = dr("a63").ToString
                If alp(63) = " " Then
                    TextBox64.Text = " "
                    TextBox64.Visible = False

                End If


            End While

        Else
            MsgBox("Crossword Does Not Exist !!", MsgBoxStyle.OkOnly)
        End If
        dr.Close()
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")


        Timer1.Interval = 500
        TargetDT = DateTime.Now.Add(CountDownFrom)
        Timer1.Start()

        Dim quno, clen As Integer
        qlmt = 0
        cltype = ""
        crcount = 0

        cmd = New SqlCommand("select *from cr_db where crno='" + crlabel.Text + "' ", myconn1)
        dr1 = cmd.ExecuteReader()
        If dr1.HasRows() = True Then
            While dr1.Read()
                qlmt = dr1("qtot")

            End While
        End If
        dr1.Close()

        For quno = 1 To qlmt Step 1

            cmd1 = New SqlCommand("select *from question where crno='" + crlabel.Text + "' and qno='" + quno.ToString + "' ", myconn1)
            dr2 = cmd1.ExecuteReader()

            If dr2.HasRows() = True Then
                While dr2.Read()

                    If dr2("type").Equals("Across") Then
                        a = a + 1
                        astr(a) = dr2("clue").ToString
                        ast(a) = dr2("stpt").ToString
                        acl(a) = dr2("ans").ToString

                    ElseIf dr2("type").Equals("Down") Then
                        d = d + 1
                        dstr(d) = dr2("clue").ToString
                        dst(d) = dr2("stpt").ToString
                        dcl(d) = dr2("ans").ToString

                    End If
                End While
            End If
            dr2.Close()
        Next

        a = 0
        d = 0

        clen = Len(acl(1))
        If acl(1).Equals("") = False Then
            clue1.Visible = True
            clue1.Text = ast(1) & ". " & astr(1) & "(" & clen & ")"
        End If

        clen = Len(acl(2))
        If acl(2).Equals("") = False Then
            clue2.Visible = True
            clue2.Text = ast(2) & ". " & astr(2) & "(" & clen & ")"
        End If

        clen = Len(acl(3))
        If acl(3).Equals("") = False Then
            clue3.Visible = True
            clue3.Text = ast(3) & ". " & astr(3) & "(" & clen & ")"
        End If

        clen = Len(acl(4))
        If acl(4).Equals("") = False Then
            clue4.Visible = True
            clue4.Text = ast(4) & ". " & astr(4) & "(" & clen & ")"
        End If

        clen = Len(acl(5))
        If acl(5).Equals("") = False Then
            clue5.Visible = True
            clue5.Text = ast(5) & ". " & astr(5) & "(" & clen & ")"
        End If

        clen = Len(acl(6))
        If acl(6).Equals("") = False Then
            clue6.Visible = True
            clue6.Text = ast(6) & ". " & astr(6) & "(" & clen & ")"
        End If

        clen = Len(dcl(1))
        If dcl(1).Equals("") = False Then
            clue7.Visible = True
            clue7.Text = dst(1) & ". " & dstr(1) & "(" & clen & ")"
        End If

        clen = Len(dcl(2))
        If dcl(2).Equals("") = False Then
            clue8.Visible = True
            clue8.Text = dst(2) & ". " & dstr(2) & "(" & clen & ")"
        End If

        clen = Len(dcl(3))
        If dcl(3).Equals("") = False Then
            clue9.Visible = True
            clue9.Text = dst(3) & ". " & dstr(3) & "(" & clen & ")"
        End If

        clen = Len(dcl(4))
        If dcl(4).Equals("") = False Then
            clue10.Visible = True
            clue10.Text = dst(4) & ". " & dstr(4) & "(" & clen & ")"
        End If

        clen = Len(dcl(5))
        If dcl(5).Equals("") = False Then
            clue11.Visible = True
            clue11.Text = dst(5) & ". " & dstr(5) & "(" & clen & ")"
        End If

        clen = Len(dcl(6))
        If dcl(6).Equals("") = False Then
            clue12.Visible = True
            clue12.Text = dst(6) & ". " & dstr(6) & "(" & clen & ")"
        End If

        myconn.Close()
       

        subpro.Text = "Submit"
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click

        myconn.Close()
        myconn.Open()

        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()

        home.hide()

        flag = 1
        val(0) = TextBox1.Text
        val(1) = TextBox2.Text
        val(2) = TextBox3.Text
        val(3) = TextBox4.Text
        val(4) = TextBox5.Text
        val(5) = TextBox6.Text
        val(6) = TextBox7.Text
        val(7) = TextBox8.Text
        val(8) = TextBox9.Text
        val(9) = TextBox10.Text
        val(10) = TextBox11.Text
        val(11) = TextBox12.Text
        val(12) = TextBox13.Text
        val(13) = TextBox14.Text
        val(14) = TextBox15.Text
        val(15) = TextBox16.Text
        val(16) = TextBox17.Text
        val(17) = TextBox18.Text
        val(18) = TextBox19.Text
        val(19) = TextBox20.Text
        val(20) = TextBox21.Text
        val(21) = TextBox22.Text
        val(22) = TextBox23.Text
        val(23) = TextBox24.Text
        val(24) = TextBox25.Text
        val(25) = TextBox26.Text
        val(26) = TextBox27.Text
        val(27) = TextBox28.Text
        val(28) = TextBox29.Text
        val(29) = TextBox30.Text
        val(30) = TextBox31.Text
        val(31) = TextBox32.Text
        val(32) = TextBox33.Text
        val(33) = TextBox34.Text
        val(34) = TextBox35.Text
        val(35) = TextBox36.Text
        val(36) = TextBox37.Text
        val(37) = TextBox38.Text
        val(38) = TextBox39.Text
        val(39) = TextBox40.Text
        val(40) = TextBox41.Text
        val(41) = TextBox42.Text
        val(42) = TextBox43.Text
        val(43) = TextBox44.Text
        val(44) = TextBox45.Text
        val(45) = TextBox46.Text
        val(46) = TextBox47.Text
        val(47) = TextBox48.Text
        val(48) = TextBox49.Text
        val(49) = TextBox50.Text
        val(50) = TextBox51.Text
        val(51) = TextBox52.Text
        val(52) = TextBox53.Text
        val(53) = TextBox54.Text
        val(54) = TextBox55.Text
        val(55) = TextBox56.Text
        val(56) = TextBox57.Text
        val(57) = TextBox58.Text
        val(58) = TextBox59.Text
        val(59) = TextBox60.Text
        val(60) = TextBox61.Text
        val(61) = TextBox62.Text
        val(62) = TextBox63.Text
        val(63) = TextBox64.Text

        Dim o As Integer
        For o = 0 To 63 Step 1
            If val(o) = "" Then
                val(o) = "x"
            End If
        Next



        Dim i, j, len, st, en As Integer

        qno1 = 1
        len = 0
        st = 0
        en = 0

        i = 0

        stri = ""
        stri1 = ""

        For j = 0 To 63 Step 1
            i = i + 1
            stri1 = ""

            If val(j) <> " " Then
                stri1 = stri & val(j)
                stri = stri1


                If i = 8 Then
                    If stri.Length > 1 Then
                        len = stri.Length
                        in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crlabel.Text + "','" & qno1 & "','" + stri + "','" + "Across" + "');"
                        cmd1 = New SqlCommand(in_str1, myconn1)
                        cmd1.ExecuteNonQuery()
                        check()

                        qno1 = qno1 + 1
                        'MessageBox.Show(stri.ToString, "full Question Added")
                    End If

                    i = 0
                    stri = ""
                End If


            Else

                If stri.Length > 1 Then
                    len = stri.Length

                    in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crlabel.Text + "','" & qno1 & "','" + stri + "','" + "Across" + "');"
                    cmd1 = New SqlCommand(in_str1, myconn1)
                    cmd1.ExecuteNonQuery()
                    check()
                    qno1 = qno1 + 1
                    'MessageBox.Show(stri, "Question Added")
                    stri = ""
                Else
                    ' MsgBox("Space detected:")
                    stri = ""
                End If

                If i = 8 Then
                    i = 0
                End If

            End If
        Next

        'MsgBox("Across Done")

        i = 0

        stri = ""
        stri1 = ""

        For j = 0 To 63 Step 8
            i = i + 1
            stri1 = ""

            If val(j) <> " " Then
                stri1 = stri & val(j)
                stri = stri1


                If i = 8 Then
                    If stri.Length > 1 Then
                        len = stri.Length
                        in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crlabel.Text + "','" & qno1 & "','" + stri + "','" + "Down" + "');"
                        cmd1 = New SqlCommand(in_str1, myconn1)
                        cmd1.ExecuteNonQuery()
                        check()
                        qno1 = qno1 + 1
                        'MessageBox.Show(stri.ToString, "full Question Added")
                    End If

                    i = 0
                    stri = ""
                End If

                If j = 56 Then
                    j = -7
                ElseIf j = 57 Then
                    j = -6
                ElseIf j = 58 Then
                    j = -5
                ElseIf j = 59 Then
                    j = -4
                ElseIf j = 60 Then
                    j = -3
                ElseIf j = 61 Then
                    j = -2
                ElseIf j = 62 Then
                    j = -1
                End If


            Else

                If stri.Length > 1 Then
                    len = stri.Length
                    in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crlabel.Text + "','" & qno1 & "','" + stri + "','" + "Down" + "');"
                    cmd1 = New SqlCommand(in_str1, myconn1)
                    cmd1.ExecuteNonQuery()
                    check()
                    qno1 = qno1 + 1
                    'MessageBox.Show(stri, "Question Added")
                    stri = ""
                Else
                    'MsgBox("Space detected:")
                    stri = ""
                End If

                If i = 8 Then
                    i = 0
                End If

                If j = 56 Then
                    j = -7
                ElseIf j = 57 Then
                    j = -6
                ElseIf j = 58 Then
                    j = -5
                ElseIf j = 59 Then
                    j = -4
                ElseIf j = 60 Then
                    j = -3
                ElseIf j = 61 Then
                    j = -2
                ElseIf j = 62 Then
                    j = -1
                End If

            End If
        Next

        cmd = New SqlCommand("DELETE from hints", myconn)
        cmd.ExecuteNonQuery()

        Dim good, half, quarter As Integer
        good = (qlmt * 8)
        half = (qlmt * 5)
        quarter = (qlmt * 3)

        If score >= good Then
            Label42.Text = "Well Done"
        ElseIf score >= half Then
            Label42.Text = "Study Well"
        ElseIf score >= quarter Then
            Label42.Text = "Clear your concepts"
        Else
            Label42.Text = "Contact your faculty"
        End If

        Label41.Text = score.ToString
        'dr.Close()
        myconn.Close()
        myconn.Open()

        sovdate = DateString.ToString
     
        resid = rid.Next(1000, 9999).ToString
        For i = 0 To 1 Step 1
            cmd3 = New SqlCommand("select *from result where resid='" + resid + "'", myconn)
            dr4 = cmd3.ExecuteReader()
            If dr4.HasRows() = True Then
                resid = rid.Next(1000, 9999).ToString
                i = -1
                dr4.Close()

            End If
            dr4.Close()
        Next

        dr4.Close()
        myconn.Close()
        myconn.Open()
     

        If score < quarter Then

            cmd1 = New SqlCommand("select facid from cr_db where crno='" + crlabel.Text + "'", myconn)
            dr4 = cmd1.ExecuteReader()
            If dr4.HasRows() = True Then
                While dr4.Read()
                    fcid = dr4("facid").ToString
                End While
            End If

            dr4.Close()

            cmd1 = New SqlCommand("select * from Defaulter where stuid='" + stulog.slog_user.Text + "' and facid='" + fcid + "'", myconn)
            dr4 = cmd1.ExecuteReader()
            If dr4.HasRows() = True Then
                While dr4.Read()
                    crcount = dr4("crcount")
                End While

            End If
            dr4.Close()

            If crcount = 0 Then

                crcount = crcount + 1
                in_str = "insert into Defaulter(stuid,facid,crcount)values('" + stulog.slog_user.Text + "','" + fcid + "','" & crcount & "');"
                cmd1 = New SqlCommand(in_str, myconn)
                cmd1.ExecuteNonQuery()
            Else

                crcount = crcount + 1
                in_str = "update Defaulter set crcount='" & crcount & "' where stuid='" + stulog.slog_user.Text + "' and facid='" + fcid + "'"
                cmd1 = New SqlCommand(in_str, myconn)
                cmd1.ExecuteNonQuery()

            End If

        End If

        myconn.Close()
        myconn.Open()

        in_str = "insert into Result(resid,prnno,crno,score,level,time,sovdate) values ('" + resid + "','" + stulog.slog_user.Text + "','" + crlabel.Text + "','" + Label41.Text + "','" + Level.selevel.Text + "','" + Label8.Text + "','" & sovdate & "');"
        cmd1 = New SqlCommand(in_str, myconn)
        ' adp = New SqlDataAdapter(in_str, myconn)
        cmd1.ExecuteNonQuery()

        'fillthegrid1()
        ' Level.selevel.Text = "Select Level"
        myconn.Close()
        myconn.Open()


        Timer1.Stop()
        If subpro.Text = "Submit" Then
            If tleft > 2 And Level.selevel.Text = "Easy" And score = qlmt * 10 Then
                score = score + 10
                MsgBox("Bravo You Have scored 10 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
            ElseIf tleft > 2 And Level.selevel.Text = "Medium" And score = qlmt * 10 Then
                score = score + 15
                MsgBox("Bravo You Have scored 15 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
            ElseIf tleft > 2 And Level.selevel.Text = "Hard" And score = qlmt * 10 Then
                score = score + 20
                MsgBox("Bravo You Have scored 20 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
            End If

            Label41.Text = score.ToString
            in_str = "update Result set score='" + Label41.Text + "' where resid = '" + resid + "'"
            cmd = New SqlCommand(in_str, myconn)
            cmd.ExecuteNonQuery()

            Me.Hide()
            Scorecard.Form2_Load(sender, e)
            Scorecard.Show()
        ElseIf subpro.Text = "solve" Then
            solve.Show()
            Submit.Show()
            Reset.Show()

        End If



    End Sub
   

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        stulog.Show()
    End Sub



   

    'Sub fillthegrid1()
    '    ds = New DataSet()
    '    adp.Fill(ds, "hints")
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            tleft = ts.TotalMinutes
            Label8.Text = ts.ToString("mm\:ss")
        Else
            Label8.Text = "00:00"
            Timer1.Stop()
            msgup()


        End If
    End Sub
    Sub check()
        Dim chkstr As String
        cmd2 = New SqlCommand("select *from question where crno='" + crlabel.Text + "' and qno='" & qno1 & "' ", myconn1)
        dr3 = cmd2.ExecuteReader()

        If dr3.HasRows() = True Then
            While dr3.Read()
                chkstr = dr3("ans").ToString
                If stri.Equals(chkstr) = True Then
                    score = score + 10
                End If
            End While

        End If
        dr3.Close()
    End Sub
    Sub msgup()

        ' If tm > 0 Then
        MessageBox.Show("TimeUp", "EDUCROSS")
        Button2_Click(True, AcceptButton)
        'End If
        tm = tm + 1


    End Sub



    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.QuestionTableAdapter.FillBy(Me.EducrossDataSet4.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
        TextBox35.Text = ""
        TextBox36.Text = ""
        TextBox37.Text = ""
        TextBox38.Text = ""
        TextBox39.Text = ""
        TextBox40.Text = ""
        TextBox41.Text = ""
        TextBox42.Text = ""
        TextBox43.Text = ""
        TextBox44.Text = ""
        TextBox45.Text = ""
        TextBox46.Text = ""
        TextBox47.Text = ""
        TextBox48.Text = ""
        TextBox49.Text = ""
        TextBox50.Text = ""
        TextBox51.Text = ""
        TextBox52.Text = ""
        TextBox53.Text = ""
        TextBox54.Text = ""
        TextBox55.Text = ""
        TextBox56.Text = ""
        TextBox57.Text = ""
        TextBox58.Text = ""
        TextBox59.Text = ""
        TextBox60.Text = ""
        TextBox61.Text = ""
        TextBox62.Text = ""
        TextBox63.Text = ""
        TextBox64.Text = ""
    End Sub
    'Sub fillthegrid1()
    '    ds = New DataSet()
    '    adp.Fill(ds, "Result")
    'End Sub
    Public Sub solve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solve.Click

        subpro.Text = "solve"
        Me.Button2_Click(sender, e)
        Label41.Text = score.ToString
        Proceed.Show()

        solve.Hide()
        Submit.Hide()
        Reset.Hide()




        cmd = New SqlCommand("select * from crsol where crno='" + crlabel.Text + "' ", myconn1)


        dr = cmd.ExecuteReader()

        If dr.HasRows() = True Then

            While dr.Read()
                TextBox1.Text = dr("a00").ToString
                TextBox2.Text = dr("a01").ToString
                TextBox3.Text = dr("a02").ToString
                TextBox4.Text = dr("a03").ToString
                TextBox5.Text = dr("a04").ToString
                TextBox6.Text = dr("a05").ToString
                TextBox7.Text = dr("a06").ToString
                TextBox8.Text = dr("a07").ToString
                TextBox9.Text = dr("a08").ToString
                TextBox10.Text = dr("a09").ToString
                TextBox11.Text = dr("a10").ToString
                TextBox12.Text = dr("a11").ToString
                TextBox13.Text = dr("a12").ToString
                TextBox14.Text = dr("a13").ToString
                TextBox15.Text = dr("a14").ToString
                TextBox16.Text = dr("a15").ToString
                TextBox17.Text = dr("a16").ToString
                TextBox18.Text = dr("a17").ToString
                TextBox19.Text = dr("a18").ToString
                TextBox20.Text = dr("a19").ToString
                TextBox21.Text = dr("a20").ToString
                TextBox22.Text = dr("a21").ToString
                TextBox23.Text = dr("a22").ToString
                TextBox24.Text = dr("a23").ToString
                TextBox25.Text = dr("a24").ToString
                TextBox26.Text = dr("a25").ToString
                TextBox27.Text = dr("a26").ToString
                TextBox28.Text = dr("a27").ToString
                TextBox29.Text = dr("a28").ToString
                TextBox30.Text = dr("a29").ToString
                TextBox31.Text = dr("a30").ToString
                TextBox32.Text = dr("a31").ToString
                TextBox33.Text = dr("a32").ToString
                TextBox34.Text = dr("a33").ToString
                TextBox35.Text = dr("a34").ToString
                TextBox36.Text = dr("a35").ToString
                TextBox37.Text = dr("a36").ToString
                TextBox38.Text = dr("a37").ToString
                TextBox39.Text = dr("a38").ToString
                TextBox40.Text = dr("a39").ToString
                TextBox41.Text = dr("a40").ToString
                TextBox42.Text = dr("a41").ToString
                TextBox43.Text = dr("a42").ToString
                TextBox44.Text = dr("a43").ToString
                TextBox45.Text = dr("a44").ToString
                TextBox46.Text = dr("a45").ToString
                TextBox47.Text = dr("a46").ToString
                TextBox48.Text = dr("a47").ToString
                TextBox49.Text = dr("a48").ToString
                TextBox50.Text = dr("a49").ToString
                TextBox51.Text = dr("a50").ToString
                TextBox52.Text = dr("a51").ToString
                TextBox53.Text = dr("a52").ToString
                TextBox54.Text = dr("a53").ToString
                TextBox55.Text = dr("a54").ToString
                TextBox56.Text = dr("a55").ToString
                TextBox57.Text = dr("a56").ToString
                TextBox58.Text = dr("a57").ToString
                TextBox59.Text = dr("a58").ToString
                TextBox60.Text = dr("a59").ToString
                TextBox61.Text = dr("a60").ToString
                TextBox62.Text = dr("a61").ToString
                TextBox63.Text = dr("a62").ToString
                TextBox64.Text = dr("a63").ToString

            End While

        End If

    End Sub

    Private Sub Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed.Click
        myconn.Close()
        myconn.Open()

        If tleft > 2 And Level.selevel.Text = "Easy" And score = qlmt * 10 Then
            score = score + 10
            MsgBox("Bravo You Have scored 10 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
        ElseIf tleft > 2 And Level.selevel.Text = "Medium" And score = qlmt * 10 Then
            score = score + 15
            MsgBox("Bravo You Have scored 15 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
        ElseIf tleft > 2 And Level.selevel.Text = "Hard" And score = qlmt * 10 Then
            score = score + 20
            MsgBox("Bravo You Have scored 20 BONUS POINTS", MsgBoxStyle.Information, "CONGRATULATIONS")
        End If

        Label41.Text = score.ToString
        in_str = "update Result set score='" + Label41.Text + "' where resid = '" + resid + "'"
        cmd = New SqlCommand(in_str, myconn)
        cmd.ExecuteNonQuery()

        Me.Hide()
        solve.Show()
        Submit.Show()
        Scorecard.Form2_Load(sender, e)
        Scorecard.Show()
   

    End Sub

    Private Sub home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home.Click
        If subpro.Text = "solve" Then
            Me.Hide()
            crcross.Show()

        End If
        Timer1.Stop()
        Me.Hide()
        stuhp.ComboBox1.Text = ""
        stuhp.ComboBox2.Text = ""
        stuhp.ComboBox3.Text = ""
        stuhp.Show()
    End Sub
End Class
