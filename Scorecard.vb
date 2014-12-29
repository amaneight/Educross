Imports System.Data.SqlClient
Public Class Scorecard
    Dim myconn As New SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim dr As SqlDataReader
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
    Dim scrstr As String

    Public Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.TopMost = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        If cross.faclb.Text = "fac" Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Show()
            Label5.Show()

            scrstr = cross.crnum.Text & " " & cross.topic.Text & " unit of " & cross.Label39.Text
            Label5.Text = scrstr

        Else
            Label1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Hide()
            Label5.Hide()

            scrstr = "You have scored " & stucross.Label41.Text & " Points"
            Label2.Text = scrstr
            Label3.Text = stucross.Label42.Text
        End If

    End Sub

    


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        If cross.faclb.Text = "fac" Then
            cross.faclb.Text = ""
            fc_hp.ComboBox1.Text = ""
            fc_hp.ComboBox2.Text = ""
            fc_hp.ComboBox3.Text = ""
            fc_hp.ComboBox1.Items.Clear()
            fc_hp.ComboBox1.Items.Add("SE")
            fc_hp.ComboBox1.Items.Add("TE")
            fc_hp.ComboBox1.Items.Add("BE")
            fc_hp.Show()
        Else
            stuhp.ComboBox1.Text = ""
            stuhp.ComboBox2.Text = ""
            stuhp.ComboBox3.Text = ""
            stuhp.ComboBox1.Items.Clear()
            stuhp.ComboBox1.Items.Add("SE")
            stuhp.ComboBox1.Items.Add("TE")
            stuhp.ComboBox1.Items.Add("BE")
            stuhp.Show()
        End If
      

    End Sub
End Class