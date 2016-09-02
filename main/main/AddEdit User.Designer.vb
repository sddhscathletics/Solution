<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddEdit_User
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sidebartime = New System.Windows.Forms.Timer(Me.components)
        Me.bigbtngroup = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Sidebar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resdrop = New System.Windows.Forms.Button()
        Me.sideAthletesBtn = New System.Windows.Forms.Button()
        Me.sideadminBtn = New System.Windows.Forms.Button()
        Me.sideresultBtn = New System.Windows.Forms.Button()
        Me.sidecalendarBtn = New System.Windows.Forms.Button()
        Me.sideResSub1 = New System.Windows.Forms.Button()
        Me.sideResSub2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDbBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AthleteDataSet = New main.AthleteDataSet()
        Me.Login = New main.Login()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UserDbTableAdapter1 = New main.AthleteDataSetTableAdapters.userDbTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.scrollBtn = New System.Windows.Forms.Button()
        Me.bigbtngroup.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDbBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AthleteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidebartime
        '
        Me.sidebartime.Interval = 1
        '
        'bigbtngroup
        '
        Me.bigbtngroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.bigbtngroup.Controls.Add(Me.Button5)
        Me.bigbtngroup.Controls.Add(Me.Button3)
        Me.bigbtngroup.Controls.Add(Me.Sidebar)
        Me.bigbtngroup.Controls.Add(Me.Button2)
        Me.bigbtngroup.Controls.Add(Me.RadioButton3)
        Me.bigbtngroup.Controls.Add(Me.RadioButton2)
        Me.bigbtngroup.Controls.Add(Me.RadioButton1)
        Me.bigbtngroup.Controls.Add(Me.Label3)
        Me.bigbtngroup.Controls.Add(Me.Label2)
        Me.bigbtngroup.Controls.Add(Me.passText)
        Me.bigbtngroup.Controls.Add(Me.Label1)
        Me.bigbtngroup.Controls.Add(Me.idText)
        Me.bigbtngroup.Controls.Add(Me.DataGridView1)
        Me.bigbtngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bigbtngroup.Location = New System.Drawing.Point(0, 30)
        Me.bigbtngroup.Name = "bigbtngroup"
        Me.bigbtngroup.Size = New System.Drawing.Size(1411, 688)
        Me.bigbtngroup.TabIndex = 6
        Me.bigbtngroup.TabStop = False
        Me.bigbtngroup.Text = "GroupBox1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1010, 412)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1010, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "Create"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.Button1)
        Me.Sidebar.Controls.Add(Me.resdrop)
        Me.Sidebar.Controls.Add(Me.sideAthletesBtn)
        Me.Sidebar.Controls.Add(Me.sideadminBtn)
        Me.Sidebar.Controls.Add(Me.sideresultBtn)
        Me.Sidebar.Controls.Add(Me.sidecalendarBtn)
        Me.Sidebar.Controls.Add(Me.sideResSub1)
        Me.Sidebar.Controls.Add(Me.sideResSub2)
        Me.Sidebar.Location = New System.Drawing.Point(-180, -10)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(200, 731)
        Me.Sidebar.TabIndex = 92
        Me.Sidebar.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Location = New System.Drawing.Point(2, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "   MAIN"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'resdrop
        '
        Me.resdrop.BackColor = System.Drawing.Color.Gray
        Me.resdrop.FlatAppearance.BorderSize = 0
        Me.resdrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.resdrop.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.resdrop.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.resdrop.Location = New System.Drawing.Point(173, 135)
        Me.resdrop.Name = "resdrop"
        Me.resdrop.Size = New System.Drawing.Size(25, 50)
        Me.resdrop.TabIndex = 1
        Me.resdrop.Text = "▼"
        Me.resdrop.UseVisualStyleBackColor = False
        '
        'sideAthletesBtn
        '
        Me.sideAthletesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideAthletesBtn.FlatAppearance.BorderSize = 0
        Me.sideAthletesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideAthletesBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sideAthletesBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideAthletesBtn.Location = New System.Drawing.Point(2, 186)
        Me.sideAthletesBtn.Name = "sideAthletesBtn"
        Me.sideAthletesBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideAthletesBtn.TabIndex = 0
        Me.sideAthletesBtn.Text = "   ATHLETES"
        Me.sideAthletesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideAthletesBtn.UseVisualStyleBackColor = False
        '
        'sideadminBtn
        '
        Me.sideadminBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideadminBtn.FlatAppearance.BorderSize = 0
        Me.sideadminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideadminBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideadminBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideadminBtn.Location = New System.Drawing.Point(2, 237)
        Me.sideadminBtn.Name = "sideadminBtn"
        Me.sideadminBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideadminBtn.TabIndex = 0
        Me.sideadminBtn.Text = "   MANAGE USERS"
        Me.sideadminBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideadminBtn.UseVisualStyleBackColor = False
        Me.sideadminBtn.Visible = False
        '
        'sideresultBtn
        '
        Me.sideresultBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sideresultBtn.FlatAppearance.BorderSize = 0
        Me.sideresultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sideresultBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sideresultBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideresultBtn.Location = New System.Drawing.Point(2, 135)
        Me.sideresultBtn.Name = "sideresultBtn"
        Me.sideresultBtn.Size = New System.Drawing.Size(196, 50)
        Me.sideresultBtn.TabIndex = 0
        Me.sideresultBtn.Text = "   RESULTS"
        Me.sideresultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideresultBtn.UseVisualStyleBackColor = False
        '
        'sidecalendarBtn
        '
        Me.sidecalendarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.sidecalendarBtn.FlatAppearance.BorderSize = 0
        Me.sidecalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sidecalendarBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.sidecalendarBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sidecalendarBtn.Location = New System.Drawing.Point(2, 84)
        Me.sidecalendarBtn.Name = "sidecalendarBtn"
        Me.sidecalendarBtn.Size = New System.Drawing.Size(196, 50)
        Me.sidecalendarBtn.TabIndex = 0
        Me.sidecalendarBtn.Text = "   CALENDAR"
        Me.sidecalendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sidecalendarBtn.UseVisualStyleBackColor = False
        '
        'sideResSub1
        '
        Me.sideResSub1.BackColor = System.Drawing.Color.Gray
        Me.sideResSub1.FlatAppearance.BorderSize = 0
        Me.sideResSub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideResSub1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideResSub1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideResSub1.Location = New System.Drawing.Point(2, 126)
        Me.sideResSub1.Name = "sideResSub1"
        Me.sideResSub1.Size = New System.Drawing.Size(196, 29)
        Me.sideResSub1.TabIndex = 2
        Me.sideResSub1.Text = "   RESULTS SUB 1"
        Me.sideResSub1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideResSub1.UseVisualStyleBackColor = False
        '
        'sideResSub2
        '
        Me.sideResSub2.BackColor = System.Drawing.Color.Gray
        Me.sideResSub2.FlatAppearance.BorderSize = 0
        Me.sideResSub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sideResSub2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.sideResSub2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.sideResSub2.Location = New System.Drawing.Point(2, 156)
        Me.sideResSub2.Name = "sideResSub2"
        Me.sideResSub2.Size = New System.Drawing.Size(196, 29)
        Me.sideResSub2.TabIndex = 2
        Me.sideResSub2.Text = "   RESULTS SUB 1"
        Me.sideResSub2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sideResSub2.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1010, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(1160, 318)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(1092, 318)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(1026, 318)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(1023, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Access Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(1023, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pass"
        '
        'passText
        '
        Me.passText.Location = New System.Drawing.Point(1023, 212)
        Me.passText.Multiline = True
        Me.passText.Name = "passText"
        Me.passText.Size = New System.Drawing.Size(200, 29)
        Me.passText.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(1023, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'idText
        '
        Me.idText.Location = New System.Drawing.Point(1023, 101)
        Me.idText.Multiline = True
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(200, 29)
        Me.idText.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PassDataGridViewTextBoxColumn, Me.AccessLevel})
        Me.DataGridView1.DataSource = Me.UserDbBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(52, 34)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 150
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(903, 600)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 300
        '
        'PassDataGridViewTextBoxColumn
        '
        Me.PassDataGridViewTextBoxColumn.DataPropertyName = "Pass"
        Me.PassDataGridViewTextBoxColumn.HeaderText = "Pass"
        Me.PassDataGridViewTextBoxColumn.Name = "PassDataGridViewTextBoxColumn"
        Me.PassDataGridViewTextBoxColumn.ReadOnly = True
        Me.PassDataGridViewTextBoxColumn.Width = 300
        '
        'AccessLevel
        '
        Me.AccessLevel.DataPropertyName = "AccessLevel"
        Me.AccessLevel.HeaderText = "AccessLevel"
        Me.AccessLevel.Name = "AccessLevel"
        Me.AccessLevel.ReadOnly = True
        Me.AccessLevel.Width = 300
        '
        'UserDbBindingSource1
        '
        Me.UserDbBindingSource1.DataMember = "userDb"
        Me.UserDbBindingSource1.DataSource = Me.AthleteDataSet
        '
        'AthleteDataSet
        '
        Me.AthleteDataSet.DataSetName = "AthleteDataSet"
        Me.AthleteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login
        '
        Me.Login.DataSetName = "Login"
        Me.Login.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'UserDbTableAdapter1
        '
        Me.UserDbTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.Button14)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button13)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.scrollBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Location = New System.Drawing.Point(78, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(189, 27)
        Me.lblTitle.TabIndex = 16
        Me.lblTitle.Text = "MANAGE USERS"
        '
        'lblAlertCount
        '
        Me.lblAlertCount.AutoSize = True
        Me.lblAlertCount.BackColor = System.Drawing.Color.DarkGray
        Me.lblAlertCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertCount.Location = New System.Drawing.Point(1215, 16)
        Me.lblAlertCount.Name = "lblAlertCount"
        Me.lblAlertCount.Size = New System.Drawing.Size(15, 16)
        Me.lblAlertCount.TabIndex = 3
        Me.lblAlertCount.Text = "0"
        Me.lblAlertCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button14.Location = New System.Drawing.Point(1011, 23)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(24, 21)
        Me.Button14.TabIndex = 6
        Me.Button14.Text = "search"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button4.BackgroundImage = Global.main.My.Resources.Resources.helpbtn
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(1157, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 44)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button13.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button13.Location = New System.Drawing.Point(1201, 11)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 44)
        Me.Button13.TabIndex = 6
        Me.Button13.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.exitBtn.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1245, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(372, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(633, 22)
        Me.TextBox1.TabIndex = 5
        '
        'scrollBtn
        '
        Me.scrollBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.scrollBtn.BackgroundImage = Global.main.My.Resources.Resources.scrollbtn
        Me.scrollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scrollBtn.Location = New System.Drawing.Point(10, 11)
        Me.scrollBtn.Name = "scrollBtn"
        Me.scrollBtn.Size = New System.Drawing.Size(44, 44)
        Me.scrollBtn.TabIndex = 3
        Me.scrollBtn.UseVisualStyleBackColor = False
        '
        'AddEdit_User
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bigbtngroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "AddEdit_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "name yo form fool"
        Me.bigbtngroup.ResumeLayout(False)
        Me.bigbtngroup.PerformLayout()
        Me.Sidebar.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDbBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AthleteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidebartime As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bigbtngroup As GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents passText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.TextBox
    Friend WithEvents Login As Login
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AthleteDataSet As main.AthleteDataSet
    Friend WithEvents UserDbBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UserDbTableAdapter1 As main.AthleteDataSetTableAdapters.userDbTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAlertCount As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents scrollBtn As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Sidebar As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents resdrop As System.Windows.Forms.Button
    Friend WithEvents sideAthletesBtn As System.Windows.Forms.Button
    Friend WithEvents sideadminBtn As System.Windows.Forms.Button
    Friend WithEvents sideresultBtn As System.Windows.Forms.Button
    Friend WithEvents sidecalendarBtn As System.Windows.Forms.Button
    Friend WithEvents sideResSub1 As System.Windows.Forms.Button
    Friend WithEvents sideResSub2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
End Class
