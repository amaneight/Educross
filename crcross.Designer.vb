<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crcross
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CrnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.facid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrdbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducrossDataSet6 = New WindowsApplication1.educrossDataSet6()
        Me.Cr_dbTableAdapter = New WindowsApplication1.educrossDataSet6TableAdapters.cr_dbTableAdapter()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducrossDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Button3.TabIndex = 163
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CrnoDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.SubDataGridViewTextBoxColumn, Me.TopicDataGridViewTextBoxColumn, Me.QtotDataGridViewTextBoxColumn, Me.View, Me.Delete, Me.facid})
        Me.DataGridView1.DataSource = Me.CrdbBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(88, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(970, 180)
        Me.DataGridView1.TabIndex = 164
        '
        'CrnoDataGridViewTextBoxColumn
        '
        Me.CrnoDataGridViewTextBoxColumn.DataPropertyName = "crno"
        Me.CrnoDataGridViewTextBoxColumn.HeaderText = "Crossword No"
        Me.CrnoDataGridViewTextBoxColumn.Name = "CrnoDataGridViewTextBoxColumn"
        Me.CrnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CrnoDataGridViewTextBoxColumn.Width = 120
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubDataGridViewTextBoxColumn
        '
        Me.SubDataGridViewTextBoxColumn.DataPropertyName = "sub"
        Me.SubDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubDataGridViewTextBoxColumn.Name = "SubDataGridViewTextBoxColumn"
        Me.SubDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TopicDataGridViewTextBoxColumn
        '
        Me.TopicDataGridViewTextBoxColumn.DataPropertyName = "topic"
        Me.TopicDataGridViewTextBoxColumn.HeaderText = "Topic"
        Me.TopicDataGridViewTextBoxColumn.Name = "TopicDataGridViewTextBoxColumn"
        Me.TopicDataGridViewTextBoxColumn.ReadOnly = True
        Me.TopicDataGridViewTextBoxColumn.Width = 300
        '
        'QtotDataGridViewTextBoxColumn
        '
        Me.QtotDataGridViewTextBoxColumn.DataPropertyName = "qtot"
        Me.QtotDataGridViewTextBoxColumn.HeaderText = "Questions"
        Me.QtotDataGridViewTextBoxColumn.Name = "QtotDataGridViewTextBoxColumn"
        Me.QtotDataGridViewTextBoxColumn.ReadOnly = True
        '
        'View
        '
        Me.View.HeaderText = "View"
        Me.View.Name = "View"
        Me.View.ReadOnly = True
        Me.View.Text = "View"
        Me.View.UseColumnTextForButtonValue = True
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'facid
        '
        Me.facid.DataPropertyName = "facid"
        Me.facid.HeaderText = "facid"
        Me.facid.Name = "facid"
        Me.facid.ReadOnly = True
        Me.facid.Width = 5
        '
        'CrdbBindingSource
        '
        Me.CrdbBindingSource.DataMember = "cr_db"
        Me.CrdbBindingSource.DataSource = Me.EducrossDataSet6
        '
        'EducrossDataSet6
        '
        Me.EducrossDataSet6.DataSetName = "educrossDataSet6"
        Me.EducrossDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cr_dbTableAdapter
        '
        Me.Cr_dbTableAdapter.ClearBeforeFill = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Postinkantaja Job", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Maroon
        Me.Label43.Location = New System.Drawing.Point(403, 119)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(466, 53)
        Me.Label43.TabIndex = 165
        Me.Label43.Text = "Test your knowledge"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Postinkantaja Job", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(354, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(536, 107)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "EDu.CroSS"
        '
        'crcross
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 742)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "crcross"
        Me.Text = "Created Crossword"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducrossDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EducrossDataSet6 As WindowsApplication1.educrossDataSet6
    Friend WithEvents CrdbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cr_dbTableAdapter As WindowsApplication1.educrossDataSet6TableAdapters.cr_dbTableAdapter
    Friend WithEvents CrnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TopicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents facid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
