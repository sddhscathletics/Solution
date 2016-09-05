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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEdit_User))
        Me.Sidebar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resdrop = New System.Windows.Forms.Button()
        Me.sideAthletesBtn = New System.Windows.Forms.Button()
        Me.sideadminBtn = New System.Windows.Forms.Button()
        Me.sideresultBtn = New System.Windows.Forms.Button()
        Me.sidecalendarBtn = New System.Windows.Forms.Button()
        Me.sideResSub1 = New System.Windows.Forms.Button()
        Me.sideResSub2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAlertCount = New System.Windows.Forms.Label()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.notifBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.scrollBtn = New System.Windows.Forms.Button()
        Me.bigbtngroup = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDbBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AthleteDataSet = New main.AthleteDataSet()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.access3 = New System.Windows.Forms.RadioButton()
        Me.access2 = New System.Windows.Forms.RadioButton()
        Me.access1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.sidebartime = New System.Windows.Forms.Timer(Me.components)
        Me.Login = New main.Login()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UserDbTableAdapter1 = New main.AthleteDataSetTableAdapters.userDbTableAdapter()
        Me.Sidebar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.bigbtngroup.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDbBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AthleteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Sidebar.Location = New System.Drawing.Point(-200, 20)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(200, 731)
        Me.Sidebar.TabIndex = 93
        Me.Sidebar.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.resdrop.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.sideAthletesBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.sideadminBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.sideresultBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.sidecalendarBtn.Cursor = System.Windows.Forms.Cursors.Hand
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.lblAlertCount)
        Me.GroupBox2.Controls.Add(Me.helpBtn)
        Me.GroupBox2.Controls.Add(Me.notifBtn)
        Me.GroupBox2.Controls.Add(Me.exitBtn)
        Me.GroupBox2.Controls.Add(Me.scrollBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(-10, -11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1377, 58)
        Me.GroupBox2.TabIndex = 94
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
        'helpBtn
        '
        Me.helpBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.helpBtn.BackgroundImage = Global.main.My.Resources.Resources.helpbtn
        Me.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.helpBtn.FlatAppearance.BorderSize = 0
        Me.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.helpBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.helpBtn.Location = New System.Drawing.Point(1157, 11)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(44, 44)
        Me.helpBtn.TabIndex = 6
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'notifBtn
        '
        Me.notifBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.notifBtn.BackgroundImage = Global.main.My.Resources.Resources.notifbtn
        Me.notifBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.notifBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.notifBtn.FlatAppearance.BorderSize = 0
        Me.notifBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.notifBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.notifBtn.Location = New System.Drawing.Point(1201, 11)
        Me.notifBtn.Name = "notifBtn"
        Me.notifBtn.Size = New System.Drawing.Size(44, 44)
        Me.notifBtn.TabIndex = 6
        Me.notifBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.exitBtn.BackgroundImage = Global.main.My.Resources.Resources.close1
        Me.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.Location = New System.Drawing.Point(1245, 11)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(44, 44)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'scrollBtn
        '
        Me.scrollBtn.BackColor = System.Drawing.SystemColors.GrayText
        Me.scrollBtn.BackgroundImage = Global.main.My.Resources.Resources.scrollbtn
        Me.scrollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.scrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scrollBtn.Location = New System.Drawing.Point(10, 11)
        Me.scrollBtn.Name = "scrollBtn"
        Me.scrollBtn.Size = New System.Drawing.Size(44, 44)
        Me.scrollBtn.TabIndex = 3
        Me.scrollBtn.UseVisualStyleBackColor = False
        '
        'bigbtngroup
        '
        Me.bigbtngroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.bigbtngroup.Controls.Add(Me.DataGridView1)
        Me.bigbtngroup.Controls.Add(Me.confirmBtn)
        Me.bigbtngroup.Controls.Add(Me.editBtn)
        Me.bigbtngroup.Controls.Add(Me.createBtn)
        Me.bigbtngroup.Controls.Add(Me.GroupBox1)
        Me.bigbtngroup.Controls.Add(Me.deleteBtn)
        Me.bigbtngroup.Controls.Add(Me.access3)
        Me.bigbtngroup.Controls.Add(Me.access2)
        Me.bigbtngroup.Controls.Add(Me.access1)
        Me.bigbtngroup.Controls.Add(Me.Label3)
        Me.bigbtngroup.Controls.Add(Me.Label2)
        Me.bigbtngroup.Controls.Add(Me.passText)
        Me.bigbtngroup.Controls.Add(Me.Label1)
        Me.bigbtngroup.Controls.Add(Me.idText)
        Me.bigbtngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bigbtngroup.Location = New System.Drawing.Point(0, 30)
        Me.bigbtngroup.Name = "bigbtngroup"
        Me.bigbtngroup.Size = New System.Drawing.Size(1411, 688)
        Me.bigbtngroup.TabIndex = 95
        Me.bigbtngroup.TabStop = False
        Me.bigbtngroup.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(903, 600)
        Me.DataGridView1.TabIndex = 95
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
        'confirmBtn
        '
        Me.confirmBtn.BackColor = System.Drawing.Color.Gray
        Me.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBtn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.Location = New System.Drawing.Point(997, 559)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(251, 75)
        Me.confirmBtn.TabIndex = 94
        Me.confirmBtn.Text = "CONFIRM CHANGES"
        Me.confirmBtn.UseVisualStyleBackColor = False
        Me.confirmBtn.Visible = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.Gray
        Me.editBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.Location = New System.Drawing.Point(997, 438)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(251, 40)
        Me.editBtn.TabIndex = 93
        Me.editBtn.Text = "EDIT"
        Me.editBtn.UseVisualStyleBackColor = False
        Me.editBtn.Visible = False
        '
        'createBtn
        '
        Me.createBtn.BackColor = System.Drawing.Color.Gray
        Me.createBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createBtn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createBtn.Location = New System.Drawing.Point(997, 392)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(251, 40)
        Me.createBtn.TabIndex = 93
        Me.createBtn.Text = "CREATE USER"
        Me.createBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Location = New System.Drawing.Point(-200, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 731)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Location = New System.Drawing.Point(2, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 50)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "   MAIN"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Location = New System.Drawing.Point(173, 135)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 50)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "▼"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Location = New System.Drawing.Point(2, 186)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(196, 50)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "   ATHLETES"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.Location = New System.Drawing.Point(2, 237)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(196, 50)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "   MANAGE USERS"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button9.Location = New System.Drawing.Point(2, 135)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(196, 50)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "   RESULTS"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!)
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button10.Location = New System.Drawing.Point(2, 84)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(196, 50)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "   CALENDAR"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Gray
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button11.Location = New System.Drawing.Point(2, 126)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(196, 29)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "   RESULTS SUB 1"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Gray
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.Button12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button12.Location = New System.Drawing.Point(2, 156)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(196, 29)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "   RESULTS SUB 1"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Gray
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(997, 438)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(238, 40)
        Me.deleteBtn.TabIndex = 4
        Me.deleteBtn.Text = "DELETE"
        Me.deleteBtn.UseVisualStyleBackColor = False
        Me.deleteBtn.Visible = False
        '
        'access3
        '
        Me.access3.AutoSize = True
        Me.access3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.access3.Enabled = False
        Me.access3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.access3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.access3.Location = New System.Drawing.Point(1016, 301)
        Me.access3.Name = "access3"
        Me.access3.Size = New System.Drawing.Size(134, 20)
        Me.access3.TabIndex = 5
        Me.access3.TabStop = True
        Me.access3.Text = "2 (Adminstrator)"
        Me.access3.UseVisualStyleBackColor = True
        '
        'access2
        '
        Me.access2.AutoSize = True
        Me.access2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.access2.Enabled = False
        Me.access2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.access2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.access2.Location = New System.Drawing.Point(1016, 278)
        Me.access2.Name = "access2"
        Me.access2.Size = New System.Drawing.Size(91, 20)
        Me.access2.TabIndex = 4
        Me.access2.TabStop = True
        Me.access2.Text = "1 (Coach)"
        Me.access2.UseVisualStyleBackColor = True
        '
        'access1
        '
        Me.access1.AutoSize = True
        Me.access1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.access1.Enabled = False
        Me.access1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.access1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.access1.Location = New System.Drawing.Point(1016, 255)
        Me.access1.Name = "access1"
        Me.access1.Size = New System.Drawing.Size(103, 20)
        Me.access1.TabIndex = 3
        Me.access1.TabStop = True
        Me.access1.Text = "0 (Student)"
        Me.access1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1006, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Access Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1006, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pass"
        '
        'passText
        '
        Me.passText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passText.Location = New System.Drawing.Point(1010, 146)
        Me.passText.Name = "passText"
        Me.passText.ReadOnly = True
        Me.passText.Size = New System.Drawing.Size(238, 33)
        Me.passText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1006, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'idText
        '
        Me.idText.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idText.Location = New System.Drawing.Point(1010, 69)
        Me.idText.Name = "idText"
        Me.idText.ReadOnly = True
        Me.idText.Size = New System.Drawing.Size(238, 33)
        Me.idText.TabIndex = 1
        '
        'sidebartime
        '
        Me.sidebartime.Interval = 1
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
        'AddEdit_User
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.bigbtngroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "AddEdit_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Users"
        Me.Sidebar.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.bigbtngroup.ResumeLayout(False)
        Me.bigbtngroup.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDbBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AthleteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents idText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents passText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents access1 As RadioButton
    Friend WithEvents access2 As RadioButton
    Friend WithEvents access3 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents createBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents confirmBtn As Button
    Friend WithEvents bigbtngroup As GroupBox
    Friend WithEvents scrollBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents notifBtn As Button
    Friend WithEvents helpBtn As Button
    Friend WithEvents lblAlertCount As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents sideResSub2 As Button
    Friend WithEvents sideResSub1 As Button
    Friend WithEvents sidecalendarBtn As Button
    Friend WithEvents sideresultBtn As Button
    Friend WithEvents sideadminBtn As Button
    Friend WithEvents sideAthletesBtn As Button
    Friend WithEvents resdrop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Sidebar As GroupBox
    Friend WithEvents UserDbTableAdapter1 As AthleteDataSetTableAdapters.userDbTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Login As Login
    Friend WithEvents AthleteDataSet As AthleteDataSet
    Friend WithEvents UserDbBindingSource1 As BindingSource
    Friend WithEvents sidebartime As Timer
    Friend WithEvents AccessLevel As DataGridViewTextBoxColumn
    Friend WithEvents PassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
