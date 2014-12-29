<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subcross
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ResultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducrossDataSet5 = New WindowsApplication1.educrossDataSet5()
        Me.ResultTableAdapter = New WindowsApplication1.educrossDataSet5TableAdapters.ResultTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EducrossDataSet6 = New WindowsApplication1.educrossDataSet6()
        Me.CrdbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cr_dbTableAdapter = New WindowsApplication1.educrossDataSet6TableAdapters.cr_dbTableAdapter()
        Me.count = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.resid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Topic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sovdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducrossDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducrossDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.resid, Me.CrnoDataGridViewTextBoxColumn, Me.Subject, Me.Topic, Me.score, Me.level, Me.time, Me.sovdate, Me.prnno})
        Me.DataGridView1.DataSource = Me.ResultBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(73, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(957, 449)
        Me.DataGridView1.TabIndex = 0
        '
        'ResultBindingSource
        '
        Me.ResultBindingSource.DataMember = "Result"
        Me.ResultBindingSource.DataSource = Me.EducrossDataSet5
        '
        'EducrossDataSet5
        '
        Me.EducrossDataSet5.DataSetName = "educrossDataSet5"
        Me.EducrossDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResultTableAdapter
        '
        Me.ResultTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Maroon
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 33)
        Me.Button3.TabIndex = 162
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(977, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Label1"
        '
        'EducrossDataSet6
        '
        Me.EducrossDataSet6.DataSetName = "educrossDataSet6"
        Me.EducrossDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrdbBindingSource
        '
        Me.CrdbBindingSource.DataMember = "cr_db"
        Me.CrdbBindingSource.DataSource = Me.EducrossDataSet6
        '
        'Cr_dbTableAdapter
        '
        Me.Cr_dbTableAdapter.ClearBeforeFill = True
        '
        'count
        '
        Me.count.AutoSize = True
        Me.count.BackColor = System.Drawing.Color.Transparent
        Me.count.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.ForeColor = System.Drawing.Color.Maroon
        Me.count.Location = New System.Drawing.Point(263, 671)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(61, 25)
        Me.count.TabIndex = 188
        Me.count.Text = "count"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Postinkantaja Job", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Maroon
        Me.Label43.Location = New System.Drawing.Point(397, 119)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(466, 53)
        Me.Label43.TabIndex = 190
        Me.Label43.Text = "Test your knowledge"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Postinkantaja Job", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Maroon
        Me.Label44.Location = New System.Drawing.Point(358, 12)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(536, 107)
        Me.Label44.TabIndex = 189
        Me.Label44.Text = "EDu.CroSS"
        '
        'resid
        '
        Me.resid.DataPropertyName = "resid"
        Me.resid.HeaderText = "Result ID"
        Me.resid.Name = "resid"
        Me.resid.ReadOnly = True
        '
        'CrnoDataGridViewTextBoxColumn
        '
        Me.CrnoDataGridViewTextBoxColumn.DataPropertyName = "crno"
        Me.CrnoDataGridViewTextBoxColumn.HeaderText = "Crossword ID"
        Me.CrnoDataGridViewTextBoxColumn.Name = "CrnoDataGridViewTextBoxColumn"
        Me.CrnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CrnoDataGridViewTextBoxColumn.Width = 120
        '
        'Subject
        '
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        Me.Subject.Width = 120
        '
        'Topic
        '
        Me.Topic.HeaderText = "Topic"
        Me.Topic.Name = "Topic"
        Me.Topic.ReadOnly = True
        Me.Topic.Width = 170
        '
        'score
        '
        Me.score.DataPropertyName = "score"
        Me.score.HeaderText = "Score"
        Me.score.Name = "score"
        Me.score.ReadOnly = True
        '
        'level
        '
        Me.level.DataPropertyName = "level"
        Me.level.HeaderText = "Level"
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        '
        'time
        '
        Me.time.DataPropertyName = "time"
        Me.time.HeaderText = "Time Left"
        Me.time.Name = "time"
        Me.time.ReadOnly = True
        '
        'sovdate
        '
        Me.sovdate.DataPropertyName = "sovdate"
        Me.sovdate.HeaderText = "Solve Date"
        Me.sovdate.Name = "sovdate"
        Me.sovdate.ReadOnly = True
        '
        'prnno
        '
        Me.prnno.DataPropertyName = "prnno"
        Me.prnno.HeaderText = "prnno"
        Me.prnno.Name = "prnno"
        Me.prnno.ReadOnly = True
        Me.prnno.Width = 5
        '
        'subcross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "subcross"
        Me.Text = "Submitted Crossword"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducrossDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducrossDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EducrossDataSet5 As WindowsApplication1.educrossDataSet5
    Friend WithEvents ResultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultTableAdapter As WindowsApplication1.educrossDataSet5TableAdapters.ResultTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EducrossDataSet6 As WindowsApplication1.educrossDataSet6
    Friend WithEvents CrdbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cr_dbTableAdapter As WindowsApplication1.educrossDataSet6TableAdapters.cr_dbTableAdapter
    Friend WithEvents count As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents resid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CrnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Topic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents score As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents level As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sovdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prnno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
