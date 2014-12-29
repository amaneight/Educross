Imports System.Data.SqlClient

Public Class stuhp
    Dim myconn, myconn1 As New SqlConnection
    Dim cmd, cmd1 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1 As SqlDataReader
    Dim adp As SqlDataAdapter
    Dim keyascii As Integer
    Dim ra As Integer
    Dim str As String
    Dim in_str As String
    Dim selyr As String
    Dim selsub As String
    Dim seltop As String
    Dim crno As Integer
    Dim fname As String
    Dim flag As Integer = 0



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        stulog.slog_user.Text = ""
        stulog.slog_pass.Text = ""
        Login.Show()

    End Sub

  
    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged

        selyr = ComboBox1.Text.ToString

        If selyr.Equals("SE") Then
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox2.Items.Add("DS")
            ComboBox2.Items.Add("DELD")
            ComboBox2.Items.Add("FDS")
            ComboBox2.Items.Add("CO")
            ComboBox2.Items.Add("HSS")


        ElseIf selyr.Equals("TE") Then
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox2.Items.Add("OS")
            ComboBox2.Items.Add("TOC")
            ComboBox2.Items.Add("CNT")
            ComboBox2.Items.Add("DBMS")
            ComboBox2.Items.Add("SE")
            ComboBox2.Items.Add("SSP")
            ComboBox2.Items.Add("MIS")
            ComboBox2.Items.Add("DAA")
            ComboBox2.Items.Add("HCIU")
            ComboBox2.Items.Add("PP")


        ElseIf selyr.Equals("BE") Then
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox2.Items.Add("ISA")
            ComboBox2.Items.Add("OOMD")
            ComboBox2.Items.Add("STQA")
            ComboBox2.Items.Add("ADM")
            ComboBox2.Items.Add("AI")
            ComboBox2.Items.Add("CD")
            ComboBox2.Items.Add("AOS")
            ComboBox2.Items.Add("ES")
            ComboBox2.Items.Add("MC")
            ComboBox2.Items.Add("MS")
            ComboBox2.Items.Add("DS")
            ComboBox2.Items.Add("IR")
            ComboBox2.Items.Add("RTS")
            ComboBox2.Items.Add("SA")
            ComboBox2.Items.Add("AG")
            ComboBox2.Items.Add("ACN")
            ComboBox2.Items.Add("BI")
            ComboBox2.Items.Add("NNES")
            ComboBox2.Items.Add("GIS")
        End If

    End Sub

    Private Sub ComboBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged


        selsub = ComboBox2.Text.ToString


        If selsub.Equals("OS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Process Management")
            ComboBox3.Items.Add("Process Communication and Synchronization")
            ComboBox3.Items.Add("Memory Management")
            ComboBox3.Items.Add("I/O and File Management ")
            ComboBox3.Items.Add("Protection and Security")

        End If


        If selsub.Equals("TOC") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Basic Concept")
            ComboBox3.Items.Add("Finite automata(FA)")
            ComboBox3.Items.Add("Contexts Free Grammars and languages")
            ComboBox3.Items.Add("Regular Grammar and CFL")
            ComboBox3.Items.Add("Push down automata(PDA)")
            ComboBox3.Items.Add("Turing Machine")

        End If

        If selsub.Equals("CNT") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Network Layer and Routing")
            ComboBox3.Items.Add("Network layer – II (Protocols)")
            ComboBox3.Items.Add("Transport Layer")
            ComboBox3.Items.Add("Application Layer")
            ComboBox3.Items.Add("Multimedia Networking ")
            ComboBox3.Items.Add("Wireless and Broadband Network")

        End If
        If selsub.Equals("DBMS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Relational Query Languages")
            ComboBox3.Items.Add("Relational Database Design")
            ComboBox3.Items.Add("File Systems")
            ComboBox3.Items.Add("Transaction Management")
            ComboBox3.Items.Add("Object-Oriented Databases")

        End If

        If selsub.Equals("SE") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Requirements Engineering")
            ComboBox3.Items.Add("Design Engineering")
            ComboBox3.Items.Add("Testing Strategies")
            ComboBox3.Items.Add("Project management Concepts")
            ComboBox3.Items.Add("Project Planning")

        End If
        If selsub.Equals("SSP") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Macros")
            ComboBox3.Items.Add("Compiler I")
            ComboBox3.Items.Add("Compiler II")
            ComboBox3.Items.Add("Loaders and Linkers")
            ComboBox3.Items.Add("System Software Development Tools")

        End If


        If selsub.Equals("MIS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction to Information System")
            ComboBox3.Items.Add("Decision Support Systems")
            ComboBox3.Items.Add("E-commerce")
            ComboBox3.Items.Add("Applications of MIS")
            ComboBox3.Items.Add("Enterprise Management Systems")
            ComboBox3.Items.Add("Security and Ethical Challenges")

        End If

        If selsub.Equals("DAA") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Divide and Conquer and The Greedy Method")
            ComboBox3.Items.Add("Dynamic Programming")
            ComboBox3.Items.Add("Backtracking")
            ComboBox3.Items.Add("Branch-Bound")
            ComboBox3.Items.Add("NP-Hard and NP-Complete Problems")

        End If
        If selsub.Equals("HCIU") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("HCI introduction and basic concepts")
            ComboBox3.Items.Add("Interaction Design Basics")
            ComboBox3.Items.Add("Design Process and Standards")
            ComboBox3.Items.Add("UI evaluation")
            ComboBox3.Items.Add("Models and Theories")
            ComboBox3.Items.Add("Groupware")

        End If

        If selsub.Equals("PP") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Introduction")
            ComboBox3.Items.Add("Procedures")
            ComboBox3.Items.Add("Object Oriented Programming")
            ComboBox3.Items.Add("Declarative Programming Paradigm")
            ComboBox3.Items.Add("Parallel Programming Paradigm")
            ComboBox3.Items.Add("Additional Programming Paradigms")

        End If
        If selsub.Equals("DS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("SETS AND PROPORTIONS")
            ComboBox3.Items.Add("RELATIONS AND FUNCTIONS")
            ComboBox3.Items.Add("GROUPS AND RINGS")
            ComboBox3.Items.Add("GROUPS AND RINGS")
            ComboBox3.Items.Add("TREES")
            ComboBox3.Items.Add("PNC AND DISCRETE PROBABILITY")

        End If

        If selsub.Equals("CO") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("COMPUTER EVOLUTION AND ARITHMETIC")
            ComboBox3.Items.Add("CENTRAL PROCESSING UNIT")
            ComboBox3.Items.Add("BASICS OF 8086 PROGRAMMING")
            ComboBox3.Items.Add("CONTROL UNIT")
            ComboBox3.Items.Add("MEMORY ORGANISATION")
            ComboBox3.Items.Add("I/O ORGANISATION")

        End If

        If selsub.Equals("DELD") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("NUMBER SYSTEM AND LOGICAL FAMILIES")
            ComboBox3.Items.Add("COMBINATIONAL LOGIC  DESIGN")
            ComboBox3.Items.Add("SEQUENTIAL LOGIC")
            ComboBox3.Items.Add("SEQUENTIAL LOGIC DESIGN")
            ComboBox3.Items.Add("PROGRAMMABLE LOGIC DEVICES AND INTRO. TO HDL")
            ComboBox3.Items.Add("VHDLPROGRAMMING")

        End If


        If selsub.Equals("FDS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("INTRO TO C")
            ComboBox3.Items.Add("POINTERS IN C AND FILE HANDLING")
            ComboBox3.Items.Add("INTRO TO DATA STRUCTURE & ANALYSIS OF ALGO.")
            ComboBox3.Items.Add("SEARCHING AND SORTING TECHNIQUES")
            ComboBox3.Items.Add("LINEAR DATA STRUCTURES USING SEQUENTIAL ORGANISATION")
            ComboBox3.Items.Add("LINEAR DATA STRUCTURES USING LINKED ORGANISATION")

        End If


        If selsub.Equals("PSOOPS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("PROBLEM SOLVING CONCEPTS")
            ComboBox3.Items.Add("PROBLEM SOLVING WITH LOGIC STRUCTURES")
            ComboBox3.Items.Add("ARRAY AND TEXT PROCESSING")
            ComboBox3.Items.Add("FOUNDATION OF OOP")
            ComboBox3.Items.Add("OVERLOADING AND INHERITANCE")
            ComboBox3.Items.Add("TEMPLATES AND EXCEPTION HANDLING")

        End If


        If selsub.Equals("EM-3") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("LINEAR DIFFERENTIAL EQUATION")
            ComboBox3.Items.Add("TRANSFORMS")
            ComboBox3.Items.Add("STATISTICS AND PROBABILITY")
            ComboBox3.Items.Add("VECTOR DIFFERENTIAL CALCULUS")
            ComboBox3.Items.Add("VECTOR INTEGRAL CALCULUS AND APPLICATION")
            ComboBox3.Items.Add("COMPLEX VARIABLES")

        End If


        If selsub.Equals("CG") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("INTRO.")
            ComboBox3.Items.Add("POLYGONS AND 2D TRANSFORMATION")
            ComboBox3.Items.Add("SEGMENTS,WINDOWING AND CLIPPING")
            ComboBox3.Items.Add("3D TRANSFORMATION AND PROJECTION")
            ComboBox3.Items.Add("SHADING,COLOR MODELS AND ANIMATION")
            ComboBox3.Items.Add("CURVES AND FRACTALS")

        End If



        If selsub.Equals("PAI") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("INTRO. TO ASSEMBLY LANG. PROGRAMMING AND 80386 PROCESSOR")
            ComboBox3.Items.Add("80386 MEMORY SEGMENTATION")
            ComboBox3.Items.Add("PROTECTED MODE")
            ComboBox3.Items.Add("INTERRUPTS")
            ComboBox3.Items.Add("MICROCONTROLLER-I")
            ComboBox3.Items.Add("MICROCONTROLLER-II")

        End If


        If selsub.Equals("DSF") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" STACKS")
            ComboBox3.Items.Add("QUEUES")
            ComboBox3.Items.Add("TREES")
            ComboBox3.Items.Add("GRAPHS")
            ComboBox3.Items.Add("TABLES")
            ComboBox3.Items.Add("FILE ORGANISATION")

        End If



        If selsub.Equals("FCN") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" FUNADMENTALS OF SIGNALS")
            ComboBox3.Items.Add("MODULATION AND MULTIPLEXING TECHNIQUES")
            ComboBox3.Items.Add("TRANSMISSION MEDIA AND SWITCHING")
            ComboBox3.Items.Add("LAYER MODELS AND TOPOLOGIES")
            ComboBox3.Items.Add("ERROR CONTROL AND DATA LINK CONTROL")
            ComboBox3.Items.Add("MULTIPLE ACCESS AND ETHERNET")

        End If

        If selsub.Equals("ISA") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Security Fundamentals")
            ComboBox3.Items.Add("Cryptography")
            ComboBox3.Items.Add("Key Management")
            ComboBox3.Items.Add("Network Security")
            ComboBox3.Items.Add("Security Management and Applications")
            ComboBox3.Items.Add("Cyber Crimes and Laws")

        End If


        If selsub.Equals("OOMD") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Intro to OMG Standards")
            ComboBox3.Items.Add("Unit II")
            ComboBox3.Items.Add("Unit III")
            ComboBox3.Items.Add("Unit IV")
            ComboBox3.Items.Add("Unit V")
            ComboBox3.Items.Add("Unit VI")

        End If

        If selsub.Equals("CD") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Unit I")
            ComboBox3.Items.Add("Parsing")
            ComboBox3.Items.Add("Unit III")
            ComboBox3.Items.Add("Unit IV")
            ComboBox3.Items.Add("Unit V")
            ComboBox3.Items.Add("Unit VI")

        End If

        If selsub.Equals("IR") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Unit I")
            ComboBox3.Items.Add("Unit II")
            ComboBox3.Items.Add("Unit III")
            ComboBox3.Items.Add("Unit IV")
            ComboBox3.Items.Add("Unit V")
            ComboBox3.Items.Add("Unit VI")

        End If

        If selsub.Equals("RTS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Unit I")
            ComboBox3.Items.Add("Unit II")
            ComboBox3.Items.Add("Unit III")
            ComboBox3.Items.Add("Unit IV")
            ComboBox3.Items.Add("Unit V")
            ComboBox3.Items.Add("Unit VI")

        End If

        If selsub.Equals("SA") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Unit I")
            ComboBox3.Items.Add("Unit II")
            ComboBox3.Items.Add("Unit III")
            ComboBox3.Items.Add("Unit IV")
            ComboBox3.Items.Add("Unit V")
            ComboBox3.Items.Add("Unit VI")

        End If


        If selsub.Equals("STQA") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Testing Principles")
            ComboBox3.Items.Add("Test managemenet")
            ComboBox3.Items.Add("Software Metrics")
            ComboBox3.Items.Add("Quality Assurrance")
            ComboBox3.Items.Add("Quality Standards")
            ComboBox3.Items.Add("Development of CMM")

        End If

        If selsub.Equals("ADM") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Overview")
            ComboBox3.Items.Add("Transaction Processing")
            ComboBox3.Items.Add("OBD and XML")
            ComboBox3.Items.Add("Data Warehousing")
            ComboBox3.Items.Add("Olap and data mining")
            ComboBox3.Items.Add("Database Security")

        End If

        If selsub.Equals("AI") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add("Intro to AI")
            ComboBox3.Items.Add("Heuristics Research and game playing")
            ComboBox3.Items.Add("Knowledge Representation")
            ComboBox3.Items.Add("Planning perception")
            ComboBox3.Items.Add("Learning expert system")
            ComboBox3.Items.Add("AI programming")

        End If


        If selsub.Equals("AOS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction")
            ComboBox3.Items.Add(" II Multitasking ")
            ComboBox3.Items.Add(" III Multiprocessor systems")
            ComboBox3.Items.Add(" IV Memory management")
            ComboBox3.Items.Add(" V I/O system")
            ComboBox3.Items.Add(" VI File system")

        End If

        If selsub.Equals("ES") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction to Embedded System")
            ComboBox3.Items.Add(" II System Processor")
            ComboBox3.Items.Add(" III I/O Interfacing ")
            ComboBox3.Items.Add(" IV Programming Concepts, Embedded System Programming C & C++")
            ComboBox3.Items.Add(" V Real Time Operating Systems")
            ComboBox3.Items.Add(" VI Overview & Applications of Embedded System ")

        End If

        If selsub.Equals("MC") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction")
            ComboBox3.Items.Add(" II GSM")
            ComboBox3.Items.Add(" III GSM Services")
            ComboBox3.Items.Add(" IV Mobile Data Networks")
            ComboBox3.Items.Add(" V Mobile Network Layer ")
            ComboBox3.Items.Add(" VI Emerging Mobile Technologies")
        End If


        If selsub.Equals("MS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction")
            ComboBox3.Items.Add(" II Digital Image Processing ")
            ComboBox3.Items.Add(" III Audio and audio compression")
            ComboBox3.Items.Add(" IV Video")
            ComboBox3.Items.Add(" V Virtual Reality and Multimedia")
            ComboBox3.Items.Add(" VI Animation")


        End If

        If selsub.Equals("DS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction")
            ComboBox3.Items.Add(" II Inter-process Communication and Coordination")
            ComboBox3.Items.Add(" III Synchronization and Election")
            ComboBox3.Items.Add(" IV Distributed File Systems")
            ComboBox3.Items.Add(" V Distributed Shared Memory")
            ComboBox3.Items.Add(" VI Fault Tolerant and Recovery")

        End If

        If selsub.Equals("AG") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""

            ComboBox3.Items.Add(" I Brief Review of 3D modeling and 3D object Representation  ")
            ComboBox3.Items.Add(" II Animation  ")
            ComboBox3.Items.Add(" III Solid Modeling")
            ComboBox3.Items.Add(" IV Illumination models")
            ComboBox3.Items.Add(" V Rendering  ")
            ComboBox3.Items.Add(" VI Virtual Reality")
        End If


        If selsub.Equals("DS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction")
            ComboBox3.Items.Add(" II Inter-process Communication and Coordination")
            ComboBox3.Items.Add(" III Synchronization and Election")
            ComboBox3.Items.Add(" IV Distributed File Systems")
            ComboBox3.Items.Add(" V Distributed Shared Memory")
            ComboBox3.Items.Add(" VI Fault Tolerant and Recovery")



        End If

        If selsub.Equals("ACN") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction   ")
            ComboBox3.Items.Add(" II Advanced Technologies")
            ComboBox3.Items.Add(" III Performance of Networks")
            ComboBox3.Items.Add(" IV Advanced Routing - I ")
            ComboBox3.Items.Add(" V Advanced Routing - II ")
            ComboBox3.Items.Add(" VI Ad Hoc Networking")


        End If

        If selsub.Equals("BI") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction  ")
            ComboBox3.Items.Add(" II Data Visualization & Statistics ")
            ComboBox3.Items.Add(" III Data mining and pattern matching ")
            ComboBox3.Items.Add(" IV Modeling, Simulation & Collaboration ")
            ComboBox3.Items.Add(" V Bioinformatics tools ")
            ComboBox3.Items.Add(" VI Further Scope")
        End If


        If selsub.Equals("NNES") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Introduction to Artificial Neural Networks ")
            ComboBox3.Items.Add(" II Feedforward Neural Networks ")
            ComboBox3.Items.Add(" III Radial Basis Function Networks and Pattern Analysis")
            ComboBox3.Items.Add(" IV Self organizing maps and feedback networks ")
            ComboBox3.Items.Add(" V Expert Systems Architectures ")
            ComboBox3.Items.Add(" VI Shells and Case Studies ")


        End If

        If selsub.Equals("GIS") Then
            ComboBox3.Items.Clear()
            ComboBox3.Text = ""
            ComboBox3.Items.Add(" I Digital Image Processing Fundamentals  ")
            ComboBox3.Items.Add(" II Foundations of Remote Sensing ")
            ComboBox3.Items.Add(" III GIS Fundamentals ")
            ComboBox3.Items.Add(" IV Spatial Data Management")
            ComboBox3.Items.Add(" V Data Modeling and Analysis")
            ComboBox3.Items.Add(" VI Applications and development")


        End If
        seltop = ComboBox3.Text.ToString

    End Sub

    Public Sub Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceed.Click
        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()

        crno = 1000
        crno = crno + ((ComboBox1.SelectedIndex + 1) * 100)
        crno = crno + ((ComboBox2.SelectedIndex + 1) * 10)
        crno = crno + ComboBox3.SelectedIndex + 1

        cmd = New SqlCommand("select * from cr_db where crno='" + crno.ToString + "' ", myconn)
        dr = cmd.ExecuteReader()

        If dr.HasRows() = False Then
            MsgBox("Crossword does not exist", MsgBoxStyle.Critical, "EDU.CROSS")
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            dr.Close()
        Else
            dr.Close()
            cmd1 = New SqlCommand("select * from Result where crno='" + crno.ToString + "' and prnno='" + stulog.slog_user.Text + "'", myconn1)
            dr1 = cmd1.ExecuteReader()
            If dr1.HasRows() = True Then
                MsgBox("You have already solved this crossword", MsgBoxStyle.Exclamation, "EDU.CROSS")
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
                dr1.Close()
            Else
                dr1.Close()
                ipcrno.Text = crno.ToString

                Level.Show()
            End If
        End If

    End Sub

    Public Sub Level_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")

        ipcrno.Visible = False

        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()

        cmd = New SqlCommand("select * from studentreg where prnno='" + stulog.slog_user.Text + "' and password='" + stulog.slog_pass.Text + "' ", myconn)
        dr = cmd.ExecuteReader()
        Dim fn, ln As String

        If dr.HasRows() = True Then

            While dr.Read()
                fn = dr("fname").ToString
                ln = dr("lname").ToString
                fname = "Hi, " & fn & " " & ln & " !!"
            End While
        End If
        Label1.Text = fname
        dr.Close()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("SE")
        ComboBox1.Items.Add("TE")
        ComboBox1.Items.Add("BE")

    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ipcrno.Text = "Edit"
        Me.Hide()

        If stulog.fl.Text = "flag" Then
            stulog.fl.Text = "fl"
        ElseIf stulog.fl.Text = "fl" Then

            stureg.stureg_Load(sender, e)
        End If

        stureg.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        If stulog.fl.Text = "flag" Then
            stulog.fl.Text = "fl"
        ElseIf stulog.fl.Text = "fl" Then
            subcross.subcross_Load(sender, e)
        End If
        subcross.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        rules.frmval.Text = "Rules"
        rules.rules_Load(sender, e)
        rules.Show()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        keyascii = Asc(e.KeyChar)
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        keyascii = Asc(e.KeyChar)
        If e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            keyascii = 13
            Exit Sub
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
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