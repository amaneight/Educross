Imports System.Data.SqlClient
Public Class crcross
    Dim myconn, myconn1 As New SqlConnection
    Dim cmd, cmd1, cmd2 As SqlCommand
    Dim ds As DataSet
    Dim dr, dr1 As SqlDataReader
    Dim adp As SqlDataAdapter
    Dim keyascii As Integer
    Dim ra As Integer
    Dim in_str As String
    Dim i, j As Integer
    Dim str As String
    Dim dgval As String

    Public Sub crcross_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EducrossDataSet6.cr_db' table. You can move, or remove it, as needed.
        Me.Cr_dbTableAdapter.Fill(Me.EducrossDataSet6.cr_db)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("C:\Users\Dell\Documents\Visual Studio 2010\Projects\educross1\WindowsApplication1\My Project\woodenback.jpg")
        ' MsgBox(faclog.flog_user.Text)
        myconn = New SqlConnection("Data Source=aquarius-PC\SQLEXPRESS;Initial Catalog=educross;Integrated Security=True;Pooling=False")
        myconn.Open()
        DataGridView1.Columns(7).Visible = True

       
        j = DataGridView1.Rows.Count
        str = faclog.flog_user.Text
        For k = 0 To j - 1 Step 1
            If k < DataGridView1.Rows.Count Then
                dgval = DataGridView1.Item(7, k).Value
                If dgval <> "" And dgval <> str Then
                    DataGridView1.Rows.RemoveAt(k)
                    k = k - 1
                End If
            End If
        Next

        DataGridView1.Columns(7).Visible = False
    End Sub

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        fc_hp.Show()

    End Sub

    Public Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        j = DataGridView1.Rows.Count

        i = DataGridView1.CurrentRow.Index()
        If DataGridView1.Item(5, i).Selected = True Then

            viewcross.crlabel.Text = DataGridView1.Item(0, i).Value
            viewcross.Label5.Text = DataGridView1.Item(3, i).Value
            If faclog.fl3.Text = "flag1" Then
                faclog.fl3.Text = "fl"
            ElseIf faclog.fl3.Text = "fl" Then

                viewcross.viewcross_Load(sender, e)
            End If
            Me.Hide()
            viewcross.Show()

        ElseIf DataGridView1.Item(6, i).Selected = True And i <> (j - 1) Then
            str = DataGridView1.Item(0, i).Value
            cmd = New SqlCommand("delete from cr_db where crno='" + str + "'  ", myconn)
            dr = cmd.ExecuteReader()
            dr.Close()
            cmd = New SqlCommand("delete from crsol where crno='" + str + "'  ", myconn)
            dr = cmd.ExecuteReader()
            dr.Close()
            cmd = New SqlCommand("delete from Result where crno='" + str + "'  ", myconn)
            dr = cmd.ExecuteReader()
            dr.Close()
            cmd = New SqlCommand("delete from question where crno='" + str + "'  ", myconn)
            dr = cmd.ExecuteReader()
            dr.Close()
            DataGridView1.Rows.RemoveAt(i)
        Else
            MsgBox("Invalid Click", MsgBoxStyle.Information, "EDU.CROSS")
        End If


    End Sub

End Class