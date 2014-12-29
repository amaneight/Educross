Imports System.Data.SqlClient
Public Class viewcross
    Dim myconn As New SqlConnection
    Dim myconn1 As New SqlConnection
    Dim cmd, cmd1, cmd2 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1, dr2, dr3 As SqlDataReader
    Dim adp As SqlDataAdapter
 
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
    Dim qlmt, n As Integer
    Dim stri, stri1, cltype As String
    Dim qno1 As Integer = 1
    Dim tleft As Double
    Dim sovdate As String

    Public Sub viewcross_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.QuestionTableAdapter.Fill(Me.EducrossDataSet4.question)
        score = 0

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized


        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()


        flag = 0
        tm = 0
        a = 0
        d = 0

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


        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")

        myconn1.Open()

        cmd = New SqlCommand("select * from crsol where crno='" + crlabel.Text + "'", myconn1)

        'and a00='" + TextBox1.Text + "' and a01='" + TextBox2.Text + "' and a02='" + submit.click + "' and a03='" + TextBox4.Text + "'and a04='" + TextBox5.Text + "' and a05='" + TextBox6.Text + "' and a06='" + TextBox7.Text + "' and a07='" + TextBox8.Text + "' and a08='" + TextBox9.Text + "' and a09='" + TextBox10.Text + "'and a10='" + TextBox11.Text + "' and a11='" + TextBox12.Text + "' and a12='" + TextBox13.Text + "' and a13='" + TextBox14.Text + "' and a14='" + TextBox15.Text + "' and a15='" + TextBox16.Text + "' and a16='" + TextBox17.Text + "' and a17='" + TextBox18.Text + "' and a18='" + TextBox19.Text + "' and a19='" + TextBox20.Text + "' and a20='" + TextBox21.Text + "' and a21='" + TextBox22.Text + "' and a22='" + TextBox23.Text + "' and a23='" + TextBox24.Text + "' and a24='" + TextBox25.Text + "' and a25='" + TextBox26.Text + "' and a26='" + TextBox27.Text + "' and a27='" + TextBox28.Text + "' and a28='" + TextBox29.Text + "' and a29='" + TextBox30.Text + "' and a30='" + TextBox31.Text + "' and a31='" + TextBox32.Text + "' and a32='" + TextBox33.Text + "' and a33='" + TextBox34.Text + "' and a34='" + TextBox35.Text + "' and a35='" + TextBox36.Text + "' and a36='" + TextBox37.Text + "' and a37='" + TextBox38.Text + "' and a38='" + TextBox39.Text + "' and a39='" + TextBox40.Text + "' and a40='" + TextBox41.Text + "' and a41='" + TextBox42.Text + "' and a42='" + TextBox43.Text + "' and a43='" + TextBox44.Text + "' and a44='" + TextBox45.Text + "' and a45='" + TextBox46.Text + "' and a46='" + TextBox47.Text + "' and a47='" + TextBox48.Text + "' and a48='" + TextBox49.Text + "' ", myconn)
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

        Dim quno, clen As Integer
        qlmt = 0
        cltype = ""

        cmd = New SqlCommand("select *from cr_db where crno='1231' ", myconn1)
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
                'MsgBox("Enter")
                'cltype = dr2("type").ToString
                'MsgBox(cltype)
                While dr2.Read()
                    ' 
                    If dr2("type").Equals("Down") = True Then

                        d = d + 1

                        dstr(d) = dr2("clue").ToString

                        dst(d) = dr2("stpt").ToString
                        dcl(d) = dr2("ans").ToString

                    End If
                    If dr2("type").Equals("Across") = True Then
                        a = a + 1
                        astr(a) = dr2("clue").ToString
                        ast(a) = dr2("stpt").ToString
                        acl(a) = dr2("ans").ToString
                        ' MsgBox(astr(quno))
                        ' MsgBox(ast(quno))
                    End If


                End While
            End If
            dr2.Close()
        Next

        a = 0
        d = 0
        clen = Len(dcl(1))
        If clen <> 0 Then
            clue7.Visible = True
            clue7.Text = dst(1) & ". " & dstr(1) & "(" & clen & ")"
        End If

        clen = Len(dcl(2))
        If clen <> 0 Then
            clue8.Visible = True
            clue8.Text = dst(2) & ". " & dstr(2) & "(" & clen & ")"
        End If

        clen = Len(dcl(3))
        If clen <> 0 Then
            clue9.Visible = True
            clue9.Text = dst(3) & ". " & dstr(3) & "(" & clen & ")"
        End If

        clen = Len(dcl(4))
        If clen <> 0 Then
            clue10.Visible = True
            clue10.Text = dst(4) & ". " & dstr(4) & "(" & clen & ")"
        End If

        clen = Len(dcl(5))
        If clen <> 0 Then
            clue11.Visible = True
            clue11.Text = dst(5) & ". " & dstr(5) & "(" & clen & ")"
        End If

        clen = Len(dcl(6))
        If clen <> 0 Then
            clue12.Visible = True
            clue12.Text = dst(6) & ". " & dstr(6) & "(" & clen & ")"
        End If

        clen = Len(acl(1))
        If clen <> 0 Then
            clue1.Visible = True
            clue1.Text = ast(1) & ". " & astr(1) & "(" & clen & ")"
        End If

        clen = Len(acl(2))
        If clen <> 0 Then
            clue2.Visible = True
            clue2.Text = ast(2) & ". " & astr(2) & "(" & clen & ")"
        End If

        clen = Len(acl(3))
        If clen <> 0 Then
            clue3.Visible = True
            clue3.Text = ast(3) & ". " & astr(3) & "(" & clen & ")"
        End If

        clen = Len(acl(4))
        If clen <> 0 Then
            clue4.Visible = True
            clue4.Text = ast(4) & ". " & astr(4) & "(" & clen & ")"
        End If

        clen = Len(acl(5))
        If clen <> 0 Then
            clue5.Visible = True
            clue5.Text = ast(5) & ". " & astr(5) & "(" & clen & ")"
        End If

        clen = Len(acl(6))
        If clen <> 0 Then
            clue6.Visible = True
            clue6.Text = ast(6) & ". " & astr(6) & "(" & clen & ")"
        End If


        myconn.Close()
    End Sub

   
    Private Sub home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home.Click
        Me.Hide()
        crcross.Show()

    End Sub
End Class