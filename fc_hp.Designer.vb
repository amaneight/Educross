<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fc_hp
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
        Me.createcr = New System.Windows.Forms.Button()
        Me.fname = New System.Windows.Forms.Label()
        Me.fdept = New System.Windows.Forms.Label()
        Me.fcrcnt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fccnt = New System.Windows.Forms.Label()
        Me.EducrossDataSet3 = New WindowsApplication1.educrossDataSet3()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New WindowsApplication1.educrossDataSet3TableAdapters.questionTableAdapter()
        Me.CrdbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducrossDataSet2 = New WindowsApplication1.educrossDataSet2()
        Me.Cr_dbTableAdapter = New WindowsApplication1.educrossDataSet2TableAdapters.cr_dbTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.crlabel = New System.Windows.Forms.Label()
        Me.edittp = New System.Windows.Forms.Label()
        CType(Me.EducrossDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducrossDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createcr
        '
        Me.createcr.BackColor = System.Drawing.Color.Transparent
        Me.createcr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createcr.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.createcr.FlatAppearance.BorderSize = 2
        Me.createcr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.createcr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.createcr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createcr.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createcr.ForeColor = System.Drawing.Color.Maroon
        Me.createcr.Location = New System.Drawing.Point(138, 480)
        Me.createcr.Name = "createcr"
        Me.createcr.Size = New System.Drawing.Size(238, 52)
        Me.createcr.TabIndex = 3
        Me.createcr.Text = "Create Crossword"
        Me.createcr.UseVisualStyleBackColor = False
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.BackColor = System.Drawing.Color.Transparent
        Me.fname.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.Color.Maroon
        Me.fname.Location = New System.Drawing.Point(821, 27)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(86, 32)
        Me.fname.TabIndex = 8
        Me.fname.Text = "Label4"
        '
        'fdept
        '
        Me.fdept.AutoSize = True
        Me.fdept.BackColor = System.Drawing.Color.Transparent
        Me.fdept.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdept.ForeColor = System.Drawing.Color.Maroon
        Me.fdept.Location = New System.Drawing.Point(821, 73)
        Me.fdept.Name = "fdept"
        Me.fdept.Size = New System.Drawing.Size(86, 32)
        Me.fdept.TabIndex = 9
        Me.fdept.Text = "Label5"
        '
        'fcrcnt
        '
        Me.fcrcnt.AutoSize = True
        Me.fcrcnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcrcnt.Location = New System.Drawing.Point(1023, 128)
        Me.fcrcnt.Name = "fcrcnt"
        Me.fcrcnt.Size = New System.Drawing.Size(0, 24)
        Me.fcrcnt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(821, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "No. of Crossword :"
        '
        'fccnt
        '
        Me.fccnt.AutoSize = True
        Me.fccnt.BackColor = System.Drawing.Color.Transparent
        Me.fccnt.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fccnt.ForeColor = System.Drawing.Color.Maroon
        Me.fccnt.Location = New System.Drawing.Point(1042, 128)
        Me.fccnt.Name = "fccnt"
        Me.fccnt.Size = New System.Drawing.Size(86, 32)
        Me.fccnt.TabIndex = 9
        Me.fccnt.Text = "Label5"
        '
        'EducrossDataSet3
        '
        Me.EducrossDataSet3.DataSetName = "educrossDataSet3"
        Me.EducrossDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "question"
        Me.QuestionBindingSource.DataSource = Me.EducrossDataSet3
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'CrdbBindingSource
        '
        Me.CrdbBindingSource.DataMember = "cr_db"
        Me.CrdbBindingSource.DataSource = Me.EducrossDataSet2
        '
        'EducrossDataSet2
        '
        Me.EducrossDataSet2.DataSetName = "educrossDataSet2"
        Me.EducrossDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cr_dbTableAdapter
        '
        Me.Cr_dbTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Postinkantaja Job", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(272, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(536, 107)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "EDu.CroSS"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Postinkantaja Job", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Maroon
        Me.Label43.Location = New System.Drawing.Point(303, 119)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(466, 53)
        Me.Label43.TabIndex = 164
        Me.Label43.Text = "Test your knowledge"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Maroon
        Me.Button5.Location = New System.Drawing.Point(12, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 37)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Logout"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Maroon
        Me.Button6.Location = New System.Drawing.Point(1227, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 37)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Edit Details"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Capture it", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Maroon
        Me.Button4.Location = New System.Drawing.Point(587, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(328, 120)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "CREATED " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CROSSWORD"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button7.FlatAppearance.BorderSize = 2
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Capture it", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Maroon
        Me.Button7.Location = New System.Drawing.Point(1027, 306)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(320, 120)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "CHECK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STATISTICS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(184, 306)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 32)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(79, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "TOPIC :"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(184, 365)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(248, 32)
        Me.ComboBox2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(51, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 32)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "SUBJECT :"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(184, 423)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(248, 32)
        Me.ComboBox3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(89, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 32)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "YEAR :"
        '
        'crlabel
        '
        Me.crlabel.AutoSize = True
        Me.crlabel.Location = New System.Drawing.Point(20, 734)
        Me.crlabel.Name = "crlabel"
        Me.crlabel.Size = New System.Drawing.Size(36, 13)
        Me.crlabel.TabIndex = 182
        Me.crlabel.Text = "crnum"
        '
        'edittp
        '
        Me.edittp.AutoSize = True
        Me.edittp.Location = New System.Drawing.Point(1280, 84)
        Me.edittp.Name = "edittp"
        Me.edittp.Size = New System.Drawing.Size(0, 13)
        Me.edittp.TabIndex = 183
        '
        'fc_hp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.edittp)
        Me.Controls.Add(Me.crlabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fcrcnt)
        Me.Controls.Add(Me.fccnt)
        Me.Controls.Add(Me.fdept)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.createcr)
        Me.Controls.Add(Me.Label3)
        Me.Name = "fc_hp"
        Me.Text = "Faculty homepage"
        CType(Me.EducrossDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrdbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducrossDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createcr As System.Windows.Forms.Button
    Friend WithEvents fname As System.Windows.Forms.Label
    Friend WithEvents fdept As System.Windows.Forms.Label
    Friend WithEvents fcrcnt As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fccnt As System.Windows.Forms.Label
    Friend WithEvents EducrossDataSet3 As WindowsApplication1.educrossDataSet3
    Friend WithEvents QuestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuestionTableAdapter As WindowsApplication1.educrossDataSet3TableAdapters.questionTableAdapter
    Friend WithEvents EducrossDataSet2 As WindowsApplication1.educrossDataSet2
    Friend WithEvents CrdbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cr_dbTableAdapter As WindowsApplication1.educrossDataSet2TableAdapters.cr_dbTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents crlabel As System.Windows.Forms.Label
    Friend WithEvents edittp As System.Windows.Forms.Label
End Class
