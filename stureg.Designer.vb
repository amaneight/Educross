<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stureg
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sr_prn = New System.Windows.Forms.TextBox()
        Me.sr_fname = New System.Windows.Forms.TextBox()
        Me.sr_mname = New System.Windows.Forms.TextBox()
        Me.sr_lname = New System.Windows.Forms.TextBox()
        Me.sr_roll = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.sr_year = New System.Windows.Forms.ComboBox()
        Me.sr_div = New System.Windows.Forms.ComboBox()
        Me.sr_contact = New System.Windows.Forms.TextBox()
        Me.sr_pass = New System.Windows.Forms.TextBox()
        Me.sr_cpass = New System.Windows.Forms.TextBox()
        Me.sr_male = New System.Windows.Forms.RadioButton()
        Me.sr_female = New System.Windows.Forms.RadioButton()
        Me.confirmbut = New System.Windows.Forms.Button()
        Me.resetbut = New System.Windows.Forms.Button()
        Me.sr_age = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducrossDataSet1 = New WindowsApplication1.educrossDataSet1()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.sr_dept = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EducrossDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(341, 300)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(327, 359)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Roll No:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(353, 412)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(878, 412)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Division:-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(625, 748)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(252, 472)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mobile Number:-"
        '
        'sr_prn
        '
        Me.sr_prn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_prn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_prn.Location = New System.Drawing.Point(446, 203)
        Me.sr_prn.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_prn.MaxLength = 10
        Me.sr_prn.Name = "sr_prn"
        Me.sr_prn.Size = New System.Drawing.Size(219, 33)
        Me.sr_prn.TabIndex = 1
        '
        'sr_fname
        '
        Me.sr_fname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_fname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_fname.Location = New System.Drawing.Point(446, 300)
        Me.sr_fname.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_fname.MaxLength = 15
        Me.sr_fname.Name = "sr_fname"
        Me.sr_fname.Size = New System.Drawing.Size(219, 33)
        Me.sr_fname.TabIndex = 2
        '
        'sr_mname
        '
        Me.sr_mname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_mname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_mname.Location = New System.Drawing.Point(687, 300)
        Me.sr_mname.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_mname.MaxLength = 15
        Me.sr_mname.Name = "sr_mname"
        Me.sr_mname.Size = New System.Drawing.Size(219, 33)
        Me.sr_mname.TabIndex = 3
        '
        'sr_lname
        '
        Me.sr_lname.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_lname.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_lname.Location = New System.Drawing.Point(919, 300)
        Me.sr_lname.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_lname.MaxLength = 15
        Me.sr_lname.Name = "sr_lname"
        Me.sr_lname.Size = New System.Drawing.Size(219, 33)
        Me.sr_lname.TabIndex = 4
        '
        'sr_roll
        '
        Me.sr_roll.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_roll.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_roll.Location = New System.Drawing.Point(447, 356)
        Me.sr_roll.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_roll.MaxLength = 3
        Me.sr_roll.Name = "sr_roll"
        Me.sr_roll.Size = New System.Drawing.Size(118, 33)
        Me.sr_roll.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(486, 256)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(716, 251)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Middle Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(960, 251)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 25)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(723, 531)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Confirm Password:-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(308, 529)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Password:-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(327, 590)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 25)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Gender:-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(914, 360)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 25)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Age:-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(304, 206)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 25)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Username:-"
        '
        'sr_year
        '
        Me.sr_year.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_year.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_year.FormattingEnabled = True
        Me.sr_year.Items.AddRange(New Object() {"S.E.", "T.E.", "B.E."})
        Me.sr_year.Location = New System.Drawing.Point(447, 412)
        Me.sr_year.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_year.Name = "sr_year"
        Me.sr_year.Size = New System.Drawing.Size(118, 33)
        Me.sr_year.TabIndex = 7
        Me.sr_year.Text = "S.E."
        '
        'sr_div
        '
        Me.sr_div.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_div.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_div.FormattingEnabled = True
        Me.sr_div.Items.AddRange(New Object() {"Div.1", "Div.2"})
        Me.sr_div.Location = New System.Drawing.Point(1013, 412)
        Me.sr_div.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_div.Name = "sr_div"
        Me.sr_div.Size = New System.Drawing.Size(125, 33)
        Me.sr_div.TabIndex = 8
        Me.sr_div.Text = "Div.1"
        '
        'sr_contact
        '
        Me.sr_contact.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_contact.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_contact.Location = New System.Drawing.Point(446, 472)
        Me.sr_contact.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_contact.MaxLength = 10
        Me.sr_contact.Name = "sr_contact"
        Me.sr_contact.Size = New System.Drawing.Size(219, 33)
        Me.sr_contact.TabIndex = 9
        '
        'sr_pass
        '
        Me.sr_pass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_pass.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_pass.Location = New System.Drawing.Point(446, 529)
        Me.sr_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.sr_pass.MaxLength = 10
        Me.sr_pass.Name = "sr_pass"
        Me.sr_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.sr_pass.Size = New System.Drawing.Size(219, 33)
        Me.sr_pass.TabIndex = 11
        '
        'sr_cpass
        '
        Me.sr_cpass.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_cpass.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_cpass.Location = New System.Drawing.Point(919, 531)
        Me.sr_cpass.Margin = New System.Windows.Forms.Padding(2)
        Me.sr_cpass.MaxLength = 10
        Me.sr_cpass.Name = "sr_cpass"
        Me.sr_cpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.sr_cpass.Size = New System.Drawing.Size(219, 33)
        Me.sr_cpass.TabIndex = 12
        '
        'sr_male
        '
        Me.sr_male.AutoSize = True
        Me.sr_male.BackColor = System.Drawing.Color.Transparent
        Me.sr_male.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_male.ForeColor = System.Drawing.Color.Maroon
        Me.sr_male.Location = New System.Drawing.Point(447, 590)
        Me.sr_male.Margin = New System.Windows.Forms.Padding(2)
        Me.sr_male.Name = "sr_male"
        Me.sr_male.Size = New System.Drawing.Size(73, 29)
        Me.sr_male.TabIndex = 13
        Me.sr_male.TabStop = True
        Me.sr_male.Text = "Male"
        Me.sr_male.UseVisualStyleBackColor = False
        '
        'sr_female
        '
        Me.sr_female.AutoSize = True
        Me.sr_female.BackColor = System.Drawing.Color.Transparent
        Me.sr_female.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_female.ForeColor = System.Drawing.Color.Maroon
        Me.sr_female.Location = New System.Drawing.Point(555, 590)
        Me.sr_female.Margin = New System.Windows.Forms.Padding(2)
        Me.sr_female.Name = "sr_female"
        Me.sr_female.Size = New System.Drawing.Size(92, 29)
        Me.sr_female.TabIndex = 14
        Me.sr_female.TabStop = True
        Me.sr_female.Text = "Female"
        Me.sr_female.UseVisualStyleBackColor = False
        '
        'confirmbut
        '
        Me.confirmbut.BackColor = System.Drawing.Color.Transparent
        Me.confirmbut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmbut.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.confirmbut.FlatAppearance.BorderSize = 2
        Me.confirmbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.confirmbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.confirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmbut.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmbut.ForeColor = System.Drawing.Color.Maroon
        Me.confirmbut.Location = New System.Drawing.Point(437, 650)
        Me.confirmbut.Margin = New System.Windows.Forms.Padding(2)
        Me.confirmbut.Name = "confirmbut"
        Me.confirmbut.Size = New System.Drawing.Size(167, 48)
        Me.confirmbut.TabIndex = 15
        Me.confirmbut.Text = "Confirm"
        Me.confirmbut.UseVisualStyleBackColor = False
        '
        'resetbut
        '
        Me.resetbut.BackColor = System.Drawing.Color.Transparent
        Me.resetbut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.resetbut.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.resetbut.FlatAppearance.BorderSize = 2
        Me.resetbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood
        Me.resetbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.resetbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetbut.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbut.ForeColor = System.Drawing.Color.Maroon
        Me.resetbut.Location = New System.Drawing.Point(831, 650)
        Me.resetbut.Margin = New System.Windows.Forms.Padding(2)
        Me.resetbut.Name = "resetbut"
        Me.resetbut.Size = New System.Drawing.Size(143, 48)
        Me.resetbut.TabIndex = 16
        Me.resetbut.Text = "Reset"
        Me.resetbut.UseVisualStyleBackColor = False
        '
        'sr_age
        '
        Me.sr_age.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_age.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_age.Location = New System.Drawing.Point(1013, 352)
        Me.sr_age.Margin = New System.Windows.Forms.Padding(2)
        Me.sr_age.MaxLength = 2
        Me.sr_age.Name = "sr_age"
        Me.sr_age.Size = New System.Drawing.Size(125, 33)
        Me.sr_age.TabIndex = 6
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.EducrossDataSet1
        Me.BindingSource1.Position = 0
        '
        'EducrossDataSet1
        '
        Me.EducrossDataSet1.DataSetName = "educrossDataSet1"
        Me.EducrossDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Button3.Location = New System.Drawing.Point(15, 15)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 46)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(906, 475)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 25)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Dept:-"
        '
        'sr_dept
        '
        Me.sr_dept.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sr_dept.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sr_dept.FormattingEnabled = True
        Me.sr_dept.Items.AddRange(New Object() {"IT", "E&TC", "CS", "Mech"})
        Me.sr_dept.Location = New System.Drawing.Point(1013, 472)
        Me.sr_dept.Margin = New System.Windows.Forms.Padding(6)
        Me.sr_dept.Name = "sr_dept"
        Me.sr_dept.Size = New System.Drawing.Size(125, 33)
        Me.sr_dept.TabIndex = 10
        Me.sr_dept.Text = "IT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Postinkantaja Job", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(546, 116)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(466, 53)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Test your knowledge"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Postinkantaja Job", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(428, 9)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(536, 107)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "EDu.CroSS"
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.Maroon
        Me.user.Location = New System.Drawing.Point(451, 206)
        Me.user.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(50, 25)
        Me.user.TabIndex = 38
        Me.user.Text = "user"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(10, 708)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "All fields are mandatory"
        '
        'stureg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.resetbut)
        Me.Controls.Add(Me.confirmbut)
        Me.Controls.Add(Me.sr_female)
        Me.Controls.Add(Me.sr_male)
        Me.Controls.Add(Me.sr_age)
        Me.Controls.Add(Me.sr_cpass)
        Me.Controls.Add(Me.sr_pass)
        Me.Controls.Add(Me.sr_contact)
        Me.Controls.Add(Me.sr_dept)
        Me.Controls.Add(Me.sr_div)
        Me.Controls.Add(Me.sr_year)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.sr_roll)
        Me.Controls.Add(Me.sr_lname)
        Me.Controls.Add(Me.sr_mname)
        Me.Controls.Add(Me.sr_fname)
        Me.Controls.Add(Me.sr_prn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "stureg"
        Me.Text = "Student Registration"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EducrossDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sr_prn As System.Windows.Forms.TextBox
    Friend WithEvents sr_fname As System.Windows.Forms.TextBox
    Friend WithEvents sr_mname As System.Windows.Forms.TextBox
    Friend WithEvents sr_lname As System.Windows.Forms.TextBox
    Friend WithEvents sr_roll As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents sr_year As System.Windows.Forms.ComboBox
    Friend WithEvents sr_div As System.Windows.Forms.ComboBox
    Friend WithEvents sr_contact As System.Windows.Forms.TextBox
    Friend WithEvents sr_pass As System.Windows.Forms.TextBox
    Friend WithEvents sr_cpass As System.Windows.Forms.TextBox
    Friend WithEvents sr_male As System.Windows.Forms.RadioButton
    Friend WithEvents sr_female As System.Windows.Forms.RadioButton
    Friend WithEvents confirmbut As System.Windows.Forms.Button
    Friend WithEvents resetbut As System.Windows.Forms.Button
    Friend WithEvents sr_age As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EducrossDataSet1 As WindowsApplication1.educrossDataSet1
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents sr_dept As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
