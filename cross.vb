Imports System.Data.SqlClient

Public Class cross
    Dim myconn1 As New SqlConnection
    Dim myconn2, myconn3, myconn4, myconn As New SqlConnection
    Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1 As SqlDataReader
    Dim adp, adp1 As SqlDataAdapter
    Dim keyascii As Integer
    Dim ra As Integer
    Dim in_str1, in_str2, in_str3, in_str4 As String
    Dim str(10) As String
    Dim crno As String
    Dim qno1, qnum1 As String
    Dim clue(7) As Char
    Dim type As String
    Dim stpt As String
    Dim endpt As String
    Dim ans As String
    Dim len As Integer
    Dim stri, stri1 As String
    Dim val(65) As Char
    Dim accnt, docnt As Integer
    Dim strtype As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        note.Show()
        crno = 1000
        crno = crno + ((fc_hp.ComboBox1.SelectedIndex + 1) * 100)
        crno = crno + ((fc_hp.ComboBox2.SelectedIndex + 1) * 10)
        crno = crno + fc_hp.ComboBox3.SelectedIndex + 1

        crnum.Text = crno.ToString
        Label39.Text = fc_hp.ComboBox2.Text
        topic.Text = fc_hp.ComboBox3.Text


        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()

        myconn2 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn2.Open()

        str(0) = "select *from hints"
        adp = New SqlDataAdapter(str(0), myconn1)
        fillthegrid1()

        str(1) = "select *from crsol"
        adp = New SqlDataAdapter(str(1), myconn2)
        fillthegrid2()

        q_no.Visible = False
        quest.Visible = False
        st_pt.Visible = False
        end_pt.Visible = False
        sol.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        en_pt.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        ori.Visible = False
        Button1.Visible = False
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        faclog.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click

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


        

        Dim i, j, len, st, en As Integer

        accnt = 0
        docnt = 0

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
                        'en = j + 1
                        'st = en - len + 1
                        accnt = accnt + 1
                        in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crnum.Text + "','" + qno1 + "','" + stri + "','" + "Across" + "');"
                        cmd1 = New SqlCommand(in_str1, myconn1)
                        cmd1.ExecuteNonQuery()
                        fillthegrid1()
                        qno1 = qno1 + 1
                        'MessageBox.Show(stri.ToString, "full Question Added")
                    End If

                    i = 0
                    stri = ""
                End If


            Else

                If stri.Length > 1 Then
                    len = stri.Length
                    'en = j
                    'st = en - len + 1
                    accnt = accnt + 1
                    in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crnum.Text + "','" + qno1 + "','" + stri + "','" + "Across" + "');"
                    cmd1 = New SqlCommand(in_str1, myconn1)
                    cmd1.ExecuteNonQuery()
                    fillthegrid1()
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
                        'en = j + 1
                        'st = en - len + 1
                        docnt = docnt + 1
                        in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crnum.text + "','" + qno1 + "','" + stri + "','" + "Down" + "');"
                        cmd1 = New SqlCommand(in_str1, myconn1)
                        cmd1.ExecuteNonQuery()
                        fillthegrid1()
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
                    'en = j
                    'st = en - len + 1
                    docnt = docnt + 1
                    in_str1 = "insert into hints(crno,qno,ans,type) values ('" + crnum.text + "','" + qno1 + "','" + stri + "','" + "Down" + "');"
                    cmd1 = New SqlCommand(in_str1, myconn1)
                    cmd1.ExecuteNonQuery()
                    fillthegrid1()
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

        'MsgBox("Down Done")
        Dim cnt As Integer

        myconn4 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn4.Open()

        Dim cmd6 As New SqlCommand("SELECT COUNT(*) FROM hints", myconn4)

        cnt = (cmd6.ExecuteScalar)
        myconn4.Close()

        If cnt < 5 Then
            MsgBox("There should be atleast 5 questions in a crossword")
        Else
            note.Hide()
            myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
            myconn.Open()
            in_str4 = "insert into cr_db(crno,dept,year,sub,topic,facid) values ('" + crno.ToString + "','" + "IT" + "','" + fc_hp.ComboBox1.Text.ToString + "','" + fc_hp.ComboBox2.Text.ToString + "','" + fc_hp.ComboBox3.Text.ToString + "','" + faclog.flog_user.Text + "');"
            cmd6 = New SqlCommand(in_str4, myconn)
            cmd6.ExecuteNonQuery()


            'myconn.Close()
            in_str2 = "insert into crsol(crno,a00,a01,a02,a03,a04,a05,a06,a07,a08,a09,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,a26,a27,a28,a29,a30,a31,a32,a33,a34,a35,a36,a37,a38,a39,a40,a41,a42,a43,a44,a45,a46,a47,a48,a49,a50,a51,a52,a53,a54,a55,a56,a57,a58,a59,a60,a61,a62,a63) values ('" + crnum.Text + "','" + val(0) + "','" + val(1) + "','" + val(2) + "','" + val(3) + "','" + val(4) + "','" + val(5) + "','" + val(6) + "','" + val(7) + "','" + val(8) + "','" + val(9) + "','" + val(10) + "','" + val(11) + "','" + val(12) + "','" + val(13) + "','" + val(14) + "','" + val(15) + "','" + val(16) + "','" + val(17) + "','" + val(18) + "','" + val(19) + "','" + val(20) + "','" + val(21) + "','" + val(22) + "','" + val(23) + "','" + val(24) + "','" + val(25) + "','" + val(26) + "','" + val(27) + "','" + val(28) + "','" + val(29) + "','" + val(30) + "','" + val(31) + "','" + val(32) + "','" + val(33) + "','" + val(34) + "','" + val(35) + "','" + val(36) + "','" + val(37) + "','" + val(38) + "','" + val(39) + "','" + val(40) + "','" + val(41) + "','" + val(42) + "','" + val(43) + "','" + val(44) + "','" + val(45) + "','" + val(46) + "','" + val(47) + "','" + val(48) + "','" + val(49) + "','" + val(50) + "','" + val(51) + "','" + val(52) + "','" + val(53) + "','" + val(54) + "','" + val(55) + "','" + val(56) + "','" + val(57) + "','" + val(58) + "','" + val(59) + "','" + val(60) + "','" + val(61) + "','" + val(62) + "','" + val(63) + "');"
            cmd2 = New SqlCommand(in_str2, myconn2)
            cmd2.ExecuteNonQuery()
            fillthegrid2()
            myconn2.Close()
            'MsgBox("Crossword Submitted")
            Submit.Hide()
            reset.Hide()
            home.Hide()

            q_no.Visible = True
            quest.Visible = True
            st_pt.Visible = True
            end_pt.Visible = True
            sol.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            en_pt.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            ori.Visible = True
            Button1.Visible = True
            myconn1.Close()
            myconn2.Close()
            qnum1 = 1
            insertq()
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnt As String
        Dim spt, ept As Integer

        spt = 0
        ept = 0

        myconn4 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn4.Open()
        'str(3) = "select * from question"
        'adp1 = New SqlDataAdapter(str(3), myconn4)
        'fillthegrid3()
        If st_pt.Text <> "" Then
            spt = st_pt.Text
        End If
        If en_pt.Text <> "" Then
            ept = en_pt.Text
        End If



        If quest.Text.Equals("") = True Or st_pt.Text.Equals("") = True Or en_pt.Text.Equals("") = True Then
            MsgBox("Fill all the details", MsgBoxStyle.Exclamation, "EDU.CROSS")
        ElseIf spt > ept Or spt > 64 Or ept > 64 Or spt < 1 Or ept < 1 Then
            MsgBox("Invalid start or end point", MsgBoxStyle.Exclamation, "EDU.CROSS")
            st_pt.Text = ""
            en_pt.Text = ""
        Else
            in_str3 = "insert into question(crno,qno,clue,type,stpt,endpt,ans) values ('" + crnum.Text + "','" + qnum1 + "','" + quest.Text + "','" + ori.Text + "','" & st_pt.Text & "','" & en_pt.Text & "','" + sol.Text + "');"

            cmd4 = New SqlCommand(in_str3, myconn4)
            cmd4.ExecuteNonQuery()
            fillthegrid3()
            quest.Text = ""
            st_pt.Text = ""
            en_pt.Text = ""
            ' MsgBox(qnum1)
            qnum1 = qnum1 + 1

            insertq()

            If qnum1 >= qno1 Then
                Dim cmd6 As New SqlCommand("SELECT COUNT(*) FROM hints", myconn4)

                cnt = Convert.ToString(cmd6.ExecuteScalar)

                Dim ins_str As String
                Dim ss As String
                ss = crnum.Text

                ins_str = "update cr_db set qtot='" + cnt + "' where crno = '" + ss + "'"
                cmd6 = New SqlCommand(ins_str, myconn4)
                cmd6.ExecuteNonQuery()
                fillthegrid4()

                dr.Close()

                cmd5 = New SqlCommand("DELETE from hints", myconn4)
                cmd5.ExecuteNonQuery()

                qnum1 = 1

                ' MessageBox.Show("Questions added successfully")
                myconn4.Close()
                faclb.Text = "fac"
                Me.Hide()
                Scorecard.Show()


            End If
        End If

    End Sub

    Sub insertq()


        myconn3 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")

        myconn3.Open()


        str(2) = "select * from hints"
        adp = New SqlDataAdapter(str(2), myconn3)
        fillthegrid1()

        cmd3 = New SqlCommand("select * from hints where crno='" + crnum.Text + "' and qno='" & qnum1 & "' ", myconn3)
        dr = cmd3.ExecuteReader()

        If dr.HasRows() = True Then
            While dr.Read()
                q_no.Text = dr("qno").ToString
                sol.Text = dr("ans").ToString
                ori.Text = dr("type").ToString

            End While
        End If
        myconn3.Close()
    End Sub

    Sub fillthegrid1()
        ds = New DataSet()
        adp.Fill(ds, "hints")
    End Sub
    Sub fillthegrid2()
        ds = New DataSet()
        adp.Fill(ds, "crsol")
    End Sub
    Sub fillthegrid3()
        ds = New DataSet()
        adp.Fill(ds, "question")

    End Sub
    Sub fillthegrid4()
        ds = New DataSet()
        adp.Fill(ds, "cr_db")

    End Sub
    Sub getcount()
        Dim dt As DataTable
        ds = New DataSet()
        adp.Fill(ds, "question")
        dt = ds.Tables("question")
        MessageBox.Show(dt.Rows.Count, "Question count")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        fc_hp.Show()
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "
        TextBox13.Text = " "
        TextBox14.Text = " "
        TextBox15.Text = " "
        TextBox16.Text = " "
        TextBox17.Text = " "
        TextBox18.Text = " "
        TextBox19.Text = " "
        TextBox20.Text = " "
        TextBox21.Text = " "
        TextBox22.Text = " "
        TextBox23.Text = " "
        TextBox24.Text = " "
        TextBox25.Text = " "
        TextBox26.Text = " "
        TextBox27.Text = " "
        TextBox28.Text = " "
        TextBox29.Text = " "
        TextBox30.Text = " "
        TextBox31.Text = " "
        TextBox32.Text = " "
        TextBox33.Text = " "
        TextBox34.Text = " "
        TextBox35.Text = " "
        TextBox36.Text = " "
        TextBox37.Text = " "
        TextBox38.Text = " "
        TextBox39.Text = " "
        TextBox40.Text = " "
        TextBox41.Text = " "
        TextBox42.Text = " "
        TextBox43.Text = " "
        TextBox44.Text = " "
        TextBox45.Text = " "
        TextBox46.Text = " "
        TextBox47.Text = " "
        TextBox48.Text = " "
        TextBox49.Text = " "
        TextBox50.Text = " "
        TextBox51.Text = " "
        TextBox52.Text = " "
        TextBox53.Text = " "
        TextBox54.Text = " "
        TextBox55.Text = " "
        TextBox56.Text = " "
        TextBox57.Text = " "
        TextBox58.Text = " "
        TextBox59.Text = " "
        TextBox60.Text = " "
        TextBox61.Text = " "
        TextBox62.Text = " "
        TextBox63.Text = " "
        TextBox64.Text = " "

    End Sub

    Private Sub st_pt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles st_pt.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then
            MsgBox("Please enter Numbers Only ", MsgBoxStyle.Critical, "Validation error")
            e.Handled = True
            keyascii = 13
            Exit Sub
       
        End If
    End Sub
   
    Private Sub en_pt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles en_pt.KeyPress
        keyascii = Asc(e.KeyChar)
        If Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Then

            MsgBox("Please enter Numbers Only ", MsgBoxStyle.Critical, "Validation error")
            e.Handled = True
            keyascii = 13
            Exit Sub
           
        End If
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home.Click
        Me.Hide()
        fc_hp.ComboBox1.Text = ""
        fc_hp.ComboBox2.Text = ""
        fc_hp.ComboBox3.Text = ""
        fc_hp.ComboBox1.Items.Clear()
        fc_hp.ComboBox1.Items.Add("SE")
        fc_hp.ComboBox1.Items.Add("TE")
        fc_hp.ComboBox1.Items.Add("BE")
        fc_hp.Show()

    End Sub

End Class
