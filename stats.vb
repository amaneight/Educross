Imports System.Data.SqlClient

Public Class stats
    Dim myconn As New SqlConnection
    Dim myconn1 As New SqlConnection
    Dim cmd, cmd1, cmd2 As SqlCommand
    Dim str As String
    Dim ds As DataSet
    Dim dr, dr1, dr2, dr3 As SqlDataReader
    Dim adp As SqlDataAdapter
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan
    Dim keyascii As Integer
    Dim ra As Integer
    Dim cra(10) As String
    Dim in_str, in_str1 As String



    Public Sub stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducrossDataSet6.cr_db' table. You can move, or remove it, as needed.
        Me.Cr_dbTableAdapter1.Fill(Me.EducrossDataSet6.cr_db)
      
        'TODO: This line of code loads data into the 'EducrossDataSet9.Defaulter' table. You can move, or remove it, as needed.
        Me.DefaulterTableAdapter1.Fill(Me.EducrossDataSet9.Defaulter)
     
        'TODO: This line of code loads data into the 'EducrossDataSet5.Result' table. You can move, or remove it, as needed.
        Me.ResultTableAdapter.Fill(Me.EducrossDataSet5.Result)
        
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")

        xaxis.Show()
        Chart1.Show()
        count.Hide()
        count.Text = ""
        count.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView1.Hide()
        If faclog.fl4.Text = "flag1" Then
            faclog.fl4.Text = "fl"
        Else
            Chart1.Series.Add("High Score")
            Chart1.ChartAreas.Add("High Score")
            Chart1.Series("High Score").IsValueShownAsLabel = True
        End If
        chart1view()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home.Click

        Me.Hide()
        
        ' myconn.Close()

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()


        fc_hp.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim j, k As Integer
        Dim facid As String
        Dim dgval As String
        Dim cnt, inx(20) As Integer
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        stats_Load(sender, e)
        facid = faclog.flog_user.Text

        j = 0
        k = 0
        cnt = 0

        Chart1.Hide()
        xaxis.Hide()
        count.Show()
        DataGridView2.Hide()
        DataGridView3.Hide()
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Show()

        j = DataGridView1.Rows.Count
        For k = 0 To j - 1 Step 1
            If k < DataGridView1.Rows.Count Then
                dgval = DataGridView1.Item(6, k).Value

                If dgval <> "" And dgval <> facid Then
                    DataGridView1.Rows.RemoveAt(k)
                    k = -1
                End If
            End If
        Next
        DataGridView1.Columns(6).Visible = False
        j = DataGridView1.Rows.Count
        count.Text = "No. of crosswords : " & j - 1

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i, j As Integer
        Dim dgval, invclk As String
        i = 0
        j = 0
        invclk = ""
        j = DataGridView1.Rows.Count
        i = DataGridView1.CurrentRow.Index()

        If DataGridView1.Item(5, i).Selected = True And i <> (j - 1) Then
            DataGridView2.Columns(6).Visible = True
            str = DataGridView1.Item(0, i).Value
            DataGridView1.Hide()
            DataGridView2.Show()
            j = DataGridView2.Rows.Count

            For k = 0 To j - 1 Step 1

                If k < DataGridView2.Rows.Count Then
                    dgval = DataGridView2.Item(6, k).Value

                    If dgval <> "" And dgval <> str Then
                        ' MsgBox("out")
                        DataGridView2.Rows.RemoveAt(k)
                        k = -1
                    End If
                ElseIf k >= DataGridView2.Rows.Count Then
                    k = j
                End If
            Next

        Else
            MsgBox("Invalid Click", MsgBoxStyle.Information, "EDU.CROSS")
            invclk = "True"
        End If
        DataGridView2.Columns(6).Visible = False
        If invclk = "" Then
            j = DataGridView2.Rows.Count
            count.Text = "No. of students who solved your crossword : " & j - 1
        End If
        invclk = ""
       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        stats_Load(sender, e)
        Chart1.Show()
        xaxis.Show()
        count.Hide()
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dgval, facid As String
        Dim j As Integer = 0

        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        stats_Load(sender, e)

        Chart1.Hide()
        xaxis.Hide()
        count.Show()
        DataGridView1.Hide()
        DataGridView2.Hide()
        DataGridView3.Show()

        j = DataGridView3.Rows.Count

        facid = faclog.flog_user.Text
        DataGridView3.Columns(2).Visible = False

        For k = 0 To j - 1 Step 1
            If k < DataGridView3.Rows.Count Then
                dgval = DataGridView3.Item(2, k).Value

                If dgval <> "" And dgval <> facid Then
                    DataGridView3.Rows.RemoveAt(k)
                    k = -1
                End If
            End If
        Next
        DataGridView3.Columns(2).Visible = False
        j = DataGridView3.Rows.Count
        count.Text = "No. of students in defaulter list : " & j - 1
    End Sub
    Sub chart1view()
        Dim scnt As Double
        Dim i, j As Integer
        DataGridView1.Visible = False

        DataGridView2.Visible = False
        DataGridView3.Visible = False
        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()

        myconn1 = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn1.Open()


        cmd = New SqlCommand("select *from cr_db where facid='" + faclog.flog_user.Text + "' ", myconn)
        dr1 = cmd.ExecuteReader()
        If dr1.HasRows() = True Then
            While dr1.Read()
                cra(j) = dr1("crno").ToString
                j = j + 1
            End While
        End If
        dr1.Close()


        dr1.Close()

        For i = 0 To j - 1 Step 1
            cmd1 = New SqlCommand("SELECT max(score) FROM Result where crno='" + cra(i) + "'", myconn1)

            scnt = cmd1.ExecuteScalar
            Chart1.Series("High Score").Points.AddXY(cra(i), scnt)


            ' myconn1.Close()
            dr1.Close()
        Next

        Chart1.Series("High Score").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column

    End Sub

  
    
End Class