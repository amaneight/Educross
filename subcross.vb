Imports System.Data.SqlClient

Public Class subcross
    Dim i As Integer
    Dim myconn As New SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim adp As SqlDataAdapter

    Public Sub subcross_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducrossDataSet6.cr_db' table. You can move, or remove it, as needed.
        Me.Cr_dbTableAdapter.Fill(Me.EducrossDataSet6.cr_db)
        'TODO: This line of code loads data into the 'EducrossDataSet5.Result' table. You can move, or remove it, as needed.
        Me.ResultTableAdapter.Fill(Me.EducrossDataSet5.Result)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
  
        Label1.Hide()
        gridview()

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ResultTableAdapter.FillBy(Me.EducrossDataSet5.Result)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        stuhp.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub gridview()
        Dim j, k As Integer
        Dim stuid As String
        Dim dgval As String
        Dim cnt, inx(20) As Integer

        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()

        stuid = stulog.slog_user.Text
        DataGridView1.Columns(8).Visible = True
        j = 0
        k = 0
        cnt = 0


        j = DataGridView1.Rows.Count
        For k = 0 To j - 1 Step 1
            If k < DataGridView1.Rows.Count Then
                dgval = DataGridView1.Item(8, k).Value
                If dgval <> "" And dgval <> stuid Then
                    DataGridView1.Rows.RemoveAt(k)
                    k = -1
                End If
            End If
        Next

        j = DataGridView1.Rows.Count

        For k = 0 To j - 1 Step 1

            dgval = DataGridView1.Item(1, k).Value
            cmd = New SqlCommand("select * from cr_db where crno='" + dgval + "'", myconn)
            dr = cmd.ExecuteReader()
            If dr.HasRows() = True Then
                While dr.Read()
                    DataGridView1.Item(2, k).Value = dr("sub").ToString
                    DataGridView1.Item(3, k).Value = dr("topic").ToString
                End While
            End If
            dr.Close()

        Next
    
        myconn.Close()

        DataGridView1.Columns(8).Visible = False
        j = DataGridView1.Rows.Count
        count.Text = "You have solved " & j & " crosswords"
    End Sub
End Class